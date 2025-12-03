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
	public partial class FrmAnlikKullaniciAyar : Form
	{
		public FrmAnlikKullaniciAyar()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		//Kaydet
		private void button2_Click(object sender, EventArgs e)
		{
			try
			{

				int anlikkullaniciID = AnlikKullanici.ID;
				string uyead = txtuyeAd.Text;
				string uyesoyad = txtuyeSOyad.Text;
				string kad = txtKullaniciAd.Text;
				string ksifre = txtKullaniciSifre.Text;
				var sonuc = KullanicilarBLL.AnlikKullaniciGuncelle(anlikkullaniciID, uyead, uyesoyad, kad, ksifre);
				if (sonuc > 0)
					MessageBox.Show("Başarıyla Kaydedildi ", "Succesful", MessageBoxButtons.OK, MessageBoxIcon.Information);
				else
					MessageBox.Show("Kaydedilemedi ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

			}
			catch (Exception ex)
			{
				MessageBox.Show("HATA :\n" + ex.Message, "Succesful", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		private void FrmAnlikKullaniciAyar_Load(object sender, EventArgs e)
		{
			txtuyeAd.Text =	AnlikKullanici.Ad.ToString();
			txtuyeSOyad.Text = AnlikKullanici.Soyad.ToString();
			txtKullaniciAd.Text = AnlikKullanici.KullaniciAdi.ToString();
			txtKullaniciSifre.Text = AnlikKullanici.KullaniciSifre.ToString();
			label5.Text = "Kayıt Tarihi : " +AnlikKullanici.KayitTarihi.ToShortDateString();
		}
	}
}
