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
                Application.Exit();
            }
        }
    }
}
