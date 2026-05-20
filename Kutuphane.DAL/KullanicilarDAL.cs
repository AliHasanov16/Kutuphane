using Kutuphane.EL.Kitap;
using Kutuphane.EL.Kullanicilar;
using Kutuphane.EL.KullaniciTip;
using Kutuphane.EL.Uyeler;
using Microsoft.Data.SqlClient;
using System;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Kutuphane.DAL
{
    public class KullanicilarDAL
    {
        //SQL'Den veri alışverişi yapmamızı sağlar . veritabanı ile ilişki kurar .
		SqlConnection baglanti = new SqlConnection(@"Data Source=YOUR_SERVER;Initial Catalog=master;Integrated Security=True;Trust Server Certificate=True");

		public KullanicilarDAL() { }
        //Kullanıcıları datagriwView'e DAL ile cağırma . DAL tarafı DAL-->BLL-->UI
        public List<Kullanicilar> KullanicilarGetir()
        {
            List<Kullanicilar> kullanicilarListesi = new List<Kullanicilar>();

            string sorgu = @"SELECT * FROM Kullanicilar";

            using (SqlCommand komut = new SqlCommand(sorgu, baglanti))
            {
                baglanti.Open();
                using (SqlDataReader dr = komut.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Kullanicilar k = new Kullanicilar();

                        k.ID = Convert.ToInt32(dr["ID"]);
                        k.KullaniciAdi = dr["KullaniciAdi"] != DBNull.Value ? dr["KullaniciAdi"].ToString() : null;
                        k.KullaniciSifre = dr["KullaniciSifre"] != DBNull.Value ? dr["KullaniciSifre"].ToString() : null;
                        k.KayitTarihi = Convert.ToDateTime(dr["KayitTarihi"]);
                        k.UyeID = Convert.ToInt32(dr["UyeID"]);
                        k.UyeAdi = dr["UyeAdi"] != DBNull.Value ? dr["UyeAdi"].ToString() : null;
                        k.UyeSoyadi = dr["UyeSoyadi"] != DBNull.Value ? dr["UyeSoyadi"].ToString() : null;
                        k.KullaniciTipID = Convert.ToInt32(dr["KullaniciTipID"]) ;

                        kullanicilarListesi.Add(k);
                    }
                }
            }
            return kullanicilarListesi;
            
        } 

        public int KullaniciSil(int ID)
        {
            int sonuc = 0;

            string sorgu = @"DELETE FROM Kullanicilar WHERE ID = @ID";

            using (SqlCommand komut = new SqlCommand(sorgu,baglanti))
            {
                komut.Parameters.AddWithValue("@ID",ID);
                baglanti.Open();
                sonuc = komut.ExecuteNonQuery();
            }
            return sonuc;
        }

        public int KullaniciGuncelle(Kullanicilar k)
        {
            int sonuc = 0;
            string sorgu = @"Update Kullanicilar SET KullaniciAdi=@ad , KullaniciSifre=@sifre , KayitTarihi=@tarih , 
                             UyeID = @uyeID , UyeAdi =@uyeadi , UyeSoyadi = @uyesoyadi , KullaniciTipID = @tipi WHERE ID = @id";

            using (SqlCommand komut = new SqlCommand(sorgu, baglanti))
            {
                komut.Parameters.Add("@id",SqlDbType.Int).Value=k.ID;
                komut.Parameters.Add("@ad", SqlDbType.VarChar).Value = k.KullaniciAdi;
                komut.Parameters.Add("@sifre",SqlDbType.VarChar).Value = k.KullaniciSifre;
                komut.Parameters.Add("@tarih", SqlDbType.Date).Value = k.KayitTarihi;
                komut.Parameters.Add("@uyeID", SqlDbType.Int).Value = k.UyeID;
                komut.Parameters.Add("@uyeadi", SqlDbType.VarChar).Value = k.UyeAdi;
                komut.Parameters.Add("@uyesoyadi", SqlDbType.VarChar).Value = k.UyeSoyadi;
                komut.Parameters.Add("@tipi", SqlDbType.VarChar).Value = k.KullaniciTipID;

                baglanti.Open();
                sonuc = komut.ExecuteNonQuery();
            }
            return sonuc;
        }

        public List<Kullanicilar> KullaniciAra(string aranan)
        {
            List<Kullanicilar> kullanicilariListele = new List<Kullanicilar>();

            string sorgu = @"SELECT * FROM Kullanicilar WHERE KullaniciAdi LIKE '%'+ @aranan +'%'
                            OR UyeAdi LIKE '%'+ @aranan +'%' 
                            OR UyeSoyadi LIKE '%'+ @aranan +'%' 
                            OR UyeTipi LIKE '%'+ @aranan +'%' ";

            using (SqlCommand komut = new SqlCommand(sorgu, baglanti))
            {
                komut.Parameters.AddWithValue("@aranan", aranan);
                baglanti.Open();
                using (SqlDataReader dr = komut.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Kullanicilar k = new Kullanicilar();

                        k.ID = Convert.ToInt32(dr["ID"]) ;
                        k.KullaniciAdi = dr["KullaniciAdi"] != DBNull.Value ? dr["KullaniciAdi"].ToString() : null;
                        k.KullaniciSifre = dr["KullaniciSifre"] != DBNull.Value ? dr["KullaniciSifre"].ToString() : null;
                        k.KayitTarihi = Convert.ToDateTime(dr["KayitTarihi"]);
                        k.UyeID = dr["UyeID"] != DBNull.Value ? Convert.ToInt32(dr["UyeID"]) : null;
                        k.UyeAdi = dr["UyeAdi"] !=DBNull.Value ? dr["UyeAdi"].ToString() : null;
                        k.UyeSoyadi = dr["UyeSoyadi"] != DBNull.Value ? dr["UyeSoyadi"].ToString() : null;
                        k.KullaniciTipID = Convert.ToInt32(dr["KullaniciTipID"]);                
                        kullanicilariListele.Add(k);
                    }
                }
            }
            return kullanicilariListele;
        }


        //Kullanici LOGIN KISMI ------------------
        public Kullanicilar KullaniciGiris(string kad,string sifre)
        {
            Kullanicilar kullanici = null;

			string sorgu = @"SELECT k.ID, k.KullaniciAdi, k.KullaniciSifre, k.KayitTarihi,
                              k.UyeID, k.UyeAdi, k.UyeSoyadi, k.KullaniciTipID,t.TipID AS TipID, t.Tipi, t.YetkiDurumu
                            FROM Kullanicilar k
                             INNER JOIN KullaniciTip t ON k.KullaniciTipID = t.TipID
                             WHERE k.KullaniciAdi=@kad AND k.KullaniciSifre=@sifre";

			using (SqlCommand komut = new SqlCommand(sorgu, baglanti))
            {
               
                komut.Parameters.AddWithValue("@kad", kad);
                komut.Parameters.AddWithValue("@sifre", sifre);
                baglanti.Open();
                using (SqlDataReader dr = komut.ExecuteReader()) {
                    if (dr.Read()) { 
                        kullanici = new Kullanicilar
                        {
                            ID = Convert.ToInt32(dr["ID"]),
                            KullaniciAdi = dr["KullaniciAdi"] != DBNull.Value ? dr["KullaniciAdi"].ToString() : null,
                            KullaniciSifre = dr["KullaniciSifre"] != DBNull.Value ? dr["KullaniciSifre"].ToString() : null,
                            KayitTarihi = Convert.ToDateTime(dr["KayitTarihi"]),
                            UyeID = Convert.ToInt32(dr["UyeID"]),
                            UyeAdi = dr["UyeAdi"] != DBNull.Value ? dr["UyeAdi"].ToString() : null,
                            UyeSoyadi = dr["UyeSoyadi"] != DBNull.Value ? dr["UyeSoyadi"].ToString() : null,
							KullaniciTipID = Convert.ToInt32(dr["KullaniciTipID"]),
							//Kullancilar tavlosuu JOINN
							TipID = Convert.ToInt32(dr["TipID"]),
                            Tipi = dr["Tipi"] != DBNull.Value ? dr["Tipi"].ToString() : null,
                            YetkiDurumu = Convert.ToBoolean(dr["YetkiDurumu"])
                        };
					}
                }
                return kullanici;
            }
        }
        public int KullaniciEkle(Kullanicilar k)
        {
			int yeniUyeID = 0;

			string sorguMax = "SELECT ISNULL(MAX(UyeID),0) FROM Kullanicilar";
			using (SqlCommand komutMax = new SqlCommand(sorguMax, baglanti))
			{
				baglanti.Open();
				int sonUyeID = Convert.ToInt32(komutMax.ExecuteScalar());
				baglanti.Close();

				yeniUyeID = sonUyeID + 1; 
			}

			string sorgu = @"INSERT INTO Kullanicilar (KullaniciAdi, KullaniciSifre, KayitTarihi, UyeID, UyeAdi, UyeSoyadi, KullaniciTipID)
                                   VALUES (@KullaniciAdi, @KullaniciSifre, @KayitTarihi, @UyeID, @UyeAdi, @UyeSoyadi, @KullaniciTipID)";
            int sonuc;
			using (SqlCommand komut = new SqlCommand(sorgu, baglanti))
			{ 
				komut.Parameters.AddWithValue("@KullaniciAdi", k.KullaniciAdi);
				komut.Parameters.AddWithValue("@KullaniciSifre", k.KullaniciSifre);
				komut.Parameters.AddWithValue("@KayitTarihi", DateTime.Now);
				komut.Parameters.AddWithValue("@UyeID", yeniUyeID);
				komut.Parameters.AddWithValue("@UyeAdi", k.UyeAdi);
				komut.Parameters.AddWithValue("@UyeSoyadi", k.UyeSoyadi);
				komut.Parameters.AddWithValue("@KullaniciTipID", k.KullaniciTipID);

				baglanti.Open();
				sonuc = komut.ExecuteNonQuery();
				baglanti.Close();
			}
            if (sonuc > 1) return yeniUyeID;
            else return 0;

		}//Kullanıcı Kaydol

		//        ---  Eğer Tip yoksa Otomatik bir Kullanici Oluşturma  ----
		//******** BU KADAR SORGUYU TEK BIR SQL COMMAND İLE YAZ .      ************
		//******** SCOPE_IDENTITY KULLARAK YETKILI İD YI ATMAYAI ÖĞREN ************
		public int OtoKullaniciEkle(string kad, string sifre)
		{

            try{
				var sonuc = 0;
				string sorguu = @"	DECLARE @kontrol INT
                                    DECLARE @yetkiKontrol INT
                                
                                    SELECT @kontrol = COUNT(*) FROM KullaniciTip WHERE YetkiDurumu = 1
                                
                                    IF (@kontrol <= 0)
                                      BEGIN
                                        INSERT INTO KullaniciTip (Tipi, YetkiDurumu) VALUES (@tipi, @yetki)
                                        SET @yetkiKontrol = SCOPE_IDENTITY()
                                      END
                                
                                    IF (@yetkiKontrol IS NOT NULL)
                                      BEGIN
                                        INSERT INTO Kullanicilar (KullaniciAdi, KullaniciSifre, UyeID, KayitTarihi, UyeAdi, UyeSoyadi, KullaniciTipID)
                                        VALUES (@kad, @sifre, @uyeID, @kayitTarihi, @uyeAdi, @uyeSoyadi, @yetkiKontrol)
                                      END ";

				using (SqlCommand komutt=new SqlCommand(sorguu, baglanti))
				{
					komutt.Parameters.Add("@tipi", SqlDbType.VarChar).Value = "Admin";
					komutt.Parameters.Add("@yetki", SqlDbType.Bit).Value = true; //KullanıcıTip Tablosu İcin

					komutt.Parameters.Add("@kad", SqlDbType.VarChar).Value = kad;
					komutt.Parameters.Add("@sifre", SqlDbType.VarChar).Value = sifre;
					komutt.Parameters.Add("@uyeID", SqlDbType.Int).Value = 2;			//Kullanıcılar Tablosuna INSERT icin
					komutt.Parameters.Add("@kayitTarihi", SqlDbType.Date).Value = DateTime.Now;
					komutt.Parameters.Add("@uyeAdi", SqlDbType.VarChar).Value = "Admin";
					komutt.Parameters.Add("@uyeSoyadi", SqlDbType.VarChar).Value = "ADMİN";
					//KullaniciTipId'sine PARAMETRE Verilmedi cünki SQL-Veritabanında yetkikontrol direk verildiği icin

					if (baglanti.State != ConnectionState.Open) baglanti.Open();
					sonuc =komutt.ExecuteNonQuery();
				}
				return sonuc;
            }

			#region OtoKullaniciEkleme Tek Tek ayrı sorgular ile
			//try
			//{
			//	var tipKontrol = 0;
			//	string sorgu = "SELECT COUNT(*) FROM KullaniciTip where YetkiDurumu=1";
			//	using (SqlCommand komut = new SqlCommand(sorgu, baglanti))
			//	{
			//		if (baglanti.State != ConnectionState.Open) baglanti.Open();
			//		tipKontrol = Convert.ToInt32(komut.ExecuteScalar());
			//	}

			//            // SCOPE_IDENTITY İLE YAPILACAK KISIM .............
			//            // SCOPE_IDENTITY - son kaydedilen kişinin İDsını alır .
			//	if (tipKontrol <= 0)
			//	{
			//		string sorgu2 = "INSERT INTO KullaniciTip (Tipi, YetkiDurumu) VALUES (@tipi, @yetki) SELECT SCOPE_IDENTITY() ";
			//		using (SqlCommand komut2 = new SqlCommand(sorgu2, baglanti))
			//		{

			//			komut2.Parameters.AddWithValue("@tipi", "Admin");
			//			komut2.Parameters.Add("@yetki", SqlDbType.Bit).Value = true;

			//			if (baglanti.State != ConnectionState.Open) baglanti.Open();
			//			komut2.ExecuteScalar();
			//                     var yetkiDurumID =  komut2;

			//                     if (yetkiDurumID == null ) return 0;


			//			string srgu4 = @"INSERT INTO Kullanicilar (KullaniciAdi, KullaniciSifre, UyeID, KayitTarihi, UyeAdi, UyeSoyadi, KullaniciTipID)
			//                                  VALUES(@kad, @sifre, @uyeID, @kayitTarihi, @uyeAdi, @uyeSoyadi, @kullaniciTipID)";

			//			int sonuc = 0;
			//			using (SqlCommand komutt4 = new SqlCommand(srgu4, baglanti))
			//			{
			//				komutt4.Parameters.AddWithValue("@kad", kad);
			//				komutt4.Parameters.AddWithValue("@sifre", sifre);
			//				komutt4.Parameters.AddWithValue("@uyeID", 2);
			//				komutt4.Parameters.AddWithValue("@kayitTarihi", DateTime.Now);
			//				komutt4.Parameters.AddWithValue("@uyeAdi", "Admin");
			//				komutt4.Parameters.AddWithValue("@uyeSoyadi", "ADMİN");
			//				komutt4.Parameters.AddWithValue("@kullaniciTipID", yetkiDurumID);

			//				if (baglanti.State != ConnectionState.Open) baglanti.Open();
			//				sonuc = komutt4.ExecuteNonQuery();
			//			}
			//			return sonuc;
			//		}
			//	}
			//	else return 0;

			//BÖYLE YAZARAK YAP KOD SATIRINI KISALTIR VE HIZLANDIRIR . UZUN YAZZMAKTAN PRATİĞE GECİS ---
			//DECLARE @Tip INT
			//SELECT @Tip = COUNT(*) FROM KullaniciTip where YetkiDurumu = 1
			//IF @Tip > 0 begin

			//INSERT INTO KullaniciTip(Tipi, YetkiDurumu) VALUES(@tipi, @yetki) SELECT SCOPE_IDENTITY()
			//end
			#region OtoKullanıcıEkle TekTek usıng ıle yanı coklu usıng ıle uzun yapımı

			////////////////

			//KullaniciTipEL kt = null;
			//string sorgu3 = "SELECT TOP 1 TipID, Tipi, YetkiDurumu FROM KullaniciTip WHERE YetkiDurumu = 1 ORDER BY TipID";
			//using (SqlCommand komut3 = new SqlCommand(sorgu3, baglanti))
			//{
			//	if (baglanti.State != ConnectionState.Open) baglanti.Open();
			//	using (SqlDataReader dr = komut3.ExecuteReader())
			//	{
			//		if (dr.Read())
			//		{
			//			kt = new KullaniciTipEL
			//			{
			//				TipID = dr["TipID"] != DBNull.Value ? Convert.ToInt32(dr["TipID"]) : 0,
			//				Tipi = dr["Tipi"] != DBNull.Value ? dr["Tipi"].ToString() : null,
			//				YetkiDurumu = dr["YetkiDurumu"] != DBNull.Value ? Convert.ToBoolean(dr["YetkiDurumu"]) : false
			//			};
			//		}
			//	}
			//}

			//if (kt == null || kt.YetkiDurumu == false) return 0;

			//string srgu4 = @"INSERT INTO Kullanicilar (KullaniciAdi, KullaniciSifre, UyeID, KayitTarihi, UyeAdi, UyeSoyadi, KullaniciTipID)
			//                                 VALUES(@kad, @sifre, @uyeID, @kayitTarihi, @uyeAdi, @uyeSoyadi, @kullaniciTipID)";

			//int sonuc = 0;
			//using (SqlCommand komutt4 = new SqlCommand(srgu4, baglanti))
			//{
			//	komutt4.Parameters.AddWithValue("@kad", kad);
			//	komutt4.Parameters.AddWithValue("@sifre", sifre);
			//	komutt4.Parameters.AddWithValue("@uyeID", 2);
			//	komutt4.Parameters.AddWithValue("@kayitTarihi", DateTime.Now);
			//	komutt4.Parameters.AddWithValue("@uyeAdi", "Admin");
			//	komutt4.Parameters.AddWithValue("@uyeSoyadi", "ADMİN");
			//	komutt4.Parameters.AddWithValue("@kullaniciTipID", kt.TipID);,

			//	if (baglanti.State != ConnectionState.Open) baglanti.Open();
			//	sonuc = komutt4.ExecuteNonQuery();
			//}
			//return sonuc;
			#endregion
			//}
			#endregion

			catch (Exception ex)
			{
				return 0;
			}
			finally{
				if (baglanti != null && baglanti.State == ConnectionState.Open) baglanti.Close();
			}
		}

		//KULLANICI TİPİ VARMI YOKMU KONTROL ?
		//SONRA BIR ADMIN KULLANICI TİPİ OLUSTURULCAK YANI YETKISI TRUE YAPILCAK .
		//SONRA YENI KULLANICI OLUŞTURULCAK VE ONUN IDSINDEN ONA KULLANICITİPİNDEN YETKİSİ VERİLCEK
		//VE 1 ADMIN GİRİŞİ SAĞLANACAK
		//amaç : eğer tabloda kullanicitip ve kullanicilar boşise uyg giriş için otomatik bir YetkiDurumu 1 olan bir yeni kullanici oluşturmak


		//ANLİK KULLANICI AYAR DEĞİŞTİRME KENDİNİN
		public int AnlikKullaniciGuncelle(int kullaniciID, string uyead ,string uyesoyad, string kad, string ksifre)
		{
			int sonuc = 0;
			string sorgu = @"Update Kullanicilar SET KullaniciAdi=@ad , KullaniciSifre=@sifre ,UyeAdi =@uyeadi , UyeSoyadi = @uyesoyadi
							WHERE UyeID = @kullaniciID";

			using (SqlCommand komut = new SqlCommand(sorgu, baglanti))
			{
				komut.Parameters.Add("@kullaniciID", SqlDbType.Int).Value = kullaniciID;
				komut.Parameters.Add("@uyeadi", SqlDbType.VarChar).Value = uyead;
				komut.Parameters.Add("@uyesoyadi", SqlDbType.VarChar).Value = uyesoyad;
				komut.Parameters.Add("@ad", SqlDbType.VarChar).Value = kad;
				komut.Parameters.Add("@sifre", SqlDbType.VarChar).Value = ksifre;

				baglanti.Open();
				sonuc = komut.ExecuteNonQuery();
			}
			return sonuc;
		}
	}
}
