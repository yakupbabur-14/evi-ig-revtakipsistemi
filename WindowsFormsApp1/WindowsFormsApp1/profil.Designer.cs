
namespace WindowsFormsApp1
{
    partial class profil
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
            this.lblProfilBaslik = new System.Windows.Forms.Label();
            this.lblKullaniciAdi = new System.Windows.Forms.Label();
            this.lblPuan = new System.Windows.Forms.Label();
            this.btnAnaSayfayaDon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblProfilBaslik
            // 
            this.lblProfilBaslik.AutoSize = true;
            this.lblProfilBaslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblProfilBaslik.Location = new System.Drawing.Point(351, 22);
            this.lblProfilBaslik.Name = "lblProfilBaslik";
            this.lblProfilBaslik.Size = new System.Drawing.Size(78, 24);
            this.lblProfilBaslik.TabIndex = 0;
            this.lblProfilBaslik.Text = "profilim";
            // 
            // lblKullaniciAdi
            // 
            this.lblKullaniciAdi.AutoSize = true;
            this.lblKullaniciAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKullaniciAdi.Location = new System.Drawing.Point(31, 74);
            this.lblKullaniciAdi.Name = "lblKullaniciAdi";
            this.lblKullaniciAdi.Size = new System.Drawing.Size(54, 16);
            this.lblKullaniciAdi.TabIndex = 1;
            this.lblKullaniciAdi.Text = "misafir";
            // 
            // lblPuan
            // 
            this.lblPuan.AutoSize = true;
            this.lblPuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPuan.Location = new System.Drawing.Point(31, 118);
            this.lblPuan.Name = "lblPuan";
            this.lblPuan.Size = new System.Drawing.Size(16, 16);
            this.lblPuan.TabIndex = 2;
            this.lblPuan.Text = "0";
            // 
            // btnAnaSayfayaDon
            // 
            this.btnAnaSayfayaDon.Location = new System.Drawing.Point(277, 218);
            this.btnAnaSayfayaDon.Name = "btnAnaSayfayaDon";
            this.btnAnaSayfayaDon.Size = new System.Drawing.Size(126, 53);
            this.btnAnaSayfayaDon.TabIndex = 3;
            this.btnAnaSayfayaDon.Text = "ana sayfaya dön";
            this.btnAnaSayfayaDon.UseVisualStyleBackColor = true;
            // 
            // profil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAnaSayfayaDon);
            this.Controls.Add(this.lblPuan);
            this.Controls.Add(this.lblKullaniciAdi);
            this.Controls.Add(this.lblProfilBaslik);
            this.Name = "profil";
            this.Text = "profil";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProfilBaslik;
        private System.Windows.Forms.Label lblKullaniciAdi;
        private System.Windows.Forms.Label lblPuan;
        private System.Windows.Forms.Button btnAnaSayfayaDon;
    }
}