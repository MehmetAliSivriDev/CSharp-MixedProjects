using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kurs_Kayıt_Programı
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
       
        new Form3 ogk = new Form3();

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ogk.Show();
        }
    }
}
