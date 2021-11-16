
namespace FitBull
{
    partial class Ogunler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ogunler));
            this.label1 = new System.Windows.Forms.Label();
            this.btnKisiselBilgiler = new System.Windows.Forms.Button();
            this.lblTarih = new System.Windows.Forms.Label();
            this.grpKahvalti = new System.Windows.Forms.GroupBox();
            this.dgvKahvalti = new System.Windows.Forms.DataGridView();
            this.txtKahvaltiKalorisi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnKahvaltiListeyiTemizle = new System.Windows.Forms.Button();
            this.btnKahvaltiSil = new System.Windows.Forms.Button();
            this.btnKahvaltiEkle = new System.Windows.Forms.Button();
            this.grpOgleYemegi = new System.Windows.Forms.GroupBox();
            this.dgvOgle = new System.Windows.Forms.DataGridView();
            this.btnOgleListeyiTemizle = new System.Windows.Forms.Button();
            this.btnOgleYemegiSil = new System.Windows.Forms.Button();
            this.txtOgleYemegiKalorisi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnÖgleYemegiEkle = new System.Windows.Forms.Button();
            this.grpAksamYemegi = new System.Windows.Forms.GroupBox();
            this.dgvAksam = new System.Windows.Forms.DataGridView();
            this.btnAksamListeyiTemizle = new System.Windows.Forms.Button();
            this.btnAksamYemegiSil = new System.Windows.Forms.Button();
            this.txtAksamYemegiKalorisi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAksamYemegiEkle = new System.Windows.Forms.Button();
            this.grpAperatif = new System.Windows.Forms.GroupBox();
            this.dgvAperatif = new System.Windows.Forms.DataGridView();
            this.btnAperatifListeyiTemizle = new System.Windows.Forms.Button();
            this.btnAperatifSil = new System.Windows.Forms.Button();
            this.txtAperatifKalorisi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAperatifEkle = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtToplamKalori = new System.Windows.Forms.TextBox();
            this.btnKisiselKaloriAnalizi2 = new System.Windows.Forms.Button();
            this.btnGenelKaloriAnalizi2 = new System.Windows.Forms.Button();
            this.btnYemekCesidiRaporu = new System.Windows.Forms.Button();
            this.btnOgunlerCikis = new System.Windows.Forms.Button();
            this.grpKahvalti.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKahvalti)).BeginInit();
            this.grpOgleYemegi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOgle)).BeginInit();
            this.grpAksamYemegi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAksam)).BeginInit();
            this.grpAperatif.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAperatif)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(481, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ÖĞÜNLER";
            // 
            // btnKisiselBilgiler
            // 
            this.btnKisiselBilgiler.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKisiselBilgiler.Location = new System.Drawing.Point(28, 37);
            this.btnKisiselBilgiler.Name = "btnKisiselBilgiler";
            this.btnKisiselBilgiler.Size = new System.Drawing.Size(208, 48);
            this.btnKisiselBilgiler.TabIndex = 1;
            this.btnKisiselBilgiler.Text = "Kişisel Bilgiler";
            this.btnKisiselBilgiler.UseVisualStyleBackColor = true;
            this.btnKisiselBilgiler.Click += new System.EventHandler(this.btnKisiselBilgiler_Click);
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.Location = new System.Drawing.Point(922, 44);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(49, 20);
            this.lblTarih.TabIndex = 2;
            this.lblTarih.Text = "Tarih";
            this.lblTarih.Click += new System.EventHandler(this.lblTarih_Click);
            // 
            // grpKahvalti
            // 
            this.grpKahvalti.Controls.Add(this.dgvKahvalti);
            this.grpKahvalti.Controls.Add(this.txtKahvaltiKalorisi);
            this.grpKahvalti.Controls.Add(this.label2);
            this.grpKahvalti.Controls.Add(this.btnKahvaltiListeyiTemizle);
            this.grpKahvalti.Controls.Add(this.btnKahvaltiSil);
            this.grpKahvalti.Controls.Add(this.btnKahvaltiEkle);
            this.grpKahvalti.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpKahvalti.Location = new System.Drawing.Point(32, 115);
            this.grpKahvalti.Name = "grpKahvalti";
            this.grpKahvalti.Size = new System.Drawing.Size(483, 367);
            this.grpKahvalti.TabIndex = 5;
            this.grpKahvalti.TabStop = false;
            this.grpKahvalti.Text = "Kahvaltıda Tüketilen Yiyeceklerin Listesi";
            // 
            // dgvKahvalti
            // 
            this.dgvKahvalti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKahvalti.Location = new System.Drawing.Point(11, 26);
            this.dgvKahvalti.Name = "dgvKahvalti";
            this.dgvKahvalti.RowHeadersWidth = 51;
            this.dgvKahvalti.RowTemplate.Height = 24;
            this.dgvKahvalti.Size = new System.Drawing.Size(438, 220);
            this.dgvKahvalti.TabIndex = 11;
            // 
            // txtKahvaltiKalorisi
            // 
            this.txtKahvaltiKalorisi.Location = new System.Drawing.Point(228, 321);
            this.txtKahvaltiKalorisi.Name = "txtKahvaltiKalorisi";
            this.txtKahvaltiKalorisi.Size = new System.Drawing.Size(192, 23);
            this.txtKahvaltiKalorisi.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(61, 326);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Kahvaltı Kalorisi:";
            // 
            // btnKahvaltiListeyiTemizle
            // 
            this.btnKahvaltiListeyiTemizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKahvaltiListeyiTemizle.Location = new System.Drawing.Point(326, 252);
            this.btnKahvaltiListeyiTemizle.Name = "btnKahvaltiListeyiTemizle";
            this.btnKahvaltiListeyiTemizle.Size = new System.Drawing.Size(141, 48);
            this.btnKahvaltiListeyiTemizle.TabIndex = 8;
            this.btnKahvaltiListeyiTemizle.Text = "Listeyi Temizle";
            this.btnKahvaltiListeyiTemizle.UseVisualStyleBackColor = true;
            this.btnKahvaltiListeyiTemizle.Click += new System.EventHandler(this.btnKahvaltiListeyiTemizle_Click);
            // 
            // btnKahvaltiSil
            // 
            this.btnKahvaltiSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKahvaltiSil.Location = new System.Drawing.Point(175, 252);
            this.btnKahvaltiSil.Name = "btnKahvaltiSil";
            this.btnKahvaltiSil.Size = new System.Drawing.Size(132, 48);
            this.btnKahvaltiSil.TabIndex = 7;
            this.btnKahvaltiSil.Text = "Kahvaltı Sil";
            this.btnKahvaltiSil.UseVisualStyleBackColor = true;
            this.btnKahvaltiSil.Click += new System.EventHandler(this.btnKahvaltiSil_Click);
            // 
            // btnKahvaltiEkle
            // 
            this.btnKahvaltiEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKahvaltiEkle.Location = new System.Drawing.Point(15, 252);
            this.btnKahvaltiEkle.Name = "btnKahvaltiEkle";
            this.btnKahvaltiEkle.Size = new System.Drawing.Size(132, 48);
            this.btnKahvaltiEkle.TabIndex = 6;
            this.btnKahvaltiEkle.Text = "Kahvaltı Ekle";
            this.btnKahvaltiEkle.UseVisualStyleBackColor = true;
            this.btnKahvaltiEkle.Click += new System.EventHandler(this.btnKahvaltiEkle_Click);
            // 
            // grpOgleYemegi
            // 
            this.grpOgleYemegi.Controls.Add(this.dgvOgle);
            this.grpOgleYemegi.Controls.Add(this.btnOgleListeyiTemizle);
            this.grpOgleYemegi.Controls.Add(this.btnOgleYemegiSil);
            this.grpOgleYemegi.Controls.Add(this.txtOgleYemegiKalorisi);
            this.grpOgleYemegi.Controls.Add(this.label3);
            this.grpOgleYemegi.Controls.Add(this.btnÖgleYemegiEkle);
            this.grpOgleYemegi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpOgleYemegi.Location = new System.Drawing.Point(603, 125);
            this.grpOgleYemegi.Name = "grpOgleYemegi";
            this.grpOgleYemegi.Size = new System.Drawing.Size(493, 367);
            this.grpOgleYemegi.TabIndex = 9;
            this.grpOgleYemegi.TabStop = false;
            this.grpOgleYemegi.Text = "Öğle Yemeğinde Tüketilen Yiyeceklerin Listesi";
            // 
            // dgvOgle
            // 
            this.dgvOgle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOgle.Location = new System.Drawing.Point(15, 35);
            this.dgvOgle.Name = "dgvOgle";
            this.dgvOgle.RowHeadersWidth = 51;
            this.dgvOgle.RowTemplate.Height = 24;
            this.dgvOgle.Size = new System.Drawing.Size(452, 201);
            this.dgvOgle.TabIndex = 13;
            // 
            // btnOgleListeyiTemizle
            // 
            this.btnOgleListeyiTemizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOgleListeyiTemizle.Location = new System.Drawing.Point(338, 252);
            this.btnOgleListeyiTemizle.Name = "btnOgleListeyiTemizle";
            this.btnOgleListeyiTemizle.Size = new System.Drawing.Size(141, 48);
            this.btnOgleListeyiTemizle.TabIndex = 12;
            this.btnOgleListeyiTemizle.Text = "Listeyi Temizle";
            this.btnOgleListeyiTemizle.UseVisualStyleBackColor = true;
            this.btnOgleListeyiTemizle.Click += new System.EventHandler(this.btnOgleListeyiTemizle_Click);
            // 
            // btnOgleYemegiSil
            // 
            this.btnOgleYemegiSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOgleYemegiSil.Location = new System.Drawing.Point(176, 252);
            this.btnOgleYemegiSil.Name = "btnOgleYemegiSil";
            this.btnOgleYemegiSil.Size = new System.Drawing.Size(132, 48);
            this.btnOgleYemegiSil.TabIndex = 11;
            this.btnOgleYemegiSil.Text = "Öğle Yemeği Sil";
            this.btnOgleYemegiSil.UseVisualStyleBackColor = true;
            this.btnOgleYemegiSil.Click += new System.EventHandler(this.btnOgleYemegiSil_Click);
            // 
            // txtOgleYemegiKalorisi
            // 
            this.txtOgleYemegiKalorisi.Location = new System.Drawing.Point(228, 321);
            this.txtOgleYemegiKalorisi.Name = "txtOgleYemegiKalorisi";
            this.txtOgleYemegiKalorisi.Size = new System.Drawing.Size(192, 23);
            this.txtOgleYemegiKalorisi.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(19, 326);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Öğle Yemeği Kalorisi:";
            // 
            // btnÖgleYemegiEkle
            // 
            this.btnÖgleYemegiEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnÖgleYemegiEkle.Location = new System.Drawing.Point(15, 252);
            this.btnÖgleYemegiEkle.Name = "btnÖgleYemegiEkle";
            this.btnÖgleYemegiEkle.Size = new System.Drawing.Size(132, 48);
            this.btnÖgleYemegiEkle.TabIndex = 6;
            this.btnÖgleYemegiEkle.Text = "Öğle Yemeği Ekle";
            this.btnÖgleYemegiEkle.UseVisualStyleBackColor = true;
            this.btnÖgleYemegiEkle.Click += new System.EventHandler(this.btnÖgleYemegiEkle_Click);
            // 
            // grpAksamYemegi
            // 
            this.grpAksamYemegi.Controls.Add(this.dgvAksam);
            this.grpAksamYemegi.Controls.Add(this.btnAksamListeyiTemizle);
            this.grpAksamYemegi.Controls.Add(this.btnAksamYemegiSil);
            this.grpAksamYemegi.Controls.Add(this.txtAksamYemegiKalorisi);
            this.grpAksamYemegi.Controls.Add(this.label4);
            this.grpAksamYemegi.Controls.Add(this.btnAksamYemegiEkle);
            this.grpAksamYemegi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpAksamYemegi.Location = new System.Drawing.Point(28, 535);
            this.grpAksamYemegi.Name = "grpAksamYemegi";
            this.grpAksamYemegi.Size = new System.Drawing.Size(493, 367);
            this.grpAksamYemegi.TabIndex = 10;
            this.grpAksamYemegi.TabStop = false;
            this.grpAksamYemegi.Text = "Akşam Yemeğinde Tüketilen Yiyeceklerin Listesi";
            // 
            // dgvAksam
            // 
            this.dgvAksam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAksam.Location = new System.Drawing.Point(22, 53);
            this.dgvAksam.Name = "dgvAksam";
            this.dgvAksam.RowHeadersWidth = 51;
            this.dgvAksam.RowTemplate.Height = 24;
            this.dgvAksam.Size = new System.Drawing.Size(431, 164);
            this.dgvAksam.TabIndex = 13;
            // 
            // btnAksamListeyiTemizle
            // 
            this.btnAksamListeyiTemizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAksamListeyiTemizle.Location = new System.Drawing.Point(338, 252);
            this.btnAksamListeyiTemizle.Name = "btnAksamListeyiTemizle";
            this.btnAksamListeyiTemizle.Size = new System.Drawing.Size(141, 48);
            this.btnAksamListeyiTemizle.TabIndex = 12;
            this.btnAksamListeyiTemizle.Text = "Listeyi Temizle";
            this.btnAksamListeyiTemizle.UseVisualStyleBackColor = true;
            this.btnAksamListeyiTemizle.Click += new System.EventHandler(this.btnAksamListeyiTemizle_Click);
            // 
            // btnAksamYemegiSil
            // 
            this.btnAksamYemegiSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAksamYemegiSil.Location = new System.Drawing.Point(176, 252);
            this.btnAksamYemegiSil.Name = "btnAksamYemegiSil";
            this.btnAksamYemegiSil.Size = new System.Drawing.Size(132, 48);
            this.btnAksamYemegiSil.TabIndex = 11;
            this.btnAksamYemegiSil.Text = "Akşam Yemeği Sil";
            this.btnAksamYemegiSil.UseVisualStyleBackColor = true;
            this.btnAksamYemegiSil.Click += new System.EventHandler(this.btnAksamYemegiSil_Click);
            // 
            // txtAksamYemegiKalorisi
            // 
            this.txtAksamYemegiKalorisi.Location = new System.Drawing.Point(228, 321);
            this.txtAksamYemegiKalorisi.Name = "txtAksamYemegiKalorisi";
            this.txtAksamYemegiKalorisi.Size = new System.Drawing.Size(192, 23);
            this.txtAksamYemegiKalorisi.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(19, 326);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Akşam Yemeği Kalorisi:";
            // 
            // btnAksamYemegiEkle
            // 
            this.btnAksamYemegiEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAksamYemegiEkle.Location = new System.Drawing.Point(15, 252);
            this.btnAksamYemegiEkle.Name = "btnAksamYemegiEkle";
            this.btnAksamYemegiEkle.Size = new System.Drawing.Size(132, 48);
            this.btnAksamYemegiEkle.TabIndex = 6;
            this.btnAksamYemegiEkle.Text = "Akşam Yemeği Ekle";
            this.btnAksamYemegiEkle.UseVisualStyleBackColor = true;
            this.btnAksamYemegiEkle.Click += new System.EventHandler(this.btnAksamYemegiEkle_Click);
            // 
            // grpAperatif
            // 
            this.grpAperatif.Controls.Add(this.dgvAperatif);
            this.grpAperatif.Controls.Add(this.btnAperatifListeyiTemizle);
            this.grpAperatif.Controls.Add(this.btnAperatifSil);
            this.grpAperatif.Controls.Add(this.txtAperatifKalorisi);
            this.grpAperatif.Controls.Add(this.label5);
            this.grpAperatif.Controls.Add(this.btnAperatifEkle);
            this.grpAperatif.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpAperatif.Location = new System.Drawing.Point(603, 535);
            this.grpAperatif.Name = "grpAperatif";
            this.grpAperatif.Size = new System.Drawing.Size(493, 367);
            this.grpAperatif.TabIndex = 11;
            this.grpAperatif.TabStop = false;
            this.grpAperatif.Text = "Aperatif/Diğer Tüketilen Yiyeceklerin Listesi";
            // 
            // dgvAperatif
            // 
            this.dgvAperatif.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAperatif.Location = new System.Drawing.Point(15, 53);
            this.dgvAperatif.Name = "dgvAperatif";
            this.dgvAperatif.RowHeadersWidth = 51;
            this.dgvAperatif.RowTemplate.Height = 24;
            this.dgvAperatif.Size = new System.Drawing.Size(441, 164);
            this.dgvAperatif.TabIndex = 13;
            // 
            // btnAperatifListeyiTemizle
            // 
            this.btnAperatifListeyiTemizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAperatifListeyiTemizle.Location = new System.Drawing.Point(338, 252);
            this.btnAperatifListeyiTemizle.Name = "btnAperatifListeyiTemizle";
            this.btnAperatifListeyiTemizle.Size = new System.Drawing.Size(141, 48);
            this.btnAperatifListeyiTemizle.TabIndex = 12;
            this.btnAperatifListeyiTemizle.Text = "Listeyi Temizle";
            this.btnAperatifListeyiTemizle.UseVisualStyleBackColor = true;
            this.btnAperatifListeyiTemizle.Click += new System.EventHandler(this.btnAperatifListeyiTemizle_Click);
            // 
            // btnAperatifSil
            // 
            this.btnAperatifSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAperatifSil.Location = new System.Drawing.Point(176, 252);
            this.btnAperatifSil.Name = "btnAperatifSil";
            this.btnAperatifSil.Size = new System.Drawing.Size(132, 48);
            this.btnAperatifSil.TabIndex = 11;
            this.btnAperatifSil.Text = "Aperatif/Diğer Sil";
            this.btnAperatifSil.UseVisualStyleBackColor = true;
            this.btnAperatifSil.Click += new System.EventHandler(this.btnAperatifSil_Click);
            // 
            // txtAperatifKalorisi
            // 
            this.txtAperatifKalorisi.Location = new System.Drawing.Point(238, 321);
            this.txtAperatifKalorisi.Name = "txtAperatifKalorisi";
            this.txtAperatifKalorisi.Size = new System.Drawing.Size(192, 23);
            this.txtAperatifKalorisi.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(19, 326);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Aperatif/Diğer Kalorisi:";
            // 
            // btnAperatifEkle
            // 
            this.btnAperatifEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAperatifEkle.Location = new System.Drawing.Point(15, 252);
            this.btnAperatifEkle.Name = "btnAperatifEkle";
            this.btnAperatifEkle.Size = new System.Drawing.Size(132, 48);
            this.btnAperatifEkle.TabIndex = 6;
            this.btnAperatifEkle.Text = "Aperatif/Diğer Ekle";
            this.btnAperatifEkle.UseVisualStyleBackColor = true;
            this.btnAperatifEkle.Click += new System.EventHandler(this.btnAperatifEkle_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(25, 913);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(150, 125);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(209, 956);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Toplam Kalori:";
            // 
            // txtToplamKalori
            // 
            this.txtToplamKalori.Location = new System.Drawing.Point(355, 948);
            this.txtToplamKalori.Name = "txtToplamKalori";
            this.txtToplamKalori.Size = new System.Drawing.Size(140, 26);
            this.txtToplamKalori.TabIndex = 14;
            this.txtToplamKalori.TextChanged += new System.EventHandler(this.txtToplamKalori_TextChanged);
            // 
            // btnKisiselKaloriAnalizi2
            // 
            this.btnKisiselKaloriAnalizi2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKisiselKaloriAnalizi2.Location = new System.Drawing.Point(522, 934);
            this.btnKisiselKaloriAnalizi2.Name = "btnKisiselKaloriAnalizi2";
            this.btnKisiselKaloriAnalizi2.Size = new System.Drawing.Size(149, 49);
            this.btnKisiselKaloriAnalizi2.TabIndex = 15;
            this.btnKisiselKaloriAnalizi2.Text = "Kişisel Kalori Analizi";
            this.btnKisiselKaloriAnalizi2.UseVisualStyleBackColor = true;
            this.btnKisiselKaloriAnalizi2.Click += new System.EventHandler(this.btnKisiselKaloriAnalizi2_Click);
            // 
            // btnGenelKaloriAnalizi2
            // 
            this.btnGenelKaloriAnalizi2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGenelKaloriAnalizi2.Location = new System.Drawing.Point(701, 934);
            this.btnGenelKaloriAnalizi2.Name = "btnGenelKaloriAnalizi2";
            this.btnGenelKaloriAnalizi2.Size = new System.Drawing.Size(149, 49);
            this.btnGenelKaloriAnalizi2.TabIndex = 16;
            this.btnGenelKaloriAnalizi2.Text = "Genel Kalori Analizi";
            this.btnGenelKaloriAnalizi2.UseVisualStyleBackColor = true;
            this.btnGenelKaloriAnalizi2.Click += new System.EventHandler(this.btnGenelKaloriAnalizi2_Click);
            // 
            // btnYemekCesidiRaporu
            // 
            this.btnYemekCesidiRaporu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYemekCesidiRaporu.Location = new System.Drawing.Point(884, 934);
            this.btnYemekCesidiRaporu.Name = "btnYemekCesidiRaporu";
            this.btnYemekCesidiRaporu.Size = new System.Drawing.Size(149, 49);
            this.btnYemekCesidiRaporu.TabIndex = 17;
            this.btnYemekCesidiRaporu.Text = "Yemek Çeşidi Raporu";
            this.btnYemekCesidiRaporu.UseVisualStyleBackColor = true;
            this.btnYemekCesidiRaporu.Click += new System.EventHandler(this.btnYemekCesidiRaporu_Click);
            // 
            // btnOgunlerCikis
            // 
            this.btnOgunlerCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOgunlerCikis.Location = new System.Drawing.Point(914, 1003);
            this.btnOgunlerCikis.Name = "btnOgunlerCikis";
            this.btnOgunlerCikis.Size = new System.Drawing.Size(168, 35);
            this.btnOgunlerCikis.TabIndex = 18;
            this.btnOgunlerCikis.Text = "ÇIKIŞ";
            this.btnOgunlerCikis.UseVisualStyleBackColor = true;
            this.btnOgunlerCikis.Click += new System.EventHandler(this.btnOgunlerCikis_Click);
            // 
            // Ogunler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1133, 749);
            this.Controls.Add(this.btnOgunlerCikis);
            this.Controls.Add(this.btnYemekCesidiRaporu);
            this.Controls.Add(this.btnGenelKaloriAnalizi2);
            this.Controls.Add(this.btnKisiselKaloriAnalizi2);
            this.Controls.Add(this.txtToplamKalori);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.grpAperatif);
            this.Controls.Add(this.grpAksamYemegi);
            this.Controls.Add(this.grpOgleYemegi);
            this.Controls.Add(this.grpKahvalti);
            this.Controls.Add(this.lblTarih);
            this.Controls.Add(this.btnKisiselBilgiler);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Ogunler";
            this.Text = "Ogunler";
            this.Load += new System.EventHandler(this.Ogunler_Load);
            this.grpKahvalti.ResumeLayout(false);
            this.grpKahvalti.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKahvalti)).EndInit();
            this.grpOgleYemegi.ResumeLayout(false);
            this.grpOgleYemegi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOgle)).EndInit();
            this.grpAksamYemegi.ResumeLayout(false);
            this.grpAksamYemegi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAksam)).EndInit();
            this.grpAperatif.ResumeLayout(false);
            this.grpAperatif.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAperatif)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKisiselBilgiler;
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.GroupBox grpKahvalti;
        private System.Windows.Forms.Button btnKahvaltiEkle;
        private System.Windows.Forms.Button btnKahvaltiSil;
        private System.Windows.Forms.Button btnKahvaltiListeyiTemizle;
        private System.Windows.Forms.TextBox txtKahvaltiKalorisi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpOgleYemegi;
        private System.Windows.Forms.TextBox txtOgleYemegiKalorisi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnÖgleYemegiEkle;
        private System.Windows.Forms.Button btnOgleListeyiTemizle;
        private System.Windows.Forms.Button btnOgleYemegiSil;
        private System.Windows.Forms.GroupBox grpAksamYemegi;
        private System.Windows.Forms.Button btnAksamListeyiTemizle;
        private System.Windows.Forms.Button btnAksamYemegiSil;
        private System.Windows.Forms.TextBox txtAksamYemegiKalorisi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAksamYemegiEkle;
        private System.Windows.Forms.GroupBox grpAperatif;
        private System.Windows.Forms.Button btnAperatifListeyiTemizle;
        private System.Windows.Forms.Button btnAperatifSil;
        private System.Windows.Forms.TextBox txtAperatifKalorisi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAperatifEkle;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtToplamKalori;
        private System.Windows.Forms.Button btnKisiselKaloriAnalizi2;
        private System.Windows.Forms.Button btnGenelKaloriAnalizi2;
        private System.Windows.Forms.Button btnYemekCesidiRaporu;
        private System.Windows.Forms.Button btnOgunlerCikis;
        private System.Windows.Forms.DataGridView dgvKahvalti;
        private System.Windows.Forms.DataGridView dgvOgle;
        private System.Windows.Forms.DataGridView dgvAksam;
        private System.Windows.Forms.DataGridView dgvAperatif;
    }
}