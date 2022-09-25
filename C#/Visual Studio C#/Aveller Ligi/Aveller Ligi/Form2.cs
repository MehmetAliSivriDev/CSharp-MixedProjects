using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aveller_Ligi
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        int gspuan;
        int fbpuan;
        int tspuan;
        int bjkpuan;

        Random rastgelesayi = new Random(); 
        private void Form2_Load(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            axWindowsMediaPlayer1.Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int gs = rastgelesayi.Next(0, 7);
            int ts = rastgelesayi.Next(0, 7);
            int fb = rastgelesayi.Next(0, 7);
            int bjk = rastgelesayi.Next(0, 7);

            //1.HAFTA

            label7.Text = gs.ToString();
            label8.Text = fb.ToString();
            label9.Text = bjk.ToString();
            label10.Text = ts.ToString();
           
                //1. HAFTA GS - FB
            if (Convert.ToInt32(label7.Text) > Convert.ToInt32(label8.Text))
            {
                gspuan += 3;
            }
            if (Convert.ToInt32(label8.Text) > Convert.ToInt32(label7.Text))
            {
                fbpuan += 3;
            }
            if (Convert.ToInt32(label7.Text) == Convert.ToInt32(label8.Text))
            {
                gspuan += 1;
                fbpuan += 1;
            }

                //1. HAFTA BJK - TS
            if (Convert.ToInt32(label9.Text) > Convert.ToInt32(label10.Text))
            {
                bjkpuan += 3;
            }
            if (Convert.ToInt32(label10.Text) > Convert.ToInt32(label9.Text))
            {
                tspuan += 3;
            }
            if (Convert.ToInt32(label9.Text) == Convert.ToInt32(label10.Text))
            {
                bjkpuan += 1;
                tspuan += 1;
            }

            //2.HAFTA

            label18.Text = gs.ToString();
            label14.Text = fb.ToString();
            label16.Text = bjk.ToString();
            label12.Text = ts.ToString();
                  
                //2. HAFTA GS - BJK
            if (Convert.ToInt32(label18.Text) > Convert.ToInt32(label16.Text))
            {
                gspuan += 3;
            }
            if (Convert.ToInt32(label16.Text) > Convert.ToInt32(label18.Text))
            {
                bjkpuan += 3;
            }
            if (Convert.ToInt32(label18.Text) == Convert.ToInt32(label16.Text))
            {
                gspuan += 1;
                bjkpuan += 1;
            }

                 //2. HAFTA FB - TS
            if (Convert.ToInt32(label14.Text) > Convert.ToInt32(label12.Text))
            {
                fbpuan += 3;
            }
            if (Convert.ToInt32(label12.Text) > Convert.ToInt32(label14.Text))
            {
                tspuan += 3;
            }
            if (Convert.ToInt32(label14.Text) == Convert.ToInt32(label12.Text))
            {
                fbpuan += 1;
                tspuan += 1;
            }

            //3.HAFTA

            label28.Text = gs.ToString();
            label24.Text = fb.ToString();
            label22.Text = bjk.ToString();
            label26.Text = ts.ToString();
                 
                //3. HAFTA GS - TS
            if (Convert.ToInt32(label28.Text) > Convert.ToInt32(label26.Text))
            {
                gspuan += 3;
            }
            if (Convert.ToInt32(label26.Text) > Convert.ToInt32(label28.Text))
            {
                tspuan += 3;
            }
            if (Convert.ToInt32(label28.Text) == Convert.ToInt32(label26.Text))
            {
                gspuan += 1;
                tspuan += 1;
            }

                 //3. HAFTA FB - BJK
            if (Convert.ToInt32(label24.Text) > Convert.ToInt32(label22.Text))
            {
                fbpuan += 3;
            }
            if (Convert.ToInt32(label22.Text) > Convert.ToInt32(label24.Text))
            {
                bjkpuan += 3;
            }
            if (Convert.ToInt32(label24.Text) == Convert.ToInt32(label22.Text))
            {
                bjkpuan += 1;
                fbpuan += 1;
            }

            //4.HAFTA

            label36.Text = gs.ToString();
            label38.Text = fb.ToString();
            label32.Text = bjk.ToString();
            label34.Text = ts.ToString();
                
                //4. HAFTA FB - GS
            if (Convert.ToInt32(label38.Text) > Convert.ToInt32(label36.Text))
            {
                fbpuan += 3;
            }
            if (Convert.ToInt32(label36.Text) > Convert.ToInt32(label38.Text))
            {
                gspuan += 3;
            }
            if (Convert.ToInt32(label38.Text) == Convert.ToInt32(label36.Text))
            {
                gspuan += 1;
                fbpuan += 1;
            }

                //4. HAFTA TS - BJK
            if (Convert.ToInt32(label34.Text) > Convert.ToInt32(label32.Text))
            {
                tspuan += 3;
            }
            if (Convert.ToInt32(label32.Text) > Convert.ToInt32(label34.Text))
            {
                bjkpuan += 3;
            }
            if (Convert.ToInt32(label34.Text) == Convert.ToInt32(label32.Text))
            {
                bjkpuan += 1;
                tspuan += 1;
            }

            //5.HAFTA

            label46.Text = gs.ToString();
            label42.Text = fb.ToString();
            label48.Text = bjk.ToString();
            label44.Text = ts.ToString();
            
                //5. HAFTA BJK - GS
            if (Convert.ToInt32(label48.Text) > Convert.ToInt32(label46.Text))
            {
                bjkpuan += 3;
            }
            if (Convert.ToInt32(label46.Text) > Convert.ToInt32(label48.Text))
            {
                gspuan += 3;
            }
            if (Convert.ToInt32(label48.Text) == Convert.ToInt32(label46.Text))
            {
                gspuan += 1;
                bjkpuan += 1;
            }

                 //5. HAFTA TS - FB
            if (Convert.ToInt32(label44.Text) > Convert.ToInt32(label42.Text))
            {
                tspuan += 3;
            }
            if (Convert.ToInt32(label42.Text) > Convert.ToInt32(label44.Text))
            {
                fbpuan += 3;
            }
            if (Convert.ToInt32(label44.Text) == Convert.ToInt32(label42.Text))
            {
                fbpuan += 1;
                tspuan += 1;
            }

            //6.HAFTA

            label56.Text = gs.ToString();
            label52.Text = fb.ToString();
            label54.Text = bjk.ToString();
            label58.Text = ts.ToString();
            
               //6. HAFTA TS - GS
            if (Convert.ToInt32(label58.Text) > Convert.ToInt32(label56.Text))
            {
                tspuan += 3;
            }
            if (Convert.ToInt32(label56.Text) > Convert.ToInt32(label58.Text))
            {
                gspuan += 3;
            }
            if (Convert.ToInt32(label58.Text) == Convert.ToInt32(label56.Text))
            {
                gspuan += 1;
                tspuan += 1;
            }

              //6. HAFTA BJK - FB
            if (Convert.ToInt32(label54.Text) > Convert.ToInt32(label52.Text))
            {
                bjkpuan += 3;
            }
            if (Convert.ToInt32(label52.Text) > Convert.ToInt32(label54.Text))
            {
                fbpuan += 3;
            }
            if (Convert.ToInt32(label54.Text) == Convert.ToInt32(label52.Text))
            {
                bjkpuan += 1;
                fbpuan += 1;
            }

            //PUAN TABLOSU

            label68.Text = gspuan.ToString();
            label64.Text = bjkpuan.ToString();
            label62.Text = tspuan.ToString();
            label66.Text = fbpuan.ToString();

            //ŞAMPİYONLUK SIRALAMASI 

            if(gspuan > fbpuan && gspuan > bjkpuan && gspuan > tspuan)
            {
                pictureBox1.Visible = true;
                MessageBox.Show("ŞAMPİYON GALATASARAY!!");
                pictureBox1.ImageLocation = "C:\\Users\\sivri\\Pictures\\Visual Studio C# Fotoğrafları\\gsarma.jpg";
                axWindowsMediaPlayer1.URL = "C:\\Users\\sivri\\Pictures\\Visual Studio C# Fotoğrafları\\Kazanma Sesi - Ses Efektleri.mp3";
            }
            if (fbpuan > gspuan && fbpuan > bjkpuan && fbpuan > tspuan)
            {
                pictureBox1.Visible = true;
                MessageBox.Show("ŞAMPİYON FENERBAHÇE!!");
                pictureBox1.ImageLocation = "C:\\Users\\sivri\\Pictures\\Visual Studio C# Fotoğrafları\\fenerbahçe arması.png";
                axWindowsMediaPlayer1.URL = "C:\\Users\\sivri\\Pictures\\Visual Studio C# Fotoğrafları\\Kazanma Sesi - Ses Efektleri.mp3";
            }
            if (bjkpuan > gspuan && bjkpuan > fbpuan && bjkpuan > tspuan)
            {
                pictureBox1.Visible = true;
                MessageBox.Show("ŞAMPİYON BEŞİKTAŞ!!");
                pictureBox1.ImageLocation = "C:\\Users\\sivri\\Pictures\\Visual Studio C# Fotoğrafları\\beşiktaş arması.png";
                axWindowsMediaPlayer1.URL = "C:\\Users\\sivri\\Pictures\\Visual Studio C# Fotoğrafları\\Kazanma Sesi - Ses Efektleri.mp3";
            }
            if (tspuan > gspuan && tspuan > bjkpuan && tspuan > fbpuan)
            {
                pictureBox1.Visible = true;
                MessageBox.Show("ŞAMPİYON TRABZONSPOR!!");
                pictureBox1.ImageLocation = "C:\\Users\\sivri\\Pictures\\Visual Studio C# Fotoğrafları\\trabzonspor arması.png";
                axWindowsMediaPlayer1.URL = "C:\\Users\\sivri\\Pictures\\Visual Studio C# Fotoğrafları\\Kazanma Sesi - Ses Efektleri.mp3";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label7.Text = "0";
            label8.Text = "0";
            label9.Text = "0";
            label10.Text = "0";
            label12.Text = "0";
            label14.Text = "0";
            label16.Text = "0";
            label18.Text = "0";
            label22.Text = "0";
            label24.Text = "0";
            label26.Text = "0";
            label28.Text = "0";
            label32.Text = "0";
            label34.Text = "0";
            label36.Text = "0";
            label38.Text = "0";
            label42.Text = "0";
            label44.Text = "0";
            label46.Text = "0";
            label48.Text = "0";
            label52.Text = "0";
            label54.Text = "0";
            label56.Text = "0";
            label58.Text = "0";
            label62.Text = "0";
            label64.Text = "0";
            label66.Text = "0";
            label68.Text = "0";
            pictureBox1.Visible = false;
        }
    }
}
