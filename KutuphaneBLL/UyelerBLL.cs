using Kutuphane.DAL;
using Kutuphane.EL.Emanetler;
using Kutuphane.EL.Uyeler;
using Kutuphane.EL.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneBLL
{
	public static class UyelerBLL
	{

		public static List<Uyeler> UyelerGetir()
		{
			return new UyelerDAL().UyelerGetir();
		}

		public static int UyeEkle(Uyeler u)
		{
			UyelerDAL uyelerDAL = new UyelerDAL();
			if (string.IsNullOrEmpty(u.UyeAdi) || string.IsNullOrEmpty(u.UyeSoyadi) ||string.IsNullOrEmpty(u.UyeTipi)) 
				return -1;
			
			return uyelerDAL.UyeEkle(u);
		}

		public static int UyeSil (int UyeID){
			UyelerDAL uyelerDAL =  new UyelerDAL();
			if (UyeID <= 0) return -1;
			return uyelerDAL.UyeSil(UyeID);
		}

		public static int UyeGuncelle(Uyeler u)
		{
			UyelerDAL uyelerDAL = new UyelerDAL();
			if (u.UyeAdi == "" || u.UyeSoyadi=="" || u.UyeTipi =="") return -1;
			return uyelerDAL.UyeGuncelle(u);
		}

		public static List<Uyeler> UyeAra(string aranan)
		{
			UyelerDAL uyelerDAL=new UyelerDAL();
			return uyelerDAL.UyeAra(aranan);
		}

		public static object UyeEkle(Emanetler ee)
		{
			throw new NotImplementedException();
		}

		public static List<UyeTopBakma> UyeTopGetir()
		{
			return new UyelerDAL().UyeTopGetir();
		}
		
		//CHart 2 Uyeler
		public static List<chart2Uyeler> UyelerChart2()
		{
			return new UyelerDAL().UyelerChart2();
		}
	}
}
