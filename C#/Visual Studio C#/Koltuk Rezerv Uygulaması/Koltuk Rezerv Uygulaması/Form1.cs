using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Koltuk_Rezerv_Uygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //KAYIT YAPMA
            listBox1.Items.Add(textBox1.Text);
            listBox2.Items.Add(textBox2.Text);
            listBox3.Items.Add(comboBox1.Text);
            listBox4.Items.Add(comboBox2.Text);
            listBox5.Items.Add("1");

            //TEMİZLEME ve REZERV ETME İŞLEMİ

            textBox1.Clear();
            textBox2.Clear();
            comboBox1.Text = "";
            comboBox2.Text = "";
            button1.Enabled = false;
            button1.BackColor = Color.Red;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //KAYIT YAPMA
            listBox1.Items.Add(textBox1.Text);
            listBox2.Items.Add(textBox2.Text);
            listBox3.Items.Add(comboBox1.Text);
            listBox4.Items.Add(comboBox2.Text);
            listBox5.Items.Add("2");

            //TEMİZLEME ve REZERV ETME İŞLEMİ

            textBox1.Clear();
            textBox2.Clear();
            comboBox1.Text = "";
            comboBox2.Text = "";
            button2.Enabled = false;
            button2.BackColor = Color.Red;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //KAYIT YAPMA
            listBox1.Items.Add(textBox1.Text);
            listBox2.Items.Add(textBox2.Text);
            listBox3.Items.Add(comboBox1.Text);
            listBox4.Items.Add(comboBox2.Text);
            listBox5.Items.Add("3");

            //TEMİZLEME ve REZERV ETME İŞLEMİ

            textBox1.Clear();
            textBox2.Clear();
            comboBox1.Text = "";
            comboBox2.Text = "";
            button3.Enabled = false;
            button3.BackColor = Color.Red;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //KAYIT YAPMA
            listBox1.Items.Add(textBox1.Text);
            listBox2.Items.Add(textBox2.Text);
            listBox3.Items.Add(comboBox1.Text);
            listBox4.Items.Add(comboBox2.Text);
            listBox5.Items.Add("4");

            //TEMİZLEME ve REZERV ETME İŞLEMİ

            textBox1.Clear();
            textBox2.Clear();
            comboBox1.Text = "";
            comboBox2.Text = "";
            button4.Enabled = false;
            button4.BackColor = Color.Red;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //KAYIT YAPMA
            listBox1.Items.Add(textBox1.Text);
            listBox2.Items.Add(textBox2.Text);
            listBox3.Items.Add(comboBox1.Text);
            listBox4.Items.Add(comboBox2.Text);
            listBox5.Items.Add("5");

            //TEMİZLEME ve REZERV ETME İŞLEMİ

            textBox1.Clear();
            textBox2.Clear();
            comboBox1.Text = "";
            comboBox2.Text = "";
            button5.Enabled = false;
            button5.BackColor = Color.Red;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //KAYIT YAPMA
            listBox1.Items.Add(textBox1.Text);
            listBox2.Items.Add(textBox2.Text);
            listBox3.Items.Add(comboBox1.Text);
            listBox4.Items.Add(comboBox2.Text);
            listBox5.Items.Add("6");

            //TEMİZLEME ve REZERV ETME İŞLEMİ

            textBox1.Clear();
            textBox2.Clear();
            comboBox1.Text = "";
            comboBox2.Text = "";
            button6.Enabled = false;
            button6.BackColor = Color.Red;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //KAYIT YAPMA
            listBox1.Items.Add(textBox1.Text);
            listBox2.Items.Add(textBox2.Text);
            listBox3.Items.Add(comboBox1.Text);
            listBox4.Items.Add(comboBox2.Text);
            listBox5.Items.Add("7");

            //TEMİZLEME ve REZERV ETME İŞLEMİ

            textBox1.Clear();
            textBox2.Clear();
            comboBox1.Text = "";
            comboBox2.Text = "";
            button12.Enabled = false;
            button12.BackColor = Color.Red;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //KAYIT YAPMA
            listBox1.Items.Add(textBox1.Text);
            listBox2.Items.Add(textBox2.Text);
            listBox3.Items.Add(comboBox1.Text);
            listBox4.Items.Add(comboBox2.Text);
            listBox5.Items.Add("8");

            //TEMİZLEME ve REZERV ETME İŞLEMİ

            textBox1.Clear();
            textBox2.Clear();
            comboBox1.Text = "";
            comboBox2.Text = "";
            button11.Enabled = false;
            button11.BackColor = Color.Red;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //KAYIT YAPMA
            listBox1.Items.Add(textBox1.Text);
            listBox2.Items.Add(textBox2.Text);
            listBox3.Items.Add(comboBox1.Text);
            listBox4.Items.Add(comboBox2.Text);
            listBox5.Items.Add("9");

            //TEMİZLEME ve REZERV ETME İŞLEMİ

            textBox1.Clear();
            textBox2.Clear();
            comboBox1.Text = "";
            comboBox2.Text = "";
            button10.Enabled = false;
            button10.BackColor = Color.Red;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //KAYIT YAPMA
            listBox1.Items.Add(textBox1.Text);
            listBox2.Items.Add(textBox2.Text);
            listBox3.Items.Add(comboBox1.Text);
            listBox4.Items.Add(comboBox2.Text);
            listBox5.Items.Add("10");

            //TEMİZLEME ve REZERV ETME İŞLEMİ

            textBox1.Clear();
            textBox2.Clear();
            comboBox1.Text = "";
            comboBox2.Text = "";
            button9.Enabled = false;
            button9.BackColor = Color.Red;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //KAYIT YAPMA
            listBox1.Items.Add(textBox1.Text);
            listBox2.Items.Add(textBox2.Text);
            listBox3.Items.Add(comboBox1.Text);
            listBox4.Items.Add(comboBox2.Text);
            listBox5.Items.Add("11");

            //TEMİZLEME ve REZERV ETME İŞLEMİ

            textBox1.Clear();
            textBox2.Clear();
            comboBox1.Text = "";
            comboBox2.Text = "";
            button8.Enabled = false;
            button8.BackColor = Color.Red;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //KAYIT YAPMA
            listBox1.Items.Add(textBox1.Text);
            listBox2.Items.Add(textBox2.Text);
            listBox3.Items.Add(comboBox1.Text);
            listBox4.Items.Add(comboBox2.Text);
            listBox5.Items.Add("12");

            //TEMİZLEME ve REZERV ETME İŞLEMİ

            textBox1.Clear();
            textBox2.Clear();
            comboBox1.Text = "";
            comboBox2.Text = "";
            button7.Enabled = false;
            button7.BackColor = Color.Red;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            //KAYIT YAPMA
            listBox1.Items.Add(textBox1.Text);
            listBox2.Items.Add(textBox2.Text);
            listBox3.Items.Add(comboBox1.Text);
            listBox4.Items.Add(comboBox2.Text);
            listBox5.Items.Add("13");

            //TEMİZLEME ve REZERV ETME İŞLEMİ

            textBox1.Clear();
            textBox2.Clear();
            comboBox1.Text = "";
            comboBox2.Text = "";
            button18.Enabled = false;
            button18.BackColor = Color.Red;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            //KAYIT YAPMA
            listBox1.Items.Add(textBox1.Text);
            listBox2.Items.Add(textBox2.Text);
            listBox3.Items.Add(comboBox1.Text);
            listBox4.Items.Add(comboBox2.Text);
            listBox5.Items.Add("14");

            //TEMİZLEME ve REZERV ETME İŞLEMİ

            textBox1.Clear();
            textBox2.Clear();
            comboBox1.Text = "";
            comboBox2.Text = "";
            button17.Enabled = false;
            button17.BackColor = Color.Red;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            //KAYIT YAPMA
            listBox1.Items.Add(textBox1.Text);
            listBox2.Items.Add(textBox2.Text);
            listBox3.Items.Add(comboBox1.Text);
            listBox4.Items.Add(comboBox2.Text);
            listBox5.Items.Add("15");

            //TEMİZLEME ve REZERV ETME İŞLEMİ

            textBox1.Clear();
            textBox2.Clear();
            comboBox1.Text = "";
            comboBox2.Text = "";
            button16.Enabled = false;
            button16.BackColor = Color.Red;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            //KAYIT YAPMA
            listBox1.Items.Add(textBox1.Text);
            listBox2.Items.Add(textBox2.Text);
            listBox3.Items.Add(comboBox1.Text);
            listBox4.Items.Add(comboBox2.Text);
            listBox5.Items.Add("16");

            //TEMİZLEME ve REZERV ETME İŞLEMİ

            textBox1.Clear();
            textBox2.Clear();
            comboBox1.Text = "";
            comboBox2.Text = "";
            button15.Enabled = false;
            button15.BackColor = Color.Red;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            //KAYIT YAPMA
            listBox1.Items.Add(textBox1.Text);
            listBox2.Items.Add(textBox2.Text);
            listBox3.Items.Add(comboBox1.Text);
            listBox4.Items.Add(comboBox2.Text);
            listBox5.Items.Add("17");

            //TEMİZLEME ve REZERV ETME İŞLEMİ

            textBox1.Clear();
            textBox2.Clear();
            comboBox1.Text = "";
            comboBox2.Text = "";
            button14.Enabled = false;
            button14.BackColor = Color.Red;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            //KAYIT YAPMA
            listBox1.Items.Add(textBox1.Text);
            listBox2.Items.Add(textBox2.Text);
            listBox3.Items.Add(comboBox1.Text);
            listBox4.Items.Add(comboBox2.Text);
            listBox5.Items.Add("18");

            //TEMİZLEME ve REZERV ETME İŞLEMİ

            textBox1.Clear();
            textBox2.Clear();
            comboBox1.Text = "";
            comboBox2.Text = "";
            button13.Enabled = false;
            button13.BackColor = Color.Red;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            //TÜM HERŞEYİ TEMİZLEME İŞLEMİ
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            button10.Enabled = true;    
            button11.Enabled = true;
            button12.Enabled = true;
            button13.Enabled= true;
            button14.Enabled = true;
            button15.Enabled = true;
            button16.Enabled = true;
            button17.Enabled = true;
            button18.Enabled = true;
            button1.BackColor = Color.IndianRed;
            button2.BackColor = Color.IndianRed;
            button3.BackColor = Color.IndianRed;
            button4.BackColor = Color.IndianRed;
            button5.BackColor = Color.IndianRed;
            button6.BackColor = Color.IndianRed;
            button7.BackColor = Color.IndianRed;
            button8.BackColor = Color.IndianRed;
            button9.BackColor = Color.IndianRed;
            button10.BackColor = Color.IndianRed;
            button11.BackColor = Color.IndianRed;
            button12.BackColor = Color.IndianRed;
            button13.BackColor = Color.IndianRed;
            button14.BackColor = Color.IndianRed;
            button15.BackColor = Color.IndianRed;
            button16.BackColor = Color.IndianRed;
            button17.BackColor = Color.IndianRed;
            button18.BackColor = Color.IndianRed;
            textBox1.Clear();
            textBox2.Clear();
            comboBox1.Text = "";
            comboBox2.Text = "";
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            listBox4.Items.Clear();
            listBox5.Items.Clear();

            
        }
    }
}
