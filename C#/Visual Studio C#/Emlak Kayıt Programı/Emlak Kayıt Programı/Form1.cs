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

namespace Emlak_Kayıt_Programı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        SqlConnection baglan = new SqlConnection("Data Source=LAPTOP-O296KKRT;Initial Catalog=EmlakBilgisi;Integrated Security=True");
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Zambak Sitesi")
            {
                zmkButton.BackColor = Color.Green;
                gulButton.BackColor = Color.Red;
                mnkButton.BackColor = Color.Red;
                pptButton.BackColor = Color.Red;
            }

            if (comboBox1.Text == "Gül Sitesi")
            {
                zmkButton.BackColor = Color.Red;
                gulButton.BackColor = Color.Green;
                mnkButton.BackColor = Color.Red;
                pptButton.BackColor = Color.Red;
            }

            if (comboBox1.Text == "Menekşe Sitesi")
            {
                zmkButton.BackColor = Color.Red;
                gulButton.BackColor = Color.Red;
                mnkButton.BackColor = Color.Green;
                pptButton.BackColor = Color.Red;
            }

            if (comboBox1.Text == "Papatya Sitesi")
            {
                zmkButton.BackColor = Color.Red;
                gulButton.BackColor = Color.Red;
                mnkButton.BackColor = Color.Red;
                pptButton.BackColor = Color.Green;
            }
        }

        private void verigoruntuleme ()
        {
            listView1.Items.Clear();

            baglan.Open();

            SqlCommand komut = new SqlCommand("Select *From emlaktablo", baglan);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();

                ekle.Text = oku["id"].ToString();
                ekle.SubItems.Add(oku["site"].ToString());
                ekle.SubItems.Add(oku["satkira"].ToString());
                ekle.SubItems.Add(oku["oda"].ToString());
                ekle.SubItems.Add(oku["metrekare"].ToString());
                ekle.SubItems.Add(oku["fiyat"].ToString());
                ekle.SubItems.Add(oku["blok"].ToString());
                ekle.SubItems.Add(oku["no"].ToString());
                ekle.SubItems.Add(oku["adsoyad"].ToString());
                ekle.SubItems.Add(oku["telefon"].ToString());
                ekle.SubItems.Add(oku["notlar"].ToString());

                listView1.Items.Add(ekle);

            }

            baglan.Close();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            verigoruntuleme();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglan.Open();

            SqlCommand kaydet = new SqlCommand("Insert into emlaktablo (id,site,satkira,oda,metrekare,fiyat,blok,no,adsoyad,telefon,notlar) values ('" + textBox1.Text.ToString() + "','" + comboBox1.Text.ToString() + "','" + comboBox2.Text.ToString() + "','" + comboBox3.Text.ToString() + "','" + textBox2.Text.ToString() + "','" + textBox3.Text.ToString() + "','" + textBox4.Text.ToString() + "','" + textBox5.Text.ToString() + "','" + textBox6.Text.ToString() + "','" + textBox7.Text.ToString() + "','" + textBox8.Text.ToString() + "')", baglan);
            kaydet.ExecuteNonQuery();
            baglan.Close();
            verigoruntuleme();

            textBox1.Clear();
            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();

            zmkButton.BackColor = Color.IndianRed;
            gulButton.BackColor = Color.IndianRed;
            mnkButton.BackColor = Color.IndianRed;
            pptButton.BackColor = Color.IndianRed;  

        }

        int id = 0;
        private void button3_Click(object sender, EventArgs e)
        {
            baglan.Open();

            SqlCommand sil = new SqlCommand("Delete From emlaktablo where id = (" + id + ")", baglan);
            sil.ExecuteNonQuery();
            baglan.Close();
            verigoruntuleme();

            textBox1.Clear();
            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();

            zmkButton.BackColor = Color.IndianRed;
            gulButton.BackColor = Color.IndianRed;
            mnkButton.BackColor = Color.IndianRed;
            pptButton.BackColor = Color.IndianRed;

        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);

            textBox1.Text = listView1.SelectedItems[0].SubItems[0].Text;
            comboBox1.Text = listView1.SelectedItems[0].SubItems[1].Text;
            comboBox2.Text = listView1.SelectedItems[0].SubItems[2].Text;
            comboBox3.Text = listView1.SelectedItems[0].SubItems[3].Text;
            textBox2.Text = listView1.SelectedItems[0].SubItems[4].Text;
            textBox3.Text = listView1.SelectedItems[0].SubItems[5].Text;
            textBox4.Text = listView1.SelectedItems[0].SubItems[6].Text;
            textBox5.Text = listView1.SelectedItems[0].SubItems[7].Text;
            textBox6.Text = listView1.SelectedItems[0].SubItems[8].Text;
            textBox7.Text = listView1.SelectedItems[0].SubItems[9].Text;
            textBox8.Text = listView1.SelectedItems[0].SubItems[10].Text;

            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            baglan.Open();

            SqlCommand duzenle = new SqlCommand("Update emlaktablo set id = '" + textBox1.Text.ToString() + "',site='" + comboBox1.Text.ToString() + "',satkira='" + comboBox2.Text.ToString() + "',oda='" + comboBox3.Text.ToString() + "',metrekare='" + textBox2.Text.ToString() + "',fiyat='" + textBox3.Text.ToString() + "',blok='" + textBox4.Text.ToString() + "',no='" + textBox5.Text.ToString() + "',adsoyad='" + textBox6.Text.ToString() + "',telefon='" + textBox7.Text.ToString() + "',notlar='" + textBox8.Text.ToString() + "' where id = " + id + "", baglan);
            duzenle.ExecuteNonQuery();
            baglan.Close();
            verigoruntuleme();

            textBox1.Clear();
            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();

            zmkButton.BackColor = Color.IndianRed;
            gulButton.BackColor = Color.IndianRed;
            mnkButton.BackColor = Color.IndianRed;
            pptButton.BackColor = Color.IndianRed;
        }

    }
}
