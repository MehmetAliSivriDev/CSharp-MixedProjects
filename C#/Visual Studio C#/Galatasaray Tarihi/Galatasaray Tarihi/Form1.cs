using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Galatasaray_Tarihi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void genelTarihToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label2.Visible = true;
            richTextBox1.Visible = true;
            pictureBox1.Visible = true;

            richTextBox1.Text = "Galatasaray Spor Kulübü, 1905 yılında Galatasaray Lisesi öğrencilerinden Ali Sami Yen tarafından kurulur. 1905 yılından 1919 yılına kadar başkanlık yapan Ali Sami Yen, kulübün kuruluş amacını “Maksadımız İngilizler gibi toplu bir halde oynamak, bir renge ve bir isme malik olmak ve Türk olmayan takımları yenmek” sözleriyle anlatır.\nAli Sami Yen’in başı çektiği kulübün kurucu üyeleri ise Asım Sonumut, Emin Bülend Serdaroğlu, Celal İbrahim, Nikolof, Milo Bakiş, Pol Bakiş, Bekir Sıtkı Bircan, Tahsin Nahit, Reşat Şirvanizade, Hüseyin Hüsnü, Refik Cevdet Kalpakçıoğlu, Abidin Daver olmuştur.\n1905’te Osmanlı İmparatorluğu’nda bir dernekler yasası bulunmadığından, Galatasaray Spor Kulübü yasal olarak tescil edilme olanağını bulamamıştır. 1912 yılında Cemiyetler Kanunu çıkarıldıktan sonra, kulüp yasal bir kimlik kazandı.";
            pictureBox1.ImageLocation = "C:\\Users\\sivri\\Documents\\Yazılım\\C#\\Visual Studio C#\\Galatasaray Tarihi\\Gerekli Dosyalar\\ali sami yen.jpg";


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Visible = false;
            label2.Visible = false;
            richTextBox1.Visible = false;
            pictureBox1.Visible = false;
            axWindowsMediaPlayer1.Visible = false;  
        }

        private void lİGBAŞARILARIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label2.Visible=false;    
            richTextBox1.Visible = true;
            pictureBox1.Visible=true;

            label1.Text = "Türkiye Başarıları";

            richTextBox1.Text = "Şu ana kadar 22 kez Süper Lig şampiyonu olmuş, 18 kez Türkiye Kupası ve 16 kez de Türkiye Süper Kupası kazanmıştır.";
            pictureBox1.ImageLocation = "C:\\Users\\sivri\\Documents\\Yazılım\\C#\\Visual Studio C#\\Galatasaray Tarihi\\Gerekli Dosyalar\\Süper_Lig_logosu.png";

        }

        private void aVRUPABAŞARILARIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Visible = true;
            pictureBox1.Visible = true;
            label2.Visible = false;

            label1.Text = "Avrupa Başarıları";

            richTextBox1.Text = "UEFA Avrupa Ligi E Grubu'nda yarın İtalya temsilcisi Lazio'yu konuk edecek Galatasarayi Avrupa kupalarında oynadığı 294 maçta 103 galibiyet elde ederken, 114 mağlubiyet yaşadı. Galatasaray, Avrupa kupalarında daha önce Lazio ile 4 kez karşılaşan Galatasaray, birer galibiyet ve beraberlik alırken 2 kez yenildi. Türkiye'nin Avrupa kupalarındaki en başarılı futbol takımı konumunda bulunan Galatasaray'ın müzesinde birer UEFA Kupası ve UEFA Süper Kupa bulunuyor. Şampiyon Kulüpler Kupası'nda bir kez yarı final, 2 defa da çeyrek final oynayan sarı-kırmızılı ekip, UEFA Şampiyonlar Ligi'nde ise 3 kez son 8 takım arasına kaldı.";
            pictureBox1.ImageLocation = "C:\\Users\\sivri\\Documents\\Yazılım\\C#\\Visual Studio C#\\Galatasaray Tarihi\\Gerekli Dosyalar\\gsuefa.png";
        }

        private void kAZANILANKUPLARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Visible = true;
            pictureBox1.Visible = true;
            label2.Visible = true;

            label1.Text = "Kazanılan Kupalar";
            label2.Text = "Kupa Listesi";

            richTextBox1.Text = "Galatasaray'ın müzesinde tuttuğu kupa listesi -->";
            pictureBox1.ImageLocation = "C:\\Users\\sivri\\Documents\\Yazılım\\C#\\Visual Studio C#\\Galatasaray Tarihi\\Gerekli Dosyalar\\gs kupa.png";
        }

        private void fatihTerimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Visible = true;
            pictureBox1.Visible = true;
            label2.Visible = true;

            label1.Text = "Fatih Terim";
            label2.Text = "Fatih Terim ve Başarıları";

            richTextBox1.Text = "Terim yönetiminde Galatasaray, UEFA Kupası'nı kaldırarak Avrupa'da en önemli başarısını elde ederken, 8 lig, 3 TSYD Kupası, 3 Türkiye Kupası, 2 Cumhurbaşkanlığı Kupası ve 3 kez de Süper Kupa şampiyonluğu kazandı.";
            pictureBox1.ImageLocation = "C:\\Users\\sivri\\Documents\\Yazılım\\C#\\Visual Studio C#\\Galatasaray Tarihi\\Gerekli Dosyalar\\ft.jpg";
        }

        private void gerçekleriTarihYazarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Visible = false;
            pictureBox1.Visible=false;
            label2.Visible = false;
            label1.Visible = true;
            label1.Text = "Gerçekleri Tarih Yazar";

            axWindowsMediaPlayer1.URL = "C:\\Users\\sivri\\Documents\\Yazılım\\C#\\Visual Studio C#\\Galatasaray Tarihi\\Gerekli Dosyalar\\Gerçekleri Tarih Yazar  Galatasaray Marşları.mp3";
        }

        private void şereftirSeniSevmekToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Visible = false;
            pictureBox1.Visible = false;
            label2.Visible = false;
            label1.Visible=true;
            label1.Text = "Şereftir Seni Sevmek";

            axWindowsMediaPlayer1.URL = "C:\\Users\\sivri\\Documents\\Yazılım\\C#\\Visual Studio C#\\Galatasaray Tarihi\\Gerekli Dosyalar\\Şereftir Seni Sevmek (Stüdyo)  Galatasaray Marşları.mp3";
        }
    }
}
