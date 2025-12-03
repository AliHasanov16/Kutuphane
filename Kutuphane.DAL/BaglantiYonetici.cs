using Kutuphane.EL.Baglanti;
using Microsoft.Data.SqlClient;

namespace Kutuphane.DAL
{
	public static class BaglantiYonetici
	{
		public static SqlConnection BaglantiGetir(BaglantiEL b)
		{
			string conn = string.Format(@"Data Source={0};Initial Catalog={1};User ID={2};Password={3};TrustServerCertificate=True;",b.DataSource, b.InitialCatalog, b.SunucuAdi, b.Sifre);

			SqlConnection baglanti = new SqlConnection(conn);
			if (baglanti.State == System.Data.ConnectionState.Closed)
				baglanti.Open();

			return baglanti;
		}
	}
}
