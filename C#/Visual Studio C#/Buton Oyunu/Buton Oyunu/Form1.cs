using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buton_Oyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int puan;
        private void timer1_Tick(object sender, EventArgs e)
        {
            
            int timer = Convert.ToInt32(label1.Text);

            timer++;

            label1.Text = timer.ToString();
            
            if (timer == 1000)
            {
                timer1.Enabled = false;
                MessageBox.Show("Oyun Bitti!");

            }

            //BUTTON 1
            if (timer %13 == 0)
            {
                button1.BackColor = Color.Green;
            }
            if (timer %10 == 0)
            {
                button1.BackColor= Color.Red;
            }

            if (button1.BackColor == Color.Green)
            {
                button1.Enabled = true;

            }
            if (button1.BackColor == Color.Red)
            {
                button1.Enabled= false;
            }

            //BUTTON 2
            if (timer % 15 == 0)
            {
                button2.BackColor = Color.Green;
            }
            if (timer % 12 == 0)
            {
                button2.BackColor = Color.Red;
            }

            if (button2.BackColor == Color.Green)
            {
                button2.Enabled = true;

            }
            if (button2.BackColor == Color.Red)
            {
                button2.Enabled = false;
            }

            //BUTTON 3
            if (timer % 16 == 0)
            {
                button3.BackColor = Color.Green;
            }
            if (timer % 15 == 0)
            {
                button3.BackColor = Color.Red;
            }

            if (button3.BackColor == Color.Green)
            {
                button3.Enabled = true;

            }
            if (button3.BackColor == Color.Red)
            {
                button3.Enabled = false;
            }

            //BUTTON 4
            if (timer % 20 == 0)
            {
                button4.BackColor = Color.Green;
            }
            if (timer % 28 == 0)
            {
                button4.BackColor = Color.Red;
            }

            if (button4.BackColor == Color.Green)
            {
                button4.Enabled = true;

            }
            if (button4.BackColor == Color.Red)
            {
                button4.Enabled = false;
            }

            //BUTTON 5
            if (timer % 14 == 0)
            {
                button5.BackColor = Color.Green;
            }
            if (timer %12  == 0)
            {
                button5.BackColor = Color.Red;
            }

            if (button5.BackColor == Color.Green)
            {
                button5.Enabled = true;

            }
            if (button5.BackColor == Color.Red)
            {
                button5.Enabled = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            //label1.Visible = false;
              
        }

        private void button11_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            puan += 1;
            label2.Text = Convert.ToString(puan);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            puan += 1;
            label2.Text = Convert.ToString(puan);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            puan += 1;
            label2.Text = Convert.ToString(puan);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            puan += 1;
            label2.Text = Convert.ToString(puan);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            puan += 1;
            label2.Text = Convert.ToString(puan);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button1.BackColor = Color.Gray;
            button2.BackColor = Color.Gray;
            button3.BackColor = Color.Gray;
            button4.BackColor = Color.Gray;
            button5.BackColor = Color.Gray;
            label2.Text = "0";
            label1.Text = "0";
        }
    }
}
