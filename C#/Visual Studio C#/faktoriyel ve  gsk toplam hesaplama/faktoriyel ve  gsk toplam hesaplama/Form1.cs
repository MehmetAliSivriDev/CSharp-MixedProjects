using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace faktoriyel_ve__gsk_toplam_hesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int faktoriyel = 1;
            int toplam = 0;


            for (int i =1;i<= Convert.ToInt32(textBox1.Text);i++)
            {
                faktoriyel = faktoriyel * i;
            }
            for (int j =0; j<= Convert.ToInt32(textBox1.Text);j++)
            {
                toplam = toplam + j;
            }
            label3.Text = Convert.ToString(faktoriyel);
            label5.Text = Convert.ToString(toplam);
        }
    }
}
