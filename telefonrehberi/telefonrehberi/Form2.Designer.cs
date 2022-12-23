namespace telefonrehberi
{
    partial class Form2
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
            this.textAd = new System.Windows.Forms.TextBox();
            this.textSoyad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.listAd = new System.Windows.Forms.ListBox();
            this.listSoyad = new System.Windows.Forms.ListBox();
            this.listNumara = new System.Windows.Forms.ListBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGüncelle = new System.Windows.Forms.Button();
            this.btnAra = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textNumara = new System.Windows.Forms.MaskedTextBox();
            this.btncıkıs = new System.Windows.Forms.Button();
            this.btncevir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textAd
            // 
            this.textAd.Location = new System.Drawing.Point(98, 22);
            this.textAd.Name = "textAd";
            this.textAd.Size = new System.Drawing.Size(159, 23);
            this.textAd.TabIndex = 0;
            // 
            // textSoyad
            // 
            this.textSoyad.Location = new System.Drawing.Point(98, 63);
            this.textSoyad.Name = "textSoyad";
            this.textSoyad.Size = new System.Drawing.Size(159, 23);
            this.textSoyad.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(55, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "AD";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(34, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "SOYAD";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(20, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "NUMARA";
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.LightSalmon;
            this.btnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEkle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEkle.Location = new System.Drawing.Point(417, 21);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(178, 23);
            this.btnEkle.TabIndex = 6;
            this.btnEkle.Text = "Kaydet";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // listAd
            // 
            this.listAd.BackColor = System.Drawing.Color.Cornsilk;
            this.listAd.FormattingEnabled = true;
            this.listAd.ItemHeight = 15;
            this.listAd.Location = new System.Drawing.Point(56, 183);
            this.listAd.Name = "listAd";
            this.listAd.Size = new System.Drawing.Size(183, 169);
            this.listAd.TabIndex = 7;
            this.listAd.SelectedIndexChanged += new System.EventHandler(this.listAd_SelectedIndexChanged);
            // 
            // listSoyad
            // 
            this.listSoyad.BackColor = System.Drawing.Color.Cornsilk;
            this.listSoyad.FormattingEnabled = true;
            this.listSoyad.ItemHeight = 15;
            this.listSoyad.Location = new System.Drawing.Point(236, 183);
            this.listSoyad.Name = "listSoyad";
            this.listSoyad.Size = new System.Drawing.Size(183, 169);
            this.listSoyad.TabIndex = 8;
            this.listSoyad.SelectedIndexChanged += new System.EventHandler(this.listSoyad_SelectedIndexChanged);
            // 
            // listNumara
            // 
            this.listNumara.BackColor = System.Drawing.Color.Cornsilk;
            this.listNumara.FormattingEnabled = true;
            this.listNumara.ItemHeight = 15;
            this.listNumara.Location = new System.Drawing.Point(417, 183);
            this.listNumara.Name = "listNumara";
            this.listNumara.Size = new System.Drawing.Size(183, 169);
            this.listNumara.TabIndex = 9;
            this.listNumara.SelectedIndexChanged += new System.EventHandler(this.listNumara_SelectedIndexChanged);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.SkyBlue;
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSil.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSil.Location = new System.Drawing.Point(60, 388);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(88, 23);
            this.btnSil.TabIndex = 10;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.BackColor = System.Drawing.Color.Silver;
            this.btnGüncelle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGüncelle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGüncelle.Location = new System.Drawing.Point(422, 388);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(178, 23);
            this.btnGüncelle.TabIndex = 11;
            this.btnGüncelle.Text = " Seçili Kişiyi Güncelle";
            this.btnGüncelle.UseVisualStyleBackColor = false;
            this.btnGüncelle.Click += new System.EventHandler(this.btnGüncelle_Click);
            // 
            // btnAra
            // 
            this.btnAra.BackColor = System.Drawing.Color.Tomato;
            this.btnAra.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAra.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAra.Location = new System.Drawing.Point(417, 76);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(178, 23);
            this.btnAra.TabIndex = 12;
            this.btnAra.Text = "Kişi Ara";
            this.btnAra.UseVisualStyleBackColor = false;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(122, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "ADI";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(307, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "SOYADI";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(474, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "NUMARASI";
            // 
            // textNumara
            // 
            this.textNumara.Location = new System.Drawing.Point(98, 102);
            this.textNumara.Mask = "00000000000";
            this.textNumara.Name = "textNumara";
            this.textNumara.Size = new System.Drawing.Size(159, 23);
            this.textNumara.TabIndex = 16;
            // 
            // btncıkıs
            // 
            this.btncıkıs.BackColor = System.Drawing.Color.DarkBlue;
            this.btncıkıs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncıkıs.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btncıkıs.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btncıkıs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btncıkıs.Location = new System.Drawing.Point(877, 388);
            this.btncıkıs.Name = "btncıkıs";
            this.btncıkıs.Size = new System.Drawing.Size(75, 50);
            this.btncıkıs.TabIndex = 17;
            this.btncıkıs.Text = "Çıkış Yap";
            this.btncıkıs.UseVisualStyleBackColor = false;
            this.btncıkıs.Click += new System.EventHandler(this.btncıkıs_Click);
            // 
            // btncevir
            // 
            this.btncevir.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btncevir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btncevir.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btncevir.Location = new System.Drawing.Point(770, 388);
            this.btncevir.Name = "btncevir";
            this.btncevir.Size = new System.Drawing.Size(75, 50);
            this.btncevir.TabIndex = 18;
            this.btncevir.Text = "Kişileri indir";
            this.btncevir.UseVisualStyleBackColor = false;
            this.btncevir.Click += new System.EventHandler(this.btncevir_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(964, 450);
            this.Controls.Add(this.btncevir);
            this.Controls.Add(this.btncıkıs);
            this.Controls.Add(this.textNumara);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.btnGüncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.listNumara);
            this.Controls.Add(this.listSoyad);
            this.Controls.Add(this.listAd);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textSoyad);
            this.Controls.Add(this.textAd);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TELEFON REHBERİ";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textAd;
        private TextBox textSoyad;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnEkle;
        private ListBox listAd;
        private ListBox listSoyad;
        private ListBox listNumara;
        private Button btnSil;
        private Button btnGüncelle;
        private Button btnAra;
        private Label label4;
        private Label label5;
        private Label label6;
        private MaskedTextBox textNumara;
        private Button btncıkıs;
        private Button btncevir;
    }
}