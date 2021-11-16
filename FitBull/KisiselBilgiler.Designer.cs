
namespace FitBull
{
    partial class KisiselBilgiler
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KisiselBilgiler));
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnKbDegisiklikleriKaydet = new System.Windows.Forms.Button();
            this.nmrKBKilo = new System.Windows.Forms.NumericUpDown();
            this.nmrKBBoy = new System.Windows.Forms.NumericUpDown();
            this.dtpKBDogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.cmbKBCinsiyet = new System.Windows.Forms.ComboBox();
            this.txtKBKullaniciAdi = new System.Windows.Forms.TextBox();
            this.txtKBAdi = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKBSifre = new System.Windows.Forms.TextBox();
            this.btnKbDuzenle = new System.Windows.Forms.Button();
            this.btnKbGeri = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtKBSoyad = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nmrKBKilo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrKBBoy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(373, 268);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(23, 17);
            this.label10.TabIndex = 47;
            this.label10.Text = "kg";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(370, 231);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 17);
            this.label9.TabIndex = 46;
            this.label9.Text = "cm";
            // 
            // btnKbDegisiklikleriKaydet
            // 
            this.btnKbDegisiklikleriKaydet.Location = new System.Drawing.Point(191, 390);
            this.btnKbDegisiklikleriKaydet.Margin = new System.Windows.Forms.Padding(2);
            this.btnKbDegisiklikleriKaydet.Name = "btnKbDegisiklikleriKaydet";
            this.btnKbDegisiklikleriKaydet.Size = new System.Drawing.Size(152, 28);
            this.btnKbDegisiklikleriKaydet.TabIndex = 45;
            this.btnKbDegisiklikleriKaydet.Text = "DEĞİŞİKLİKLERİ KAYDET";
            this.btnKbDegisiklikleriKaydet.UseVisualStyleBackColor = true;
            this.btnKbDegisiklikleriKaydet.Click += new System.EventHandler(this.btnKbDegisiklikleriKaydet_Click);
            // 
            // nmrKBKilo
            // 
            this.nmrKBKilo.DecimalPlaces = 1;
            this.nmrKBKilo.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nmrKBKilo.Location = new System.Drawing.Point(206, 267);
            this.nmrKBKilo.Margin = new System.Windows.Forms.Padding(2);
            this.nmrKBKilo.Maximum = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.nmrKBKilo.Minimum = new decimal(new int[] {
            35,
            0,
            0,
            0});
            this.nmrKBKilo.Name = "nmrKBKilo";
            this.nmrKBKilo.Size = new System.Drawing.Size(158, 20);
            this.nmrKBKilo.TabIndex = 44;
            this.nmrKBKilo.Value = new decimal(new int[] {
            35,
            0,
            0,
            0});
            this.nmrKBKilo.ValueChanged += new System.EventHandler(this.nmrKBKilo_ValueChanged);
            // 
            // nmrKBBoy
            // 
            this.nmrKBBoy.DecimalPlaces = 1;
            this.nmrKBBoy.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.nmrKBBoy.Location = new System.Drawing.Point(206, 231);
            this.nmrKBBoy.Margin = new System.Windows.Forms.Padding(2);
            this.nmrKBBoy.Maximum = new decimal(new int[] {
            220,
            0,
            0,
            0});
            this.nmrKBBoy.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nmrKBBoy.Name = "nmrKBBoy";
            this.nmrKBBoy.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nmrKBBoy.Size = new System.Drawing.Size(155, 20);
            this.nmrKBBoy.TabIndex = 43;
            this.nmrKBBoy.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nmrKBBoy.ValueChanged += new System.EventHandler(this.nmrKBBoy_ValueChanged);
            // 
            // dtpKBDogumTarihi
            // 
            this.dtpKBDogumTarihi.Location = new System.Drawing.Point(206, 193);
            this.dtpKBDogumTarihi.Margin = new System.Windows.Forms.Padding(2);
            this.dtpKBDogumTarihi.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpKBDogumTarihi.Name = "dtpKBDogumTarihi";
            this.dtpKBDogumTarihi.Size = new System.Drawing.Size(157, 20);
            this.dtpKBDogumTarihi.TabIndex = 42;
            this.dtpKBDogumTarihi.Value = new System.DateTime(2004, 12, 31, 0, 0, 0, 0);
            this.dtpKBDogumTarihi.ValueChanged += new System.EventHandler(this.dtpKBDogumTarihi_ValueChanged);
            // 
            // cmbKBCinsiyet
            // 
            this.cmbKBCinsiyet.FormattingEnabled = true;
            this.cmbKBCinsiyet.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.cmbKBCinsiyet.Location = new System.Drawing.Point(206, 161);
            this.cmbKBCinsiyet.Margin = new System.Windows.Forms.Padding(2);
            this.cmbKBCinsiyet.Name = "cmbKBCinsiyet";
            this.cmbKBCinsiyet.Size = new System.Drawing.Size(159, 21);
            this.cmbKBCinsiyet.TabIndex = 41;
            this.cmbKBCinsiyet.SelectedIndexChanged += new System.EventHandler(this.cmbKBCinsiyet_SelectedIndexChanged);
            // 
            // txtKBKullaniciAdi
            // 
            this.txtKBKullaniciAdi.Location = new System.Drawing.Point(206, 131);
            this.txtKBKullaniciAdi.Margin = new System.Windows.Forms.Padding(2);
            this.txtKBKullaniciAdi.Name = "txtKBKullaniciAdi";
            this.txtKBKullaniciAdi.Size = new System.Drawing.Size(159, 20);
            this.txtKBKullaniciAdi.TabIndex = 38;
            this.txtKBKullaniciAdi.TextChanged += new System.EventHandler(this.txtKBKullaniciAdi_TextChanged);
            // 
            // txtKBAdi
            // 
            this.txtKBAdi.Location = new System.Drawing.Point(207, 62);
            this.txtKBAdi.Margin = new System.Windows.Forms.Padding(2);
            this.txtKBAdi.Name = "txtKBAdi";
            this.txtKBAdi.Size = new System.Drawing.Size(159, 20);
            this.txtKBAdi.TabIndex = 37;
            this.txtKBAdi.TextChanged += new System.EventHandler(this.txtKBAdi_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(146, 267);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 17);
            this.label8.TabIndex = 36;
            this.label8.Text = "Kilo:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(143, 231);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 17);
            this.label7.TabIndex = 35;
            this.label7.Text = "Boy:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(84, 197);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 17);
            this.label6.TabIndex = 34;
            this.label6.Text = "Doğum Tarihi:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(118, 160);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 17);
            this.label5.TabIndex = 33;
            this.label5.Text = "Cinsiyet:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(93, 132);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 30;
            this.label2.Text = "Kullanıcı Adı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(150, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 17);
            this.label1.TabIndex = 29;
            this.label1.Text = "Ad:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(10, 337);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 81);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 28;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(140, 301);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 31;
            this.label3.Text = "Şifre:";
            // 
            // txtKBSifre
            // 
            this.txtKBSifre.Location = new System.Drawing.Point(206, 300);
            this.txtKBSifre.Margin = new System.Windows.Forms.Padding(2);
            this.txtKBSifre.Name = "txtKBSifre";
            this.txtKBSifre.Size = new System.Drawing.Size(159, 20);
            this.txtKBSifre.TabIndex = 39;
            this.txtKBSifre.TextChanged += new System.EventHandler(this.txtKBSifre_TextChanged);
            // 
            // btnKbDuzenle
            // 
            this.btnKbDuzenle.Location = new System.Drawing.Point(141, 342);
            this.btnKbDuzenle.Margin = new System.Windows.Forms.Padding(2);
            this.btnKbDuzenle.Name = "btnKbDuzenle";
            this.btnKbDuzenle.Size = new System.Drawing.Size(129, 28);
            this.btnKbDuzenle.TabIndex = 48;
            this.btnKbDuzenle.Text = "DÜZENLE";
            this.btnKbDuzenle.UseVisualStyleBackColor = true;
            this.btnKbDuzenle.Click += new System.EventHandler(this.btnKbDuzenle_Click);
            // 
            // btnKbGeri
            // 
            this.btnKbGeri.Location = new System.Drawing.Point(304, 342);
            this.btnKbGeri.Margin = new System.Windows.Forms.Padding(2);
            this.btnKbGeri.Name = "btnKbGeri";
            this.btnKbGeri.Size = new System.Drawing.Size(124, 28);
            this.btnKbGeri.TabIndex = 49;
            this.btnKbGeri.Text = "GERİ";
            this.btnKbGeri.UseVisualStyleBackColor = true;
            this.btnKbGeri.Click += new System.EventHandler(this.btnKbGeri_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(187, 16);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 20);
            this.label4.TabIndex = 50;
            this.label4.Text = "KİŞİSEL BİLGİLER";
            // 
            // txtKBSoyad
            // 
            this.txtKBSoyad.Location = new System.Drawing.Point(207, 97);
            this.txtKBSoyad.Margin = new System.Windows.Forms.Padding(2);
            this.txtKBSoyad.Name = "txtKBSoyad";
            this.txtKBSoyad.Size = new System.Drawing.Size(159, 20);
            this.txtKBSoyad.TabIndex = 52;
            this.txtKBSoyad.TextChanged += new System.EventHandler(this.txtKBSoyad_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(127, 98);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 17);
            this.label11.TabIndex = 51;
            this.label11.Text = "Soyad:";
            // 
            // KisiselBilgiler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 451);
            this.Controls.Add(this.txtKBSoyad);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnKbGeri);
            this.Controls.Add(this.btnKbDuzenle);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnKbDegisiklikleriKaydet);
            this.Controls.Add(this.nmrKBKilo);
            this.Controls.Add(this.nmrKBBoy);
            this.Controls.Add(this.dtpKBDogumTarihi);
            this.Controls.Add(this.cmbKBCinsiyet);
            this.Controls.Add(this.txtKBSifre);
            this.Controls.Add(this.txtKBKullaniciAdi);
            this.Controls.Add(this.txtKBAdi);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "KisiselBilgiler";
            this.Text = "KisiselBilgiler";
            ((System.ComponentModel.ISupportInitialize)(this.nmrKBKilo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrKBBoy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnKbDegisiklikleriKaydet;
        private System.Windows.Forms.NumericUpDown nmrKBKilo;
        private System.Windows.Forms.NumericUpDown nmrKBBoy;
        private System.Windows.Forms.DateTimePicker dtpKBDogumTarihi;
        private System.Windows.Forms.ComboBox cmbKBCinsiyet;
        private System.Windows.Forms.TextBox txtKBKullaniciAdi;
        private System.Windows.Forms.TextBox txtKBAdi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKBSifre;
        private System.Windows.Forms.Button btnKbDuzenle;
        private System.Windows.Forms.Button btnKbGeri;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtKBSoyad;
        private System.Windows.Forms.Label label11;
    }
}