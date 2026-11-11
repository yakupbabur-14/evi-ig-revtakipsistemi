using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class profil : Form
    {
        public profil() { InitializeComponent(); this.Load += profil_Load; }
        private void profil_Load(object sender, EventArgs e)
        {
            if (!Oturum.Acik) return;
            try
            {
                using (SqlConnection con = Veritabani.BaglantiOlustur())
                using (SqlCommand cmd = new SqlCommand(@"SELECT K.AdSoyad, ISNULL(SUM(P.Puan),0) FROM dbo.Kullanicilar K LEFT JOIN dbo.PuanHareketleri P ON P.KullaniciID=K.KullaniciID WHERE K.KullaniciID=@id GROUP BY K.AdSoyad", con))
                { cmd.Parameters.Add("@id", SqlDbType.Int).Value = Oturum.KullaniciID; con.Open(); using (SqlDataReader dr = cmd.ExecuteReader()) if (dr.Read()) { lblKullaniciAdi.Text = dr.GetString(0); lblPuan.Text = dr.GetInt32(1).ToString(); } }
            }
            catch (Exception ex) { MessageBox.Show("Profil bilgileri yüklenemedi: " + ex.Message); }
        }
        private void btnAnaSayfayaDon_Click(object sender, EventArgs e) { new anasayfa().Show(); this.Close(); }
    }
}
