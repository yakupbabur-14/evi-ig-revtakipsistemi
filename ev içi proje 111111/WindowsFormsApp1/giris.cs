using System;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class giris : Form
    {
        public giris() { InitializeComponent(); txtSifre.UseSystemPasswordChar = true; }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = txtKullaniciAdi.Text.Trim();
            string sifre = txtSifre.Text;
            if (string.IsNullOrWhiteSpace(kullaniciAdi) || string.IsNullOrWhiteSpace(sifre))
            {
                MessageBox.Show("Lütfen kullanıcı adı ve şifrenizi girin!", "Eksik bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection con = Veritabani.BaglantiOlustur())
                {
                    con.Open();
                    int kullaniciId; string kayitliHash; string ad; string tamAd;
                    using (SqlCommand cmd = new SqlCommand(@"SELECT KullaniciID, KullaniciAdi, AdSoyad, SifreHash
                        FROM dbo.Kullanicilar WHERE KullaniciAdi=@kullaniciAdi AND AktifMi=1", con))
                    {
                        cmd.Parameters.Add("@kullaniciAdi", System.Data.SqlDbType.NVarChar, 50).Value = kullaniciAdi;
                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (!dr.Read())
                            {
                                MessageBox.Show("Kullanıcı adı veya şifre hatalı!", "Giriş başarısız", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                            kullaniciId = dr.GetInt32(0); ad = dr.GetString(1); tamAd = dr.GetString(2); kayitliHash = dr.GetString(3);
                        }
                    }
                    string yeniHash = SifreHashle(sifre);
                    bool eskiDuzMetin = string.Equals(kayitliHash, sifre, StringComparison.Ordinal);
                    if (!eskiDuzMetin && !string.Equals(kayitliHash, yeniHash, StringComparison.OrdinalIgnoreCase))
                    {
                        MessageBox.Show("Kullanıcı adı veya şifre hatalı!", "Giriş başarısız", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (eskiDuzMetin)
                    {
                        using (SqlCommand guncelle = new SqlCommand("UPDATE dbo.Kullanicilar SET SifreHash=@hash WHERE KullaniciID=@id", con))
                        {
                            guncelle.Parameters.Add("@hash", System.Data.SqlDbType.NVarChar, 256).Value = yeniHash;
                            guncelle.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = kullaniciId;
                            guncelle.ExecuteNonQuery();
                        }
                    }
                    Oturum.Baslat(kullaniciId, ad, tamAd);
                }
                anasayfa ana = new anasayfa();
                ana.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanına bağlanılamadı veya giriş yapılamadı:\n" + ex.Message, "Bağlantı hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static string SifreHashle(string sifre)
        {
            using (SHA256 sha = SHA256.Create())
                return BitConverter.ToString(sha.ComputeHash(Encoding.UTF8.GetBytes(sifre))).Replace("-", string.Empty);
        }
    }
}
