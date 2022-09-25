using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alarm_Sistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            axWindowsMediaPlayer1.Visible = false;

            for (int i = 0; i < 24; i++)
            {
                comboBox1.Items.Add(i.ToString());   
            }
            for (int j = 0; j < 60; j++)
            {
                comboBox2.Items.Add(j.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label5.Text = DateTime.Now.Hour.ToString();
            label6.Text = DateTime.Now.Minute.ToString();

            if (comboBox1.Text == label5.Text && comboBox2.Text == label6.Text)
            {
                timer1.Enabled = false;
                axWindowsMediaPlayer1.URL = "C:\\Users\\sivri\\Documents\\Yazılım\\C#\\Visual Studio C#\\Alarm Sistemi\\Gerekli Dosyalar\\Alarm Sesi.mp3";
                MessageBox.Show("UYAN!!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
          Application.Exit();
        }
    }
}
