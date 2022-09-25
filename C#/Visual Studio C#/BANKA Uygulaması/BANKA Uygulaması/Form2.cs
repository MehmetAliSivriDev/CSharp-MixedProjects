using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BANKA_Uygulaması
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        
        private void Form2_Load(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = "C:\\Users\\sivri\\Documents\\Yazılım\\C#\\Visual Studio C#\\BANKA Uygulaması\\Gerekli Dosyalar\\809482.png";
            pictureBox2.ImageLocation = "C:\\Users\\sivri\\Documents\\Yazılım\\C#\\Visual Studio C#\\BANKA Uygulaması\\Gerekli Dosyalar\\stack-of-gold-coins-1.png";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 hesapbilgisi = new Form3();
            this.Hide();
            hesapbilgisi.Show();
            

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 parayatirma = new Form4();
            this.Hide();
            parayatirma.Show();
        }
    }
}
