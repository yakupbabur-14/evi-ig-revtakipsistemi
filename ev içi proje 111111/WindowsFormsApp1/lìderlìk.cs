using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class lıderlık : Form
    {
        public lıderlık() { InitializeComponent(); this.Load += lıderlık_Load; }
        private void lıderlık_Load(object sender, EventArgs e) {
            try {
                using (SqlConnection baglanti = Veritabani.BaglantiOlustur())
                using (SqlDataAdapter da = new SqlDataAdapter(@"SELECT KullaniciAdi AS [Kullanıcı], ToplamPuan AS [Toplam Puan] FROM dbo.vw_LiderlikTablosu ORDER BY ToplamPuan DESC, KullaniciAdi", baglanti))
                { DataTable dt = new DataTable(); da.Fill(dt); dgvLiderlik.DataSource = dt; dgvLiderlik.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; dgvLiderlik.ReadOnly = true; dgvLiderlik.AllowUserToAddRows = false; dgvLiderlik.SelectionMode = DataGridViewSelectionMode.FullRowSelect; }
            } catch (Exception ex) { MessageBox.Show("Liderlik tablosu yüklenemedi: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void btnAnaSayfayaDon_Click(object sender, EventArgs e) { new anasayfa().Show(); this.Close(); }
    }
}
