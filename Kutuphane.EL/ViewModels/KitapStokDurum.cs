using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane.EL.ViewModels
{
	public class KitapStokDurum
	{
		public string? KitapAdi { get; set; }
		public string? Tur { get; set; }
		public string? Yazar { get; set; }
		public int Stok { get; set; }
		public string StokDurumu { get; set; }
	}
}
