using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane.EL.Emanetler
{
    public class Emanetler
	{
		public int? EmanetID { get; set; }
		public int? KitapID { get; set; }
		public int? UyeID { get; set; }
		public DateTime? AlinanTarih { get; set; }
		public DateTime? İadeTarihi { get; set; }
		public int? Ceza { get; set; }
	}
}
