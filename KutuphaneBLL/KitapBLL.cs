using Kutuphane.DAL;
using Kutuphane.EL.Emanetler;
using Kutuphane.EL.Kitap;
using Kutuphane.EL.Model;
using Kutuphane.EL.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneBLL
{
	public static class KitapBLL
	{

		public static List<Kitap> KitaplariGetir()
		{
			return new KitapDAL().KitaplariGetir();
		}

		public static int KitapEkle(Kitap k)
		{
			KitapDAL kitapDAL = new KitapDAL();
			if (string.IsNullOrEmpty(k.KitapAdi) || string.IsNullOrEmpty(k.Yazar))
			{
				return -1;
			}
			return kitapDAL.KitapEkle(k);
		}

		public static int KitapSil(int KitapID)
		{
			if (KitapID <= 0) return -1;

			return KitapDAL.KitapSil(KitapID);
		}

		public static List<Kitap> KitapAra(string aranan){
			
			KitapDAL kitapDal = new KitapDAL();
			return kitapDal.KitapAra(aranan);
		}

		public static Mesaj KitapGuncelle(Kitap k)
		{
			KitapDAL kitapDAL = new KitapDAL();
			return kitapDAL.KitapGuncelle(k);
		}

		public static List<KitapStokDurum> KitapStokDurum()
		{
			return new KitapDAL().KitapStokDurum();
		}

		public static int KitapOduncAlma(int? kitapID, int? anlikkullaniciID)
		{
			KitapDAL kitapDAL = new KitapDAL();
			return kitapDAL.KitapOduncAlma(kitapID, anlikkullaniciID);
		}

		/////////////////////////// Kitap Chart 
		///
		public static List<KitaplarChart1> KitapChart1()
		{
			return new KitapDAL().KitapChart1();
		}
	}
}
