using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace Kutuphane.DAL
{
	public class HaraketlerDAL
	{

		SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-CU679RN\SQLEXPRESS01;Initial Catalog=KutuphaneDB;Integrated Security=True;Trust Server Certificate=True");
		public HaraketlerDAL() { }

	}
}
