using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hayvan_Ses_Oyunu
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Visible = false;

            axWindowsMediaPlayer1.URL = "C:\\Users\\sivri\\Pictures\\Hayvan Programı Fotoğraları\\Hayvan Programı Sesler\\Gerçek İnek Sesi.mp3";


        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("YANLIŞ CEVAP VERDİNİZ!!");
            axWindowsMediaPlayer1.URL = "C:\\Users\\sivri\\Pictures\\Visual Studio C# Fotoğrafları\\Yanlış cevap sesi (dıııt)  Ses Efekti.mp3";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 soru2 = new Form3();

            MessageBox.Show("TEBRİKLER DOĞRU CEVAP VERDİNİZ!!");
            axWindowsMediaPlayer1.URL = "C:\\Users\\sivri\\Pictures\\Visual Studio C# Fotoğrafları\\Kazanma Sesi - Ses Efektleri.mp3";
            soru2.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("YANLIŞ CEVAP VERDİNİZ!!");
            axWindowsMediaPlayer1.URL = "C:\\Users\\sivri\\Pictures\\Visual Studio C# Fotoğrafları\\Yanlış cevap sesi (dıııt)  Ses Efekti.mp3";
        }
    }
}
