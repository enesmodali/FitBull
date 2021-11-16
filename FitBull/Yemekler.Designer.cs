
namespace FitBull
{
    partial class Yemekler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Yemekler));
            this.label1 = new System.Windows.Forms.Label();
            this.cmbKategorilerYemekÇeşitleri = new System.Windows.Forms.ComboBox();
            this.cmbYemekler = new System.Windows.Forms.ComboBox();
            this.grpSecilenYemekler = new System.Windows.Forms.GroupBox();
            this.dgvYemekListesi = new System.Windows.Forms.DataGridView();
            this.txtYemeklerBirim = new System.Windows.Forms.TextBox();
            this.txtYemeklerKalori = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOgunEkle = new System.Windows.Forms.Button();
            this.btnOgunlereDon = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbOgunSec = new System.Windows.Forms.ComboBox();
            this.grpSecilenYemekler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvYemekListesi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(184, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "YEMEKLER";
            // 
            // cmbKategorilerYemekÇeşitleri
            // 
            this.cmbKategorilerYemekÇeşitleri.FormattingEnabled = true;
            this.cmbKategorilerYemekÇeşitleri.Items.AddRange(new object[] {
            "Salatalar"});
            this.cmbKategorilerYemekÇeşitleri.Location = new System.Drawing.Point(48, 44);
            this.cmbKategorilerYemekÇeşitleri.Margin = new System.Windows.Forms.Padding(2);
            this.cmbKategorilerYemekÇeşitleri.Name = "cmbKategorilerYemekÇeşitleri";
            this.cmbKategorilerYemekÇeşitleri.Size = new System.Drawing.Size(151, 21);
            this.cmbKategorilerYemekÇeşitleri.TabIndex = 1;
            this.cmbKategorilerYemekÇeşitleri.SelectedIndexChanged += new System.EventHandler(this.cmbKategorilerYemekÇeşitleri_SelectedIndexChanged);
            // 
            // cmbYemekler
            // 
            this.cmbYemekler.FormattingEnabled = true;
            this.cmbYemekler.Items.AddRange(new object[] {
            "Tavuklu"});
            this.cmbYemekler.Location = new System.Drawing.Point(48, 82);
            this.cmbYemekler.Margin = new System.Windows.Forms.Padding(2);
            this.cmbYemekler.Name = "cmbYemekler";
            this.cmbYemekler.Size = new System.Drawing.Size(151, 21);
            this.cmbYemekler.TabIndex = 2;
            this.cmbYemekler.SelectedIndexChanged += new System.EventHandler(this.cmbYemekler_SelectedIndexChanged);
            // 
            // grpSecilenYemekler
            // 
            this.grpSecilenYemekler.Controls.Add(this.dgvYemekListesi);
            this.grpSecilenYemekler.Controls.Add(this.txtYemeklerBirim);
            this.grpSecilenYemekler.Controls.Add(this.txtYemeklerKalori);
            this.grpSecilenYemekler.Controls.Add(this.label3);
            this.grpSecilenYemekler.Controls.Add(this.label2);
            this.grpSecilenYemekler.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpSecilenYemekler.Location = new System.Drawing.Point(75, 124);
            this.grpSecilenYemekler.Margin = new System.Windows.Forms.Padding(2);
            this.grpSecilenYemekler.Name = "grpSecilenYemekler";
            this.grpSecilenYemekler.Padding = new System.Windows.Forms.Padding(2);
            this.grpSecilenYemekler.Size = new System.Drawing.Size(328, 239);
            this.grpSecilenYemekler.TabIndex = 11;
            this.grpSecilenYemekler.TabStop = false;
            this.grpSecilenYemekler.Text = "Seçilen Yemeklerin Listesi";
            // 
            // dgvYemekListesi
            // 
            this.dgvYemekListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvYemekListesi.Location = new System.Drawing.Point(20, 20);
            this.dgvYemekListesi.Margin = new System.Windows.Forms.Padding(2);
            this.dgvYemekListesi.Name = "dgvYemekListesi";
            this.dgvYemekListesi.RowHeadersWidth = 51;
            this.dgvYemekListesi.RowTemplate.Height = 24;
            this.dgvYemekListesi.Size = new System.Drawing.Size(267, 137);
            this.dgvYemekListesi.TabIndex = 16;
            // 
            // txtYemeklerBirim
            // 
            this.txtYemeklerBirim.Location = new System.Drawing.Point(37, 200);
            this.txtYemeklerBirim.Margin = new System.Windows.Forms.Padding(2);
            this.txtYemeklerBirim.Name = "txtYemeklerBirim";
            this.txtYemeklerBirim.Size = new System.Drawing.Size(139, 23);
            this.txtYemeklerBirim.TabIndex = 15;
            this.txtYemeklerBirim.TextChanged += new System.EventHandler(this.txtYemeklerBirim_TextChanged);
            // 
            // txtYemeklerKalori
            // 
            this.txtYemeklerKalori.Location = new System.Drawing.Point(216, 200);
            this.txtYemeklerKalori.Margin = new System.Windows.Forms.Padding(2);
            this.txtYemeklerKalori.Name = "txtYemeklerKalori";
            this.txtYemeklerKalori.Size = new System.Drawing.Size(80, 23);
            this.txtYemeklerKalori.TabIndex = 14;
            this.txtYemeklerKalori.TextChanged += new System.EventHandler(this.txtYemeklerKalori_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Location = new System.Drawing.Point(232, 171);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Kalori";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Location = new System.Drawing.Point(85, 171);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Birim";
            // 
            // btnOgunEkle
            // 
            this.btnOgunEkle.Location = new System.Drawing.Point(151, 393);
            this.btnOgunEkle.Margin = new System.Windows.Forms.Padding(2);
            this.btnOgunEkle.Name = "btnOgunEkle";
            this.btnOgunEkle.Size = new System.Drawing.Size(119, 32);
            this.btnOgunEkle.TabIndex = 12;
            this.btnOgunEkle.Text = "ÖĞÜN EKLE";
            this.btnOgunEkle.UseVisualStyleBackColor = true;
            this.btnOgunEkle.Click += new System.EventHandler(this.btnOgunEkle_Click);
            // 
            // btnOgunlereDon
            // 
            this.btnOgunlereDon.Location = new System.Drawing.Point(291, 393);
            this.btnOgunlereDon.Margin = new System.Windows.Forms.Padding(2);
            this.btnOgunlereDon.Name = "btnOgunlereDon";
            this.btnOgunlereDon.Size = new System.Drawing.Size(123, 32);
            this.btnOgunlereDon.TabIndex = 13;
            this.btnOgunlereDon.Text = "ÖĞÜNLERE DÖN";
            this.btnOgunlereDon.UseVisualStyleBackColor = true;
            this.btnOgunlereDon.Click += new System.EventHandler(this.btnOgunlereDon_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(8, 366);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(92, 73);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(292, 48);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Öğün Seç";
            // 
            // cmbOgunSec
            // 
            this.cmbOgunSec.FormattingEnabled = true;
            this.cmbOgunSec.Items.AddRange(new object[] {
            "Kahvalti",
            "OgleYemegi",
            "AksamYemegi",
            "Aperatif"});
            this.cmbOgunSec.Location = new System.Drawing.Point(252, 82);
            this.cmbOgunSec.Margin = new System.Windows.Forms.Padding(2);
            this.cmbOgunSec.Name = "cmbOgunSec";
            this.cmbOgunSec.Size = new System.Drawing.Size(151, 21);
            this.cmbOgunSec.TabIndex = 16;
            this.cmbOgunSec.SelectedIndexChanged += new System.EventHandler(this.cmbOgunSec_SelectedIndexChanged);
            // 
            // Yemekler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 448);
            this.Controls.Add(this.cmbOgunSec);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnOgunlereDon);
            this.Controls.Add(this.btnOgunEkle);
            this.Controls.Add(this.grpSecilenYemekler);
            this.Controls.Add(this.cmbYemekler);
            this.Controls.Add(this.cmbKategorilerYemekÇeşitleri);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Yemekler";
            this.Text = "Yemekler";
            this.Load += new System.EventHandler(this.Yemekler_Load);
            this.grpSecilenYemekler.ResumeLayout(false);
            this.grpSecilenYemekler.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvYemekListesi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbKategorilerYemekÇeşitleri;
        private System.Windows.Forms.ComboBox cmbYemekler;
        private System.Windows.Forms.GroupBox grpSecilenYemekler;
        private System.Windows.Forms.TextBox txtYemeklerKalori;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOgunEkle;
        private System.Windows.Forms.Button btnOgunlereDon;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtYemeklerBirim;
        private System.Windows.Forms.DataGridView dgvYemekListesi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbOgunSec;
    }
}