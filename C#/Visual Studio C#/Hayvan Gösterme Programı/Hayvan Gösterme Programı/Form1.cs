using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hayvan_Gösterme_Programı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            axWindowsMediaPlayer1.Visible = false;

            pictureBox1.ImageLocation = "C:\\Users\\sivri\\Pictures\\Hayvan Programı Fotoğraları\\aslan.jpg";
            axWindowsMediaPlayer1.URL = "C:\\Users\\sivri\\Pictures\\Hayvan Programı Fotoğraları\\Hayvan Programı Sesler\\Muazzam Aslan Sesi.mp3";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            axWindowsMediaPlayer1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            axWindowsMediaPlayer1.Visible = false;

            pictureBox1.ImageLocation = "C:\\Users\\sivri\\Pictures\\Hayvan Programı Fotoğraları\\maymun.jpeg";
            axWindowsMediaPlayer1.URL = "C:\\Users\\sivri\\Pictures\\Hayvan Programı Fotoğraları\\Hayvan Programı Sesler\\MAYMUN SESİ (MAYMUN ÇARLİ).mp3";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            axWindowsMediaPlayer1.Visible = false;

            pictureBox1.ImageLocation = "C:\\Users\\sivri\\Pictures\\Hayvan Programı Fotoğraları\\ayı.jpg";
            axWindowsMediaPlayer1.URL = "C:\\Users\\sivri\\Pictures\\Hayvan Programı Fotoğraları\\Hayvan Programı Sesler\\ayı sesi   ÖZEL KAYIT  ( HD ).mp3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            axWindowsMediaPlayer1.Visible = false;

            pictureBox1.ImageLocation = "C:\\Users\\sivri\\Pictures\\Hayvan Programı Fotoğraları\\bülbül.jpg";
            axWindowsMediaPlayer1.URL = "C:\\Users\\sivri\\Pictures\\Hayvan Programı Fotoğraları\\Hayvan Programı Sesler\\Canlı Bülbül Sesi HD.mp3";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            axWindowsMediaPlayer1.Visible = false;

            pictureBox1.ImageLocation = "C:\\Users\\sivri\\Pictures\\Hayvan Programı Fotoğraları\\inek.jpg";
            axWindowsMediaPlayer1.URL = "C:\\Users\\sivri\\Pictures\\Hayvan Programı Fotoğraları\\Hayvan Programı Sesler\\Gerçek İnek Sesi.mp3";
        }
    }
}
