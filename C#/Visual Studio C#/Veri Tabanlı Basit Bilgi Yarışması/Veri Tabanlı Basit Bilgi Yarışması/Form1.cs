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

namespace Veri_Tabanlı_Basit_Bilgi_Yarışması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglan = new SqlConnection("Data Source=LAPTOP-O296KKRT;Initial Catalog=bilgiyarisi;Integrated Security=True");

        int soru = 0;
        int puan = 0;
        int zaman = 21;
        private void Form1_Load(object sender, EventArgs e)
        {
            richTextBox1.Enabled = false;
            button2.Visible = false;
            lbldogru.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            zaman = 21;

            button1.Text = "İLERİ";
            soru += 1;
            lblsoru.Text = soru.ToString();

            button2.Visible = false;

            aButton.Enabled = true;
            bButton.Enabled = true;
            cButton.Enabled = true;
            dButton.Enabled = true;
            button1.Enabled = false;

            aButton.BackColor = DefaultBackColor;
            bButton.BackColor = DefaultBackColor;
            cButton.BackColor = DefaultBackColor;
            dButton.BackColor = DefaultBackColor;


            if (soru == 1)
            {
                baglan.Open();

                SqlCommand komut = new SqlCommand("Select *From soru1 order by NEWID()", baglan);
                SqlDataReader oku = komut.ExecuteReader();

                while (oku.Read())
                {
                    richTextBox1.Text = oku["soru"].ToString();
                    aButton.Text = oku["a"].ToString();
                    bButton.Text = oku["b"].ToString();
                    cButton.Text = oku["c"].ToString();
                    dButton.Text = oku["d"].ToString();
                    lbldogru.Text = oku["dogru"].ToString();

                }

                baglan.Close();
            }

            if (soru == 2)
            {
                baglan.Open();

                SqlCommand komut = new SqlCommand("Select *From soru2 order by NEWID()", baglan);
                SqlDataReader oku = komut.ExecuteReader();

                while (oku.Read())
                {
                    richTextBox1.Text = oku["soru"].ToString();
                    aButton.Text = oku["a"].ToString();
                    bButton.Text = oku["b"].ToString();
                    cButton.Text = oku["c"].ToString();
                    dButton.Text = oku["d"].ToString();
                    lbldogru.Text = oku["dogru"].ToString();

                }

                baglan.Close();
            }

            if (soru == 3)
            {
                baglan.Open();

                SqlCommand komut = new SqlCommand("Select *From soru3 order by NEWID()", baglan);
                SqlDataReader oku = komut.ExecuteReader();

                while (oku.Read())
                {
                    richTextBox1.Text = oku["soru"].ToString();
                    aButton.Text = oku["a"].ToString();
                    bButton.Text = oku["b"].ToString();
                    cButton.Text = oku["c"].ToString();
                    dButton.Text = oku["d"].ToString();
                    lbldogru.Text = oku["dogru"].ToString();

                }

                baglan.Close();
            }

            if (soru == 4)
            {
                baglan.Open();

                SqlCommand komut = new SqlCommand("Select *From soru4 order by NEWID()", baglan);
                SqlDataReader oku = komut.ExecuteReader();

                while (oku.Read())
                {
                    richTextBox1.Text = oku["soru"].ToString();
                    aButton.Text = oku["a"].ToString();
                    bButton.Text = oku["b"].ToString();
                    cButton.Text = oku["c"].ToString();
                    dButton.Text = oku["d"].ToString();
                    lbldogru.Text = oku["dogru"].ToString();

                }

                baglan.Close();
            }

            if (soru == 5)
            {
                baglan.Open();

                SqlCommand komut = new SqlCommand("Select *From soru5 order by NEWID()", baglan);
                SqlDataReader oku = komut.ExecuteReader();

                while (oku.Read())
                {
                    richTextBox1.Text = oku["soru"].ToString();
                    aButton.Text = oku["a"].ToString();
                    bButton.Text = oku["b"].ToString();
                    cButton.Text = oku["c"].ToString();
                    dButton.Text = oku["d"].ToString();
                    lbldogru.Text = oku["dogru"].ToString();

                }

                baglan.Close();
            }

            if (soru == 6)
            {
                button2.Visible = true;

                aButton.Enabled = false;
                bButton.Enabled = false;
                cButton.Enabled = false;
                dButton.Enabled = false;
                button1.Enabled = false;
                button1.Text = "BİTTİ";

            }

         
        }

        private void aButton_Click(object sender, EventArgs e)
        {
            if (aButton.Text == lbldogru.Text)
            {
                puan += 1;
                lblpuan.Text = puan.ToString();

                aButton.Enabled = false;
                bButton.Enabled = false;
                cButton.Enabled = false;
                dButton.Enabled = false;
                button1.Enabled = true;

                aButton.BackColor = Color.Green;    
            }
            else
            {
                button2.Visible = true;

                aButton.Enabled = false;
                bButton.Enabled = false;
                cButton.Enabled = false;
                dButton.Enabled = false;
                button1.Enabled = false;
            }
        }

        private void bButton_Click(object sender, EventArgs e)
        {
            if (bButton.Text == lbldogru.Text)
            {
                puan += 1;
                lblpuan.Text = puan.ToString();

                aButton.Enabled = false;
                bButton.Enabled = false;
                cButton.Enabled = false;
                dButton.Enabled = false;
                button1.Enabled = true;

                bButton.BackColor = Color.Green;
            }
            else
            {
                button2.Visible = true;

                aButton.Enabled = false;
                bButton.Enabled = false;
                cButton.Enabled = false;
                dButton.Enabled = false;
                button1.Enabled = false;
            }
        }

        private void cButton_Click(object sender, EventArgs e)
        {
            if (cButton.Text == lbldogru.Text)
            {
                puan += 1;
                lblpuan.Text = puan.ToString();

                aButton.Enabled = false;
                bButton.Enabled = false;
                cButton.Enabled = false;
                dButton.Enabled = false;
                button1.Enabled = true;

                cButton.BackColor = Color.Green;
            }
            else
            {
                button2.Visible = true;

                aButton.Enabled = false;
                bButton.Enabled = false;
                cButton.Enabled = false;
                dButton.Enabled = false;
                button1.Enabled = false;
            }
        }

        private void dButton_Click(object sender, EventArgs e)
        {
            if (dButton.Text == lbldogru.Text)
            {
                puan += 1;
                lblpuan.Text = puan.ToString();

                aButton.Enabled = false;
                bButton.Enabled = false;
                cButton.Enabled = false;
                dButton.Enabled = false;
                button1.Enabled = true;

                dButton.BackColor = Color.Green;
            }
            else
            {
                button2.Visible = true;

                aButton.Enabled = false;
                bButton.Enabled = false;
                cButton.Enabled = false;
                dButton.Enabled = false;
                button1.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            soru = 0;
            puan = 0;
            lblsoru.Text = soru.ToString();
            lblpuan.Text = puan.ToString();
            button1.Enabled = true;
            button1.Text = "BAŞLA";

            timer1.Enabled = false;

            richTextBox1.Clear();
            aButton.Text = "A";
            bButton.Text = "B";
            cButton.Text = "C";
            dButton.Text = "D";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            zaman = zaman - 1;
            lblzaman.Text = zaman.ToString();

            if (zaman == 0)
            {
                timer1.Enabled = false;

                button2.Visible = true;

                aButton.Enabled = false;
                bButton.Enabled = false;
                cButton.Enabled = false;
                dButton.Enabled = false;
                button1.Enabled = false;

            }
        }
    }
}
