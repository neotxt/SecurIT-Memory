using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using SecurIT_Logic;

namespace SecurIT_Memory
{
    public partial class GameForm : Form
    {
        private int attempts = 0;
        private Timer gameTimer = new Timer();
        private int seconds = 0;
        private CardButton firstClickedCard = null;
        private bool isWaiting = false;
        private int gridSize;

        public GameForm(int size)
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            gridSize = size;

            gameTimer.Interval = 1000;
            gameTimer.Tick += GameTimer_Tick;
        }

        private void GenerateGrid(int size)
        {
            int totalCards = size * size;
            List<Card> deck = new List<Card>();

            List<Image> cardImages = new List<Image>
            {
                Properties.Resources.Virus,
                Properties.Resources.Bug,
                Properties.Resources.Cloud,
                Properties.Resources.Sécurité,
                Properties.Resources.Folder,
                Properties.Resources.Hacker,
                Properties.Resources.Key,
                Properties.Resources.Cursor
            };

            for (int i = 0; i < totalCards / 2; i++)
            {
                Image currentImage = cardImages[i % cardImages.Count];
                deck.Add(new Card(i, currentImage));
                deck.Add(new Card(i, currentImage));
            }

            // Fisher-Yates shuffle algorithm
            Random rng = new Random();
            int n = deck.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                Card temp = deck[k];
                deck[k] = deck[n];
                deck[n] = temp;
            }

            // Dynamic grid centering calculation
            int cardWidth = 80;
            int cardHeight = 80;
            int margin = 10;

            int totalGridWidth = (size * cardWidth) + ((size - 1) * margin);
            int totalGridHeight = (size * cardHeight) + ((size - 1) * margin);

            int startX = (ClientSize.Width - totalGridWidth) / 2;
            int startY = (ClientSize.Height - totalGridHeight) / 2;

            int deckIndex = 0;
            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    int posX = startX + col * (cardWidth + margin);
                    int posY = startY + row * (cardHeight + margin);

                    CardButton cb = new CardButton(new Point(posX, posY), deck[deckIndex]);
                    cb.Click += Card_Click;
                    Controls.Add(cb);
                    deckIndex++;
                }
            }
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            seconds++;
            int mins = seconds / 60;
            int secs = seconds % 60;

            if (Controls.ContainsKey("lblChronos"))
                Controls["lblChronos"].Text = $"Temps : {mins:00}:{secs:00}";
        }

        private void Card_Click(object sender, EventArgs e)
        {
            if (isWaiting) return;

            CardButton clickedCard = (CardButton)sender;

            if (clickedCard.CardData.State == CardState.Matched || clickedCard.CardData.State == CardState.FaceUp)
                return;

            clickedCard.FlipUp();

            if (firstClickedCard == null)
            {
                firstClickedCard = clickedCard;
            }
            else
            {
                attempts++;
                if (Controls.ContainsKey("lblEssais"))
                    Controls["lblEssais"].Text = $"Essais : {attempts}";

                isWaiting = true;

                if (firstClickedCard.CardData.PairId == clickedCard.CardData.PairId)
                {
                    firstClickedCard.CardData.State = CardState.Matched;
                    clickedCard.CardData.State = CardState.Matched;

                    firstClickedCard = null;
                    isWaiting = false;
                    CheckForVictory();
                }
                else
                {
                    // Delay before flipping cards back to allow player memorization
                    Timer delayTimer = new Timer();
                    delayTimer.Interval = 1000;
                    delayTimer.Tick += (s, ev) =>
                    {
                        firstClickedCard.FlipDown();
                        clickedCard.FlipDown();
                        firstClickedCard = null;
                        isWaiting = false;
                        delayTimer.Stop();
                    };
                    delayTimer.Start();
                }
            }
        }

        private void CheckForVictory()
        {
            bool hasWon = true;
            foreach (Control ctrl in Controls)
            {
                if (ctrl is CardButton cb && cb.CardData.State != CardState.Matched)
                {
                    hasWon = false;
                    break;
                }
            }

            if (hasWon)
            {
                gameTimer.Stop();
                MessageBox.Show($"Félicitations ! Victoire en {attempts} essais et {seconds} secondes.");
                // On ferme la fenêtre pour que le MainMenu réapparaisse
                Close();
            }
        }

        // Action du nouveau bouton MENU
        private void btnBackToMenu_Click(object sender, EventArgs e)
        {
            // On ferme la fenêtre en cours, ce qui déclenchera la réapparition du menu
            Close();
        }

        private void GameForm_Load(object sender, EventArgs e)
        {
            GenerateGrid(gridSize);
            gameTimer.Start();
        }
    }
}