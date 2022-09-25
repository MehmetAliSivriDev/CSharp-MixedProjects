using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BANKA_Uygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglan = new SqlConnection("Data Source=LAPTOP-O296KKRT;Initial Catalog=bankauygulaması;Integrated Security=True");


        string kullanici, sifre;
        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = "C:\\Users\\sivri\\Documents\\Yazılım\\C#\\Visual Studio C#\\BANKA Uygulaması\\Gerekli Dosyalar\\images.jpg";
            axWindowsMediaPlayer1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglan.Open();

            SqlCommand komut = new SqlCommand("Select *From hesaplar where kullanici='" + kullanici + "',sifre='" + sifre + "'" ,baglan);
            SqlDataReader oku = komut.ExecuteReader();

            if (oku.Read())
            {
                    Form2 arayuz = new Form2();
                    arayuz.Show();
                    this.Hide();

            }


                /*if (textBox1.Text == oku["kullanici"].ToString() && textBox2.Text == oku["sifre"].ToString())
                {
                    
                }
                else
                {
                    axWindowsMediaPlayer1.URL = "C:\\Users\\sivri\\Pictures\\Visual Studio C# Fotoğrafları\\Yanlış cevap sesi (dıııt)  Ses Efekti.mp3";
                    MessageBox.Show("Yanlış Giriş Yaptınız Tekrar Deneyiniz!!");
                }
                */

            baglan.Close();
        }
    }
}
