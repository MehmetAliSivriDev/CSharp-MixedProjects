using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dizi_Çalışması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int[] sayidizisi = new int[listBox1.Items.Count];

            for (int i = 0; i < sayidizisi.Length; i++) 
            {
                sayidizisi[i] = Int32.Parse(listBox1.Items[i].ToString());
            }
            Array.Sort(sayidizisi);
            label8.Text = sayidizisi[sayidizisi.Length -1 ].ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int[] sayidizisi = new int[listBox1.Items.Count];

            for (int i = 0; i < sayidizisi.Length; i++)
            {
                sayidizisi[i] = Int32.Parse(listBox1.Items[i].ToString());
            }
            Array.Sort(sayidizisi);
            label9.Text = sayidizisi[0].ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int[] sayidizisi = new int[listBox1.Items.Count];

            int toplam = 0;

            for(int i = 0; i < sayidizisi.Length; i++)
            {
                sayidizisi[i] = Int32.Parse(listBox1.Items[i].ToString());
            }

            foreach (int sayi in sayidizisi)
            {
                toplam = toplam + sayi;
            }
            label10.Text = toplam.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int[] sayidizisi = new int[listBox1.Items.Count];

            int toplam = 0;

            for (int i = 0; i < sayidizisi.Length ; i++)
            {
                sayidizisi [i] = Int32.Parse(listBox1.Items[i].ToString());
            }

            foreach (int sayi in sayidizisi)
            {
                toplam = toplam + sayi;
            }
            label11.Text = (toplam/sayidizisi.Length).ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int[] sayidizisi = new int[listBox1.Items.Count];

            for(int i = 0; i < sayidizisi.Length ; i++)
            {
                sayidizisi[i] = Int32.Parse(listBox1.Items[i].ToString());  
            }
            Array.Sort(sayidizisi);

            foreach(int sayi in sayidizisi)
            {
                if(sayi % 2 != 0)
                {
                    listBox2.Items.Add(sayi);
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int[] sayidizisi = new int[listBox1.Items.Count];

            for(int i = 0; i < sayidizisi.Length ; i++)
            {
                sayidizisi [i] = Int32.Parse(listBox1.Items[i].ToString());
            }
            Array.Sort(sayidizisi);

            foreach (int sayi in sayidizisi)
            {
                if(sayi %2 == 0)
                {
                    listBox3.Items.Add(sayi);
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.Focus();

            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();

            label8.Text = "00";
            label9.Text = "00";
            label10.Text = "00";
            label11.Text = "00";

        }
    }
}
