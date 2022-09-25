namespace Galatasaray_Tarihi
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tARİHİToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.genelTarihToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bAŞARILARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lİGBAŞARILARIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aVRUPABAŞARILARIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kAZANILANKUPLARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gÖREVALANTEKNİKADAMLARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fatihTerimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pOPÜLERMARŞLARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gerçekleriTarihYazarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.şereftirSeniSevmekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tARİHİToolStripMenuItem,
            this.bAŞARILARToolStripMenuItem,
            this.gÖREVALANTEKNİKADAMLARToolStripMenuItem,
            this.pOPÜLERMARŞLARToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1303, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tARİHİToolStripMenuItem
            // 
            this.tARİHİToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.genelTarihToolStripMenuItem});
            this.tARİHİToolStripMenuItem.Name = "tARİHİToolStripMenuItem";
            this.tARİHİToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.tARİHİToolStripMenuItem.Text = "TARİHİ";
            // 
            // genelTarihToolStripMenuItem
            // 
            this.genelTarihToolStripMenuItem.Name = "genelTarihToolStripMenuItem";
            this.genelTarihToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            this.genelTarihToolStripMenuItem.Text = "Kuruluş Tarihi";
            this.genelTarihToolStripMenuItem.Click += new System.EventHandler(this.genelTarihToolStripMenuItem_Click);
            // 
            // bAŞARILARToolStripMenuItem
            // 
            this.bAŞARILARToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lİGBAŞARILARIToolStripMenuItem,
            this.aVRUPABAŞARILARIToolStripMenuItem,
            this.kAZANILANKUPLARToolStripMenuItem});
            this.bAŞARILARToolStripMenuItem.Name = "bAŞARILARToolStripMenuItem";
            this.bAŞARILARToolStripMenuItem.Size = new System.Drawing.Size(99, 24);
            this.bAŞARILARToolStripMenuItem.Text = "BAŞARILAR";
            // 
            // lİGBAŞARILARIToolStripMenuItem
            // 
            this.lİGBAŞARILARIToolStripMenuItem.Name = "lİGBAŞARILARIToolStripMenuItem";
            this.lİGBAŞARILARIToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.lİGBAŞARILARIToolStripMenuItem.Text = "TÜRKİYE BAŞARILARI";
            this.lİGBAŞARILARIToolStripMenuItem.Click += new System.EventHandler(this.lİGBAŞARILARIToolStripMenuItem_Click);
            // 
            // aVRUPABAŞARILARIToolStripMenuItem
            // 
            this.aVRUPABAŞARILARIToolStripMenuItem.Name = "aVRUPABAŞARILARIToolStripMenuItem";
            this.aVRUPABAŞARILARIToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.aVRUPABAŞARILARIToolStripMenuItem.Text = "AVRUPA BAŞARILARI";
            this.aVRUPABAŞARILARIToolStripMenuItem.Click += new System.EventHandler(this.aVRUPABAŞARILARIToolStripMenuItem_Click);
            // 
            // kAZANILANKUPLARToolStripMenuItem
            // 
            this.kAZANILANKUPLARToolStripMenuItem.Name = "kAZANILANKUPLARToolStripMenuItem";
            this.kAZANILANKUPLARToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.kAZANILANKUPLARToolStripMenuItem.Text = "KAZANILAN KUPLAR";
            this.kAZANILANKUPLARToolStripMenuItem.Click += new System.EventHandler(this.kAZANILANKUPLARToolStripMenuItem_Click);
            // 
            // gÖREVALANTEKNİKADAMLARToolStripMenuItem
            // 
            this.gÖREVALANTEKNİKADAMLARToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fatihTerimToolStripMenuItem});
            this.gÖREVALANTEKNİKADAMLARToolStripMenuItem.Name = "gÖREVALANTEKNİKADAMLARToolStripMenuItem";
            this.gÖREVALANTEKNİKADAMLARToolStripMenuItem.Size = new System.Drawing.Size(239, 24);
            this.gÖREVALANTEKNİKADAMLARToolStripMenuItem.Text = "GÖREV ALAN TEKNİK ADAMLAR";
            // 
            // fatihTerimToolStripMenuItem
            // 
            this.fatihTerimToolStripMenuItem.Name = "fatihTerimToolStripMenuItem";
            this.fatihTerimToolStripMenuItem.Size = new System.Drawing.Size(169, 26);
            this.fatihTerimToolStripMenuItem.Text = "Fatih TERİM";
            this.fatihTerimToolStripMenuItem.Click += new System.EventHandler(this.fatihTerimToolStripMenuItem_Click);
            // 
            // pOPÜLERMARŞLARToolStripMenuItem
            // 
            this.pOPÜLERMARŞLARToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gerçekleriTarihYazarToolStripMenuItem,
            this.şereftirSeniSevmekToolStripMenuItem});
            this.pOPÜLERMARŞLARToolStripMenuItem.Name = "pOPÜLERMARŞLARToolStripMenuItem";
            this.pOPÜLERMARŞLARToolStripMenuItem.Size = new System.Drawing.Size(154, 24);
            this.pOPÜLERMARŞLARToolStripMenuItem.Text = "POPÜLER MARŞLAR";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.richTextBox1.Location = new System.Drawing.Point(12, 106);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(831, 590);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(12, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(348, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "Galatasaray SK Kuruluş Tarihi";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(863, 106);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(428, 368);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Red;
            this.label2.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label2.Location = new System.Drawing.Point(1009, 492);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 27);
            this.label2.TabIndex = 4;
            this.label2.Text = "ALİ SAMİ YEN";
            // 
            // gerçekleriTarihYazarToolStripMenuItem
            // 
            this.gerçekleriTarihYazarToolStripMenuItem.Name = "gerçekleriTarihYazarToolStripMenuItem";
            this.gerçekleriTarihYazarToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.gerçekleriTarihYazarToolStripMenuItem.Text = "Gerçekleri Tarih Yazar";
            this.gerçekleriTarihYazarToolStripMenuItem.Click += new System.EventHandler(this.gerçekleriTarihYazarToolStripMenuItem_Click);
            // 
            // şereftirSeniSevmekToolStripMenuItem
            // 
            this.şereftirSeniSevmekToolStripMenuItem.Name = "şereftirSeniSevmekToolStripMenuItem";
            this.şereftirSeniSevmekToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.şereftirSeniSevmekToolStripMenuItem.Text = "Şereftir Seni Sevmek";
            this.şereftirSeniSevmekToolStripMenuItem.Click += new System.EventHandler(this.şereftirSeniSevmekToolStripMenuItem_Click);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(863, 543);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(38, 36);
            this.axWindowsMediaPlayer1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(1303, 734);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Galatasaray Tarihi ve Bilgi Alma Programı";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tARİHİToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem genelTarihToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bAŞARILARToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lİGBAŞARILARIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aVRUPABAŞARILARIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kAZANILANKUPLARToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gÖREVALANTEKNİKADAMLARToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fatihTerimToolStripMenuItem;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ToolStripMenuItem pOPÜLERMARŞLARToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem gerçekleriTarihYazarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem şereftirSeniSevmekToolStripMenuItem;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
    }
}

