using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dragRaceBet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rand = new Random();


        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            checkBox2.Checked = false;
            checkBox3.Checked = false;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            checkBox3.Checked = false;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            checkBox2.Checked = false;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int firstCarDistance = pictureBox1.Width;
            int secondCarDistance = pictureBox2.Width;
            int thirdCarDistance = pictureBox3.Width;

            int finish = finishLine.Left;

            pictureBox1.Left += rand.Next(10, 25);
            pictureBox2.Left += rand.Next(10, 25);
            pictureBox3.Left += rand.Next(10, 25);

            int x = Convert.ToInt32(result.Text);
            int y = Convert.ToInt32(textBox1.Text);

            if (y > x)
            {
                timer1.Enabled = false;
                MessageBox.Show("Don't do a qələt greater than your head !");
            }

            if (firstCarDistance + pictureBox1.Left >= finish)
            {
                if (checkBox1.Checked)
                {
                    x += y;                                 
                }
                else
                {
                    x -= y;                   
                }

                result.Text = x.ToString();
                timer1.Enabled = false;
                MessageBox.Show("First car wins!");
            }

            if (secondCarDistance + pictureBox2.Left >= finish)
            {
                if (checkBox2.Checked)
                {
                    x += y;                    
                }
                else
                {
                    x -= y;                    
                }
                result.Text = x.ToString();
                timer1.Enabled = false;
                MessageBox.Show("Second car wins!");               
            }

            if (thirdCarDistance + pictureBox3.Left >= finish)
            {
                if (checkBox3.Checked)
                {
                    x += y;                 
                }
                else
                {
                    x -= y;                   
                }

                result.Text = x.ToString();
                timer1.Enabled = false;
                MessageBox.Show("Third car wins!");               
            }
        }
        
    }
}
