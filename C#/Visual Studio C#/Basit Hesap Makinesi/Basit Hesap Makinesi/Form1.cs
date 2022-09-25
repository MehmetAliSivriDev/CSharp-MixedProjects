namespace Basit_Hesap_Makinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, toplam;

            sayi1 = Convert.ToInt32(textBox1.Text);
            sayi2 = Convert.ToInt32(textBox2.Text);

            toplam = sayi1 + sayi2;

            label4.Text = toplam.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, carpim;

            sayi1 = Convert.ToInt32(textBox1.Text); 
            sayi2 = Convert.ToInt32(textBox2.Text);

            carpim = sayi1 * sayi2;

            label4.Text= carpim.ToString(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, bolme;

            sayi1 = Convert.ToInt32(textBox1.Text);
            sayi2 = Convert.ToInt32(textBox2.Text);

            bolme = sayi1 / sayi2;

            label4.Text = bolme.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, cikarma;

            sayi1 = Convert.ToInt32(textBox1.Text);
            sayi2 = Convert.ToInt32(textBox2.Text);

            cikarma = sayi1 - sayi2;

            label4.Text = cikarma.ToString();
        }
    }
}