
namespace FitBull
{
    partial class AnaSayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaSayfa));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnOgunler = new System.Windows.Forms.Button();
            this.btnKisiselKaloriAnalizi = new System.Windows.Forms.Button();
            this.btnGenelKaloriAnalizi = new System.Windows.Forms.Button();
            this.btnYemekCesidiRaporu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(341, 428);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(150, 125);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // btnOgunler
            // 
            this.btnOgunler.Location = new System.Drawing.Point(91, 33);
            this.btnOgunler.Name = "btnOgunler";
            this.btnOgunler.Size = new System.Drawing.Size(125, 79);
            this.btnOgunler.TabIndex = 10;
            this.btnOgunler.Text = "ÖĞÜNLER";
            this.btnOgunler.UseVisualStyleBackColor = true;
            this.btnOgunler.Click += new System.EventHandler(this.btnOgunler_Click);
            // 
            // btnKisiselKaloriAnalizi
            // 
            this.btnKisiselKaloriAnalizi.Location = new System.Drawing.Point(259, 33);
            this.btnKisiselKaloriAnalizi.Name = "btnKisiselKaloriAnalizi";
            this.btnKisiselKaloriAnalizi.Size = new System.Drawing.Size(125, 79);
            this.btnKisiselKaloriAnalizi.TabIndex = 12;
            this.btnKisiselKaloriAnalizi.Text = "KİŞİSEL KALORİ ANALİZİ";
            this.btnKisiselKaloriAnalizi.UseVisualStyleBackColor = true;
            this.btnKisiselKaloriAnalizi.Click += new System.EventHandler(this.btnKisiselKaloriAnalizi_Click);
            // 
            // btnGenelKaloriAnalizi
            // 
            this.btnGenelKaloriAnalizi.Location = new System.Drawing.Point(427, 33);
            this.btnGenelKaloriAnalizi.Name = "btnGenelKaloriAnalizi";
            this.btnGenelKaloriAnalizi.Size = new System.Drawing.Size(125, 79);
            this.btnGenelKaloriAnalizi.TabIndex = 13;
            this.btnGenelKaloriAnalizi.Text = "GENEL KALORİ ANALİZİ";
            this.btnGenelKaloriAnalizi.UseVisualStyleBackColor = true;
            this.btnGenelKaloriAnalizi.Click += new System.EventHandler(this.btnGenelKaloriAnalizi_Click);
            // 
            // btnYemekCesidiRaporu
            // 
            this.btnYemekCesidiRaporu.Location = new System.Drawing.Point(597, 33);
            this.btnYemekCesidiRaporu.Name = "btnYemekCesidiRaporu";
            this.btnYemekCesidiRaporu.Size = new System.Drawing.Size(125, 79);
            this.btnYemekCesidiRaporu.TabIndex = 14;
            this.btnYemekCesidiRaporu.Text = "YEMEK ÇEŞİDİ RAPORU";
            this.btnYemekCesidiRaporu.UseVisualStyleBackColor = true;
            this.btnYemekCesidiRaporu.Click += new System.EventHandler(this.btnYemekCesidiRaporu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(198, 294);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(384, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "\"LÜTFEN YAPMAK İSTEDİĞİNİZ İŞLEMİ SEÇİNİZ.\"";
            // 
            // AnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 621);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnYemekCesidiRaporu);
            this.Controls.Add(this.btnGenelKaloriAnalizi);
            this.Controls.Add(this.btnKisiselKaloriAnalizi);
            this.Controls.Add(this.btnOgunler);
            this.Controls.Add(this.pictureBox2);
            this.Name = "AnaSayfa";
            this.Text = "AnaSayfa";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnOgunler;
        private System.Windows.Forms.Button btnKisiselKaloriAnalizi;
        private System.Windows.Forms.Button btnGenelKaloriAnalizi;
        private System.Windows.Forms.Button btnYemekCesidiRaporu;
        private System.Windows.Forms.Label label1;
    }
}