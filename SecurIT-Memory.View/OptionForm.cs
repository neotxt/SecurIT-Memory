using System;
using System.Windows.Forms;

namespace SecurIT_Memory
{
    public partial class OptionForm : Form
    {
        public int SelectedSize { get; private set; }

        public OptionForm(int currentSize)
        {
            InitializeComponent();

            if (currentSize == 6)
                rb6x6.Checked = true;
            else
                rb4x4.Checked = true;
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            SelectedSize = rb6x6.Checked ? 6 : 4;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void OptionForm_Load(object sender, EventArgs e)
        {
        }
    }
}