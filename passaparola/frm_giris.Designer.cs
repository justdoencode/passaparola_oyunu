namespace passaparola
{
    partial class frm_giris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_giris));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_kullaniciadi = new System.Windows.Forms.TextBox();
            this.txt_sifre = new System.Windows.Forms.TextBox();
            this.btn_giris = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_bilgi = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_cevap = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_yenikullaniciadi = new System.Windows.Forms.TextBox();
            this.btn_kaydol = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_yenisifre = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_kapat = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(7, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(62, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txt_kullaniciadi
            // 
            this.txt_kullaniciadi.Location = new System.Drawing.Point(120, 57);
            this.txt_kullaniciadi.Name = "txt_kullaniciadi";
            this.txt_kullaniciadi.Size = new System.Drawing.Size(100, 20);
            this.txt_kullaniciadi.TabIndex = 2;
            this.txt_kullaniciadi.TextChanged += new System.EventHandler(this.txt_kullaniciadi_TextChanged);
            // 
            // txt_sifre
            // 
            this.txt_sifre.Location = new System.Drawing.Point(120, 83);
            this.txt_sifre.Name = "txt_sifre";
            this.txt_sifre.Size = new System.Drawing.Size(100, 20);
            this.txt_sifre.TabIndex = 3;
            this.txt_sifre.UseSystemPasswordChar = true;
            this.txt_sifre.TextChanged += new System.EventHandler(this.txt_sifre_TextChanged);
            // 
            // btn_giris
            // 
            this.btn_giris.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_giris.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_giris.Location = new System.Drawing.Point(120, 119);
            this.btn_giris.Name = "btn_giris";
            this.btn_giris.Size = new System.Drawing.Size(75, 23);
            this.btn_giris.TabIndex = 4;
            this.btn_giris.Text = "GİRİŞ";
            this.btn_giris.UseVisualStyleBackColor = false;
            this.btn_giris.Click += new System.EventHandler(this.btn_giris_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(52)))), ((int)(((byte)(113)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.lbl_bilgi);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txt_kullaniciadi);
            this.panel1.Controls.Add(this.btn_giris);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txt_sifre);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(76, 88);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(235, 190);
            this.panel1.TabIndex = 5;
            // 
            // lbl_bilgi
            // 
            this.lbl_bilgi.AutoSize = true;
            this.lbl_bilgi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_bilgi.Location = new System.Drawing.Point(19, 156);
            this.lbl_bilgi.Name = "lbl_bilgi";
            this.lbl_bilgi.Size = new System.Drawing.Size(0, 13);
            this.lbl_bilgi.TabIndex = 7;
            this.lbl_bilgi.Click += new System.EventHandler(this.lbl_bilgi_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(7, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "KULLANICI GİRİŞİ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(52)))), ((int)(((byte)(113)))));
            this.panel2.Controls.Add(this.lbl_cevap);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txt_yenikullaniciadi);
            this.panel2.Controls.Add(this.btn_kaydol);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txt_yenisifre);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(344, 88);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(256, 190);
            this.panel2.TabIndex = 6;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // lbl_cevap
            // 
            this.lbl_cevap.AutoSize = true;
            this.lbl_cevap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_cevap.Location = new System.Drawing.Point(64, 156);
            this.lbl_cevap.Name = "lbl_cevap";
            this.lbl_cevap.Size = new System.Drawing.Size(0, 17);
            this.lbl_cevap.TabIndex = 7;
            this.lbl_cevap.Click += new System.EventHandler(this.lbl_cevap_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(9, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "YENİ KULLANICI";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txt_yenikullaniciadi
            // 
            this.txt_yenikullaniciadi.Location = new System.Drawing.Point(122, 45);
            this.txt_yenikullaniciadi.Name = "txt_yenikullaniciadi";
            this.txt_yenikullaniciadi.Size = new System.Drawing.Size(100, 20);
            this.txt_yenikullaniciadi.TabIndex = 2;
            this.txt_yenikullaniciadi.TextChanged += new System.EventHandler(this.txt_yenikullaniciadi_TextChanged);
            // 
            // btn_kaydol
            // 
            this.btn_kaydol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(47)))), ((int)(((byte)(6)))));
            this.btn_kaydol.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_kaydol.Location = new System.Drawing.Point(122, 107);
            this.btn_kaydol.Name = "btn_kaydol";
            this.btn_kaydol.Size = new System.Drawing.Size(75, 23);
            this.btn_kaydol.TabIndex = 4;
            this.btn_kaydol.Text = "KAYDOL";
            this.btn_kaydol.UseVisualStyleBackColor = false;
            this.btn_kaydol.Click += new System.EventHandler(this.btn_kaydol_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(64, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Şifre :";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txt_yenisifre
            // 
            this.txt_yenisifre.Location = new System.Drawing.Point(122, 71);
            this.txt_yenisifre.Name = "txt_yenisifre";
            this.txt_yenisifre.Size = new System.Drawing.Size(100, 20);
            this.txt_yenisifre.TabIndex = 3;
            this.txt_yenisifre.UseSystemPasswordChar = true;
            this.txt_yenisifre.TextChanged += new System.EventHandler(this.txt_yenisifre_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(9, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Kullanıcı Adı :";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(90)))), ((int)(((byte)(36)))));
            this.label7.Font = new System.Drawing.Font("Microsoft Uighur", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(207, 45);
            this.label7.TabIndex = 7;
            this.label7.Text = "PASSAPAROLA";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // btn_kapat
            // 
            this.btn_kapat.BackColor = System.Drawing.Color.Red;
            this.btn_kapat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_kapat.Location = new System.Drawing.Point(525, 23);
            this.btn_kapat.Name = "btn_kapat";
            this.btn_kapat.Size = new System.Drawing.Size(75, 23);
            this.btn_kapat.TabIndex = 8;
            this.btn_kapat.Text = "KAPAT";
            this.btn_kapat.UseVisualStyleBackColor = false;
            this.btn_kapat.Click += new System.EventHandler(this.btn_kapat_Click);
            // 
            // frm_giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(52)))), ((int)(((byte)(113)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(633, 402);
            this.Controls.Add(this.btn_kapat);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_giris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_kullaniciadi;
        private System.Windows.Forms.TextBox txt_sifre;
        private System.Windows.Forms.Button btn_giris;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_yenikullaniciadi;
        private System.Windows.Forms.Button btn_kaydol;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_yenisifre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_kapat;
        private System.Windows.Forms.Label lbl_cevap;
        private System.Windows.Forms.Label lbl_bilgi;
    }
}