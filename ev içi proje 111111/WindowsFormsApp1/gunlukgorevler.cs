using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class gunlukgorevler : Form
    {
        public gunlukgorevler() { InitializeComponent(); }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvGorevler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvGorevler.MultiSelect = false; dgvGorevler.ReadOnly = true;
            dgvGorevler.AllowUserToAddRows = false; dgvGorevler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            VerileriListele();
        }

        private void VerileriListele()
        {
            try
            {
                using (SqlConnection baglanti = Veritabani.BaglantiOlustur())
                using (SqlDataAdapter da = new SqlDataAdapter(@"SELECT G.GorevID, G.GorevAdi, G.Kategori, K.AdSoyad AS AtananKisi,
                    G.BaslangicTarihi, G.BitisTarihi, G.Puan, G.Durum FROM dbo.Gorevler G
                    LEFT JOIN dbo.Kullanicilar K ON K.KullaniciID=G.AtananID
                    WHERE G.AtananID=@kullanici ORDER BY CASE G.Durum WHEN N'Bekliyor' THEN 0 WHEN N'Devam Ediyor' THEN 1 ELSE 2 END, G.BitisTarihi", baglanti))
                {
                    da.SelectCommand.Parameters.Add("@kullanici", SqlDbType.Int).Value = Oturum.KullaniciID;
                    DataTable dt = new DataTable(); da.Fill(dt); dgvGorevler.DataSource = dt;
                    if (dgvGorevler.Columns.Contains("GorevID")) dgvGorevler.Columns["GorevID"].Visible = false;
                }
            }
            catch (Exception ex) { MessageBox.Show("Görevler yüklenemedi: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtGorevAdi.Text)) { MessageBox.Show("Görev adı boş bırakılamaz!"); return; }
            if (!Oturum.Acik) { MessageBox.Show("Oturum bulunamadı. Lütfen tekrar giriş yapın."); return; }
            try
            {
                using (SqlConnection baglanti = Veritabani.BaglantiOlustur())
                using (SqlCommand komut = new SqlCommand(@"INSERT INTO dbo.Gorevler (GorevAdi,Kategori,OlusturanID,AtananID,BaslangicTarihi,BitisTarihi,Puan,Durum)
                    VALUES (@ad,@kategori,@kullanici,@kullanici,@baslangic,@bitis,10,N'Bekliyor')", baglanti))
                {
                    komut.Parameters.Add("@ad", SqlDbType.NVarChar, 100).Value = txtGorevAdi.Text.Trim();
                    komut.Parameters.Add("@kategori", SqlDbType.NVarChar, 50).Value = cmbKategori.SelectedItem == null ? "Genel" : cmbKategori.SelectedItem.ToString();
                    komut.Parameters.Add("@kullanici", SqlDbType.Int).Value = Oturum.KullaniciID;
                    komut.Parameters.Add("@baslangic", SqlDbType.Date).Value = DateTime.Today;
                    komut.Parameters.Add("@bitis", SqlDbType.Date).Value = dtpSonTarih.Value.Date;
                    baglanti.Open(); komut.ExecuteNonQuery();
                }
                VerileriListele(); txtGorevAdi.Clear(); txtGorevAdi.Focus();
                MessageBox.Show("Görev başarıyla eklendi.");
            }
            catch (Exception ex) { MessageBox.Show("Ekleme hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dgvGorevler.CurrentRow == null || dgvGorevler.CurrentRow.Cells["GorevID"].Value == DBNull.Value)
            { MessageBox.Show("Lütfen silmek istediğiniz görevi seçin."); return; }
            int id = Convert.ToInt32(dgvGorevler.CurrentRow.Cells["GorevID"].Value);
            if (MessageBox.Show("Seçili görevi silmek istediğinize emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;
            try
            {
                using (SqlConnection baglanti = Veritabani.BaglantiOlustur())
                using (SqlCommand komut = new SqlCommand(@"DELETE FROM dbo.Gorevler WHERE GorevID=@id AND AtananID=@kullanici AND NOT EXISTS (SELECT 1 FROM dbo.PuanHareketleri WHERE GorevID=@id)", baglanti))
                {
                    komut.Parameters.Add("@id", SqlDbType.Int).Value = id; komut.Parameters.Add("@kullanici", SqlDbType.Int).Value = Oturum.KullaniciID;
                    baglanti.Open(); int etkilenen = komut.ExecuteNonQuery();
                    if (etkilenen == 0) { MessageBox.Show("Görev silinemedi. Tamamlanmış ve puan geçmişi bulunan görevler silinemez."); return; }
                }
                VerileriListele();
            }
            catch (Exception ex) { MessageBox.Show("Silme hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void label1_Click(object sender, EventArgs e) { }
        private void btnanasayfa_Click(object sender, EventArgs e) { new anasayfa().Show(); this.Close(); }
    }
}
