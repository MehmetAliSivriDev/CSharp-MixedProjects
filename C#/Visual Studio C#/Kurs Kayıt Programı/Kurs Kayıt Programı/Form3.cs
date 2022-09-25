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

namespace Kurs_Kayıt_Programı
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        SqlConnection baglan = new SqlConnection("Data Source=LAPTOP-O296KKRT;Initial Catalog=Kulüp Bilgileri;Integrated Security=True");
        private void verigoruntuleme ()
        {
            listView1.Items.Clear();
            
            baglan.Open ();

            SqlCommand komut = new SqlCommand("Select *From ogk",baglan);
            SqlDataReader oku = komut.ExecuteReader ();

            while ( oku.Read ())
            {
                ListViewItem ekle = new ListViewItem ();

                ekle.Text = oku["id"].ToString();
                ekle.SubItems.Add(oku["adsoyad"].ToString());
                ekle.SubItems.Add(oku["no"].ToString());
                ekle.SubItems.Add(oku["eposta"].ToString ());
                ekle.SubItems.Add(oku["bolum"].ToString());
                ekle.SubItems.Add(oku["sinif"].ToString());
                
                listView1 .Items.Add (ekle);    

            }
            
            baglan.Close();
        }



        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void kytButton_Click(object sender, EventArgs e)
        {
            baglan.Open();

            SqlCommand kaydet = new SqlCommand("Insert into ogk (id,adsoyad,no,eposta,bolum,sinif) values ('" + textBox1.Text.ToString() + "','" + textBox2.Text.ToString() + "','" + textBox3.Text.ToString() + "','" + textBox4.Text.ToString() + "','" + textBox5.Text.ToString() + "','" + comboBox1.Text.ToString() + "')", baglan);
            kaydet.ExecuteNonQuery ();
            baglan.Close();
            verigoruntuleme();

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            comboBox1.Text = "";

           
        }

        private void grtButton_Click(object sender, EventArgs e)
        {
            verigoruntuleme();
        }

        int id = 0;
        private void silButton_Click(object sender, EventArgs e)
        {
            baglan.Open();

            SqlCommand silme = new SqlCommand("Delete From ogk where id = (" + id + ")", baglan);
            silme.ExecuteNonQuery ();
            baglan.Close();
            verigoruntuleme();

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            comboBox1.Text = "";


        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);

            textBox1.Text = listView1.SelectedItems[0].SubItems[0].Text;
            textBox2.Text = listView1.SelectedItems[0].SubItems[1].Text;
            textBox3.Text = listView1.SelectedItems[0].SubItems[2].Text;
            textBox4.Text = listView1.SelectedItems[0].SubItems[3].Text;
            textBox5.Text = listView1.SelectedItems[0].SubItems[4].Text;
            comboBox1.Text = listView1.SelectedItems[0].SubItems[5].Text;


        }

        private void dznButton_Click(object sender, EventArgs e)
        {
            baglan.Open();

            SqlCommand duzenle = new SqlCommand("Update ogk set id = '" + textBox1.Text.ToString() + "',adsoyad='" + textBox2.Text.ToString() + "',no='" + textBox3.Text.ToString() + "',eposta='" + textBox4.Text.ToString() + "',bolum='" + textBox5.Text.ToString() + "',sinif='" + comboBox1.Text.ToString() + "'", baglan);
            duzenle.ExecuteNonQuery();
            baglan.Close();
            verigoruntuleme();

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            comboBox1.Text = "";
        }
    }
}
