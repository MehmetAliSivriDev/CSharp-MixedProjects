using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Çarpım_Tablosu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "1")
            {
                listBox1.Items.Add("---------------------------------------");
                listBox1.Items.Add("1x1=1");
                listBox1.Items.Add("1x2=2");
                listBox1.Items.Add("1x3=3");
                listBox1.Items.Add("1x4=4");
                listBox1.Items.Add("1x5=5");
                listBox1.Items.Add("1x6=6");
                listBox1.Items.Add("1x7=7");
                listBox1.Items.Add("1x8=8");
                listBox1.Items.Add("1x9=9");
                listBox1.Items.Add("1x10=10");
                listBox1.Items.Add("---------------------------------------");

            }

            if (comboBox1.Text == "2")
            {
                listBox1.Items.Add("---------------------------------------");
                listBox1.Items.Add("2x1=2");
                listBox1.Items.Add("2x2=4");
                listBox1.Items.Add("2x3=6");
                listBox1.Items.Add("2x4=8");
                listBox1.Items.Add("2x5=10");
                listBox1.Items.Add("2x6=12");
                listBox1.Items.Add("2x7=14");
                listBox1.Items.Add("2x8=16");
                listBox1.Items.Add("2x9=18");
                listBox1.Items.Add("2x10=20");
                listBox1.Items.Add("---------------------------------------");
            }

            if(comboBox1.Text == "3")
            {
                listBox1.Items.Add("---------------------------------------");
                listBox1.Items.Add("3x1=3");
                listBox1.Items.Add("3x2=6");
                listBox1.Items.Add("3x3=9");
                listBox1.Items.Add("3x4=12");
                listBox1.Items.Add("3x5=15");
                listBox1.Items.Add("3x6=18");
                listBox1.Items.Add("3x7=21");
                listBox1.Items.Add("3x8=24");
                listBox1.Items.Add("3x9=27");
                listBox1.Items.Add("3x10=30");
                listBox1.Items.Add("---------------------------------------");
            }

            if(comboBox1.Text=="4")
            {
                listBox1.Items.Add("---------------------------------------");
                listBox1.Items.Add("4x1=4");
                listBox1.Items.Add("4x2=8");
                listBox1.Items.Add("4x3=12");
                listBox1.Items.Add("4x4=16");
                listBox1.Items.Add("4x5=20");
                listBox1.Items.Add("4x6=24");
                listBox1.Items.Add("4x7=28");
                listBox1.Items.Add("4x8=32");
                listBox1.Items.Add("4x9=36");
                listBox1.Items.Add("4x10=40");
                listBox1.Items.Add("---------------------------------------");
            }

            if (comboBox1.Text=="5")
            {
                listBox1.Items.Add("---------------------------------------");
                listBox1.Items.Add("5x1=5");
                listBox1.Items.Add("5x2=10");
                listBox1.Items.Add("5x3=15");
                listBox1.Items.Add("5x4=20");
                listBox1.Items.Add("5x5=25");
                listBox1.Items.Add("5x6=30");
                listBox1.Items.Add("5x7=35");
                listBox1.Items.Add("5x8=40");
                listBox1.Items.Add("5x9=45");
                listBox1.Items.Add("5x10=50");
                listBox1.Items.Add("---------------------------------------");
            }

            if(comboBox1.Text=="6")
            {
                listBox1.Items.Add("---------------------------------------");
                listBox1.Items.Add("6x1=1");
                listBox1.Items.Add("6x2=2");
                listBox1.Items.Add("6x3=3");
                listBox1.Items.Add("6x4=4");
                listBox1.Items.Add("6x5=5");
                listBox1.Items.Add("6x6=6");
                listBox1.Items.Add("6x7=7");
                listBox1.Items.Add("6x8=8");
                listBox1.Items.Add("6x9=9");
                listBox1.Items.Add("6x10=10");
                listBox1.Items.Add("---------------------------------------");
            }
            if (comboBox1.Text=="7")
            {
                listBox1.Items.Add("---------------------------------------");
                listBox1.Items.Add("7x1=7");
                listBox1.Items.Add("7x2=14");
                listBox1.Items.Add("7x3=21");
                listBox1.Items.Add("7x4=28");
                listBox1.Items.Add("7x5=35");
                listBox1.Items.Add("7x6=42");
                listBox1.Items.Add("7x7=49");
                listBox1.Items.Add("7x8=56");
                listBox1.Items.Add("7x9=63");
                listBox1.Items.Add("7x10=70");
                listBox1.Items.Add("---------------------------------------");
            }

            if (comboBox1.Text == "8")
            {
                listBox1.Items.Add("---------------------------------------");
                listBox1.Items.Add("8x1=8");
                listBox1.Items.Add("8x2=16");
                listBox1.Items.Add("8x3=24");
                listBox1.Items.Add("8x4=32");
                listBox1.Items.Add("8x5=40");
                listBox1.Items.Add("8x6=48");
                listBox1.Items.Add("8x7=56");
                listBox1.Items.Add("8x8=64");
                listBox1.Items.Add("8x9=72");
                listBox1.Items.Add("8x10=80");
                listBox1.Items.Add("---------------------------------------");
            }

            if (comboBox1.Text == "9")
            {
                listBox1.Items.Add("---------------------------------------");
                listBox1.Items.Add("9x1=9");
                listBox1.Items.Add("9x2=18");
                listBox1.Items.Add("9x3=27");
                listBox1.Items.Add("9x4=36");
                listBox1.Items.Add("9x5=45");
                listBox1.Items.Add("9x6=54");
                listBox1.Items.Add("9x7=63");
                listBox1.Items.Add("9x8=72");
                listBox1.Items.Add("9x9=81");
                listBox1.Items.Add("9x10=90");
                listBox1.Items.Add("---------------------------------------");
            }

            if (comboBox1.Text == "10")
            {
                listBox1.Items.Add("---------------------------------------");
                listBox1.Items.Add("10x1=10");
                listBox1.Items.Add("10x2=20");
                listBox1.Items.Add("10x3=30");
                listBox1.Items.Add("10x4=40");
                listBox1.Items.Add("10x5=50");
                listBox1.Items.Add("10x6=60");
                listBox1.Items.Add("10x7=70");
                listBox1.Items.Add("10x8=80");
                listBox1.Items.Add("10x9=90");
                listBox1.Items.Add("10x10=100");
                listBox1.Items.Add("---------------------------------------");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}
