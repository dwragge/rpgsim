namespace rpgsim
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Linq;
    using System.Windows.Forms;

    public partial class OptionsDialog : Form
    {
        private Range hpRange = new Range(1, 100);
        private Range strengthRange = new Range(1, 20);
        private Range speedRange = new Range(1, 10);
        private Range rangeRange = new Range(20, 99);
        private Range xRange = new Range(0, 1280);
        private Range yRange = new Range(0, 720);

        private Random random;

        private List<Color> teamColors = new List<Color>()
        {
            Color.Blue, Color.Purple, Color.Red, Color.Green
        };

        public OptionsDialog()
        {
            random = new Random((int)DateTime.Now.Ticks);
            InitializeComponent();
            RunSim_Button.Enabled = false;
            Unit1_Team.DataSource = new List<Color>(teamColors);
            Unit2_Team.DataSource = new List<Color>(teamColors);
        }

        // Blocks copy, paste and cut.
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if ((keyData == (Keys.Control | Keys.C)) || (keyData == (Keys.Control | Keys.V)) || (keyData == (Keys.Control | Keys.X)))
            {
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void HP_Text_KeyPress(object sender, KeyPressEventArgs e)
        {
            var textBox = sender as TextBox;
            ValidateTextboxInput(textBox, e, hpRange);
        }

        private void Str_Text_KeyPress(object sender, KeyPressEventArgs e)
        {
            var textBox = sender as TextBox;
            ValidateTextboxInput(textBox, e, strengthRange);
        }

        private void Speed_Text_KeyPress(object sender, KeyPressEventArgs e)
        {
            var textBox = sender as TextBox;
            ValidateTextboxInput(textBox, e, speedRange);
        }

        private void Range_Text_KeyPress(object sender, KeyPressEventArgs e)
        {
            var textBox = sender as TextBox;
            ValidateTextboxInput(textBox, e, rangeRange);
        }

        private void X_Text_KeyPress(object sender, KeyPressEventArgs e)
        {
            var textBox = sender as TextBox;
            ValidateTextboxInput(textBox, e, xRange);
        }

        private void Y_Text_Keypress(object sender, KeyPressEventArgs e)
        {
            var textBox = sender as TextBox;
            ValidateTextboxInput(textBox, e, yRange);
        }

        private void Text_Changed(object sender, EventArgs E)
        {
            bool a, b, c, d, e, f;
            a = b = c = d = e = f = false;

            a = CanEnableButton(hpUnit1_Text, hpRange) & CanEnableButton(hpUnit2_Text, hpRange);
            b = CanEnableButton(strUnit1_Text, strengthRange) & CanEnableButton(strUnit2_Text, strengthRange);
            c = CanEnableButton(speedUnit1_Text, speedRange) & CanEnableButton(speedUnit2_Text, speedRange);
            d = CanEnableButton(rangeUnit1_Text, rangeRange) & CanEnableButton(rangeUnit2_Text, rangeRange);
            e = CanEnableButton(x_Unit1_Text, xRange) & CanEnableButton(x_Unit2_Text, xRange);
            f = CanEnableButton(y_Unit1_Text, yRange) & CanEnableButton(y_Unit2_Text, yRange);

            bool canEnable = a & b & c & d & e & f;
            if (canEnable)
            {
                RunSim_Button.Enabled = true;
            }
            else
            {
                RunSim_Button.Enabled = false;
            }
        }

        private bool CanEnableButton(TextBox t, Range r)
        {
            if (t.Text.Length == 0)
            {
                return false;
            }

            if (int.Parse(t.Text) < r.Lower)
            {
                RunSim_Button.Enabled = false;
                return false;
            }

            return true;
        }

        private void Random_Button_Click(object sender, EventArgs e)
        {
            int hp1 = random.Next(hpRange);
            int strength1 = random.Next(strengthRange);
            int speed1 = random.Next(speedRange);
            int range1 = random.Next(rangeRange);

            int hp2 = random.Next(hpRange, hp1, 10);
            int strength2 = random.Next(strengthRange, strength1, 5);
            int speed2 = random.Next(speedRange, speed1, 3);
            int range2 = random.Next(rangeRange, range1, 25);

            int numTeams = teamColors.Count();
            int team1 = random.Next(0, numTeams);
            int team2 = random.Next(0, numTeams);
            while (team2 == team1)
            {
                team2 = random.Next(0, numTeams);
            }

            hpUnit1_Text.Text = hp1.ToString();
            strUnit1_Text.Text = strength1.ToString();
            speedUnit1_Text.Text = speed1.ToString();
            rangeUnit1_Text.Text = range1.ToString();
            x_Unit1_Text.Text = random.Next(xRange).ToString();
            y_Unit1_Text.Text = random.Next(yRange).ToString();

            hpUnit2_Text.Text = hp2.ToString();
            strUnit2_Text.Text = strength2.ToString();
            speedUnit2_Text.Text = speed2.ToString();
            rangeUnit2_Text.Text = range2.ToString();
            x_Unit2_Text.Text = random.Next(xRange).ToString();
            y_Unit2_Text.Text = random.Next(yRange).ToString();

            Unit1_Team.SelectedIndex = team1;
            Unit2_Team.SelectedIndex = team2;
        }

        private void RunSim_Button_Click(object sender, EventArgs e)
        {
            int a = int.Parse(hpUnit1_Text.Text);
            DialogResult = System.Windows.Forms.DialogResult.OK;
            Close();
        }

        private void ValidateTextboxInput(TextBox box, KeyPressEventArgs e, Range r)
        {
            ToolTip tt = new ToolTip();
            string tooltipString = string.Format("Only numbers between {0} - {1} are accepted", r.Lower, r.Upper);

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                tt.Show(tooltipString, box, 50, -20, 1000);
                e.Handled = true;
                return;
            }

            if (char.IsControl(e.KeyChar))
            {
                return;
            }

            int selectedLength = box.SelectionLength;
            string boxEntry = box.Text;
            if (selectedLength > 0)
            {
                boxEntry = boxEntry.Remove(boxEntry.Length - selectedLength);
            }

            if (r.Lower > 1 && boxEntry.Length == 0)
            {
                if (int.Parse(e.KeyChar + "0") < r.Lower)
                {
                    tt.Show(tooltipString, box, 50, -20, 1000);
                    e.Handled = true;
                }

                return;
            }

            int attempedEntry = int.Parse(boxEntry + e.KeyChar);
            if (attempedEntry > r.Upper || attempedEntry < r.Lower)
            {
                tt.Show(tooltipString, box, 50, -20, 1000);
                e.Handled = true;
            }
        }
    }
}
