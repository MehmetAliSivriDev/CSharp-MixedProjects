using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kurs_Kayıt_Programı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        new Form2 giris = new Form2();  

        int sayac = 4;
        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "admin" && textBox2.Text == "1234")
            {
                giris.Show();
                this.Hide();
                
            }
            else
            {
                sayac--;
                MessageBox.Show("Şifreyi Yanlış Girdiniz Lütfen Tekrar Deneyiniz! Kalan Hakkınız = " + sayac.ToString() , "Hatalı Giriş");
                textBox1.Clear();
                textBox2.Clear();

                if (sayac == 0)
                {
                    MessageBox.Show("Birden Fazla Hatalı Giriş Yaptınız Sistem Kilitleniyor!");
                    button1.Enabled = false;    
                }
            }



           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Focus();
        }
    }
}
