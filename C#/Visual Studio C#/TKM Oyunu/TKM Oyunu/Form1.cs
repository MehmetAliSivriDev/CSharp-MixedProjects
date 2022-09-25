using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TKM_Oyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random bilgisayar = new Random();

        int pcgame,pcpuan,oyuncupuan;
        private void Form1_Load(object sender, EventArgs e)
        {
            pcpuan = 0;
            oyuncupuan = 0;

            pictureBox1.Visible = false;
            pictureBox2.Visible = false;    
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            groupBox2.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            groupBox2.Visible = true;


            //BİLGİSAYAR KISMI
            pcgame = bilgisayar.Next(0, 3);

            if (pcgame == 0)
            {
                label3.Text = "TAŞ";
                pictureBox2.ImageLocation = "C:\\Users\\sivri\\Documents\\Yazılım\\C#\\Visual Studio C#\\TKM Oyunu\\Gerekli Dosyalar\\taş.png";
            }

            if (pcgame == 1)
            {
                label3.Text = "KAĞIT";
                pictureBox2.ImageLocation = "C:\\Users\\sivri\\Documents\\Yazılım\\C#\\Visual Studio C#\\TKM Oyunu\\Gerekli Dosyalar\\kağıt.png";

            }

            if (pcgame == 2)
            {
                label3.Text = "MAKAS";
                pictureBox2.ImageLocation = "C:\\Users\\sivri\\Documents\\Yazılım\\C#\\Visual Studio C#\\TKM Oyunu\\Gerekli Dosyalar\\makas.png";

            }
            //***********************************************************************************************************************************

            //OYUNCU KISMI

            if (radioButton1.Checked == true)
            {
                label2.Text = "TAŞ";
                pictureBox1.ImageLocation = "C:\\Users\\sivri\\Documents\\Yazılım\\C#\\Visual Studio C#\\TKM Oyunu\\Gerekli Dosyalar\\taş.png";

            }

            if (radioButton2.Checked == true)
            {
                label2.Text = "KAĞIT";
                pictureBox1.ImageLocation = "C:\\Users\\sivri\\Documents\\Yazılım\\C#\\Visual Studio C#\\TKM Oyunu\\Gerekli Dosyalar\\kağıt.png";

            }

            if (radioButton3.Checked == true)
            {
                label2.Text = "MAKAS";
                pictureBox1.ImageLocation = "C:\\Users\\sivri\\Documents\\Yazılım\\C#\\Visual Studio C#\\TKM Oyunu\\Gerekli Dosyalar\\makas.png";
            }
            //***********************************************************************************************************************************

            //KAZANAN BELİRLEME

                //TAŞ
            if (label2.Text == "TAŞ" && label3.Text == "TAŞ")
            {
                label4.Text = "BERABARE!";
            }

            if (label2.Text == "TAŞ" && label3.Text == "KAĞIT")
            {
                label4.Text = "BİLGİSAYAR KAZANDI!";
                pcpuan += 1;
                label8.Text = pcpuan.ToString();
            }

            if (label2.Text == "TAŞ" && label3.Text == "MAKAS")
            {
                label4.Text = "OYUNCU KAZANDI!";
                oyuncupuan += 1;
                label7.Text = oyuncupuan.ToString();    
            }

                //KAĞIT

            if (label2.Text == "KAĞIT" && label3.Text == "KAĞIT")
            {
                label4.Text = "BERABARE!";
            }

            if (label2.Text == "KAĞIT" && label3.Text == "MAKAS")
            {
                label4.Text = "BİLGİSAYAR KAZANDI!";
                pcpuan += 1;
                label8.Text = pcpuan.ToString();
            }

            if (label2.Text == "KAĞIT" && label3.Text == "TAŞ")
            {
                label4.Text = "OYUNCU KAZANDI!";
                oyuncupuan += 1;
                label7.Text = oyuncupuan.ToString();
            }

            //MAKAS

            if (label2.Text == "MAKAS" && label3.Text == "MAKAS")
            {
                label4.Text = "BERABARE!";
            }

            if (label2.Text == "MAKAS" && label3.Text == "TAŞ")
            {
                label4.Text = "BİLGİSAYAR KAZANDI!";
                pcpuan += 1;
                label8.Text = pcpuan.ToString();
            }

            if (label2.Text == "MAKAS" && label3.Text == "KAĞIT")
            {
                label4.Text = "OYUNCU KAZANDI!";
                oyuncupuan += 1;
                label7.Text = oyuncupuan.ToString();
            }

        }
    }
}
