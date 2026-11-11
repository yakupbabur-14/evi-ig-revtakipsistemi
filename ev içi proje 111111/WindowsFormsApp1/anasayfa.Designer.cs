
namespace WindowsFormsApp1
{
    partial class anasayfa
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCikisYap = new System.Windows.Forms.Button();
            this.btnYeniGorev = new System.Windows.Forms.Button();
            this.btnProfilim = new System.Windows.Forms.Button();
            this.btnAyarlar = new System.Windows.Forms.Button();
            this.btnOduller = new System.Windows.Forms.Button();
            this.btnLiderlikTablosu = new System.Windows.Forms.Button();
            this.btnGunlukGorevler = new System.Windows.Forms.Button();
            this.btnAnaSayfa = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnCikisYap);
            this.panel1.Controls.Add(this.btnYeniGorev);
            this.panel1.Controls.Add(this.btnProfilim);
            this.panel1.Controls.Add(this.btnAyarlar);
            this.panel1.Controls.Add(this.btnOduller);
            this.panel1.Controls.Add(this.btnLiderlikTablosu);
            this.panel1.Controls.Add(this.btnGunlukGorevler);
            this.panel1.Controls.Add(this.btnAnaSayfa);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 588);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.images;
            this.pictureBox1.Location = new System.Drawing.Point(12, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(148, 132);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // btnCikisYap
            // 
            this.btnCikisYap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnCikisYap.FlatAppearance.BorderSize = 0;
            this.btnCikisYap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCikisYap.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCikisYap.Location = new System.Drawing.Point(8, 553);
            this.btnCikisYap.Name = "btnCikisYap";
            this.btnCikisYap.Size = new System.Drawing.Size(104, 23);
            this.btnCikisYap.TabIndex = 7;
            this.btnCikisYap.Text = "çıkış yap";
            this.btnCikisYap.UseVisualStyleBackColor = false;
            this.btnCikisYap.Click += new System.EventHandler(this.btnCikisYap_Click);
            // 
            // btnYeniGorev
            // 
            this.btnYeniGorev.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnYeniGorev.FlatAppearance.BorderSize = 0;
            this.btnYeniGorev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYeniGorev.Location = new System.Drawing.Point(3, 479);
            this.btnYeniGorev.Name = "btnYeniGorev";
            this.btnYeniGorev.Size = new System.Drawing.Size(105, 23);
            this.btnYeniGorev.TabIndex = 6;
            this.btnYeniGorev.Text = "yeni görev ekle";
            this.btnYeniGorev.UseVisualStyleBackColor = false;
            this.btnYeniGorev.Click += new System.EventHandler(this.btnYeniGorevEkle_Click);
            // 
            // btnProfilim
            // 
            this.btnProfilim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnProfilim.FlatAppearance.BorderSize = 0;
            this.btnProfilim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfilim.Location = new System.Drawing.Point(3, 428);
            this.btnProfilim.Name = "btnProfilim";
            this.btnProfilim.Size = new System.Drawing.Size(105, 24);
            this.btnProfilim.TabIndex = 5;
            this.btnProfilim.Text = "profilim";
            this.btnProfilim.UseVisualStyleBackColor = false;
            this.btnProfilim.Click += new System.EventHandler(this.btnProfilim_Click);
            // 
            // btnAyarlar
            // 
            this.btnAyarlar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnAyarlar.FlatAppearance.BorderSize = 0;
            this.btnAyarlar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAyarlar.Location = new System.Drawing.Point(3, 382);
            this.btnAyarlar.Name = "btnAyarlar";
            this.btnAyarlar.Size = new System.Drawing.Size(109, 23);
            this.btnAyarlar.TabIndex = 4;
            this.btnAyarlar.Text = "ayarlar";
            this.btnAyarlar.UseVisualStyleBackColor = false;
            this.btnAyarlar.Click += new System.EventHandler(this.btnAyarlar_Click);
            // 
            // btnOduller
            // 
            this.btnOduller.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnOduller.FlatAppearance.BorderSize = 0;
            this.btnOduller.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOduller.Location = new System.Drawing.Point(3, 333);
            this.btnOduller.Name = "btnOduller";
            this.btnOduller.Size = new System.Drawing.Size(109, 23);
            this.btnOduller.TabIndex = 3;
            this.btnOduller.Text = "ödüller";
            this.btnOduller.UseVisualStyleBackColor = false;
            this.btnOduller.Click += new System.EventHandler(this.btnOduller_Click);
            // 
            // btnLiderlikTablosu
            // 
            this.btnLiderlikTablosu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnLiderlikTablosu.FlatAppearance.BorderSize = 0;
            this.btnLiderlikTablosu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLiderlikTablosu.Location = new System.Drawing.Point(3, 280);
            this.btnLiderlikTablosu.Name = "btnLiderlikTablosu";
            this.btnLiderlikTablosu.Size = new System.Drawing.Size(109, 23);
            this.btnLiderlikTablosu.TabIndex = 2;
            this.btnLiderlikTablosu.Text = "liderlik tablosu";
            this.btnLiderlikTablosu.UseVisualStyleBackColor = false;
            this.btnLiderlikTablosu.Click += new System.EventHandler(this.btnLiderlikTablosu_Click);
            // 
            // btnGunlukGorevler
            // 
            this.btnGunlukGorevler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnGunlukGorevler.FlatAppearance.BorderSize = 0;
            this.btnGunlukGorevler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGunlukGorevler.Location = new System.Drawing.Point(3, 231);
            this.btnGunlukGorevler.Name = "btnGunlukGorevler";
            this.btnGunlukGorevler.Size = new System.Drawing.Size(109, 23);
            this.btnGunlukGorevler.TabIndex = 1;
            this.btnGunlukGorevler.Text = "günlük görevler";
            this.btnGunlukGorevler.UseVisualStyleBackColor = false;
            this.btnGunlukGorevler.Click += new System.EventHandler(this.btnGunlukGorevler_Click);
            // 
            // btnAnaSayfa
            // 
            this.btnAnaSayfa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnAnaSayfa.FlatAppearance.BorderSize = 0;
            this.btnAnaSayfa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnaSayfa.Location = new System.Drawing.Point(3, 177);
            this.btnAnaSayfa.Name = "btnAnaSayfa";
            this.btnAnaSayfa.Size = new System.Drawing.Size(109, 23);
            this.btnAnaSayfa.TabIndex = 0;
            this.btnAnaSayfa.Text = "ana sayfa";
            this.btnAnaSayfa.UseVisualStyleBackColor = false;
            this.btnAnaSayfa.Click += new System.EventHandler(this.btnAnaSayfa_Click);
            // 
            // anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 612);
            this.Controls.Add(this.panel1);
            this.Name = "anasayfa";
            this.Text = "ana sayfa";
            this.Load += new System.EventHandler(this.anasayfa_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnYeniGorev;
        private System.Windows.Forms.Button btnProfilim;
        private System.Windows.Forms.Button btnAyarlar;
        private System.Windows.Forms.Button btnOduller;
        private System.Windows.Forms.Button btnLiderlikTablosu;
        private System.Windows.Forms.Button btnGunlukGorevler;
        private System.Windows.Forms.Button btnAnaSayfa;
        private System.Windows.Forms.Button btnCikisYap;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}