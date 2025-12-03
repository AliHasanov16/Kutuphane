using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane.EL.Kullanicilar
{
    public class Kullanicilar
	{
		public int? ID { get; set; }
		public string? KullaniciAdi { get; set; }
		public string? KullaniciSifre { get; set; }
		public DateTime KayitTarihi { get; set; }
		public int? UyeID { get; set; }
		public string? UyeAdi { get; set; }
		public string? UyeSoyadi { get; set; }
		public int KullaniciTipID { get; set; }

		//Kullanıcı TABLOSU İÇİNNN --- JOINN
		public int? TipID { get; set; }
		public string? Tipi { get; set; }
		public Boolean YetkiDurumu { get; set;}
		//


	}
}
