
namespace WindowsFormsApp1
{
    partial class ayarlar
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
            this.lblAyarlarBaslik = new System.Windows.Forms.Label();
            this.chkBildirimler = new System.Windows.Forms.CheckBox();
            this.chkKaranlikMod = new System.Windows.Forms.CheckBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnAnaSayfayaDon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAyarlarBaslik
            // 
            this.lblAyarlarBaslik.AutoSize = true;
            this.lblAyarlarBaslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAyarlarBaslik.Location = new System.Drawing.Point(315, 23);
            this.lblAyarlarBaslik.Name = "lblAyarlarBaslik";
            this.lblAyarlarBaslik.Size = new System.Drawing.Size(72, 24);
            this.lblAyarlarBaslik.TabIndex = 0;
            this.lblAyarlarBaslik.Text = "ayarlar";
            // 
            // chkBildirimler
            // 
            this.chkBildirimler.AutoSize = true;
            this.chkBildirimler.Location = new System.Drawing.Point(47, 65);
            this.chkBildirimler.Name = "chkBildirimler";
            this.chkBildirimler.Size = new System.Drawing.Size(85, 17);
            this.chkBildirimler.TabIndex = 1;
            this.chkBildirimler.Text = "bildirimleri aç";
            this.chkBildirimler.UseVisualStyleBackColor = true;
            // 
            // chkKaranlikMod
            // 
            this.chkKaranlikMod.AutoSize = true;
            this.chkKaranlikMod.Location = new System.Drawing.Point(47, 103);
            this.chkKaranlikMod.Name = "chkKaranlikMod";
            this.chkKaranlikMod.Size = new System.Drawing.Size(123, 17);
            this.chkKaranlikMod.TabIndex = 2;
            this.chkKaranlikMod.Text = "karanlık modu kullan";
            this.chkKaranlikMod.UseVisualStyleBackColor = true;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(47, 160);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(96, 34);
            this.btnKaydet.TabIndex = 3;
            this.btnKaydet.Text = "kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            // 
            // btnAnaSayfayaDon
            // 
            this.btnAnaSayfayaDon.Location = new System.Drawing.Point(294, 248);
            this.btnAnaSayfayaDon.Name = "btnAnaSayfayaDon";
            this.btnAnaSayfayaDon.Size = new System.Drawing.Size(105, 47);
            this.btnAnaSayfayaDon.TabIndex = 4;
            this.btnAnaSayfayaDon.Text = "ana sayfaya dön";
            this.btnAnaSayfayaDon.UseVisualStyleBackColor = true;
            // 
            // ayarlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAnaSayfayaDon);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.chkKaranlikMod);
            this.Controls.Add(this.chkBildirimler);
            this.Controls.Add(this.lblAyarlarBaslik);
            this.Name = "ayarlar";
            this.Text = "ayarlar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAyarlarBaslik;
        private System.Windows.Forms.CheckBox chkBildirimler;
        private System.Windows.Forms.CheckBox chkKaranlikMod;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnAnaSayfayaDon;
    }
}