using Kutuphane.EL.Kullanicilar;
using KutuphaneBLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kutuphane
{
	public partial class LoginFormm : Form
	{
		public LoginFormm()
		{
			InitializeComponent();
		}

		//Otomatik Database,TABLO ve Kullanıcı Ekleme -- ProgramCS Taşındı En Mantıklı Yol
		private void LoginFormm_Load(object sender, EventArgs e)
		{	
			////Otoamtik Database ve Table Ekleme - PROGRAM CS EKLEMEK DAHA MANTIKLI YOKSA HERTURLU LOGINFORM EKRANA CAGIRIYOR
			//int dbtabloSonuc = BaglantiBLL.OtoKullaniciEkle();

			//if (dbtabloSonuc > 0){
			//	MessageBox.Show("DataBase ve Tablolar Otomatik Oluşturuldu . ", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

			//	//İlk once database ve tablo sonra admın yetkısınde bırısnı eklesın tabloya
			//	//Eğer kullanıcı listesinde kullanıcı yoksa otomatik admın yetkısınde kulanıcı ekler
			//	//0'dan birinisne uyg verıldıgınde uye olmaz, uye oto. eklesın 
			//	string kad = "admin";
			//	string sifre = "1234";
			//	var otokullaniciSonuc = KullanicilarBLL.OtoKullaniciEkle(kad, sifre);
			//	if (otokullaniciSonuc > 0)
			//	{
			//		MessageBox.Show("**** 💡 Giriş Yapmanız için Hesabınız oluşturulmuştur 💡 **** \n * Kullanici Adiniz : " + kad + ".\n *" +
			//			" Şifreniz : " + sifre, "Succesful", MessageBoxButtons.OK, MessageBoxIcon.Information);
			//	}
			//}
			
			//else if (dbtabloSonuc == 0){
			//	MessageBox.Show("Mevcut Database ve Tablolar Kontrol Edildi . \n Devam Edilebilir .", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
			//	//aynı işlemi burdada 1kere daha kontrol ettirdim cunkı eğer tablo var üye olmazsa ? eklesın diye
			//	string kad = "admin";
			//	string sifre = "1234";
			//	var otokullaniciSonuc = KullanicilarBLL.OtoKullaniciEkle(kad, sifre);
			//	if (otokullaniciSonuc > 0)
			//	{
			//		MessageBox.Show("**** 💡 Giriş Yapmanız için Hesabınız oluşturulmuştur 💡 **** \n * Kullanici Adiniz : " + kad + ".\n *" +
			//			" Şifreniz : " + sifre, "Succesful", MessageBoxButtons.OK, MessageBoxIcon.Information);
			//	}
			//}

			//else
			//{
					
			//	MessageBox.Show("Beklenmedik Hata Oluştu . /n Lütfen Tanımlayınız", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			//	FrmBaglanti frmBaglanti = new FrmBaglanti();
			//	frmBaglanti.Show();//Eğer bir bağlantı bulamazsada kullanıcının kendisi girer , veritabanı ADINI  Datasource fln 
				
			//}
		}

		//seeder
		//Kullanici Giriş
		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				string kad = textBox1.Text.Trim();
				string sifre = textBox2.Text.Trim();
				var sonuc = KullanicilarBLL.KullaniciGiris(kad, sifre);

				if (sonuc != null)
				{
					MessageBox.Show("Giriş Başarılı ", "Succesful", MessageBoxButtons.OK, MessageBoxIcon.Information);
					//Anlık KULLANİCİ BİLGİLERİNİ ALMA : GİRERKEN
					//Forma static class acılırki heryerden erişime acık olsun .
					//Burda girerken kontrol edilen ID'yı (Ad,Soyad) Alıp acılan statıc classdakı değişkenlere atılır .
					//ve bunlarda hangı uyenın işlem yaptığını gormek için yaptım .
					//
					AnlikKullanici.ID = Convert.ToInt32(sonuc.UyeID);
					AnlikKullanici.Ad = sonuc.UyeAdi.ToString();
					AnlikKullanici.Soyad = sonuc.UyeSoyadi.ToString();
					AnlikKullanici.KullaniciAdi = sonuc.KullaniciAdi.ToString();
					AnlikKullanici.KullaniciSifre = sonuc.KullaniciSifre.ToString();
					AnlikKullanici.KayitTarihi = sonuc.KayitTarihi;
					//İLK ÖNCE ATAMA YAPILIR SONRA ÇAĞIRILIR .
					//Anamenu formuna yazdırmak için
					AnaMenu anaMenu = new AnaMenu();
					anaMenu.Show();
					anaMenu.kullaniciAdSoyad.Text = "Hoşgeldiniz - " + AnlikKullanici.Ad + " " + AnlikKullanici.Soyad;
					//Ve direk burdan AnaMenudeki label'a değer atanır , rahatlıkla
					if (sonuc.YetkiDurumu == true)
					{
						anaMenu.adminPanel.Visible = true;
					}
				}
				else
				{
					MessageBox.Show("Böyle Bir Hesap Bulunmamaktadır . ", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
			catch (Exception ex)
			{
				{
					MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
			}
		}

		//Seeder -> using(...) 
		//KullaniciKaydol
		private void button2_Click(object sender, EventArgs e)
		{
			Kullanicilar k = new Kullanicilar();
			k.KullaniciAdi = textBox5.Text.Trim();
			k.KullaniciSifre = textBox6.Text.Trim();
			k.UyeAdi = textBox4.Text.Trim();
			k.UyeSoyadi = textBox3.Text.Trim();
			#region secim
			string y = comboBox1.Text.Trim();
			if (y == "Öğrenci") k.KullaniciTipID = 1;
			else if (y == "Standart") k.KullaniciTipID = 2;
			else if (y == "Akademisyen") k.KullaniciTipID = 3;
			#endregion

			if (k.KullaniciAdi == "" || k.KullaniciSifre == "" || k.UyeAdi == "" || k.UyeSoyadi == "" || y == "")
			{
				MessageBox.Show("Boş Alan Bırakmadığınıza Emin Olun ! ", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			int sonuc = KullanicilarBLL.KullaniciEkle(k);

			if (sonuc > 0)
			{
				MessageBox.Show("Kayıt Başarılı . ", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
				kaydol.Visible = false;
				label11.Visible = false;
				label12.Visible = false;
			}
			else MessageBox.Show("Boş Alan Bırakmadığınıza Emin Olun ! ", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
		}
		
		private void button3_Click(object sender, EventArgs e)
		{
			kaydol.Visible = false;
		}

		private void label4_Click(object sender, EventArgs e)
		{
			kaydol.Visible = true;
			label11.Visible = true;
			label12.Visible = true;
		}

		private void button4_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void label13_Click(object sender, EventArgs e)
		{
			label13.Visible = false;
			textBox2.UseSystemPasswordChar = false;
			label14.Visible = true;
		}

		private void label14_Click(object sender, EventArgs e)
		{
			label14.Visible = false;
			textBox2.UseSystemPasswordChar = true;
			label13.Visible = true;
		}

		private void button1_Enter(object sender, EventArgs e)
		{
		
		}
		private void kaydol_Enter(object sender, EventArgs e)
		{

		}
	}
}


