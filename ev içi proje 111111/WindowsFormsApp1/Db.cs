using System;
using System.Configuration;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public static class Veritabani
    {
        public static string BaglantiAdresi
        {
            get
            {
                ConnectionStringSettings ayar = ConfigurationManager.ConnectionStrings["EvIciGorevTakip"];
                if (ayar == null || string.IsNullOrWhiteSpace(ayar.ConnectionString))
                    throw new InvalidOperationException("App.config içindeki EvIciGorevTakip bağlantı ayarı bulunamadı.");
                return ayar.ConnectionString;
            }
        }

        public static SqlConnection BaglantiOlustur()
        {
            return new SqlConnection(BaglantiAdresi);
        }
    }
}
