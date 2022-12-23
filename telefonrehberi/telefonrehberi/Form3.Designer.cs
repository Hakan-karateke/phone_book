namespace telefonrehberi
{
    partial class Form3
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
            this.textyeni_ad = new System.Windows.Forms.TextBox();
            this.textyeni_sifre = new System.Windows.Forms.TextBox();
            this.texttekrar_sifre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnhesapekle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textyeni_ad
            // 
            this.textyeni_ad.Location = new System.Drawing.Point(208, 29);
            this.textyeni_ad.Name = "textyeni_ad";
            this.textyeni_ad.Size = new System.Drawing.Size(195, 23);
            this.textyeni_ad.TabIndex = 0;
            // 
            // textyeni_sifre
            // 
            this.textyeni_sifre.Location = new System.Drawing.Point(208, 94);
            this.textyeni_sifre.Name = "textyeni_sifre";
            this.textyeni_sifre.Size = new System.Drawing.Size(195, 23);
            this.textyeni_sifre.TabIndex = 1;
            this.textyeni_sifre.UseSystemPasswordChar = true;
            // 
            // texttekrar_sifre
            // 
            this.texttekrar_sifre.Location = new System.Drawing.Point(208, 136);
            this.texttekrar_sifre.Name = "texttekrar_sifre";
            this.texttekrar_sifre.Size = new System.Drawing.Size(195, 23);
            this.texttekrar_sifre.TabIndex = 2;
            this.texttekrar_sifre.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(34, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "KULLANICI ADI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(121, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "ŞİFRE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(82, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Şifreyi Doğrula";
            // 
            // btnhesapekle
            // 
            this.btnhesapekle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnhesapekle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnhesapekle.Location = new System.Drawing.Point(295, 196);
            this.btnhesapekle.Name = "btnhesapekle";
            this.btnhesapekle.Size = new System.Drawing.Size(108, 40);
            this.btnhesapekle.TabIndex = 6;
            this.btnhesapekle.Text = "OLUŞTUR";
            this.btnhesapekle.UseVisualStyleBackColor = false;
            this.btnhesapekle.Click += new System.EventHandler(this.btnhesapekle_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(564, 282);
            this.Controls.Add(this.btnhesapekle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.texttekrar_sifre);
            this.Controls.Add(this.textyeni_sifre);
            this.Controls.Add(this.textyeni_ad);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YENİ ÜYE";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textyeni_ad;
        private TextBox textyeni_sifre;
        private TextBox texttekrar_sifre;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnhesapekle;
    }
}