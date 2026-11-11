Ev Ici Gorev Takip Sistemi - Duzeltilmis Kaynak

GEREKSINIMLER
- Visual Studio 2022 (veya .NET Framework 4.8.1 targeting pack destekleyen Visual Studio)
- .NET Framework 4.8.1
- SQL Server Express veya SQL Server
- SQL Server Management Studio

KURULUM
1. Database.sql dosyasini SQL Server Management Studio'da acip calistirin.
   Betik mevcut veritabanini ve tablolarini silmez; eksik Kategori alanini ekler.
2. WindowsFormsApp1/App.config icindeki Data Source degerini kendi SQL Server orneginize gore duzenleyin.
   Ornek: Data Source=.\SQLEXPRESS veya Data Source=SUNUCUADI\SQLEXPRESS.
3. WindowsFormsApp1.sln dosyasini Visual Studio ile acin.
4. Build > Rebuild Solution ile yeniden derleyin.
5. Uygulamayi calistirin.

ORNEK GIRIS
Kullanici adi: yakup
Sifre: 6565

Eski veritabanindaki duz metin parolalar basarili ilk giriste SHA-256 ozete donusturulur.
Yeni ornek kullanici SHA-256 parola ozetiyle eklenir.

YAPILAN DUZELTMELER
- Proje dosyasindaki Turkce karakterli dosya adlari gercek dosya adlariyla esitlendi.
- Oturum yonetimi eklendi; gorevler artik ilk aktif kullaniciya degil giris yapan kullaniciya baglanir.
- SQL baglanti adresi kaynak koddan cikarilip App.config icine alindi.
- Gorevlerde uygulamanin kullandigi Kategori alani veritabanina eklendi.
- Gorev silme sorgulari yanlis Id yerine GorevID kullanacak sekilde duzeltildi.
- Tamamlanmis gorevlerin puan gecmisi silinerek kaybolmasin diye silme korumasi eklendi.
- Liderlik tablosu puan hareketleri tablosundan hesaplanir.
- Profil ve odul ekranlari gercek veritabanı verilerini yukler.
- Eski duz metin parola kayitlari basarili giriste hash'e yukseltilir.

TEST NOTU
Bu calisma ortaminda Windows/.NET Framework derleyicisi ve SQL Server bulunmadigindan gercek Windows Forms derlemesi ve canli veritabani testi calistirilamadi. Proje XML'i, proje icindeki dosya referanslari ve Designer olay metodu eslesmeleri statik olarak kontrol edildi. Ilk calistirmadan once Visual Studio'da yeniden derleyip SQL baglantisini dogrulayin.
