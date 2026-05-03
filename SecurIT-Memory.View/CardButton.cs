using System.Drawing;
using System.Windows.Forms;
using SecurIT_Logic;

namespace SecurIT_Memory
{
    internal class CardButton : Button
    {
        public Card CardData { get; private set; }

        public CardButton(Point location, Card cardData)
        {
            Location = location;
            CardData = cardData;
            Size = new Size(80, 80);
            Font = new Font("Arial", 20, FontStyle.Bold);
            BackgroundImageLayout = ImageLayout.Zoom;

            UpdateDisplay();
        }

        public void FlipUp()
        {
            CardData.State = CardState.FaceUp;
            UpdateDisplay();
        }

        public void FlipDown()
        {
            if (CardData.State != CardState.Matched)
            {
                CardData.State = CardState.FaceDown;
                UpdateDisplay();
            }
        }

        public void UpdateDisplay()
        {
            switch (CardData.State)
            {
                case CardState.FaceDown:
                    BackColor = Color.DarkBlue;
                    Text = string.Empty;
                    BackgroundImage = null;
                    Image = null;
                    break;

                case CardState.FaceUp:
                case CardState.Matched:
                    BackColor = Color.White;

                    if (CardData.FrontImage != null)
                    {
                        BackgroundImage = CardData.FrontImage;
                        Text = string.Empty;
                    }
                    else
                    {
                        Text = CardData.PairId.ToString();
                    }
                    break;
            }
        }
    }
}