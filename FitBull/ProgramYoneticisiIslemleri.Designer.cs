
namespace FitBull
{
    partial class ProgramYoneticisiIslemleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProgramYoneticisiIslemleri));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnPYIVeriEkle = new System.Windows.Forms.Button();
            this.btnPYIVeriSil = new System.Windows.Forms.Button();
            this.btnPYICikis = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(120, 50);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(133, 100);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // btnPYIVeriEkle
            // 
            this.btnPYIVeriEkle.Location = new System.Drawing.Point(98, 217);
            this.btnPYIVeriEkle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPYIVeriEkle.Name = "btnPYIVeriEkle";
            this.btnPYIVeriEkle.Size = new System.Drawing.Size(170, 50);
            this.btnPYIVeriEkle.TabIndex = 6;
            this.btnPYIVeriEkle.Text = "VERİ EKLE";
            this.btnPYIVeriEkle.UseVisualStyleBackColor = true;
            this.btnPYIVeriEkle.Click += new System.EventHandler(this.btnPYIVeriEkle_Click);
            // 
            // btnPYIVeriSil
            // 
            this.btnPYIVeriSil.Location = new System.Drawing.Point(98, 300);
            this.btnPYIVeriSil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPYIVeriSil.Name = "btnPYIVeriSil";
            this.btnPYIVeriSil.Size = new System.Drawing.Size(170, 46);
            this.btnPYIVeriSil.TabIndex = 7;
            this.btnPYIVeriSil.Text = "VERİ SİL";
            this.btnPYIVeriSil.UseVisualStyleBackColor = true;
            this.btnPYIVeriSil.Click += new System.EventHandler(this.btnPYIVeriSil_Click);
            // 
            // btnPYICikis
            // 
            this.btnPYICikis.Location = new System.Drawing.Point(140, 380);
            this.btnPYICikis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPYICikis.Name = "btnPYICikis";
            this.btnPYICikis.Size = new System.Drawing.Size(92, 40);
            this.btnPYICikis.TabIndex = 8;
            this.btnPYICikis.Text = "ÇIKIŞ";
            this.btnPYICikis.UseVisualStyleBackColor = true;
            this.btnPYICikis.Click += new System.EventHandler(this.btnPYICikis_Click);
            // 
            // ProgramYoneticisiIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 478);
            this.Controls.Add(this.btnPYICikis);
            this.Controls.Add(this.btnPYIVeriSil);
            this.Controls.Add(this.btnPYIVeriEkle);
            this.Controls.Add(this.pictureBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ProgramYoneticisiIslemleri";
            this.Text = "ProgramYoneticisiIslemleri";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnPYIVeriEkle;
        private System.Windows.Forms.Button btnPYIVeriSil;
        private System.Windows.Forms.Button btnPYICikis;
    }
}