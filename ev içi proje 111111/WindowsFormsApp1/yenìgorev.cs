using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class yenıgorev : Form
    {
        public yenıgorev() { InitializeComponent(); dtpTarih.MinDate = DateTime.Today; }

        private void btnGorevEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtGorevAdi.Text))
            { MessageBox.Show("Lütfen görev adı girin!"); txtGorevAdi.Focus(); return; }
            if (cmbKategori.SelectedIndex < 0)
            { MessageBox.Show("Lütfen kategori seçin!"); cmbKategori.Focus(); return; }
            if (!Oturum.Acik) { MessageBox.Show("Oturum bulunamadı. Lütfen tekrar giriş yapın."); return; }

            try
            {
                using (SqlConnection baglanti = Veritabani.BaglantiOlustur())
                using (SqlCommand komut = new SqlCommand(@"INSERT INTO dbo.Gorevler
                    (GorevAdi, Kategori, OlusturanID, AtananID, BaslangicTarihi, BitisTarihi, Puan, Durum)
                    VALUES (@ad, @kategori, @kullanici, @kullanici, @baslangic, @bitis, 10, N'Bekliyor')", baglanti))
                {
                    komut.Parameters.Add("@ad", SqlDbType.NVarChar, 100).Value = txtGorevAdi.Text.Trim();
                    komut.Parameters.Add("@kategori", SqlDbType.NVarChar, 50).Value = cmbKategori.Text;
                    komut.Parameters.Add("@kullanici", SqlDbType.Int).Value = Oturum.KullaniciID;
                    komut.Parameters.Add("@baslangic", SqlDbType.Date).Value = DateTime.Today;
                    komut.Parameters.Add("@bitis", SqlDbType.Date).Value = dtpTarih.Value.Date;
                    baglanti.Open(); komut.ExecuteNonQuery();
                }
                MessageBox.Show("Görev başarıyla kaydedildi!");
                txtGorevAdi.Clear(); cmbKategori.SelectedIndex = -1; dtpTarih.Value = DateTime.Today;
            }
            catch (Exception ex) { MessageBox.Show("Görev kaydedilemedi: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void cmbKategori_SelectedIndexChanged(object sender, EventArgs e) { }
        private void btnAnaSayfayaDon_Click(object sender, EventArgs e) { new anasayfa().Show(); this.Close(); }
        private void yenıgorev_Load(object sender, EventArgs e) { }
    }
}
