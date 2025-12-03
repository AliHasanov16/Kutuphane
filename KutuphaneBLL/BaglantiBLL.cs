using Kutuphane.DAL;
using Kutuphane.EL.Baglanti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneBLL
{
	public static class BaglantiBLL
	{
		public static bool BaglantiTest(BaglantiEL b)
		{
			return new BaglantiDAL().BaglantiTest(b);
		}
		public static int BAGLAN(BaglantiEL b)/*string dsource, string icatalot, string sadi, string sifre*/
		{
			return new BaglantiDAL().BAGLAN(b);
		}

		//Otomatik Database ve Table Oluşturma .
		public static int OtoKullaniciEkle() {
			return new BaglantiDAL().OtoKullaniciEkle();
		}
	}
}
