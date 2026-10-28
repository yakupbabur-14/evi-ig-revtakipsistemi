using System;
using System.Data;
using System.Data.SqlClient; // SQL Server kütüphanesini ekledik
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class gunlukgorevler : Form
    {
        // SQL Server bağlantı cümcüğü (SSMS'deki sunucu adınla uyumlu)
        string baglantiCumlesi = @"Server=.\SQLEXPRESS;Database=EvGorevleriDB;Trusted_Connection=True;";

        public gunlukgorevler()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvGorevler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            VerileriListele(); 

        }

        void VerileriListele()
        {
            using (SqlConnection baglanti = new SqlConnection(baglantiCumlesi))
            {
                try
                {
                    baglanti.Open();
                    string sorgu = "SELECT * FROM Gorevler";
                    SqlDataAdapter da = new SqlDataAdapter(sorgu, baglanti);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvGorevler.DataSource = dt;

                    // İstersen ID sütununu gizleyebilirsin:
                    // dgvGorevler.Columns["Id"].Visible = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Listeleme hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtGorevAdi.Text))
            {
                MessageBox.Show("Görev adı boş bırakılamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // SQL Server'a kayıt ekleme işlemi
            using (SqlConnection baglanti = new SqlConnection(baglantiCumlesi))
            {
                try
                {
                    baglanti.Open();
                    string sorgu = "INSERT INTO Gorevler (GorevAdi, Kategori, SonTarih) VALUES (@gorev, @kategori, @tarih)";

                    using (SqlCommand komut = new SqlCommand(sorgu, baglanti))
                    {
                        komut.Parameters.AddWithValue("@gorev", txtGorevAdi.Text);
                        komut.Parameters.AddWithValue("@kategori", cmbKategori.SelectedItem?.ToString() ?? "Genel");
                        komut.Parameters.AddWithValue("@tarih", dtpSonTarih.Value.ToShortDateString());

                        komut.ExecuteNonQuery();
                    }

                    MessageBox.Show("Görev başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    VerileriListele(); // Tabloyu güncelle
                    txtGorevAdi.Clear();
                    txtGorevAdi.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ekleme hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dgvGorevler.SelectedRows.Count > 0)
            {
                // Seçilen satırın Id değerini alıyoruz
                int secilenId = Convert.ToInt32(dgvGorevler.SelectedRows[0].Cells["Id"].Value);

                using (SqlConnection baglanti = new SqlConnection(baglantiCumlesi))
                {
                    try
                    {
                        baglanti.Open();
                        string sorgu = "DELETE FROM Gorevler WHERE Id = @id";

                        using (SqlCommand komut = new SqlCommand(sorgu, baglanti))
                        {
                            komut.Parameters.AddWithValue("@id", secilenId);
                            komut.ExecuteNonQuery();
                        }

                        MessageBox.Show("Görev başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        VerileriListele(); // Tabloyu güncelle
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Silme hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen silmek istediğiniz satırı tablodan seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}