using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane.EL.ViewModels
{
	public class EmanetlerCeza
	{
		public string? AdiSoyadi { get; set; }
		public string? KitapAdi { get; set; }
		public DateTime? AlinanTarih { get; set; }
		public DateTime? İadeTarihi { get; set; }
		public int? Ceza { get; set; }
	}
}
