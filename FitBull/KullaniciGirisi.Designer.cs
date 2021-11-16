
namespace FitBull
{
    partial class KullaniciGirisi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KullaniciGirisi));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKGKullaniciAdi = new System.Windows.Forms.TextBox();
            this.txtKGSifre = new System.Windows.Forms.TextBox();
            this.btnKGGiris = new System.Windows.Forms.Button();
            this.btnKGKayitOl = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(165, 26);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(133, 100);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(100, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(160, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Şifre:";
            // 
            // txtKGKullaniciAdi
            // 
            this.txtKGKullaniciAdi.Location = new System.Drawing.Point(229, 171);
            this.txtKGKullaniciAdi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtKGKullaniciAdi.Name = "txtKGKullaniciAdi";
            this.txtKGKullaniciAdi.Size = new System.Drawing.Size(160, 22);
            this.txtKGKullaniciAdi.TabIndex = 10;
            // 
            // txtKGSifre
            // 
            this.txtKGSifre.Location = new System.Drawing.Point(229, 225);
            this.txtKGSifre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtKGSifre.Name = "txtKGSifre";
            this.txtKGSifre.Size = new System.Drawing.Size(160, 22);
            this.txtKGSifre.TabIndex = 11;
            // 
            // btnKGGiris
            // 
            this.btnKGGiris.Location = new System.Drawing.Point(141, 313);
            this.btnKGGiris.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnKGGiris.Name = "btnKGGiris";
            this.btnKGGiris.Size = new System.Drawing.Size(157, 47);
            this.btnKGGiris.TabIndex = 12;
            this.btnKGGiris.Text = "GİRİŞ";
            this.btnKGGiris.UseVisualStyleBackColor = true;
            this.btnKGGiris.Click += new System.EventHandler(this.btnKGGiris_Click);
            // 
            // btnKGKayitOl
            // 
            this.btnKGKayitOl.Location = new System.Drawing.Point(141, 397);
            this.btnKGKayitOl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnKGKayitOl.Name = "btnKGKayitOl";
            this.btnKGKayitOl.Size = new System.Drawing.Size(157, 47);
            this.btnKGKayitOl.TabIndex = 13;
            this.btnKGKayitOl.Text = "KAYIT OL";
            this.btnKGKayitOl.UseVisualStyleBackColor = true;
            this.btnKGKayitOl.Click += new System.EventHandler(this.btnKGKayitOl_Click);
            // 
            // KullaniciGirisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 493);
            this.Controls.Add(this.btnKGKayitOl);
            this.Controls.Add(this.btnKGGiris);
            this.Controls.Add(this.txtKGSifre);
            this.Controls.Add(this.txtKGKullaniciAdi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "KullaniciGirisi";
            this.Text = "KullaniciGirisi";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKGKullaniciAdi;
        private System.Windows.Forms.TextBox txtKGSifre;
        private System.Windows.Forms.Button btnKGGiris;
        private System.Windows.Forms.Button btnKGKayitOl;
    }
}