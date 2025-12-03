using Kutuphane.EL.Uyeler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Data;
using Microsoft.Data.SqlClient;
using Kutuphane.EL.ViewModels;

namespace Kutuphane.DAL
{
    public class UyelerDAL
    {
		SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-CU679RN\SQLEXPRESS01;Initial Catalog=KutuphaneDB;Integrated Security=True;Trust Server Certificate=True");
		public UyelerDAL() { }
		//Üyeleri datagriwView'e DAL ile cağırma . DAL tarafı DAL-->BLL-->UI
		public List<Uyeler> UyelerGetir()
        {
            List<Uyeler> uyeListesi = new List<Uyeler>();

            SqlCommand komut = new SqlCommand("Select * From Uyeler", baglanti);
            baglanti.Open();
            SqlDataReader dr = komut.ExecuteReader();

            while (dr.Read())
            {
				Uyeler k = new Uyeler()
				{
					UyeID = dr["UyeID"] == DBNull.Value ? 0 : Convert.ToInt32(dr["UyeID"]),
					UyeAdi = dr["UyeAdi"] == DBNull.Value ? string.Empty : dr["UyeAdi"].ToString(),
					UyeSoyadi = dr["UyeSoyadi"] == DBNull.Value ? string.Empty : dr["UyeSoyadi"].ToString(),
					UyeTipi = dr["UyeTipi"] == DBNull.Value ? string.Empty : dr["UyeTipi"].ToString()
				};

				uyeListesi.Add(k);
            }
            baglanti.Close();
            return uyeListesi;
        }
		//Üyeleri datagriwView'e DAL ile ekleme . DAL tarafı DAL-->BLL-->UI
		public int UyeEkle(Uyeler u)
		{
			SqlCommand komut = new SqlCommand("INSERT INTO Uyeler(UyeAdi,UyeSoyadi,UyeTipi) VALUES(@ad,@soyad,@tip)", baglanti);

			komut.Parameters.Add("@ad", SqlDbType.VarChar).Value = u.UyeAdi;
			komut.Parameters.Add("@soyad", SqlDbType.VarChar).Value = u.UyeSoyadi;
			komut.Parameters.Add("@tip", SqlDbType.VarChar).Value = u.UyeTipi;

			if (komut.Connection.State != ConnectionState.Open) komut.Connection.Open();
			int sonuc = komut.ExecuteNonQuery();
			komut.Connection.Close();

			return sonuc;

		}

		public int UyeSil(int UyeID) {

			SqlCommand komut = new SqlCommand("DELETE FROM Uyeler WHERE UyeID = @id ", baglanti);

			komut.Parameters.AddWithValue("@id", UyeID);

			if(komut.Connection.State != ConnectionState.Open) komut.Connection.Open();
			int sonuc = komut.ExecuteNonQuery();
			komut.Connection.Close();

			return sonuc;
		}

		public int UyeGuncelle(Uyeler u)
		{
			SqlCommand komut = new SqlCommand("UPDATE Uyeler SET UyeAdi=@ad , UyeSoyadi = @soyad , UyeTipi = @tip WHERE UyeID = @id", baglanti);

			komut.Parameters.Add("@ad", SqlDbType.VarChar).Value = u.UyeAdi;
			komut.Parameters.Add("@soyad", SqlDbType.VarChar).Value = u.UyeSoyadi;
			komut.Parameters.Add("@tip", SqlDbType.VarChar).Value = u.UyeTipi;
			komut.Parameters.Add("@id", SqlDbType.Int).Value = u.UyeID;

			if (komut.Connection.State != ConnectionState.Open) komut.Connection.Open();
			int sonuc = komut.ExecuteNonQuery();
			komut.Connection.Close();

			return sonuc;

		}

		public List<Uyeler> UyeAra(string aranan) {
		
			List<Uyeler> uyelerListesi = new List<Uyeler>();

			string sorgu = @"SELECT * FROM Uyeler 
                         WHERE UyeAdi LIKE '%' + @aranan + '%' 
                         OR UyeSoyadi LIKE '%' + @aranan + '%' 
                         OR UyeTipi LIKE '%' + @aranan + '%'";

			SqlCommand komut = new SqlCommand(sorgu,baglanti);
			komut.Parameters.AddWithValue("@aranan", aranan);

			baglanti.Open();

			SqlDataReader dr = komut.ExecuteReader();
			while (dr.Read()) { 
				Uyeler u = new Uyeler();
				u.UyeID = Convert.ToInt32(dr["UyeID"]);
				u.UyeAdi = dr["UyeAdi"] != DBNull.Value ? dr["UyeAdi"].ToString() : "";
				u.UyeSoyadi = dr["UyeSoyadi"] !=DBNull.Value ? dr["UyeSoyadi"].ToString() : "";
				u.UyeTipi = dr["UyeTipi"] != DBNull.Value ? dr["UyeTipi"].ToString() : "" ;
				uyelerListesi.Add(u);
			}

			dr.Close();
			baglanti.Close();

			return uyelerListesi;

		}

		public List<UyeTopBakma> UyeTopGetir()
		{
			List<UyeTopBakma> uyeTopBakma = new List<UyeTopBakma>();

			string sorgu = @"SELECT upper(LEFT(UyeAdi,1) + '***** ' + RIGHT(UyeSoyadi,1) + '****') as 'AdSoyad' , Count(*) as 'OkunanKitap' FROM Emanetler e
							   JOIN Uyeler u on e.UyeID = u.UyeID
							   GROUP BY UyeAdi , UyeSoyadi
							   ORDER BY COUNT(*) DESC ";

			using (SqlCommand komut = new SqlCommand(sorgu,baglanti))
			{
				baglanti.Open();
				using (SqlDataReader dr = komut.ExecuteReader()) {
					while (dr.Read()) { 
						
						UyeTopBakma u = new UyeTopBakma();

						u.AdSoyad = dr["AdSoyad"] != DBNull.Value ? dr["AdSoyad"].ToString() : null;
						u.OkunanKitap = dr["OkunanKitap"] != DBNull.Value ? dr["OkunanKitap"].ToString() : null;

						uyeTopBakma.Add(u);
					}
				}
			}
			return uyeTopBakma;
		}

		public List<chart2Uyeler> UyelerChart2()
		{
			List<chart2Uyeler> chart2Uyeler = new List<chart2Uyeler>();
			string sorgu = @" SELECT CASE
								WHEN DATEDIFF(DAY,AlinanTarih,İadeTarihi)>15 THEN 'İade Zamanı Geçildi'
								WHEN DATEDIFF(DAY,AlinanTarih,İadeTarihi)<=15 THEN 'Zamanında Teslim' else 'İade Edilmedi'
								end as 'Durum' , COUNT(*) AS 'Sayisi'
								FROM Emanetler
								GROUP BY case WHEN DATEDIFF(DAY,AlinanTarih,İadeTarihi)>15 THEN 'İade Zamanı Geçildi'
								WHEN DATEDIFF(DAY,AlinanTarih,İadeTarihi)<=15 THEN 'Zamanında Teslim' else 'İade Edilmedi'
								end  ";

			using (SqlCommand komut =new SqlCommand(sorgu, baglanti)) {
				baglanti.Open();
				using (SqlDataReader dr = komut.ExecuteReader()){
					while (dr.Read()) { 
						
						chart2Uyeler ch2u = new chart2Uyeler();

						ch2u.Durum = dr["Durum"].ToString();
						ch2u.Sayisi = Convert.ToInt32(dr["Sayisi"]);

						chart2Uyeler.Add(ch2u);
					}
				}
			}
			return chart2Uyeler;
		}
	}
}