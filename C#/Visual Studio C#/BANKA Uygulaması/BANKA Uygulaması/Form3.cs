using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BANKA_Uygulaması
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        float dolar = 0;
        float euro = 100;
        float altin = 0;
        float turklirasi = 3000;
        float bitcoin = 1;
         
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 arayuz = new Form2();
            this.Hide();
            arayuz.Show();

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            tl.Text = turklirasi.ToString();
            usd.Text = dolar.ToString();
            eur.Text = euro.ToString();
            agr.Text = altin.ToString();
            btc.Text = bitcoin.ToString();
                
        }
    }
}
