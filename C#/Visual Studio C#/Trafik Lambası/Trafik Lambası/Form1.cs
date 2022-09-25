using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trafik_Lambası
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button1.BackColor = Color.Red;
            
            timer1.Enabled = true;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            

            int zamanlayıcı = Convert.ToInt32(label1.Text);

            zamanlayıcı++;

            label1.Text = zamanlayıcı.ToString();

            if (zamanlayıcı == 10)
            {
                button2.BackColor = Color.Yellow;
            }
            if (zamanlayıcı == 13)
            {
                button1.BackColor = Color.Gray;
                button2.BackColor = Color.Gray;
                button3.BackColor = Color.Green;
            }
            if (zamanlayıcı == 18)
            {
                button1.BackColor= Color.Red;
                button2.BackColor= Color.Gray;
                button3.BackColor= Color.Gray;
                
                zamanlayıcı = 0;
                label1.Text = zamanlayıcı.ToString();
            }
            
            

           

        }
    }
}
