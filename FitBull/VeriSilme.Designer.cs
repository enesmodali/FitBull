
namespace FitBull
{
    partial class VeriSilme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VeriSilme));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.cmbYemekID = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVeriSil = new System.Windows.Forms.Button();
            this.btnVeriSilCikis = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(202, 21);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 81);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // cmbYemekID
            // 
            this.cmbYemekID.FormattingEnabled = true;
            this.cmbYemekID.Location = new System.Drawing.Point(202, 151);
            this.cmbYemekID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbYemekID.Name = "cmbYemekID";
            this.cmbYemekID.Size = new System.Drawing.Size(177, 21);
            this.cmbYemekID.TabIndex = 8;
            this.cmbYemekID.SelectedIndexChanged += new System.EventHandler(this.cmbYemekAdi_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(116, 150);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Yemek ID:";
            // 
            // btnVeriSil
            // 
            this.btnVeriSil.Location = new System.Drawing.Point(167, 213);
            this.btnVeriSil.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnVeriSil.Name = "btnVeriSil";
            this.btnVeriSil.Size = new System.Drawing.Size(164, 40);
            this.btnVeriSil.TabIndex = 10;
            this.btnVeriSil.Text = "VERİ SİL";
            this.btnVeriSil.UseVisualStyleBackColor = true;
            this.btnVeriSil.Click += new System.EventHandler(this.btnVeriSil_Click);
            // 
            // btnVeriSilCikis
            // 
            this.btnVeriSilCikis.Location = new System.Drawing.Point(167, 288);
            this.btnVeriSilCikis.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnVeriSilCikis.Name = "btnVeriSilCikis";
            this.btnVeriSilCikis.Size = new System.Drawing.Size(164, 40);
            this.btnVeriSilCikis.TabIndex = 11;
            this.btnVeriSilCikis.Text = "ÇIKIŞ";
            this.btnVeriSilCikis.UseVisualStyleBackColor = true;
            this.btnVeriSilCikis.Click += new System.EventHandler(this.btnVeriSilCikis_Click);
            // 
            // VeriSilme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 378);
            this.Controls.Add(this.btnVeriSilCikis);
            this.Controls.Add(this.btnVeriSil);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbYemekID);
            this.Controls.Add(this.pictureBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "VeriSilme";
            this.Text = "VeriSilme";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ComboBox cmbYemekID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVeriSil;
        private System.Windows.Forms.Button btnVeriSilCikis;
    }
}