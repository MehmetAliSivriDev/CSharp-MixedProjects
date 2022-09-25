namespace Mutlak_Ders_Geçip_Kalma_Hesaplaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /* - Not Yüzdeleri -
             * Final = %50
             * Vize = %20 
             * Kısa Sınav1 = %10
             * Kısa Sınav2 = %10
             * Ödev = %10
             * */


            float final, vize, kisa1, kisa2, odev, ort;

            listBox1.Items.Add(textBox6.Text);
            listBox2.Items.Add(textBox7.Text);
            final = Convert.ToInt32(textBox2.Text);
            vize = Convert.ToInt32(textBox1.Text);  
            kisa1 = Convert.ToInt32(textBox3.Text); 
            kisa2 = Convert.ToInt32(textBox4.Text);
            odev = Convert.ToInt32(textBox5.Text);

            ort = (final * 50) / 100 + (vize * 20) / 100 + (kisa1 * 10) / 100 + (kisa2 * 10) / 100 + (odev * 10) / 100;

            if (ort >= 50 && final >= 50)
            {
                listBox3.Items.Add(ort.ToString());
                listBox4.Items.Add("Geçti!");
            }
            else
            {
                listBox3.Items.Add(ort.ToString());
                listBox4.Items.Add("Kaldı!");
            }
        }
    }
}