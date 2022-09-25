using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Linkli_Video_Player
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            webBrowser1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            webBrowser1.Visible = true;
            webBrowser1.Navigate(textBox1.Text);
        }
    }
}
