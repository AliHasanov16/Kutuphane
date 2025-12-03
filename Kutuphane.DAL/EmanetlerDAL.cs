using Kutuphane.EL.Emanetler;
using Kutuphane.EL.ViewModels;
using Kutuphane.EL.Kitap;
using Microsoft.Data.SqlClient;
using System;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Kutuphane.DAL
{
    public class EmanetlerDAL
    {                                                
        SqlConnection baglanti = new SqlConnection(                                                                           /*           {0}           */
        string.Format(@"Data Source={0};Initial Catalog=KutuphaneDB;Integrated Security=True;Trust Server Certificate=True", "DESKTOP-CU679RN\\SQLEXPRESS01"));
        
        public EmanetlerDAL() { }
        public List<Emanetler> EmanetleriGetir()
        {
            List<Emanetler> emanetListesi = new List<Emanetler>();
             
            SqlCommand komut = new SqlCommand("Select * From Emanetler", baglanti);
            baglanti.Open();
            SqlDataReader dr = komut.ExecuteReader();

            while (dr.Read())
            {
				Emanetler k = new Emanetler()
				{
					EmanetID = dr["EmanetID"] == DBNull.Value ? 0 : Convert.ToInt32(dr["EmanetID"]),
					KitapID = dr["KitapID"] == DBNull.Value ? 0 : Convert.ToInt32(dr["KitapID"]),
					UyeID = dr["UyeID"] == DBNull.Value ? 0 : Convert.ToInt32(dr["UyeID"]),
					AlinanTarih = dr["AlinanTarih"] == DBNull.Value ? DateTime.MinValue : Convert.ToDateTime(dr["AlinanTarih"]),
					İadeTarihi = dr["İadeTarihi"] == DBNull.Value ? DateTime.MinValue : Convert.ToDateTime(dr["İadeTarihi"]),
					Ceza = dr["Ceza"] == DBNull.Value ? 0 : Convert.ToInt32(dr["Ceza"])
				};

				emanetListesi.Add(k);
            }
            baglanti.Close();
            return emanetListesi;
        }

        public int EmanetEkle(Emanetler ee)
        {
            int sonuc = 0;

            string sorgu = @"INSERT INTO Emanetler(KitapID,UyeID,AlinanTarih,İadeTarihi,Ceza) VALUES(@kitapID,@uyeID,@atarih,@itarih,@ceza)";
            using (SqlCommand komut = new SqlCommand(sorgu, baglanti))
            {
              
				komut.Parameters.Add("@kitapID",SqlDbType.Int).Value = ee.KitapID;
                komut.Parameters.Add("@uyeID", SqlDbType.Int).Value = ee.UyeID;
                komut.Parameters.Add("@atarih", SqlDbType.Date).Value = ee.AlinanTarih;
                komut.Parameters.Add("@itarih", SqlDbType.Date).Value = ee.İadeTarihi;
                komut.Parameters.Add("@ceza", SqlDbType.Int).Value = ee.Ceza;
                
                baglanti.Open();
                sonuc = komut.ExecuteNonQuery();
            }

            return sonuc ;

        }

        public int EmanetlerSil(int EmanetID)
        {   
            int sonuc = 0;
            string sorgu = @"DELETE FROM Emanetler WHERE emanetID=@EmanetID";

            using (SqlCommand komut = new SqlCommand(sorgu,baglanti))
            {
                komut.Parameters.AddWithValue("@EmanetID", EmanetID);

                baglanti.Open();
                sonuc = komut.ExecuteNonQuery();
            }

            return sonuc;

        }

        public int EmanetGuncelle(Emanetler ee)
        {
            int sonuc = 0;                                                                                                                   
			string sorgu = @"UPDATE Emanetler Set KitapID=@kitapID , UyeID=@uyeID , AlinanTarih=@atarih , İadeTarihi=@itarih , Ceza=@ceza WHERE emanetID=@id";

            using (SqlCommand komut = new SqlCommand(sorgu, baglanti))
            {
                komut.Parameters.Add("@id", SqlDbType.Int).Value = ee.EmanetID;
                komut.Parameters.Add("@kitapID",SqlDbType.Int).Value = ee.KitapID;
                komut.Parameters.Add("@uyeID", SqlDbType.Int).Value = ee.UyeID;
                komut.Parameters.Add("@atarih",SqlDbType.Date).Value = ee.AlinanTarih;
                komut.Parameters.Add("@itarih", SqlDbType.Date).Value = ee.İadeTarihi;
                komut.Parameters.Add("@ceza", SqlDbType.Int).Value = ee.Ceza;

                baglanti.Open() ;
                sonuc = komut.ExecuteNonQuery();
            }
            return sonuc;
		}

		public List<Emanetler> EmanetlerAra(int aranan)
		{
			List<Emanetler> emanetlerListesi = new List<Emanetler>();
			string sorgu = @"SELECT * FROM Emanetler WHERE KitapID = @aranan OR UyeID = @aranan";

			using (SqlCommand komut = new SqlCommand(sorgu, baglanti))
			{
				komut.Parameters.AddWithValue("@aranan", aranan);
				baglanti.Open();

				using (SqlDataReader dr = komut.ExecuteReader())
				{
					while (dr.Read())
					{
						Emanetler ee = new Emanetler();
						ee.EmanetID = Convert.ToInt32(dr["EmanetID"]);
						ee.KitapID = Convert.ToInt32(dr["KitapID"]);
						ee.UyeID = Convert.ToInt32(dr["UyeID"]);
						ee.AlinanTarih = Convert.ToDateTime(dr["AlinanTarih"]);
						ee.İadeTarihi = dr["İadeTarihi"] != DBNull.Value ? Convert.ToDateTime(dr["İadeTarihi"]) :null ;
						ee.Ceza = Convert.ToInt32(dr["Ceza"]);
						emanetlerListesi.Add(ee);
					}
				}
			}
			return emanetlerListesi;
		}

        //View Çağırmak için  --> EL('den yeni).CS katmanı Oluşturuldu.
        public List<EmanetlerCeza> EmanetlerCeza()
        {
            List<EmanetlerCeza> emanetlerCeza = new List<EmanetlerCeza>();

            string sorgu = @"SELECT u.UyeAdi+' '+u.UyeSoyadi as 'AdiSoyadi',k.KitapAdi ,AlinanTarih,İadeTarihi,Ceza FROM Emanetler e
                            JOIN Uyeler u on e.UyeID = u.UyeID
                            JOIN Kitaplar k on e.KitapID = k.KitapID ORDER BY Ceza desc";

            using (SqlCommand komut = new SqlCommand(sorgu,baglanti))
            { 
                baglanti.Open();
                using (SqlDataReader dr = komut.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        EmanetlerCeza ee = new EmanetlerCeza();

                        ee.KitapAdi = dr["KitapAdi"] != DBNull.Value ?  dr["KitapAdi"].ToString() :null;
                        ee.AdiSoyadi = dr["AdiSoyadi"] != DBNull.Value ? dr["AdiSoyadi"].ToString() : null ;
                        ee.AlinanTarih = dr["AlinanTarih"] != DBNull.Value ? Convert.ToDateTime(dr["AlinanTarih"]) : null ;
                        ee.İadeTarihi = dr["İadeTarihi"] != DBNull.Value ? Convert.ToDateTime(dr["İadeTarihi"]) : null ;
                        ee.Ceza = dr["Ceza"] != DBNull.Value ? Convert.ToInt32(dr["Ceza"]) : null;
                        emanetlerCeza.Add(ee);
                    }
				}
			}

            return emanetlerCeza;
		}

        public List<EnFazlaEmanetAlınan> EnFazlaAlinanGetir()
        {

            List<EnFazlaEmanetAlınan> enFazlaEmanetAlınan = new List<EnFazlaEmanetAlınan>();

            string sorgu = @"SELECT KitapAdi,Tur,Yazar,BasimYili,CASE WHEN STOK<0 THEN 'Stokta Yok'
                                 WHEN STOK>0 THEN 'Stokta Mevcut' 
                                 END AS 'Stok'
                                ,COUNT(*) as 'EnFazlaAlinan'
                             FROM Emanetler e
	                            JOIN Kitaplar k on e.KitapID = k.KitapID
	                            GROUP BY KitapAdi,Tur,Yazar,BasimYili,
                                CASE WHEN STOK<0 THEN 'Stokta Yok'
                                 WHEN STOK>0 THEN 'Stokta Mevcut' 
                                 END 
                                 order by COUNT(*) desc";

            using (SqlCommand komut = new SqlCommand(sorgu, baglanti))
            {
                baglanti.Open();
                using (SqlDataReader dr = komut.ExecuteReader()) {
                    while (dr.Read()) { 
                    
                        EnFazlaEmanetAlınan en = new EnFazlaEmanetAlınan();
                        
                        en.KitapAdi = dr["KitapAdi"] != DBNull.Value ? dr["KitapAdi"].ToString() : null;
                        en.Tur = dr["Tur"] != DBNull.Value ? dr["Tur"].ToString() : null;
                        en.Yazar = dr["Yazar"] != DBNull.Value ? dr["Yazar"].ToString() : null;
                        en.BasimYili = Convert.ToDateTime(dr["BasimYili"]);
                        en.Stok = dr["Stok"].ToString();
                        en.EnFazlaAlinan = dr["EnFazlaAlinan"] != DBNull.Value ? dr["EnFazlaAlinan"].ToString() : null;

                        enFazlaEmanetAlınan.Add(en);
                    }
                }
            }
            return enFazlaEmanetAlınan;
        }

        public List<EnFazlaEmanetAlınan> EnFazlaAlinanAra(string kadi , string tur , string yazar)
        {

            List<EnFazlaEmanetAlınan> enFazlaEmanetAlınan = new List<EnFazlaEmanetAlınan>();

            string sorgu = @"select KitapAdi,Tur,Yazar,BasimYili,Stok,COUNT(*) as 'EnFazlaAlinan'
                        from Emanetler e
	                    JOIN Kitaplar k on e.KitapID = k.KitapID
	                    where KitapAdi LIKE '%' + @kadi + '%' AND 
                        TUR   LIKE '%' + @tur   + '%' AND
                        YAZAR LIKE '%' + @yazar + '%'
	                    group by KitapAdi,Tur,Yazar,BasimYili,Stok order by COUNT(*) desc";

            using (SqlCommand komut = new SqlCommand(sorgu, baglanti))
            {
                komut.Parameters.AddWithValue("@kadi", kadi);
                komut.Parameters.AddWithValue("@tur", tur);
                komut.Parameters.AddWithValue("@yazar", yazar);
                baglanti.Open();

                using (SqlDataReader dr = komut.ExecuteReader()) {
                    while (dr.Read()) { 
                    
                        EnFazlaEmanetAlınan en = new EnFazlaEmanetAlınan();

						en.KitapAdi = dr["KitapAdi"] != DBNull.Value ? dr["KitapAdi"].ToString() : null;
						en.Tur = dr["Tur"] != DBNull.Value ? dr["Tur"].ToString() : null;
						en.Yazar = dr["Yazar"] != DBNull.Value ? dr["Yazar"].ToString() : null;
						en.BasimYili = Convert.ToDateTime(dr["BasimYili"]);
						en.Stok = dr["Stok"].ToString();
						en.EnFazlaAlinan = dr["EnFazlaAlinan"] != DBNull.Value ? dr["EnFazlaAlinan"].ToString() : null;

                        enFazlaEmanetAlınan.Add(en);
					}
                }
            }
            return enFazlaEmanetAlınan;
        }

        public List<AldigimKitaplar> AldigimKitaplar(int anlikkullaniciID)
        {
            List<AldigimKitaplar> aldigimKitaplars = new List<AldigimKitaplar>();
            string sorgu = @"SELECT u.UyeAdi as 'UyeAdi',k.KitapAdi as 'KitapAdi',e.AlinanTarih as 'AlinanTarih',e.İadeTarihi as 'İadeTarihi',
	                           Ceza as 'Ceza' FROM Emanetler e 
	                            JOIN Kitaplar k on e.KitapID = k.KitapID
	                            JOIN Uyeler u ON e.UyeID = u.UyeID
	                           WHERE u.UyeID=@uyeID";
            using (SqlCommand komut = new SqlCommand(sorgu, baglanti))
            {
                komut.Parameters.Add("@uyeID",SqlDbType.Int).Value=anlikkullaniciID;

                if (baglanti.State != ConnectionState.Open) baglanti.Open();
                using (SqlDataReader dr = komut.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        AldigimKitaplar ak = new AldigimKitaplar();

                        ak.UyeAdi = dr["UyeAdi"] != DBNull.Value ? dr["UyeAdi"].ToString() : null;
                        ak.KitapAdi = dr["KitapAdi"] != DBNull.Value ? dr["KitapAdi"].ToString() : null;
                        ak.İadeTarihi = dr["AlinanTarih"] != DBNull.Value ? Convert.ToDateTime(dr["AlinanTarih"]) : null;
                        ak.İadeTarihi = dr["İadeTarihi"] != DBNull.Value ? Convert.ToDateTime(dr["İadeTarihi"]) : null;
                      //ak.İadeTarihi = dr["İadeTarihi"] == DBNull.Value ? DateTime.MinValue : Convert.ToDateTime(dr["İadeTarihi"]);
                        ak.Ceza = Convert.ToInt32(dr["Ceza"]);
                            
                        aldigimKitaplars.Add(ak);
                    }
                }
            }
            return aldigimKitaplars;
        }
	}
}
