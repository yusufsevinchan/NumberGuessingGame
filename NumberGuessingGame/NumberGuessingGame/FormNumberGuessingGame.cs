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
    public partial class FormNumberGuessingGame : Form
    {
        List<Button> list = new List<Button>();
        int first = FormOpening.first, last = FormOpening.last;
        int x = 0, y = 0;

        Random random = new Random();
        int number=0;

        public FormNumberGuessingGame()
        {
            InitializeComponent();
        }

        private void FormNumberGuessingGame_Load(object sender, EventArgs e)
        {
            lblMessage.Location = new Point(12, 140);
            lblRestart.Location = new Point(12, 190);
            Size = new Size(136, 136);
            int i;
            for (i = first; i <= last; i++)
            {
                CreatButtons(i);
                if (i < 11) Width += 50;
            }
            if (i > 10) Width = 596;
            if (lblRestart.Location.Y > Height) Height = lblRestart.Location.Y + 80;
            else Height = lblRestart.Location.Y + 80;
            ListeEkle(list);
            number = random.Next(first, last + 1);
            foreach (var c in Controls)
            {
                if (c is Button)
                {
                    Button button = (Button)c;
                    button.Click += new EventHandler(ButtonButton_Click);
                }
            }
        }

        private void CreatButtons(int i)
        {
            Button button = new Button();
            button.Size = new Size(50, 50);
            button.Location = new Point(12 + x * 56, 12 + y * 56);
            button.Name = $"button{i}";
            button.Text = i.ToString();
            if (Text.Length < 3) button.Font = new Font("Verdana", 15f);
            else button.Font = new Font("Verdana", 12.75f);
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;
            button.BackColor = BackColor;
            button.ForeColor = Color.Black;
            Controls.Add(button);
            x += 1;
            if (x % 10 == 0)
            {
                x = 0;
                y += 1;
                Height += 75;
            }
            if (i==last)
            {
                lblMessage.Location = new Point(lblMessage.Location.X, button.Location.Y + 60);
                lblRestart.Location = new Point(lblRestart.Location.X, button.Location.Y + 100);
            }
        }

        private void ListeEkle(List<Button> list)
        {
            foreach (var c in Controls)
            {
                if (c is Button) list.Add(c as Button);
            }
        }

        void ButtonButton_Click(object sender, EventArgs e)
        {
            string trueAnswer = "✔ Yes, You Choose The True Number!";
            Button btn = sender as Button;
            bool cond = btn.Text == number.ToString();
            if (cond)
            {
                DisableAndStrikeOutAllOtherButtons(btn);
                btn.FlatAppearance.BorderColor = Color.Green;
                lblMessage.ForeColor = Color.Green;
                lblMessage.Text = trueAnswer;
                btn.FlatAppearance.BorderSize = 2;
                btn.Font= new Font("Verdana", 12f);
                lblRestart.Focus();
            }
            else
            {
                bool condition = int.Parse(btn.Text) < number;
                GiveMessageAndUpdateButtons(condition, btn, number);
                DisableAndStrikeOutOtherButtons(condition, btn);
            }
        }

        private void GiveMessageAndUpdateButtons(bool cond, Button btn, int number)
        {
            lblMessage.ForeColor = Color.Black;
            if(cond) lblMessage.Text = $"My number is higher than {btn.Text}. Guess higher →";

            else lblMessage.Text = $"My number is lower than {btn.Text}. Guess lower ←";
        }

        private void DisableAndStrikeOutAllOtherButtons(Button button)
        {
            foreach (var con in Controls)
                if (con is Button)
                {
                    Button btn = con as Button;
                    if (btn.Name!=button.Name)
                    {
                        btn.Enabled = false;
                        btn.Font = new Font(btn.Font, FontStyle.Strikeout);
                    }
                }
        }

        private void DisableAndStrikeOutOtherButtons(bool cond, Button button)
        {
            if (cond)
            {
                int i = 0;
                while (i < Convert.ToInt32(button.Text))
                {
                    var btn = list[i];
                    list[i].Enabled = false;
                    list[i].Font = new Font(btn.Font, FontStyle.Strikeout);
                    i++;
                }
            }
            else
            {
                int i = list.Count - 1;
                while (i > Convert.ToInt32(button.Text)-2)
                {
                    var btn = list[i];
                    list[i].Enabled = false;
                    list[i].Font = new Font(btn.Font, FontStyle.Strikeout);
                    i--;
                }
            }
        }

        private void lblRestart_Click(object sender, EventArgs e)
        {
            Application.Restart();
            Environment.Exit(0);
        }
    }
}
