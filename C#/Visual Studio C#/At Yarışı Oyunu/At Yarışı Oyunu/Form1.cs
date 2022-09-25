using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace At_Yarışı_Oyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random gidis = new Random();
        int bahis;

        int birinciatinuzakiligi, ikinciatinuzakligi, ucuncuatinuzakligi;
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label6.Text = "";
            label11.Text = "00";
            comboBox1.Text = "";
            textBox1.Clear();

            pictureBox1.Left = 0;
            pictureBox2.Left = 0;
            pictureBox3.Left = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            bahis = Convert.ToInt32(textBox1.Text);

            int birinciatingenisligi = pictureBox1.Width;
            int ikinciatingenisligi = pictureBox2.Width;
            int ucuncuatingenisligi = pictureBox3.Width;

            int bitis = label5.Left;

            pictureBox1.Left += gidis.Next(5, 15);
            pictureBox2.Left += gidis.Next(5, 15);
            pictureBox3.Left += gidis.Next(5, 15);


            //ANLATIM
            if (pictureBox1.Left > pictureBox2.Left + 5 && pictureBox1.Left > pictureBox3.Left + 5)
            {
                label6.Text = "Birinci At Yarışı Önde Götürüyor!!";
            }
            
            if (pictureBox2.Left > pictureBox1.Left + 5 && pictureBox2.Left > pictureBox3.Left + 5)
            {
                label6.Text = "İkinci At Zirveye Oturmayı Başarıyor!!";
            }
            
            if (pictureBox3.Left > pictureBox1.Left + 5 && pictureBox3.Left > pictureBox2.Left + 5)
            {
                label6.Text = "Üçüncü At Rakiplerinin Önüne Geçmeyi Başardı!!";
            }
            
            
            //KAZANMA
            if (birinciatingenisligi + pictureBox1.Left >= bitis)
            {
                timer1.Enabled = false;
                label6.Text = "Birinci At Yarışı KAZANDI!!";
                axWindowsMediaPlayer1.URL = "C:\\Users\\sivri\\Documents\\Yazılım\\C#\\Visual Studio C#\\At Yarışı Oyunu\\Gerekli Dosyalar\\Kazanma Sesi - Ses Efektleri (mp3cut.net).mp3";

                if  (comboBox1.Text == "1")
                {
                    bahis *= 100;
                    MessageBox.Show("TEBRİKLER BAHİSİ KAZANDINIZ!!");
                    label11.Text = bahis.ToString();
                }
            }

            if (ikinciatingenisligi + pictureBox2.Left >= bitis)
            {
                timer1.Enabled = false;
                label6.Text = "İkinci At Yarışı KAZANDI!!";
                axWindowsMediaPlayer1.URL = "C:\\Users\\sivri\\Documents\\Yazılım\\C#\\Visual Studio C#\\At Yarışı Oyunu\\Gerekli Dosyalar\\Kazanma Sesi - Ses Efektleri (mp3cut.net).mp3";
               
                if (comboBox1.Text == "2")
                {
                    bahis *= 100;
                    MessageBox.Show("TEBRİKLER BAHİSİ KAZANDINIZ!!");
                    label11.Text = bahis.ToString();
                }
            }

            if (ucuncuatingenisligi + pictureBox3.Left >= bitis)
            {
                timer1.Enabled = false;
                label6.Text = "Üçüncü At Yarışı KAZANDI!!";
                axWindowsMediaPlayer1.URL = "C:\\Users\\sivri\\Documents\\Yazılım\\C#\\Visual Studio C#\\At Yarışı Oyunu\\Gerekli Dosyalar\\Kazanma Sesi - Ses Efektleri (mp3cut.net).mp3";

                if (comboBox1.Text == "3")
                {
                    bahis *= 100;
                    MessageBox.Show("TEBRİKLER BAHİSİ KAZANDINIZ!!");
                    label11.Text = bahis.ToString();
                }
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {

            axWindowsMediaPlayer1.Visible = false;
            
            birinciatinuzakiligi = pictureBox1.Left;
            ikinciatinuzakligi = pictureBox2.Left;
            ucuncuatinuzakligi = pictureBox3.Left;
        }
    }
}
