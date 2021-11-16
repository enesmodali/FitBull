
namespace FitBull
{
    partial class ProgramYoneticisiGirisi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProgramYoneticisiGirisi));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPYGKullaniciAdi = new System.Windows.Forms.TextBox();
            this.txtPYGSifre = new System.Windows.Forms.TextBox();
            this.btnPYGGiris = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(186, 26);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(133, 100);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(95, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(155, 274);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Şifre:";
            // 
            // txtPYGKullaniciAdi
            // 
            this.txtPYGKullaniciAdi.Location = new System.Drawing.Point(217, 210);
            this.txtPYGKullaniciAdi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPYGKullaniciAdi.Name = "txtPYGKullaniciAdi";
            this.txtPYGKullaniciAdi.Size = new System.Drawing.Size(178, 22);
            this.txtPYGKullaniciAdi.TabIndex = 7;
            // 
            // txtPYGSifre
            // 
            this.txtPYGSifre.Location = new System.Drawing.Point(217, 274);
            this.txtPYGSifre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPYGSifre.Name = "txtPYGSifre";
            this.txtPYGSifre.Size = new System.Drawing.Size(178, 22);
            this.txtPYGSifre.TabIndex = 8;
            // 
            // btnPYGGiris
            // 
            this.btnPYGGiris.Location = new System.Drawing.Point(173, 373);
            this.btnPYGGiris.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPYGGiris.Name = "btnPYGGiris";
            this.btnPYGGiris.Size = new System.Drawing.Size(180, 42);
            this.btnPYGGiris.TabIndex = 9;
            this.btnPYGGiris.Text = "GİRİŞ";
            this.btnPYGGiris.UseVisualStyleBackColor = true;
            this.btnPYGGiris.Click += new System.EventHandler(this.btnPYGGiris_Click);
            // 
            // ProgramYoneticisiGirisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 479);
            this.Controls.Add(this.btnPYGGiris);
            this.Controls.Add(this.txtPYGSifre);
            this.Controls.Add(this.txtPYGKullaniciAdi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ProgramYoneticisiGirisi";
            this.Text = "ProgramYöneticisiGirişi";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPYGKullaniciAdi;
        private System.Windows.Forms.TextBox txtPYGSifre;
        private System.Windows.Forms.Button btnPYGGiris;
    }
}