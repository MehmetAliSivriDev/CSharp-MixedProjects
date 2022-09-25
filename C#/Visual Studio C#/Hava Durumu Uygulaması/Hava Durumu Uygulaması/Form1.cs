using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hava_Durumu_Uygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Bursa")
            {
                webBrowser1.Visible = true;
                webBrowser1.Navigate("https://www.mgm.gov.tr/tahmin/il-ve-ilceler.aspx?il=Bursa");
            }

            if (comboBox1.Text == "İstanbul")
            {
                webBrowser1.Visible=true;
                webBrowser1.Navigate("https://www.mgm.gov.tr/tahmin/il-ve-ilceler.aspx?il=Istanbul");
            }

            if (comboBox1.Text == "Ankara")
            {
                webBrowser1.Visible = true;
                webBrowser1.Navigate("https://www.mgm.gov.tr/tahmin/il-ve-ilceler.aspx#/");
            }

            if (comboBox1.Text == "Kırklareli")
            {
                webBrowser1.Visible = true;
                webBrowser1.Navigate("https://www.mgm.gov.tr/tahmin/il-ve-ilceler.aspx?il=Kirklareli");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            webBrowser1.Visible = false;
        }
    }
}
