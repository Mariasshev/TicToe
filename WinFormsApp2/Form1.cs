namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        int player = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            button10.Enabled = false;

            if (checkBox1.Checked)
            {
                //computer first
                player = 0;
                if (!CheckWin())
                {
                    if (radioButton2.Checked)
                    {
                        ComputerTurn();
                    }
                    else if (radioButton3.Checked) {
                        SmartComputer();
                    }
                    else if(!radioButton2.Checked && !radioButton3.Checked)
                    {
                        radioButton2.Checked = true;
                        radioButton3.Checked = false;
                        ComputerTurn();
                    }
                    player = 1;
                }
            }
            else
            {
                //user first
                player = 1;
            }
            checkBox1.Enabled = false;
        }

        void SmartComputer()
        {

        }
        private void ComputerTurn()
        {
            if (!CheckWin())
            {
                Random random = new Random();
                Button chosenButton = null;
                do
                {
                    string choice = "button" + random.Next(1, 9);
                    chosenButton = this.Controls.Find(choice, true).FirstOrDefault() as Button;
                } while (chosenButton == null || !string.IsNullOrEmpty(chosenButton.Text));

                if (chosenButton != null)
                {
                    chosenButton.Text = "0";
                }
            }
        }

        bool CheckWin()
        {
            if( button1.Text == button2.Text && button2.Text == button3.Text && button1.Text != "")
            {
                if(button1.Text == "X")
                {
                    MessageBox.Show("Вы выиграли!");
                }
                else
                {
                    MessageBox.Show("Компьютер победил!");
                }
                return true;
            }

            if (button1.Text == button5.Text && button5.Text == button9.Text && button1.Text != "")
            {
                if (button1.Text == "X")
                {
                    MessageBox.Show("Вы выиграли!");
                }
                else
                {
                    MessageBox.Show("Компьютер победил!");
                }
                return true;
            }

            if (button1.Text == button4.Text && button4.Text == button7.Text && button1.Text != "")
            {
                if (button1.Text == "X")
                {
                    MessageBox.Show("Вы выиграли!");
                }
                else
                {
                    MessageBox.Show("Компьютер победил!");
                }
                return true;
            }


            if (button2.Text == button5.Text && button5.Text == button8.Text && button2.Text != "")
            {
                if (button2.Text == "X")
                {
                    MessageBox.Show("Вы выиграли!");
                }
                else
                {
                    MessageBox.Show("Компьютер победил!");
                }
                return true;
            }

            if (button3.Text == button6.Text && button6.Text == button9.Text && button3.Text != "")
            {
                if (button3.Text == "X")
                {
                    MessageBox.Show("Вы выиграли!");
                }
                else
                {
                    MessageBox.Show("Компьютер победил!");
                }
                return true;
            }

            if (button3.Text == button5.Text && button5.Text == button7.Text && button3.Text != "")
            {
                if (button3.Text == "X")
                {
                    MessageBox.Show("Вы выиграли!");
                }
                else
                {
                    MessageBox.Show("Компьютер победил!");
                }
                return true;
            }

            if (button4.Text == button5.Text && button5.Text == button6.Text && button4.Text != "")
            {
                if (button4.Text == "X")
                {
                    MessageBox.Show("Вы выиграли!");
                }
                else
                {
                    MessageBox.Show("Компьютер победил!");
                }
                return true;
            }

            if (button7.Text == button8.Text && button8.Text == button9.Text && button7.Text != "")
            {
                if (button7.Text == "X")
                {
                    MessageBox.Show("Вы выиграли!");
                }
                else
                {
                    MessageBox.Show("Компьютер победил!");
                }
                return true;
            }

            return false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (sender is Button button)
            {
                switch (player)
                {
                    case 1:
                        if (!CheckWin())
                        {
                            if (string.IsNullOrEmpty(button.Text))
                            {
                                button.Text = "X";
                                player = 0;
                            }
                            ComputerTurn();
                            player = 1;
                        }
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
