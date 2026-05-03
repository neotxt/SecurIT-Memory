using System;
using System.Windows.Forms;

namespace SecurIT_Memory
{
    public partial class MainMenu : Form
    {
        private int currentGridSize = 4;

        public MainMenu()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OptionForm optionForm = new OptionForm(currentGridSize);

            if (optionForm.ShowDialog() == DialogResult.OK)
            {
                currentGridSize = optionForm.SelectedSize;

                GameForm gameForm = new GameForm(currentGridSize);

                // Ensures the entire application exits when the game window is closed
                gameForm.FormClosed += (s, args) => Show();

                gameForm.Show();
                Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Le classement sera bientôt disponible !", "En construction");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}