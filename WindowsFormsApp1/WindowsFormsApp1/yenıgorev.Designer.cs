
namespace WindowsFormsApp1
{
    partial class yenıgorev
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
            this.lblYeniGorevBaslik = new System.Windows.Forms.Label();
            this.lblGorevAdi = new System.Windows.Forms.Label();
            this.lblKategori = new System.Windows.Forms.Label();
            this.lblTarih = new System.Windows.Forms.Label();
            this.txtGorevAdi = new System.Windows.Forms.TextBox();
            this.cmbKategori = new System.Windows.Forms.ComboBox();
            this.dtpTarih = new System.Windows.Forms.DateTimePicker();
            this.btnGorevEkle = new System.Windows.Forms.Button();
            this.btnAnaSayfayaDon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblYeniGorevBaslik
            // 
            this.lblYeniGorevBaslik.AutoSize = true;
            this.lblYeniGorevBaslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYeniGorevBaslik.Location = new System.Drawing.Point(357, 24);
            this.lblYeniGorevBaslik.Name = "lblYeniGorevBaslik";
            this.lblYeniGorevBaslik.Size = new System.Drawing.Size(153, 24);
            this.lblYeniGorevBaslik.TabIndex = 0;
            this.lblYeniGorevBaslik.Text = "yeni görev ekle";
            // 
            // lblGorevAdi
            // 
            this.lblGorevAdi.AutoSize = true;
            this.lblGorevAdi.Location = new System.Drawing.Point(51, 70);
            this.lblGorevAdi.Name = "lblGorevAdi";
            this.lblGorevAdi.Size = new System.Drawing.Size(57, 13);
            this.lblGorevAdi.TabIndex = 1;
            this.lblGorevAdi.Text = "Görev Adı:";
            // 
            // lblKategori
            // 
            this.lblKategori.AutoSize = true;
            this.lblKategori.Location = new System.Drawing.Point(51, 118);
            this.lblKategori.Name = "lblKategori";
            this.lblKategori.Size = new System.Drawing.Size(49, 13);
            this.lblKategori.TabIndex = 2;
            this.lblKategori.Text = "Kategori:";
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.Location = new System.Drawing.Point(51, 164);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(56, 13);
            this.lblTarih.TabIndex = 3;
            this.lblTarih.Text = "Son Tarih:";
            this.lblTarih.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtGorevAdi
            // 
            this.txtGorevAdi.Location = new System.Drawing.Point(114, 67);
            this.txtGorevAdi.Name = "txtGorevAdi";
            this.txtGorevAdi.Size = new System.Drawing.Size(100, 20);
            this.txtGorevAdi.TabIndex = 4;
            // 
            // cmbKategori
            // 
            this.cmbKategori.FormattingEnabled = true;
            this.cmbKategori.Location = new System.Drawing.Point(114, 115);
            this.cmbKategori.Name = "cmbKategori";
            this.cmbKategori.Size = new System.Drawing.Size(121, 21);
            this.cmbKategori.TabIndex = 5;
            // 
            // dtpTarih
            // 
            this.dtpTarih.Location = new System.Drawing.Point(114, 158);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(200, 20);
            this.dtpTarih.TabIndex = 6;
            // 
            // btnGorevEkle
            // 
            this.btnGorevEkle.Location = new System.Drawing.Point(139, 229);
            this.btnGorevEkle.Name = "btnGorevEkle";
            this.btnGorevEkle.Size = new System.Drawing.Size(75, 23);
            this.btnGorevEkle.TabIndex = 7;
            this.btnGorevEkle.Text = "kaydet";
            this.btnGorevEkle.UseVisualStyleBackColor = true;
            // 
            // btnAnaSayfayaDon
            // 
            this.btnAnaSayfayaDon.Location = new System.Drawing.Point(361, 310);
            this.btnAnaSayfayaDon.Name = "btnAnaSayfayaDon";
            this.btnAnaSayfayaDon.Size = new System.Drawing.Size(117, 23);
            this.btnAnaSayfayaDon.TabIndex = 8;
            this.btnAnaSayfayaDon.Text = "ana sayfaya dön";
            this.btnAnaSayfayaDon.UseVisualStyleBackColor = true;
            // 
            // yenıgorev
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAnaSayfayaDon);
            this.Controls.Add(this.btnGorevEkle);
            this.Controls.Add(this.dtpTarih);
            this.Controls.Add(this.cmbKategori);
            this.Controls.Add(this.txtGorevAdi);
            this.Controls.Add(this.lblTarih);
            this.Controls.Add(this.lblKategori);
            this.Controls.Add(this.lblGorevAdi);
            this.Controls.Add(this.lblYeniGorevBaslik);
            this.Name = "yenıgorev";
            this.Text = "görev ekle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblYeniGorevBaslik;
        private System.Windows.Forms.Label lblGorevAdi;
        private System.Windows.Forms.Label lblKategori;
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.TextBox txtGorevAdi;
        private System.Windows.Forms.ComboBox cmbKategori;
        private System.Windows.Forms.DateTimePicker dtpTarih;
        private System.Windows.Forms.Button btnGorevEkle;
        private System.Windows.Forms.Button btnAnaSayfayaDon;
    }
}