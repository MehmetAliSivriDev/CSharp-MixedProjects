using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zar_Atma_Programı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random zarsayisi = new Random();
        private void button1_Click(object sender, EventArgs e)
        {
            
            int zar1 = zarsayisi.Next(1,7);
            int zar2 = zarsayisi.Next(1,7);
            
            label1.Text = zar1.ToString();
            label2.Text = zar2.ToString(); 
            

            //1.Zar İçin

            if (label1.Text == "1")
            {
                pictureBox1.ImageLocation = "C:\\Users\\sivri\\Documents\\Yazılım\\C#\\Visual Studio C#\\Zar Atma Programı\\Gerekli Dosyalar\\1.png";
            }

            if (label1.Text == "2")
            {
                pictureBox1.ImageLocation = "C:\\Users\\sivri\\Documents\\Yazılım\\C#\\Visual Studio C#\\Zar Atma Programı\\Gerekli Dosyalar\\2.png";
            }

            if (label1.Text=="3")
            {
                pictureBox1.ImageLocation = "C:\\Users\\sivri\\Documents\\Yazılım\\C#\\Visual Studio C#\\Zar Atma Programı\\Gerekli Dosyalar\\3.png";
            }

            if(label1.Text == "4")
            {
                pictureBox1.ImageLocation = "C:\\Users\\sivri\\Documents\\Yazılım\\C#\\Visual Studio C#\\Zar Atma Programı\\Gerekli Dosyalar\\4.png";
            }

            if (label1.Text == "5")
            {
                pictureBox1.ImageLocation = "C:\\Users\\sivri\\Documents\\Yazılım\\C#\\Visual Studio C#\\Zar Atma Programı\\Gerekli Dosyalar\\5.png";
            }

            if (label1.Text == "6")
            {
                pictureBox1.ImageLocation = "C:\\Users\\sivri\\Documents\\Yazılım\\C#\\Visual Studio C#\\Zar Atma Programı\\Gerekli Dosyalar\\6.png";
            }

            //2.Zar İçin

            if (label2.Text == "1")
            {
                pictureBox2.ImageLocation = "C:\\Users\\sivri\\Documents\\Yazılım\\C#\\Visual Studio C#\\Zar Atma Programı\\Gerekli Dosyalar\\1.png";
            }

            if (label2.Text == "2")
            {
                pictureBox2.ImageLocation = "C:\\Users\\sivri\\Documents\\Yazılım\\C#\\Visual Studio C#\\Zar Atma Programı\\Gerekli Dosyalar\\2.png";
            }

            if (label2.Text == "3")
            {
                pictureBox2.ImageLocation = "C:\\Users\\sivri\\Documents\\Yazılım\\C#\\Visual Studio C#\\Zar Atma Programı\\Gerekli Dosyalar\\3.png";
            }

            if (label2.Text == "4")
            {
                pictureBox2.ImageLocation = "C:\\Users\\sivri\\Documents\\Yazılım\\C#\\Visual Studio C#\\Zar Atma Programı\\Gerekli Dosyalar\\4.png";
            }

            if (label2.Text == "5")
            {
                pictureBox2.ImageLocation = "C:\\Users\\sivri\\Documents\\Yazılım\\C#\\Visual Studio C#\\Zar Atma Programı\\Gerekli Dosyalar\\5.png";
            }

            if (label2.Text == "6")
            {
                pictureBox2.ImageLocation = "C:\\Users\\sivri\\Documents\\Yazılım\\C#\\Visual Studio C#\\Zar Atma Programı\\Gerekli Dosyalar\\6.png";
            }
        }
    }
}
