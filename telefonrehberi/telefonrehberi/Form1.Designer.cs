namespace telefonrehberi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGiris = new System.Windows.Forms.Button();
            this.textKullaniciadı = new System.Windows.Forms.TextBox();
            this.textSifre = new System.Windows.Forms.TextBox();
            this.AD = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnuyeekle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGiris
            // 
            this.btnGiris.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnGiris.Font = new System.Drawing.Font("Tempus Sans ITC", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGiris.Location = new System.Drawing.Point(277, 108);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(75, 23);
            this.btnGiris.TabIndex = 0;
            this.btnGiris.Text = "GİRİŞ";
            this.btnGiris.UseVisualStyleBackColor = false;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // textKullaniciadı
            // 
            this.textKullaniciadı.Location = new System.Drawing.Point(148, 24);
            this.textKullaniciadı.Name = "textKullaniciadı";
            this.textKullaniciadı.Size = new System.Drawing.Size(204, 23);
            this.textKullaniciadı.TabIndex = 1;
            // 
            // textSifre
            // 
            this.textSifre.Location = new System.Drawing.Point(148, 58);
            this.textSifre.Name = "textSifre";
            this.textSifre.Size = new System.Drawing.Size(204, 23);
            this.textSifre.TabIndex = 2;
            this.textSifre.UseSystemPasswordChar = true;
            // 
            // AD
            // 
            this.AD.AutoSize = true;
            this.AD.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AD.Location = new System.Drawing.Point(12, 28);
            this.AD.Name = "AD";
            this.AD.Size = new System.Drawing.Size(130, 19);
            this.AD.TabIndex = 3;
            this.AD.Text = "KULLANICI ADI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(87, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "ŞİFRE";
            // 
            // btnuyeekle
            // 
            this.btnuyeekle.BackColor = System.Drawing.Color.Cyan;
            this.btnuyeekle.Font = new System.Drawing.Font("Algerian", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnuyeekle.Location = new System.Drawing.Point(347, 227);
            this.btnuyeekle.Name = "btnuyeekle";
            this.btnuyeekle.Size = new System.Drawing.Size(133, 23);
            this.btnuyeekle.TabIndex = 5;
            this.btnuyeekle.Text = "Hesap Oluştur";
            this.btnuyeekle.UseVisualStyleBackColor = false;
            this.btnuyeekle.Click += new System.EventHandler(this.btnuyeekle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(513, 262);
            this.Controls.Add(this.btnuyeekle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AD);
            this.Controls.Add(this.textSifre);
            this.Controls.Add(this.textKullaniciadı);
            this.Controls.Add(this.btnGiris);
            this.Location = new System.Drawing.Point(300, 300);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rehber Giriş Kapısı";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnGiris;
        private TextBox textKullaniciadı;
        private TextBox textSifre;
        private Label AD;
        private Label label2;
        private Button btnuyeekle;
    }
}