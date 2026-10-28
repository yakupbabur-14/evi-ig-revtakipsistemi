
namespace WindowsFormsApp1
{
    partial class lıderlık
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
            this.dgvLiderlik = new System.Windows.Forms.DataGridView();
            this.lblBaslik = new System.Windows.Forms.Label();
            this.btnAnaSayfayaDon = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLiderlik)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLiderlik
            // 
            this.dgvLiderlik.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLiderlik.Location = new System.Drawing.Point(12, 84);
            this.dgvLiderlik.Name = "dgvLiderlik";
            this.dgvLiderlik.Size = new System.Drawing.Size(776, 150);
            this.dgvLiderlik.TabIndex = 0;
            // 
            // lblBaslik
            // 
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslik.Location = new System.Drawing.Point(263, 19);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(144, 24);
            this.lblBaslik.TabIndex = 1;
            this.lblBaslik.Text = "liderlik tablosu";
            // 
            // btnAnaSayfayaDon
            // 
            this.btnAnaSayfayaDon.Location = new System.Drawing.Point(267, 285);
            this.btnAnaSayfayaDon.Name = "btnAnaSayfayaDon";
            this.btnAnaSayfayaDon.Size = new System.Drawing.Size(169, 40);
            this.btnAnaSayfayaDon.TabIndex = 2;
            this.btnAnaSayfayaDon.Text = "ana sayfaya dön";
            this.btnAnaSayfayaDon.UseVisualStyleBackColor = true;
            this.btnAnaSayfayaDon.Click += new System.EventHandler(this.btnAnaSayfayaDon_Click);
            // 
            // lıderlık
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAnaSayfayaDon);
            this.Controls.Add(this.lblBaslik);
            this.Controls.Add(this.dgvLiderlik);
            this.Name = "lıderlık";
            this.Text = "liderlik tablosu";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLiderlik)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLiderlik;
        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.Button btnAnaSayfayaDon;
    }
}