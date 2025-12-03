using KutuphaneBLL;

namespace Kutuphane
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

			//Eðer BaðlantýKuramazsa SQLBaðlanma Formunu Getirir Applýactýon Run ile 
			//Eðer Sýkýntý Yoksa Connectionda o zaman Logýn Formu getirir
			#region Otomatik Veritabaný ve Tablo olusturma . Eðer admin rolunde UYE yoksa Otomatik Uye Ekleme 

			//Otoamtik Database ve Table Ekleme
			int dbtabloSonuc = BaglantiBLL.OtoKullaniciEkle(); 

			if (dbtabloSonuc > 0)
			{
				MessageBox.Show("DataBase ve Tablolar Otomatik Oluþturuldu . ", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

				//Ýlk once database ve tablo sonra admýn yetkýsýnde býrýsný eklesýn tabloya
				//Eðer kullanýcý listesinde kullanýcý yoksa otomatik admýn yetkýsýnde kulanýcý ekler
				//0'dan birinisne uyg verýldýgýnde uye olmaz, uye oto. eklesýn 
				string kad = "admin";
				string sifre = "1234";
				var otokullaniciSonuc = KullanicilarBLL.OtoKullaniciEkle(kad, sifre);
				if (otokullaniciSonuc > 0)
				{
					MessageBox.Show("**** ?? Giriþ Yapmanýz için Hesabýnýz oluþturulmuþtur ?? **** \n * Kullanici Adiniz : " + kad + ".\n *" +
						" Þifreniz : " + sifre, "Succesful", MessageBoxButtons.OK, MessageBoxIcon.Information);
					Application.Run(new LoginFormm());
				}
			}
	
			else if (dbtabloSonuc == 0)
			{
				//ayný iþlemi burdada 1kere daha kontrol ettirdim cunký eðer tablo var üye olmazsa ? eklesýn diye
				string kad = "admin";
				string sifre = "1234";
				var otokullaniciSonuc = KullanicilarBLL.OtoKullaniciEkle(kad, sifre);
				Application.Run(new LoginFormm());
				if (otokullaniciSonuc > 0)
				{
					MessageBox.Show("**** ?? Giriþ Yapmanýz için Hesabýnýz oluþturulmuþtur ?? **** \n * Kullanici Adiniz : " + kad + ".\n *" +
						" Þifreniz : " + sifre, "Succesful", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}

			else{	
				MessageBox.Show("Beklenmedik Hata Oluþtu . \nLütfen Baðlantý Adresini Tanýmlayýnýz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				Application.Run(new FrmBaglanti());
			}
			#endregion
		
		}
	}
}