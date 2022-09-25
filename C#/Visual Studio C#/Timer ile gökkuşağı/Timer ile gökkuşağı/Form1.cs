using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer_ile_gökkuşağı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int sayac;

        private void button7_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;
            label1.Text = sayac.ToString(); 

            if (sayac % 5 == 0)
            {
                button1.BackColor = Color.Red;
                button2.BackColor = Color.Orange;
                button3.BackColor = Color.Yellow;
                button4.BackColor = Color.Green;
                button5.BackColor = Color.Blue;
                button6.BackColor = Color.Purple;

            }

            if (sayac % 10 == 0)
            {
                button1.BackColor = Color.Purple;
                button2.BackColor = Color.Blue;
                button3.BackColor = Color.Green;
                button4.BackColor = Color.Yellow;
                button5.BackColor = Color.Orange;
                button6.BackColor = Color.Red;
            }
        }
    }
}
