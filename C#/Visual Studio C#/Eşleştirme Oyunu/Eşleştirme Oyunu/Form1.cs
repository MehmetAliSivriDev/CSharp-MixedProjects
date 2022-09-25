using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eşleştirme_Oyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rastgele = new Random();

        

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;

        }

        private void bsltButton_Click(object sender, EventArgs e)
        {

            int sayi = rastgele.Next(1,5);
            label1.Text = sayi.ToString();

            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;

            if (sayi == 1)
            {
                button1.Image = "C:\\Users\\sivri\\Documents\\Yazılım\\C#\\Visual Studio C#\\Eşleştirme Oyunu\\Gerekli Dosyalar\\kağıt.png";
            }
        
        }
    }
}
