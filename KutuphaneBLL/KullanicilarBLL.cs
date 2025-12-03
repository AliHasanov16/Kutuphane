using Kutuphane.DAL;
using Kutuphane.EL.Kullanicilar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneBLL
{
	public static class KullanicilarBLL
	{

		public static List<Kullanicilar> KullanicilarGetir()
		{
			return new KullanicilarDAL().KullanicilarGetir();
		} 

		public static int KullaniciSil(int ID)
		{
			KullanicilarDAL kullanicilarDAL = new KullanicilarDAL();
			if (ID < 0) return -1;
			return kullanicilarDAL.KullaniciSil(ID);
		}

		public static int KullaniciGuncelle(Kullanicilar k)
		{
			KullanicilarDAL kullanicilarDAL = new KullanicilarDAL();
			return kullanicilarDAL.KullaniciGuncelle(k);
		}

		public static List<Kullanicilar> KullaniciAra(string aranan)
		{
			KullanicilarDAL kullanicilarDAL = new KullanicilarDAL();
			return kullanicilarDAL.KullaniciAra(aranan);
		}


		//Kullanici LOGIN KISMI ---------------
		public static Kullanicilar KullaniciGiris(string kad,string sifre)
		{
			KullanicilarDAL kullanicilarDAL= new KullanicilarDAL();
			if (string.IsNullOrWhiteSpace(kad) || string.IsNullOrWhiteSpace(sifre))
				throw new Exception("Kullanici Adi Sifre Hatali Bos Olamaz");
			return kullanicilarDAL.KullaniciGiris(kad, sifre);
		}		
		public static int KullaniciEkle(Kullanicilar k)
		{
			KullanicilarDAL kullanicilarDAL = new KullanicilarDAL();
			return kullanicilarDAL.KullaniciEkle(k);
		}
		//

		public static int OtoKullaniciEkle(string kad, string sifre)
		{
			KullanicilarDAL kullanicilarDAL = new KullanicilarDAL();
			return kullanicilarDAL.OtoKullaniciEkle(kad, sifre);
		}

		//ANLİK KULLANICI AYARLAR
		public static int AnlikKullaniciGuncelle(int kullaniciID, string kad, string ksifre, string uyead, string uyesoyad)
		{
			return new KullanicilarDAL().AnlikKullaniciGuncelle(kullaniciID, kad, ksifre, uyead, uyesoyad);
		}
	}
}
