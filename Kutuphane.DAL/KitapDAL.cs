using Kutuphane.EL.Kitap;
using Kutuphane.EL.Model;
using Microsoft.Data.SqlClient;
using Kutuphane.EL.ViewModels;
using System;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Kutuphane.DAL
{   
	public class KitapDAL
	{
		SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-CU679RN\SQLEXPRESS01;Initial Catalog=KutuphaneDB;Integrated Security=True;Trust Server Certificate=True");

		public KitapDAL() { }

        public List<Kitap> KitaplariGetir()
		{
            List<Kitap> kitapListesi = new List<Kitap>();

            SqlCommand komut = new SqlCommand("Select * From Kitaplar ",baglanti);
            
			baglanti.Open();
			SqlDataReader dr = komut.ExecuteReader();

            while (dr.Read())
            {
                Kitap k = new Kitap()
                {
                    KitapID = Convert.ToInt32(dr["KitapID"]),
                    KitapAdi = dr["KitapAdi"].ToString(),
                    Tur = dr["Tur"].ToString(),
                    Yazar = dr["Yazar"].ToString(),
                    BasimYili = Convert.ToDateTime(dr["BasimYili"]),
                    Stok = Convert.ToInt32(dr["Stok"])
                };
                kitapListesi.Add(k);
            }

            baglanti.Close();
            return kitapListesi;
		}

		public int KitapEkle(Kitap k)
		{
			SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-CU679RN\SQLEXPRESS01;Initial Catalog=KutuphaneDB;Integrated Security=True;Trust Server Certificate=True");
			SqlCommand komut = new SqlCommand("INSERT INTO Kitaplar (KitapAdi, Tur, Yazar, BasimYili, Stok) VALUES (@p1, @p2, @p3, @p4, @p5)",baglanti);

			komut.Parameters.AddWithValue("@p1", k.KitapAdi);
			komut.Parameters.AddWithValue("@p2", k.Tur);
			komut.Parameters.AddWithValue("@p3", k.Yazar);
			komut.Parameters.AddWithValue("@p4", k.BasimYili);
			komut.Parameters.AddWithValue("@p5", k.Stok);

			if (komut.Connection.State != ConnectionState.Open){				
				komut.Connection.Open();
			}
			int sonuc = komut.ExecuteNonQuery();
			komut.Connection.Close();
			return sonuc;
		}

		public static int KitapSil(int KitapID)
		{
			SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-CU679RN\SQLEXPRESS01;Initial Catalog=KutuphaneDB;Integrated Security=True;Trust Server Certificate=True");
			SqlCommand komut = new SqlCommand("Delete From Kitaplar Where KitapID = @id",baglanti);

			komut.Parameters.AddWithValue("@id",KitapID);
			
			if(komut.Connection.State != ConnectionState.Open){ komut.Connection.Open(); }
			int sonuc = komut.ExecuteNonQuery();
			komut.Connection.Close();

			return sonuc;
		}

		public List<Kitap> KitapAra(string aranan)
		{
			List<Kitap> kitapListesi = new List<Kitap>();

			SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-CU679RN\SQLEXPRESS01;Initial Catalog=KutuphaneDB;Integrated Security=True;Trust Server Certificate=True");
			string sorgu = @"SELECT * FROM Kitaplar 
                         WHERE KitapAdi LIKE '%' + @aranan + '%' 
                         OR Yazar LIKE '%' + @aranan + '%' 
                         OR Tur LIKE '%' + @aranan + '%'";

			SqlCommand komut = new SqlCommand(sorgu, baglanti);
			komut.Parameters.AddWithValue("@aranan", aranan);

			baglanti.Open();
			SqlDataReader dr = komut.ExecuteReader();

			while (dr.Read())
			{
				Kitap k = new Kitap();
				k.KitapID = Convert.ToInt32(dr["KitapID"]);
				k.KitapAdi = dr["KitapAdi"] != DBNull.Value ? dr["KitapAdi"].ToString() : "" ;
				k.Tur = dr["Tur"].ToString();
				k.Yazar = dr["Yazar"].ToString();
				k.BasimYili = dr["BasimYili"] != DBNull.Value ? Convert.ToDateTime(dr["BasimYili"]) : null;
				k.Stok = Convert.ToInt32(dr["Stok"]);
				kitapListesi.Add(k);
			}
			dr.Close();
			baglanti.Close();

			return kitapListesi;
		}

		public Mesaj KitapGuncelle(Kitap k)
		{
			SqlCommand komut = new SqlCommand("Update Kitaplar Set KitapAdi=@ad,Tur=@tur,Yazar=@yazar,BasimYili=@basim,Stok=@stok Where KitapID = @id",baglanti);

			komut.Parameters.AddWithValue("@ad", SqlDbType.VarChar).Value= k.KitapAdi ;
			komut.Parameters.AddWithValue("@tur", SqlDbType.VarChar).Value= k.Tur ;
			komut.Parameters.Add("@yazar",SqlDbType.VarChar).Value = k.Yazar ;
			komut.Parameters.AddWithValue("@basim", SqlDbType.Date).Value= k.BasimYili ;
			komut.Parameters.AddWithValue("@stok", SqlDbType.Int).Value= k.Stok ;
			komut.Parameters.AddWithValue("@id", SqlDbType.Int).Value = k.KitapID;

			if (komut.Connection.State != ConnectionState.Open) komut.Connection.Open();
			int sonuc = komut.ExecuteNonQuery();
			komut.Connection.Close();

			Mesaj mesaj = new Mesaj();
			if (sonuc > 0){
				mesaj.Basarili = true;
				mesaj.Icerik = "Başarıyla kaydedildi";
			}
			else{
				mesaj.Basarili = false;
				mesaj.Icerik = "Kaydedilemedi";
			}

			return mesaj;
		}

		public List<KitapStokDurum> KitapStokDurum()
		{
			List<KitapStokDurum> kitapStokDurumListele = new List<KitapStokDurum>();

			string sorgu = @"Select KitapAdi,Tur,Yazar,Stok, CASE 
							  WHEN Stok<=0 THEN 'Stokta Yok'  
							  WHEN STOK>0 AND STOK <=10 THEN 'Bitmek Üzere' 
							  WHEN STOK>10 THEN 'Mevcut'
							  end as 'StokDurumu' from Kitaplar";
			using (SqlCommand komut = new SqlCommand(sorgu, baglanti))
			{
				baglanti.Open();
				using (SqlDataReader dr = komut.ExecuteReader())
				{
					while (dr.Read())
					{
						KitapStokDurum ksd = new KitapStokDurum();

						ksd.KitapAdi = dr["KitapAdi"] != DBNull.Value ? dr["KitapAdi"].ToString() : null;
						ksd.Tur = dr["Tur"] != DBNull.Value ? dr["Tur"].ToString() : null;
						ksd.Yazar = dr["Yazar"] != DBNull.Value ? dr["Yazar"].ToString() : null;
						ksd.Stok = Convert.ToInt32(dr["Stok"]);
						ksd.StokDurumu = dr["StokDurumu"].ToString();

						kitapStokDurumListele.Add(ksd);
					}
				}
			}
			return kitapStokDurumListele;
		}

		//KİTAP ÖDÜNÇ AL
		public int KitapOduncAlma(int? kitapID, int? anlikkullaniciID )
		{
			int sonuc = 0;
			string sorgu = @"INSERT INTO Emanetler(KitapID, UyeID, AlinanTarih, İadeTarihi,Ceza)
							VALUES(@KitapID, @UyeID, GETDATE(), NULL,0)
							UPDATE Kitaplar SET Stok = Stok - 1 WHERE KitapID = @KitapID";
			using (SqlCommand komut = new SqlCommand(sorgu, baglanti))
			{
				komut.Parameters.Add("@KitapID",SqlDbType.Int).Value=kitapID;
				komut.Parameters.Add("@UyeID", SqlDbType.Int).Value = anlikkullaniciID;

				if(baglanti.State != ConnectionState.Open) baglanti.Open();
				sonuc = komut.ExecuteNonQuery();
			}
			return sonuc;
		}

		////////////////////////////////////////////////////// CHART İÇİN
		///
		public List<KitaplarChart1> KitapChart1()
		{
			List<KitaplarChart1> kitaplarChart1 = new List<KitaplarChart1>();

			string sorgu = @"Select KitapAdi,Stok from Kitaplar";

			using (SqlCommand komut = new SqlCommand(sorgu,baglanti)){
				baglanti.Open();
				using (SqlDataReader dr = komut.ExecuteReader()) {
					if (dr.HasRows)
					{
						while (dr.Read())
						{
							KitaplarChart1 kc = new KitaplarChart1();

							kc.KitapAdi = dr["KitapAdi"].ToString();
							kc.Stok = Convert.ToInt32(dr["Stok"]);

							kitaplarChart1.Add(kc);

						}
					}
				}
			}
			return kitaplarChart1;
		}

	}
}
