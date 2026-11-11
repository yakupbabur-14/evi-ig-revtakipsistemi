/* Ev Ici Gorev Takip - SQL Server veritabani kurulumu / guncellemesi
   Guvenli tekrar calistirma: mevcut tablolar ve veriler korunur. */
IF DB_ID(N'EvIciGorevTakip') IS NULL
    CREATE DATABASE EvIciGorevTakip;
GO
USE EvIciGorevTakip;
GO

IF OBJECT_ID(N'dbo.Kullanicilar', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.Kullanicilar (
        KullaniciID INT IDENTITY(1,1) NOT NULL CONSTRAINT PK_Kullanicilar PRIMARY KEY,
        KullaniciAdi NVARCHAR(50) NOT NULL CONSTRAINT UQ_Kullanicilar_KullaniciAdi UNIQUE,
        AdSoyad NVARCHAR(100) NOT NULL,
        SifreHash NVARCHAR(256) NOT NULL,
        Email NVARCHAR(100) NULL,
        ProfilResmi NVARCHAR(255) NULL,
        KayitTarihi DATETIME NOT NULL CONSTRAINT DF_Kullanicilar_KayitTarihi DEFAULT GETDATE(),
        AktifMi BIT NOT NULL CONSTRAINT DF_Kullanicilar_AktifMi DEFAULT 1
    );
END;
GO

IF OBJECT_ID(N'dbo.Gorevler', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.Gorevler (
        GorevID INT IDENTITY(1,1) NOT NULL CONSTRAINT PK_Gorevler PRIMARY KEY,
        GorevAdi NVARCHAR(100) NOT NULL,
        Kategori NVARCHAR(50) NOT NULL CONSTRAINT DF_Gorevler_Kategori DEFAULT N'Genel',
        Aciklama NVARCHAR(500) NULL,
        OlusturanID INT NOT NULL,
        AtananID INT NULL,
        BaslangicTarihi DATE NOT NULL CONSTRAINT DF_Gorevler_Baslangic DEFAULT CONVERT(date, GETDATE()),
        BitisTarihi DATE NULL,
        Puan INT NOT NULL CONSTRAINT DF_Gorevler_Puan DEFAULT 10,
        Durum NVARCHAR(20) NOT NULL CONSTRAINT DF_Gorevler_Durum DEFAULT N'Bekliyor',
        CONSTRAINT FK_Gorevler_Olusturan FOREIGN KEY (OlusturanID) REFERENCES dbo.Kullanicilar(KullaniciID),
        CONSTRAINT FK_Gorevler_Atanan FOREIGN KEY (AtananID) REFERENCES dbo.Kullanicilar(KullaniciID),
        CONSTRAINT CK_Gorevler_Puan CHECK (Puan >= 0),
        CONSTRAINT CK_Gorevler_Durum CHECK (Durum IN (N'Bekliyor', N'Devam Ediyor', N'Tamamlandi'))
    );
END
ELSE IF COL_LENGTH(N'dbo.Gorevler', N'Kategori') IS NULL
    ALTER TABLE dbo.Gorevler ADD Kategori NVARCHAR(50) NOT NULL CONSTRAINT DF_Gorevler_Kategori_Migration DEFAULT N'Genel' WITH VALUES;
GO

IF OBJECT_ID(N'dbo.PuanHareketleri', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.PuanHareketleri (
        HareketID INT IDENTITY(1,1) NOT NULL CONSTRAINT PK_PuanHareketleri PRIMARY KEY,
        KullaniciID INT NOT NULL,
        GorevID INT NULL,
        Puan INT NOT NULL,
        Aciklama NVARCHAR(250) NULL,
        Tarih DATETIME NOT NULL CONSTRAINT DF_PuanHareketleri_Tarih DEFAULT GETDATE(),
        CONSTRAINT FK_PuanHareketleri_Kullanici FOREIGN KEY (KullaniciID) REFERENCES dbo.Kullanicilar(KullaniciID),
        CONSTRAINT FK_PuanHareketleri_Gorev FOREIGN KEY (GorevID) REFERENCES dbo.Gorevler(GorevID)
    );
END;
GO

IF OBJECT_ID(N'dbo.Oduller', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.Oduller (
        OdulID INT IDENTITY(1,1) NOT NULL CONSTRAINT PK_Oduller PRIMARY KEY,
        OdulAdi NVARCHAR(100) NOT NULL,
        Aciklama NVARCHAR(300) NULL,
        GerekliPuan INT NOT NULL,
        Resim NVARCHAR(255) NULL,
        AktifMi BIT NOT NULL CONSTRAINT DF_Oduller_AktifMi DEFAULT 1,
        CONSTRAINT CK_Oduller_GerekliPuan CHECK (GerekliPuan > 0)
    );
END;
GO

IF OBJECT_ID(N'dbo.KazanilanOduller', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.KazanilanOduller (
        KazanilanID INT IDENTITY(1,1) NOT NULL CONSTRAINT PK_KazanilanOduller PRIMARY KEY,
        KullaniciID INT NOT NULL,
        OdulID INT NOT NULL,
        KazanmaTarihi DATETIME NOT NULL CONSTRAINT DF_KazanilanOduller_Tarih DEFAULT GETDATE(),
        CONSTRAINT FK_KazanilanOduller_Kullanici FOREIGN KEY (KullaniciID) REFERENCES dbo.Kullanicilar(KullaniciID),
        CONSTRAINT FK_KazanilanOduller_Odul FOREIGN KEY (OdulID) REFERENCES dbo.Oduller(OdulID),
        CONSTRAINT UQ_KazanilanOdul UNIQUE (KullaniciID, OdulID)
    );
END;
GO

IF NOT EXISTS (SELECT 1 FROM dbo.Oduller WHERE OdulAdi=N'Film Seçme Hakkı')
    INSERT dbo.Oduller (OdulAdi, Aciklama, GerekliPuan) VALUES (N'Film Seçme Hakkı', N'Ailecek izlenecek filmi sen seç.', 50);
IF NOT EXISTS (SELECT 1 FROM dbo.Oduller WHERE OdulAdi=N'Tatlı Ödülü')
    INSERT dbo.Oduller (OdulAdi, Aciklama, GerekliPuan) VALUES (N'Tatlı Ödülü', N'İstediğin tatlıyı seç.', 100);
IF NOT EXISTS (SELECT 1 FROM dbo.Oduller WHERE OdulAdi=N'Oyun Saati')
    INSERT dbo.Oduller (OdulAdi, Aciklama, GerekliPuan) VALUES (N'Oyun Saati', N'Ekstra oyun zamanı kazan.', 150);
IF NOT EXISTS (SELECT 1 FROM dbo.Oduller WHERE OdulAdi=N'Özel Gün')
    INSERT dbo.Oduller (OdulAdi, Aciklama, GerekliPuan) VALUES (N'Özel Gün', N'İstediğin etkinliği seç.', 250);
GO

/* Eski veritabanındaki düz metin parola kullanan hesaplar, başarılı ilk girişte
   uygulama tarafından SHA-256 özete yükseltilir. Yeni örnek hesap hash ile eklenir. */
IF NOT EXISTS (SELECT 1 FROM dbo.Kullanicilar WHERE KullaniciAdi=N'yakup')
    INSERT dbo.Kullanicilar (KullaniciAdi, AdSoyad, SifreHash, Email, AktifMi)
    VALUES (N'yakup', N'Yakup', N'0AE3305415102D365F21B19B0BA90EEBFEBD1C4F38B79AE87DCE1655A31650A4', N'yakup@mail.com', 1);
GO

CREATE OR ALTER VIEW dbo.vw_LiderlikTablosu
AS
SELECT K.KullaniciID, K.KullaniciAdi, K.AdSoyad,
       ISNULL(SUM(P.Puan), 0) AS ToplamPuan
FROM dbo.Kullanicilar K
LEFT JOIN dbo.PuanHareketleri P ON P.KullaniciID=K.KullaniciID
GROUP BY K.KullaniciID, K.KullaniciAdi, K.AdSoyad;
GO

CREATE OR ALTER VIEW dbo.vw_GunlukGorevler
AS
SELECT G.GorevID, G.GorevAdi, G.Kategori, G.Aciklama,
       K.KullaniciAdi AS AtananKisi, G.BitisTarihi, G.Puan, G.Durum
FROM dbo.Gorevler G
LEFT JOIN dbo.Kullanicilar K ON K.KullaniciID=G.AtananID
WHERE G.BitisTarihi=CONVERT(date, GETDATE());
GO

CREATE OR ALTER VIEW dbo.vw_KullaniciPuanlari
AS
SELECT K.KullaniciID, K.KullaniciAdi,
       ISNULL(SUM(P.Puan), 0) AS ToplamPuan
FROM dbo.Kullanicilar K
LEFT JOIN dbo.PuanHareketleri P ON P.KullaniciID=K.KullaniciID
GROUP BY K.KullaniciID, K.KullaniciAdi;
GO

CREATE OR ALTER PROCEDURE dbo.GorevTamamla @GorevID INT
AS
BEGIN
    SET NOCOUNT ON;
    SET XACT_ABORT ON;
    BEGIN TRY
        BEGIN TRANSACTION;
        DECLARE @KullaniciID INT, @Puan INT;
        SELECT @KullaniciID=AtananID, @Puan=Puan
        FROM dbo.Gorevler WITH (UPDLOCK, HOLDLOCK)
        WHERE GorevID=@GorevID AND Durum<>N'Tamamlandi';
        IF @KullaniciID IS NULL
            THROW 50001, N'Görev bulunamadı, atanmamış veya zaten tamamlandı.', 1;
        UPDATE dbo.Gorevler SET Durum=N'Tamamlandi' WHERE GorevID=@GorevID;
        INSERT dbo.PuanHareketleri (KullaniciID, GorevID, Puan, Aciklama)
        VALUES (@KullaniciID, @GorevID, @Puan, N'Görev tamamlandı');
        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0 ROLLBACK TRANSACTION;
        THROW;
    END CATCH
END;
GO

/* Örnek hesap: yakup / 6565 */
SELECT KullaniciID, KullaniciAdi, AdSoyad, AktifMi FROM dbo.Kullanicilar;
SELECT N'Ev İçi Görev Takip veritabanı hazır.' AS Sonuc;
GO
