using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kategorili_WebBrowser_Uygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void fACEBOOKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("www.Facebook.com");
        }

        private void tWTİTTERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("www.twitter.com");
        }

        private void iNSTAGRAMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("www.instagram.com");
        }

        private void tWİTCHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("www.twitch.com");
        }

        private void yOUTUBEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("www.youtube.com");
        }

        private void gALATASARAYToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.galatasaray.org/anasayfa");
        }

        private void fENERBAHÇEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.fenerbahce.org");
        }

        private void bEŞİKTAŞToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://bjk.com.tr/tr");
        }

        private void bEİNSPORTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://beinsports.com.tr");
        }

        private void gOOGLEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("www.google.com");
        }

        private void yANDEXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://yandex.com.tr");
        }

        private void hABERTÜRKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://yandex.com.tr");
        }

        private void cNNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.cnnturk.com");
        }

        private void tRTHABERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.trthaber.com");
        }
    }
}
