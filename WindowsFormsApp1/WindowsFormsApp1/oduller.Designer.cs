
namespace WindowsFormsApp1
{
    partial class oduller
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
            this.lblOdullerBaslik = new System.Windows.Forms.Label();
            this.dgvOduller = new System.Windows.Forms.DataGridView();
            this.btnAnaSayfayaDon = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOduller)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOdullerBaslik
            // 
            this.lblOdullerBaslik.AutoSize = true;
            this.lblOdullerBaslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOdullerBaslik.Location = new System.Drawing.Point(300, 23);
            this.lblOdullerBaslik.Name = "lblOdullerBaslik";
            this.lblOdullerBaslik.Size = new System.Drawing.Size(75, 24);
            this.lblOdullerBaslik.TabIndex = 0;
            this.lblOdullerBaslik.Text = "ödüller";
            // 
            // dgvOduller
            // 
            this.dgvOduller.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOduller.Location = new System.Drawing.Point(2, 127);
            this.dgvOduller.Name = "dgvOduller";
            this.dgvOduller.Size = new System.Drawing.Size(786, 150);
            this.dgvOduller.TabIndex = 1;
            // 
            // btnAnaSayfayaDon
            // 
            this.btnAnaSayfayaDon.Location = new System.Drawing.Point(304, 341);
            this.btnAnaSayfayaDon.Name = "btnAnaSayfayaDon";
            this.btnAnaSayfayaDon.Size = new System.Drawing.Size(119, 25);
            this.btnAnaSayfayaDon.TabIndex = 2;
            this.btnAnaSayfayaDon.Text = "ana sayfaya dön";
            this.btnAnaSayfayaDon.UseVisualStyleBackColor = true;
            // 
            // oduller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAnaSayfayaDon);
            this.Controls.Add(this.dgvOduller);
            this.Controls.Add(this.lblOdullerBaslik);
            this.Name = "oduller";
            this.Text = "ödüller";
            ((System.ComponentModel.ISupportInitialize)(this.dgvOduller)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOdullerBaslik;
        private System.Windows.Forms.DataGridView dgvOduller;
        private System.Windows.Forms.Button btnAnaSayfayaDon;
    }
}