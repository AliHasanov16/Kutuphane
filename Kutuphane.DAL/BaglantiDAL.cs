using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Kutuphane.EL.Baglanti;


namespace Kutuphane.DAL
{
	public class BaglantiDAL
	{

		public BaglantiDAL() { }

		public bool BaglantiTest(BaglantiEL b)
		{
			try
			{
				using (SqlConnection baglanti = BaglantiYonetici.BaglantiGetir(b))
				{
					return true;
				}
			}
			catch
			{
				return false;
			}
		}
		public int BAGLAN(BaglantiEL b)/*string dsource, string icatalot, string sadi, string sifre,*/
		{

			var sonuc = 0;
			string sorgu = @"Truncate table baglanti
							 Insert Into Baglanti(DataSource,InitialCatalog,SunucuAdi,Sifre) 
								VALUES(@dsource,@icatalot,@sadi,@sifre)";

			using (SqlCommand komut = new SqlCommand(sorgu, BaglantiYonetici.BaglantiGetir(b)))
			{
				komut.Parameters.Add("@dsource", SqlDbType.VarChar).Value = b.DataSource;
				komut.Parameters.Add("@icatalot", SqlDbType.VarChar).Value = b.InitialCatalog;
				komut.Parameters.Add("@sadi", SqlDbType.VarChar).Value = b.SunucuAdi;
				komut.Parameters.Add("@sifre", SqlDbType.VarChar).Value = b.Sifre;

				sonuc = komut.ExecuteNonQuery();
			}
			return sonuc;
		}

		//OTOMATİK VERİ TABANI VE TABLOLARI OLUŞTURMA .
		public int OtoKullaniciEkle()   
		{
			try
			{
				int sonuc = 0;
				string sorgu = @"IF DB_ID('KutuphaneDB') IS NULL CREATE DATABASE KutuphaneDB";
				//Bir DATABASE olmadığı icin onceden sistem database olan MASTER DB'sıne bagğalnıp KutuphneDb oluşturulur .
				//Ondan Sonra TumTablola Create edilir . Olmayan dbye create table olmaz .
				SqlConnection baglanti = new SqlConnection(@"Data Source=YOUR_SERVER;Initial Catalog=master;Integrated Security=True;Trust Server Certificate=True");
				baglanti.Open();
				using (SqlCommand komut = new SqlCommand(sorgu, baglanti)){
					komut.ExecuteNonQuery();
				}

				string sorgu2 = @"DECLARE @Sonuc INT = 0;
                                IF NOT EXISTS (SELECT * FROM sys.objects WHERE name = 'KullaniciTip' AND type = 'U')
                                BEGIN
                                    SET NOCOUNT ON;
                                    CREATE TABLE KullaniciTip (
                                        TipID INT IDENTITY(1,1) PRIMARY KEY,
                                        Tipi NVARCHAR(50) NOT NULL,
                                        YetkiDurumu BIT NOT NULL DEFAULT 1
                                    );
                                    SET @Sonuc = 1;
                                END
                                IF NOT EXISTS (SELECT * FROM sys.objects WHERE name = 'Kitaplar' AND type = 'U')
                                BEGIN
                                    SET NOCOUNT ON;
                                    CREATE TABLE Kitaplar (
                                        KitapID INT IDENTITY(1,1) PRIMARY KEY,
                                        KitapAdi NVARCHAR(150) NOT NULL,
                                        Tur NVARCHAR(100),
                                        Yazar NVARCHAR(100),
                                        BasimYili DATETIME,
                                        Stok INT DEFAULT 0
                                    );
                                    SET @Sonuc = 1;
                                END
                                IF NOT EXISTS (SELECT * FROM sys.objects WHERE name = 'Uyeler' AND type = 'U')
                                BEGIN
                                    SET NOCOUNT ON;
                                    CREATE TABLE Uyeler (
                                        UyeID INT IDENTITY(1,1) PRIMARY KEY,
                                        UyeAdi NVARCHAR(100) NOT NULL,
                                        UyeSoyadi NVARCHAR(100) NOT NULL,
                                        UyeTipi NVARCHAR(50),
                                        KullaniciID INT NULL
                                    );
                                    SET @Sonuc = 1;
                                END
                                IF NOT EXISTS (SELECT * FROM sys.objects WHERE name = 'Kullanicilar' AND type = 'U')
                                BEGIN
                                    SET NOCOUNT ON;
                                    CREATE TABLE Kullanicilar (
                                        ID INT IDENTITY(1,1) PRIMARY KEY,
                                        KullaniciAdi NVARCHAR(100) NOT NULL,
                                        KullaniciSifre NVARCHAR(100) NOT NULL,
                                        KayitTarihi DATETIME DEFAULT GETDATE(),
                                        UyeID INT NULL,
                                        UyeAdi NVARCHAR(100),
                                        UyeSoyadi NVARCHAR(100),
                                        KullaniciTipID INT NOT NULL
                                    );
                                    SET @Sonuc = 1;
                                END
                                IF NOT EXISTS (SELECT * FROM sys.objects WHERE name = 'Baglanti' AND type = 'U')
                                BEGIN
                                    SET NOCOUNT ON;
                                    CREATE TABLE Baglanti (
                                        DataSource NVARCHAR(100) NOT NULL,
                                        InitialCatalog NVARCHAR(100) NOT NULL,
                                        SunucuAdi NVARCHAR(100),
                                        Sifre NVARCHAR(100)
                                    );
                                    SET @Sonuc = 1;
                                END
                                IF NOT EXISTS (SELECT * FROM sys.objects WHERE name = 'Emanetler' AND type = 'U')
                                BEGIN
                                    SET NOCOUNT ON;
                                    CREATE TABLE Emanetler (
                                        emanetID INT IDENTITY(1,1) PRIMARY KEY,
                                        KitapID INT NOT NULL,
                                        UyeID INT NOT NULL,
                                        AlinanTarih DATETIME NOT NULL DEFAULT GETDATE(),
                                        İadeTarihi DATETIME NULL,
                                        Ceza DECIMAL(10,2) DEFAULT 0
                                    );
                                    SET @Sonuc = 1;
                                END
                                IF NOT EXISTS (SELECT * FROM sys.objects WHERE name = 'Haraketler' AND type = 'U')
                                BEGIN
                                    SET NOCOUNT ON;
                                    CREATE TABLE Haraketler (
                                        ID INT IDENTITY(1,1) PRIMARY KEY,
                                        KitapID INT NOT NULL,
                                        UyeID INT NOT NULL,
                                        AlinmaZamani DATETIME NOT NULL DEFAULT GETDATE(),
                                        VerilmeZamani DATETIME NULL
                                    );
                                    SET @Sonuc = 1;
                                END
                                SELECT @Sonuc;";

				SqlConnection baglanti2 = new SqlConnection(@"Data Source=YOUR_SERVER;Initial Catalog=master;User Id=sa;Password=YOUR_PASSWORD;Integrated Security=True;Trust Server Certificate=True");
				baglanti2.Open();
				using (SqlCommand komut2 = new SqlCommand(sorgu2, baglanti2)){
					object deger=komut2.ExecuteScalar();
					if (deger != null) sonuc = Convert.ToInt32(deger);
				}
				return sonuc;
			}
			catch{
				return -1;
			}
            finally
            {
				SqlConnection baglanti2 = new SqlConnection(@"Data Source=YOUR_SERVER;Initial Catalog=master;User Id=sa;Password=YOUR_PASSWORD;Integrated Security=True;Trust Server Certificate=True");
                if(baglanti2.State == ConnectionState.Open) baglanti2.Close();
			}
		}
	}
}

