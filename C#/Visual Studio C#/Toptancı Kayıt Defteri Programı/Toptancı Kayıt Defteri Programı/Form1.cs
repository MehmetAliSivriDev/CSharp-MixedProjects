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
    

namespace Toptancı_Kayıt_Defteri_Programı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglantı = new SqlConnection("Data Source=LAPTOP-O296KKRT;Initial Catalog=toptancı kayıt defteri;Integrated Security=True");

        private void goruntuleme ()
        {
            listView1.Items.Clear();

            baglantı.Open ();
            SqlCommand komut = new SqlCommand("Select *From toptancikayit", baglantı);
            SqlDataReader oku = komut.ExecuteReader ();

            while (oku.Read ())
            {
                ListViewItem ekle = new ListViewItem(); 
                ekle.Text = oku["sira"].ToString ();
                ekle.SubItems.Add (oku["urunadi"].ToString ());
                ekle.SubItems.Add(oku["firma"].ToString());
                ekle.SubItems.Add(oku["adetsayisi"].ToString()); 

                listView1.Items.Add (ekle);   
            }
            baglantı.Close ();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand yazdirma = new SqlCommand("Insert Into toptancikayit (sira,urunadi,firma,adetsayisi) values ('" + textBox1.Text.ToString() + "','" + textBox2.Text.ToString() + "','" + textBox3.Text.ToString() + "','" + textBox4.Text.ToString() + "')",baglantı);
            yazdirma.ExecuteNonQuery ();
            baglantı.Close();
            goruntuleme();
            textBox1.Clear ();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        int id = 0;

        private void button3_Click(object sender, EventArgs e)
        {
            goruntuleme();
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            textBox1.Text = listView1.SelectedItems[0].SubItems [0].Text;
            textBox2.Text = listView1.SelectedItems[0].SubItems[1].Text;
            textBox3.Text = listView1.SelectedItems[0].SubItems[2].Text;
            textBox4.Text = listView1.SelectedItems[0].SubItems[3].Text;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand sil = new SqlCommand("Delete From toptancikayit where sira =(" + id + ")", baglantı);
            sil.ExecuteNonQuery();
            baglantı.Close();
            goruntuleme();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();


        }
    }
}
