using System;

namespace WindowsFormsApp1
{
    public static class Oturum
    {
        public static int KullaniciID { get; private set; }
        public static string KullaniciAdi { get; private set; }
        public static string AdSoyad { get; private set; }
        public static bool Acik => KullaniciID > 0;

        public static void Baslat(int kullaniciId, string kullaniciAdi, string adSoyad)
        {
            if (kullaniciId <= 0) throw new ArgumentOutOfRangeException(nameof(kullaniciId));
            KullaniciID = kullaniciId;
            KullaniciAdi = kullaniciAdi ?? string.Empty;
            AdSoyad = adSoyad ?? string.Empty;
        }

        public static void Bitir()
        {
            KullaniciID = 0;
            KullaniciAdi = null;
            AdSoyad = null;
        }
    }
}
