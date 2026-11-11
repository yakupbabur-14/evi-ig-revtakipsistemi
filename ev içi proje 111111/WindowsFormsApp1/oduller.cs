using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class oduller : Form
    {
        public oduller() { InitializeComponent(); this.Load += oduller_Load; }
        private void oduller_Load(object sender, EventArgs e)
        {
            dgvOduller.ReadOnly = true; dgvOduller.AllowUserToAddRows = false; dgvOduller.SelectionMode = DataGridViewSelectionMode.FullRowSelect; dgvOduller.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            try
            {
                using (SqlConnection con = Veritabani.BaglantiOlustur())
                using (SqlDataAdapter da = new SqlDataAdapter(@"SELECT O.OdulAdi AS [Ödül], O.Aciklama AS [Açıklama], O.GerekliPuan AS [Gerekli Puan], CASE WHEN EXISTS (SELECT 1 FROM dbo.KazanilanOduller KO WHERE KO.OdulID=O.OdulID AND KO.KullaniciID=@id) THEN N'Kazanıldı' ELSE N'Kazanılmadı' END AS [Durum] FROM dbo.Oduller O WHERE O.AktifMi=1 ORDER BY O.GerekliPuan", con))
                { da.SelectCommand.Parameters.Add("@id", SqlDbType.Int).Value = Oturum.KullaniciID; DataTable dt = new DataTable(); da.Fill(dt); dgvOduller.DataSource = dt; }
            } catch (Exception ex) { MessageBox.Show("Ödüller yüklenemedi: " + ex.Message); }
        }
        private void btnAnaSayfayaDon_Click(object sender, EventArgs e) { new anasayfa().Show(); this.Close(); }
    }
}
