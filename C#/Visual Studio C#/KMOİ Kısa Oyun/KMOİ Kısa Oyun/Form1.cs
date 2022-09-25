using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KMOİ_Kısa_Oyun
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int sorusayi = 0;
        int soruparasi = 0;
        int oyuncupara = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = "İLERİ";
            sorusayi += 1;
            label2.Text = Convert.ToString(sorusayi);
            
            if (sorusayi == 1)
            {
                richTextBox1.Text = "Günümüzde kullanılan miladi takvime göre, M.Ö. 1 Ocak 1 tarihinde doğan birinin, M.S. 1 Ocak 1 tarihi kaçıncı doğum yıl dönümüdür?";

                button2.Text = "0";
                button3.Text = "1";
                button4.Text = "2";
                button5.Text = "3";

                label5.Text = "1";

                soruparasi += 1000;
                label8.Text = Convert.ToString(soruparasi);
            }

            if (sorusayi == 2)
            {
                richTextBox1.Text = "Türkiye'de hangi adda bir yarımada vardır?";

                button2.Text = "İnebolu";
                button3.Text = "Tirebolu";
                button4.Text = "Hayrabolu";
                button5.Text = "Gelibolu";

                label5.Text = "Gelibolu";

                soruparasi += 2000;
                label8.Text = Convert.ToString(soruparasi);

                //BUTON AYARI

                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;

                button2.BackColor = Color.White;
                button3.BackColor = Color.White;
                button4.BackColor = Color.White;
                button5.BackColor = Color.White;
            }

            if (sorusayi == 3)
            {
                richTextBox1.Text = "Hangisi Oğlak Dönencesi üzerinde toprağı bulunan ülkelerden biri değildir?";

                button2.Text = "Hindistan";
                button3.Text = "Mozambik";
                button4.Text = "Brezilya";
                button5.Text = "Avustralya";

                label5.Text = "Hindistan";

                soruparasi += 4000;
                label8.Text = Convert.ToString(soruparasi);

                //BUTON AYARI

                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;

                button2.BackColor = Color.White;
                button3.BackColor = Color.White;
                button4.BackColor = Color.White;
                button5.BackColor = Color.White;
            }

            if (sorusayi == 4)
            {
                richTextBox1.Text = "Hangisini onaran veya yapıp satan kişiye (lutiye) denir?";

                button2.Text = "Beyaz Eşya";
                button3.Text = "Mobilya";
                button4.Text = "Enstrüman";
                button5.Text = "Oyuncak";

                label5.Text = "Enstrüman";

                soruparasi += 8000;
                label8.Text = Convert.ToString(soruparasi);

                //BUTON AYARI

                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;

                button2.BackColor = Color.White;
                button3.BackColor = Color.White;
                button4.BackColor = Color.White;
                button5.BackColor = Color.White;
            }

            if (sorusayi == 5)
            {
                richTextBox1.Text = "Bristol Üniversitesi'nin araştırmasına göre, 17 yaşında başlayıp 71 yaşına kadar günde yaklaşık 1 paket sigara içen bir erkeğin içtiği her sigara ömrünü ortalama ne kadar azaltmaktadır?";

                button2.Text = "1 Dakika";
                button3.Text = "5 Dakika";
                button4.Text = "11 Dakika";
                button5.Text = "55 Dakika";

                label5.Text = "11 Dakika";

                soruparasi += 16000;
                label8.Text = Convert.ToString(soruparasi);

                //BUTON AYARI

                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;

                button2.BackColor = Color.White;
                button3.BackColor = Color.White;
                button4.BackColor = Color.White;
                button5.BackColor = Color.White;

                //BİTİŞ
                button1.Text = "BİTİR";
            }
            
            if (sorusayi == 6)
            {
                button1.Visible = false;
                button8.Visible = true;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label6.Text = button2.Text;

            if (label5.Text == label6.Text)
            {
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;

                button2.BackColor = Color.Green;
                button3.BackColor = Color.Red;
                button4.BackColor = Color.Red;
                button5.BackColor = Color.Red;

                oyuncupara += soruparasi;
                label4.Text = Convert.ToString(oyuncupara);
            }
            else
            {
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;

                button8.Visible = true;

                button2.BackColor = Color.Gray;
                button3.BackColor = Color.Gray;
                button4.BackColor = Color.Gray;
                button5.BackColor = Color.Gray;

                MessageBox.Show("Soruyu Yanlış Bildiniz Elendiniz!");

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            label6.Text = button3.Text;

            if (label5.Text == label6.Text)
            {
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;

                button2.BackColor = Color.Red;
                button3.BackColor = Color.Green;
                button4.BackColor = Color.Red;
                button5.BackColor = Color.Red;

                oyuncupara += soruparasi;
                label4.Text = Convert.ToString(oyuncupara);
            }
            else
            {
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;

                button8.Visible = true;

                button2.BackColor = Color.Gray;
                button3.BackColor = Color.Gray;
                button4.BackColor = Color.Gray;
                button5.BackColor = Color.Gray;

                MessageBox.Show("Soruyu Yanlış Bildiniz Elendiniz!");
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            label6.Text = button4.Text;

            if (label5.Text == label6.Text)
            {
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;

                button2.BackColor = Color.Red;
                button3.BackColor = Color.Red;
                button4.BackColor = Color.Green;
                button5.BackColor = Color.Red;

                oyuncupara += soruparasi;
                label4.Text = Convert.ToString(oyuncupara);
            }
            else
            {
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;

                button8.Visible = true;

                button2.BackColor = Color.Gray;
                button3.BackColor = Color.Gray;
                button4.BackColor = Color.Gray;
                button5.BackColor = Color.Gray;

                MessageBox.Show("Soruyu Yanlış Bildiniz Elendiniz!");
            }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label6.Text = button5.Text;

            if (label5.Text == label6.Text)
            {
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;

                button2.BackColor = Color.Red;
                button3.BackColor = Color.Red;
                button4.BackColor = Color.Red;
                button5.BackColor = Color.Green;

                oyuncupara += soruparasi;
                label4.Text = Convert.ToString(oyuncupara);
            }
            else
            {
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;

                button8.Visible = true;

                button2.BackColor = Color.Gray;
                button3.BackColor = Color.Gray;
                button4.BackColor = Color.Gray;
                button5.BackColor = Color.Gray;

                MessageBox.Show("Soruyu Yanlış Bildiniz Elendiniz!");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button8.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            
            //TEKRARLAMA İŞLEMLERİ
            
            sorusayi = 0;
            soruparasi = 0;
            oyuncupara = 0;

            label2.Text = Convert.ToString(sorusayi);    
            label4.Text = Convert.ToString(oyuncupara);
            label5.Text = "0";
            label6.Text = "0";
            label8.Text = Convert.ToString(soruparasi);


            richTextBox1.Clear();

            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;

            button2.BackColor = Color.White;
            button3.BackColor = Color.White;
            button4.BackColor = Color.White;
            button5.BackColor = Color.White;

            button1.Text = "BAŞLAT";
            button2.Text = "A";
            button3.Text = "B";
            button4.Text = "C";
            button5.Text = "D";

            button8.Visible = false;
            button1.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (sorusayi == 1)
            {
                button2.Enabled = false;
                button4.Enabled = false;
                button6.Enabled = false;
            }

            if (sorusayi == 2)
            {
                button3.Enabled = false;
                button4.Enabled = false;
                button6.Enabled = false;
            }

            if(sorusayi == 3)
            {
                button3.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
            }

            if(sorusayi == 4)
            {
                button2.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
            }

            if(sorusayi == 5)
            {
                button3.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (sorusayi == 1)
            {
                MessageBox.Show("Seyirci Çoğunlukla 1 Diyor!");
                button7.Enabled = false;
            }

            if (sorusayi == 2)
            {
                MessageBox.Show("Seyirci Çoğunlukla Gelibolu Diyor!");
                button7.Enabled = false;
            }

            if (sorusayi == 3)
            {
                MessageBox.Show("Seyirci Çoğunlukla Hindistan Diyor!");
                button7.Enabled = false;
            }

            if (sorusayi == 4)
            {
                MessageBox.Show("Seyirci Çoğunlukla Enstrüman Diyor!");
                button7.Enabled = false;
            }

            if (sorusayi == 5)
            {
                MessageBox.Show("Seyirci Çoğunlukla 11 Dakika Diyor!");
                button7.Enabled = false;
            }


        }
    }
}
