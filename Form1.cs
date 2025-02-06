namespace PrelimApp
{
    public partial class Form1 : Form
    {
        int count;
        public Form1()
        {
            InitializeComponent();
        }
        public void spotter(Button bt1, Button bt2)
        {
            if (bt2.Text == "")
            {
                bt2.Text = bt1.Text;
                bt1.Text = "";
            }
        }
        public void solchecker()
        {
            if (button1.Text == "1" && button2.Text == "2" && button3.Text == "3" && button4.Text == "4" &&
                button5.Text == "5" && button6.Text == "6" && button8.Text == "8" && button10.Text == "10" &&
                button11.Text == "11" && button12.Text == "12" && button13.Text == "13" && button14.Text == "14" &&
                button15.Text == "15" && button16.Text == "")
            {
                MessageBox.Show("Well done, Player 1", "Shuffle Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            count = count + 1;
            textBox1.Text = "Moves: " + count;
            textBox1.Text = count.ToString();
        }

        public void shuffle()
        {
            int[] bnum = new int[16];
            int i, j, rows;
            Boolean flag = false;

            i = 1;
            do
            {
                Random rng = new Random();
                rows = Convert.ToInt32((rng.Next(0, 15)) + 1);

                for (j = 1; j <= i; j++)
                {
                    if (bnum[j] == rows)
                    {
                        flag = true;
                        break;
                    }
                }
                if (flag == true)
                {
                    flag = false;
                }
                else
                {
                    bnum[i] = rows;
                    i = i + 1;
                }
            }
            while (i <= 15);
            button1.Text = Convert.ToString(bnum[1]);
            button2.Text = Convert.ToString(bnum[2]);
            button3.Text = Convert.ToString(bnum[3]);
            button4.Text = Convert.ToString(bnum[4]);
            button5.Text = Convert.ToString(bnum[5]);
            button6.Text = Convert.ToString(bnum[6]);
            button7.Text = Convert.ToString(bnum[7]);
            button8.Text = Convert.ToString(bnum[8]);
            button9.Text = Convert.ToString(bnum[9]);
            button10.Text = Convert.ToString(bnum[10]);
            button11.Text = Convert.ToString(bnum[11]);
            button12.Text = Convert.ToString(bnum[12]);
            button13.Text = Convert.ToString(bnum[13]);
            button14.Text = Convert.ToString(bnum[14]);
            button15.Text = Convert.ToString(bnum[15]);
            button16.Text = "";

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult iExit = MessageBox.Show("Confirm if you want to exit", "Shuffle Games", MessageBoxButtons.YesNo,
                MessageBoxIcon.Information);

            if (iExit == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult iExit = MessageBox.Show("Confirm if you want to exit", "Shuffle Games", MessageBoxButtons.YesNo,
               MessageBoxIcon.Information);

            if (iExit == DialogResult.Yes)
            {
                Application.ExitThread();
            }
        }

        private void showSolutionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button1.Text = Convert.ToString(1);
            button2.Text = Convert.ToString(2);
            button3.Text = Convert.ToString(3);
            button4.Text = Convert.ToString(4);
            button5.Text = Convert.ToString(5);
            button6.Text = Convert.ToString(6);
            button7.Text = Convert.ToString(7);
            button8.Text = Convert.ToString(8);
            button9.Text = Convert.ToString(9);
            button10.Text = Convert.ToString(10);
            button11.Text = Convert.ToString(11);
            button12.Text = Convert.ToString(12);
            button13.Text = Convert.ToString(13);
            button14.Text = Convert.ToString(14);
            button15.Text = Convert.ToString(15);
            button16.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            shuffle();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            spotter(button1, button2);
            spotter(button1, button5);
            solchecker();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            spotter(button2, button1);
            spotter(button2, button3);
            spotter(button2, button6);
            solchecker();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            spotter(button3, button2);
            spotter(button3, button4);
            spotter(button3, button7);
            solchecker();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            spotter(button4, button3);
            spotter(button4, button8);
            solchecker();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            spotter(button5, button1);
            spotter(button5, button6);
            spotter(button5, button9);
            solchecker();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            spotter(button6, button2);
            spotter(button6, button5);
            spotter(button6, button7);
            spotter(button6, button10);
            solchecker();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            spotter(button7, button3);
            spotter(button7, button6);
            spotter(button7, button8);
            spotter(button7, button11);
            solchecker();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            spotter(button8, button4);
            spotter(button8, button7);
            spotter(button8, button12);
            solchecker();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            spotter(button9, button5);
            spotter(button9, button10);
            spotter(button9, button13);
            solchecker();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            spotter(button10, button6);
            spotter(button10, button9);
            spotter(button10, button11);
            spotter(button10, button14);
            solchecker();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            spotter(button11, button7);
            spotter(button11, button10);
            spotter(button11, button12);
            spotter(button11, button15);
            solchecker();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            spotter(button12, button8);
            spotter(button12, button11);
            spotter(button12, button16);
            solchecker();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            spotter(button13, button9);
            spotter(button13, button14);
            solchecker();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            spotter(button14, button10);
            spotter(button14, button13);
            spotter(button14, button15);
            solchecker();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            spotter(button15, button11);
            spotter(button15, button14);
            spotter(button15, button16);
            solchecker();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            spotter(button16, button12);
            spotter(button16, button15);
            solchecker();
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            shuffle();
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            shuffle();
            textBox1.Clear();

            this.Refresh();
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();

        }
    }
}
