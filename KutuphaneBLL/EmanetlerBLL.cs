using Kutuphane.DAL;
using Kutuphane.EL.Emanetler;
using Kutuphane.EL.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneBLL
{
	public static class EmanetlerBLL
	{
		//DependencyInjection

		public static List<Emanetler> EmanetleriGetir()
		{
			return new EmanetlerDAL().EmanetleriGetir();
		}

		public static int EmanetlerEkle(Emanetler ee)
		{
			EmanetlerDAL emanetlerDAL = new EmanetlerDAL();
			return emanetlerDAL.EmanetEkle(ee);
		}

		public static int EmanetlerSil(int EmanetID)
		{
			EmanetlerDAL emanetlerDAL = new EmanetlerDAL();
			if (EmanetID < 0) return -1;
			return emanetlerDAL.EmanetlerSil(EmanetID);
		}

		public static int EmanetGuncelle(Emanetler ee)
		{
			EmanetlerDAL emanetlerDAL = new EmanetlerDAL();
			return emanetlerDAL.EmanetGuncelle(ee);
		}

		public static List<Emanetler> EmanetlerAra(int aranan)
		{
			EmanetlerDAL emanetlerDAL = new EmanetlerDAL();
			return emanetlerDAL.EmanetlerAra(aranan);
		}

		public static List<EmanetlerCeza> EmanetlerCeza()
		{
			return new EmanetlerDAL().EmanetlerCeza();
		}
	
		public static List<EnFazlaEmanetAlınan> EnFazlaAlinanGetir()
		{
			return new EmanetlerDAL().EnFazlaAlinanGetir();
		}
		 
		public static List<EnFazlaEmanetAlınan> EnFazlaAlinanAra(string kadi,string tur,string yazar)
		{
			EmanetlerDAL emanetlerDAL = new EmanetlerDAL();
			return emanetlerDAL.EnFazlaAlinanAra(kadi,tur,yazar);
		}
		
		public static List<AldigimKitaplar> AldigimKitaplar(int anlikkullaniciID)
		{
			return new EmanetlerDAL().AldigimKitaplar(anlikkullaniciID);
		}
	}
}
