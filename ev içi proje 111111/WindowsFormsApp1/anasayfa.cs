using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class anasayfa : Form
    {
        public anasayfa()
        {
            InitializeComponent();
        }

        private void btnGunlukGorevler_Click(object sender, EventArgs e)
        {
            gunlukgorevler form = new gunlukgorevler();
            form.Show();
            this.Hide();
        }

        private void btnCikisYap_Click(object sender, EventArgs e)
        {
            DialogResult cevap = MessageBox.Show(
                "Uygulamadan çıkış yapmak istediğinize emin misiniz?",
                "Çıkış Onayı",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (cevap == DialogResult.Yes)
            {
                Oturum.Bitir();
                Application.Exit();
            }
        }

        private void btnLiderlikTablosu_Click(object sender, EventArgs e)
        {
            lıderlık form = new lıderlık();
            form.Show();
            this.Hide();
        }

        private void btnOduller_Click(object sender, EventArgs e)
        {
            oduller form = new oduller();
            form.Show();
            this.Hide();
        }

        private void btnAyarlar_Click(object sender, EventArgs e)
        {
            ayarlar form = new ayarlar();
            form.Show();
            this.Hide();
        }

        private void btnProfilim_Click(object sender, EventArgs e)
        {
            profil form = new profil();
            form.Show();
            this.Hide();
        }

        private void btnYeniGorevEkle_Click(object sender, EventArgs e)
        {
            yenıgorev form = new yenıgorev();
            form.Show();
            this.Hide();
        }

        private void btnAnaSayfa_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void anasayfa_Load(object sender, EventArgs e)
        {

        }
    }
}
