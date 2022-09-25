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

namespace Kütüphane_Kayıt_Defteri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglan = new SqlConnection("Data Source=LAPTOP-O296KKRT;Initial Catalog=Kütüphane Kayıt Defteri;Integrated Security=True");

        private void verigoruntuleme ()
        {
            listView1.Items.Clear();
            
            baglan.Open ();
            SqlCommand komut = new SqlCommand("Select *From kutuphanebilgi", baglan);
            SqlDataReader oku = komut.ExecuteReader ();

            while ( oku.Read ())
            {
                ListViewItem ekle = new ListViewItem ();
                ekle.Text = oku["id"].ToString ();
                ekle.SubItems.Add(oku["kitapad"].ToString ());
                ekle.SubItems.Add(oku["yazar"].ToString());
                ekle.SubItems.Add(oku["yayinevi"].ToString());
                ekle.SubItems.Add(oku["konu"].ToString()); 
                ekle.SubItems.Add(oku["sayfa"].ToString());

                listView1.Items.Add (ekle); 
            }
            baglan.Close ();    
        }


        private void button1_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand yazdirma = new SqlCommand("Insert into kutuphanebilgi (id,kitapad,yazar,yayinevi,konu,sayfa) values ('" + textBox1.Text.ToString() + "','" + textBox2.Text.ToString() + "','" + textBox3.Text.ToString() + "','" + textBox4.Text.ToString() + "','" + textBox5.Text.ToString() + "','" + textBox6.Text.ToString() + "')", baglan);
            yazdirma.ExecuteNonQuery ();
            baglan.Close();
            verigoruntuleme();
            textBox1.Clear ();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();

        }

        int id = 0;

        private void button2_Click(object sender, EventArgs e)
        {
            baglan.Open ();
            SqlCommand silme = new SqlCommand("Delete From kutuphanebilgi where id = (" + id + ")", baglan);
            silme.ExecuteNonQuery ();
            baglan.Close();
            verigoruntuleme ();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();

        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            textBox1.Text = listView1.SelectedItems[0].SubItems[0].Text;
            textBox2.Text = listView1.SelectedItems[0].SubItems[1].Text;
            textBox3.Text = listView1.SelectedItems[0].SubItems[2].Text;
            textBox4.Text = listView1.SelectedItems[0].SubItems[3].Text;
            textBox5.Text = listView1.SelectedItems[0].SubItems[4].Text;
            textBox6.Text = listView1.SelectedItems[0].SubItems[5].Text;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            verigoruntuleme ();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand duzenleme = new SqlCommand("Update kutuphanebilgi set id = '" + textBox1.Text.ToString() + "',kitapad='" + textBox2.Text.ToString() + "',yazar='" + textBox3.Text.ToString() + "',yayinevi='" + textBox4.Text.ToString() + "',konu='" + textBox5.Text.ToString() + "',sayfa='" + textBox6.Text.ToString() + "'where id =" + id + "", baglan);
            duzenleme.ExecuteNonQuery();
            baglan.Close();
            verigoruntuleme();
        }
    }
}
