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

namespace Basit_Hastane_Randevu_Kayıt_Sistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglantı = new SqlConnection("Data Source=LAPTOP-O296KKRT;Initial Catalog=Hastane Bilgileri;Integrated Security=True");

        private void verigoruntuleme ()
        {
            baglantı.Open ();
            SqlCommand komut = new SqlCommand ("Select *From randevubilgileri",baglantı);
            SqlDataReader oku = komut.ExecuteReader (); 
            
            while (oku.Read ())
            {
                ListViewItem ekle = new ListViewItem ();    
                ekle.Text = oku["Adsoyad"].ToString ();
                ekle.SubItems.Add (oku["tckimlik"].ToString ());
                ekle.SubItems.Add (oku["muayene"].ToString());
                listView1.Items.Add (ekle);
            }
            baglantı.Close ();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand yazdirmakomutu = new SqlCommand("Insert into randevubilgileri (Adsoyad,tckimlik,muayene) Values ('" + textBox1.Text.ToString() + "', '" + textBox2.Text.ToString() + "' , '" + comboBox1.Text.ToString() + "')", baglantı);
            yazdirmakomutu.ExecuteNonQuery ();
            baglantı.Close();
            verigoruntuleme ();
            textBox1.Clear ();
            textBox2.Clear ();
        }
    }
}
