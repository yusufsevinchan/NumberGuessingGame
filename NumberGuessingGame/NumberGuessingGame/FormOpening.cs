using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumberGuessingGame
{
    public partial class FormOpening : Form
    {
        public static int first, last;
        public FormOpening()
        {
            InitializeComponent();
        }

        private void FormOpening_Load(object sender, EventArgs e)
        {
            txtFirst.Focus();
        }

        private void FormOpening_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtFirst.Text == "" || txtLast.Text == "") return;
                first = int.Parse(txtFirst.Text);
                last = int.Parse(txtLast.Text);
                var form = new FormNumberGuessingGame();
                Hide();
                form.ShowDialog();
                Close();
            }
        }

        private void TxtSon_MouseMove(object sender, MouseEventArgs e)
        {
            toolTip1.SetToolTip(txtFirst, "Aralığı yazdıktan sonra Enter' a basınız.");
            toolTip1.SetToolTip(txtLast, "Aralığı yazdıktan sonra Enter' a basınız.");
        }

        private void AllTextBoxesTextChanged(object sender, EventArgs e)
        {
            var txt = sender as TextBox;
            txt.Text = string.Concat(txt.Text.Where(char.IsNumber));
            txt.SelectionStart = txt.Text.Length + 1;
        }
    }
}
