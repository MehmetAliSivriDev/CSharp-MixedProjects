namespace Market_Otomasyonu_Denemesi_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /* ÜRÜN FÝYATLARI
            * Cips=5TL
            * Siyah Kola=8TL
            * Sarý Kola=8TL
            * Bisküvi=4TL
            * Su=2TL
            * Sakýz=1TL
            * */

            int cips = 5;
            int bcola = 8;
            int ycola = 8;
            int bsc = 4;
            int water = 2;
            int gum = 1;

            //Toplam Fiyatý Yazdýrmak Ýçin            
            int toplamcips,toplambcola,toplamycola,toplambsc,toplamwater,toplamgum;

            //Adet Hesaplamasý Ýçin
            int cf, bf, yf, bscf, wf, gf;

            //Toplam Fiyat Hesaplamak Ýçin
            int toplam=0;
           

            if (checkBox1.Checked == true)
            {
                listBox1.Items.Add("Cips x"+comboBox1.Text);

                cf = Convert.ToInt32(comboBox1.Text);

                toplamcips = cips * cf;

                label10.Text = toplamcips.ToString();

                toplam = toplam + toplamcips;

            }

            if (checkBox2.Checked == true)
            {
                listBox1.Items.Add("Siyah Kola x" + comboBox2.Text);

                bf = Convert.ToInt32(comboBox2.Text); 

                toplambcola = bcola * bf;

                label12.Text = toplambcola.ToString();

                toplam = toplam + toplambcola;
            }

            if (checkBox3.Checked == true)
            {
                listBox1.Items.Add("Sarý Kola x" + comboBox3.Text);

                yf = Convert.ToInt32(comboBox3.Text);

                toplamycola = ycola * yf;

                label13.Text = toplamycola.ToString();

                toplam = toplam + toplamycola;

            }

            if (checkBox4.Checked == true)
            {
                listBox1.Items.Add("Bisküvi x" + comboBox4.Text);

                bscf = Convert.ToInt32(comboBox4.Text);

                toplambsc = bscf * bsc;

                label14.Text = toplambsc.ToString();

                toplam = toplam + toplambsc;

            }

            if (checkBox5.Checked == true)
            {
                listBox1.Items.Add("Su x" + comboBox5.Text);

                wf = Convert.ToInt32(comboBox5.Text);

                toplamwater = wf * water;

                label15.Text = toplamwater.ToString();

                toplam = toplam + toplamwater;
            }

            if (checkBox6.Checked == true)
            {
                listBox1.Items.Add("Sakýz x" + comboBox6.Text);

                gf = Convert.ToInt32(comboBox6.Text);

                toplamgum = gf * gum;

                label16.Text = toplamgum.ToString();

                toplam = toplam + toplamgum;
            }

            label18.Text = toplam.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label10.Text = "00";
            label12.Text = "00";
            label13.Text = "00";
            label14.Text = "00";
            label15.Text = "00";
            label16.Text = "00";
            label18.Text = "00";
        }
    }
}