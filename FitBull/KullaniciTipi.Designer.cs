
namespace FitBull
{
    partial class KullaniciTipi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KullaniciTipi));
            this.btnKTKullaniciGirisiIleDevam = new System.Windows.Forms.Button();
            this.btnKTYoneticiGirisiDevam = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnKTKullaniciGirisiIleDevam
            // 
            this.btnKTKullaniciGirisiIleDevam.Location = new System.Drawing.Point(161, 234);
            this.btnKTKullaniciGirisiIleDevam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnKTKullaniciGirisiIleDevam.Name = "btnKTKullaniciGirisiIleDevam";
            this.btnKTKullaniciGirisiIleDevam.Size = new System.Drawing.Size(152, 59);
            this.btnKTKullaniciGirisiIleDevam.TabIndex = 1;
            this.btnKTKullaniciGirisiIleDevam.Text = "Kullanıcı Girişi ile Devam Et";
            this.btnKTKullaniciGirisiIleDevam.UseVisualStyleBackColor = true;
            this.btnKTKullaniciGirisiIleDevam.Click += new System.EventHandler(this.btnKTKullaniciGirisiIleDevam_Click);
            // 
            // btnKTYoneticiGirisiDevam
            // 
            this.btnKTYoneticiGirisiDevam.Location = new System.Drawing.Point(161, 332);
            this.btnKTYoneticiGirisiDevam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnKTYoneticiGirisiDevam.Name = "btnKTYoneticiGirisiDevam";
            this.btnKTYoneticiGirisiDevam.Size = new System.Drawing.Size(152, 59);
            this.btnKTYoneticiGirisiDevam.TabIndex = 2;
            this.btnKTYoneticiGirisiDevam.Text = "Yönetici Girişi ile Devam Et";
            this.btnKTYoneticiGirisiDevam.UseVisualStyleBackColor = true;
            this.btnKTYoneticiGirisiDevam.Click += new System.EventHandler(this.btnKTYoneticiGirisiDevam_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(169, 42);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(133, 100);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // KullaniciTipi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 480);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnKTYoneticiGirisiDevam);
            this.Controls.Add(this.btnKTKullaniciGirisiIleDevam);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "KullaniciTipi";
            this.Text = "KullanıcıTipi";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnKTKullaniciGirisiIleDevam;
        private System.Windows.Forms.Button btnKTYoneticiGirisiDevam;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}