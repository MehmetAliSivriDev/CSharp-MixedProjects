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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Visible = false;
            axWindowsMediaPlayer1.URL = "C:\\Users\\sivri\\Pictures\\Hayvan Programı Fotoğraları\\Hayvan Programı Sesler\\MAYMUN SESİ (MAYMUN ÇARLİ).mp3";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 soru3 = new Form4();

            MessageBox.Show("TEBRİKLER DOĞRU CEVAP VERDİNİZ!!");
            axWindowsMediaPlayer1.URL = "C:\\Users\\sivri\\Pictures\\Visual Studio C# Fotoğrafları\\Kazanma Sesi - Ses Efektleri.mp3";
            
            soru3.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("YANLIŞ CEVAP VERDİNİZ!!");
            axWindowsMediaPlayer1.URL = "C:\\Users\\sivri\\Pictures\\Visual Studio C# Fotoğrafları\\Yanlış cevap sesi (dıııt)  Ses Efekti.mp3";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("YANLIŞ CEVAP VERDİNİZ!!");
            axWindowsMediaPlayer1.URL = "C:\\Users\\sivri\\Pictures\\Visual Studio C# Fotoğrafları\\Yanlış cevap sesi (dıııt)  Ses Efekti.mp3";
        }
    }
}
