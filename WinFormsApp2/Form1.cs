namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        int player = 0;
        List<int> changed = new List<int>();
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
            }
            else
            {
                //user first
                player = 1;
            }
            checkBox1.Enabled = false;
        }

        private int ComputerTurn()
        {
            Random random = new Random();
            return random.Next(1, 9);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (player) {
                case 0:
                    if(sender.Butt)
                    player = 1;
                    break;
                case 1:
                    sender.GetType().GetProperty("Text").SetValue(sender, "X");
                    player = 0;
                    break;
                default:
                    break;
            }
        }
    }
}