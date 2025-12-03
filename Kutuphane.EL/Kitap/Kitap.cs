using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane.EL.Kitap
{
	public class Kitap
	{
		public int KitapID { get; set; }
		public string KitapAdi { get; set; }
		public string Tur { get; set; }
		public string Yazar { get; set; }
		public DateTime? BasimYili { get; set; }
		public int Stok { get; set; }
	}
}
