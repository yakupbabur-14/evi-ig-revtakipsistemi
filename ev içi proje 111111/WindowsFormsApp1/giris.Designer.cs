
namespace WindowsFormsApp1
{
    partial class giris
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
            this.pnlGiris = new System.Windows.Forms.Panel();
            this.lblAltBilgi = new System.Windows.Forms.Label();
            this.btnGiris = new System.Windows.Forms.Button();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.lblSifre = new System.Windows.Forms.Label();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.lblKullanici = new System.Windows.Forms.Label();
            this.lblAltBaslik = new System.Windows.Forms.Label();
            this.lblBaslik = new System.Windows.Forms.Label();
            this.picArkaPlan = new System.Windows.Forms.PictureBox();
            this.pnlGiris.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picArkaPlan)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlGiris
            // 
            this.pnlGiris.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(220)))));
            this.pnlGiris.Controls.Add(this.lblAltBilgi);
            this.pnlGiris.Controls.Add(this.btnGiris);
            this.pnlGiris.Controls.Add(this.txtSifre);
            this.pnlGiris.Controls.Add(this.lblSifre);
            this.pnlGiris.Controls.Add(this.txtKullaniciAdi);
            this.pnlGiris.Controls.Add(this.lblKullanici);
            this.pnlGiris.Controls.Add(this.lblAltBaslik);
            this.pnlGiris.Controls.Add(this.lblBaslik);
            this.pnlGiris.Location = new System.Drawing.Point(420, 0);
            this.pnlGiris.Name = "pnlGiris";
            this.pnlGiris.Size = new System.Drawing.Size(580, 600);
            this.pnlGiris.TabIndex = 1;
            // 
            // lblAltBilgi
            // 
            this.lblAltBilgi.AutoSize = true;
            this.lblAltBilgi.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAltBilgi.Location = new System.Drawing.Point(222, 478);
            this.lblAltBilgi.Name = "lblAltBilgi";
            this.lblAltBilgi.Size = new System.Drawing.Size(146, 13);
            this.lblAltBilgi.TabIndex = 7;
            this.lblAltBilgi.Text = "Birlikte daha düzenli bir ev!";
            // 
            // btnGiris
            // 
            this.btnGiris.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(121)))), ((int)(((byte)(67)))));
            this.btnGiris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGiris.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGiris.ForeColor = System.Drawing.Color.White;
            this.btnGiris.Location = new System.Drawing.Point(90, 425);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(400, 50);
            this.btnGiris.TabIndex = 6;
            this.btnGiris.Text = "GİRİŞ YAP";
            this.btnGiris.UseVisualStyleBackColor = false;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // txtSifre
            // 
            this.txtSifre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSifre.Location = new System.Drawing.Point(90, 355);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(100, 29);
            this.txtSifre.TabIndex = 5;
            this.txtSifre.UseSystemPasswordChar = true;
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSifre.Location = new System.Drawing.Point(90, 325);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(41, 20);
            this.lblSifre.TabIndex = 4;
            this.lblSifre.Text = "Şifre";
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKullaniciAdi.Location = new System.Drawing.Point(93, 250);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(400, 29);
            this.txtKullaniciAdi.TabIndex = 3;
            // 
            // lblKullanici
            // 
            this.lblKullanici.AutoSize = true;
            this.lblKullanici.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKullanici.Location = new System.Drawing.Point(90, 225);
            this.lblKullanici.Name = "lblKullanici";
            this.lblKullanici.Size = new System.Drawing.Size(96, 20);
            this.lblKullanici.TabIndex = 2;
            this.lblKullanici.Text = "\tKullanıcı Adı";
            // 
            // lblAltBaslik
            // 
            this.lblAltBaslik.AutoSize = true;
            this.lblAltBaslik.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAltBaslik.Location = new System.Drawing.Point(90, 150);
            this.lblAltBaslik.Name = "lblAltBaslik";
            this.lblAltBaslik.Size = new System.Drawing.Size(203, 17);
            this.lblAltBaslik.TabIndex = 1;
            this.lblAltBaslik.Text = " Ev İçi Görev Takip Sistemine Giriş";
            // 
            // lblBaslik
            // 
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.Font = new System.Drawing.Font("Segoe UI", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslik.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(69)))), ((int)(((byte)(44)))));
            this.lblBaslik.Location = new System.Drawing.Point(90, 95);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(224, 45);
            this.lblBaslik.TabIndex = 0;
            this.lblBaslik.Text = "Hoş Geldiniz!";
            // 
            // picArkaPlan
            // 
            this.picArkaPlan.Location = new System.Drawing.Point(0, 0);
            this.picArkaPlan.Name = "picArkaPlan";
            this.picArkaPlan.Size = new System.Drawing.Size(420, 600);
            this.picArkaPlan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picArkaPlan.TabIndex = 0;
            this.picArkaPlan.TabStop = false;
            // 
            // giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(245)))), ((int)(((byte)(232)))));
            this.ClientSize = new System.Drawing.Size(984, 645);
            this.Controls.Add(this.pnlGiris);
            this.Controls.Add(this.picArkaPlan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "giris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "giriş";
            this.pnlGiris.ResumeLayout(false);
            this.pnlGiris.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picArkaPlan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picArkaPlan;
        private System.Windows.Forms.Panel pnlGiris;
        private System.Windows.Forms.Label lblAltBilgi;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.Label lblKullanici;
        private System.Windows.Forms.Label lblAltBaslik;
        private System.Windows.Forms.Label lblBaslik;
    }
}