using Kutuphane.EL.Baglanti;
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
	public partial class FrmBaglanti : Form
	{
		public FrmBaglanti()
		{
			InitializeComponent();
		}

		private void btnCik_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void btnBaglan_Click(object sender, EventArgs e)
		{
			#region Eski Yazdığım
			//try
			//{
			//	//if (string.IsNullOrWhiteSpace(txtDataSource.Text) || string.IsNullOrWhiteSpace(txtİnitialCatalog.Text) || string.IsNullOrWhiteSpace(txtSunucuAdi.Text) || string.IsNullOrWhiteSpace(txtSifre.Text))
			//{
			//	MessageBox.Show("Boş Alan Bırakmayınız", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
			//}
			//else
			//{

			//BaglantiEL b = new BaglantiEL();
			//b.DataSource = txtDataSource.Text.Trim();
			//b.InitialCatalog = txtİnitialCatalog.Text.Trim();
			//b.SunucuAdi = txtSunucuAdi.Text.Trim();
			//b.Sifre = txtSifre.Text.Trim();

			//var sonuc = BaglantiBLL.BAGLAN(b);

			//if (sonuc == null || sonuc <= 0)
			//{
			//	MessageBox.Show("Bağlantı Yanlış", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
			//}
			//else
			//{
			//	MessageBox.Show("Başarılı", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
			//	LoginFormm loginFormm = new LoginFormm();
			//	loginFormm.Show();
			//}

			//GPT
			#endregion

			BaglantiEL b = new BaglantiEL();
			b.DataSource = txtDataSource.Text.Trim();
			b.InitialCatalog = txtİnitialCatalog.Text.Trim();
			b.SunucuAdi = txtSunucuAdi.Text.Trim();
			b.Sifre = txtSifre.Text.Trim();

			if (string.IsNullOrWhiteSpace(txtDataSource.Text) || string.IsNullOrWhiteSpace(txtİnitialCatalog.Text) || string.IsNullOrWhiteSpace(txtSunucuAdi.Text) || string.IsNullOrWhiteSpace(txtSifre.Text))
			{
				MessageBox.Show("Boş Alan Bırakmayınız", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				// 🔹 Önce bağlantı test edilir
				bool testSonuc = BaglantiBLL.BaglantiTest(b);
				if (!testSonuc)
				{
					MessageBox.Show("Bağlantı başarısız! Lütfen bilgileri kontrol edin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}

				// 🔹 Eğer bağlantı başarılıysa kaydet
				int sonuc = BaglantiBLL.BAGLAN(b);

				if (sonuc > 0)
				{
					MessageBox.Show("Bağlantı başarılı !", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
					LoginFormm loginFormm = new LoginFormm();
					loginFormm.Show();
					this.Hide();
				}
				else
					MessageBox.Show("Bağlantı test geçti ama kayıt başarısız!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			//}
			//}
			//catch (Exception ex)
			//{
			//	MessageBox.Show("Bağlantı Kuruluamadı ", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
			//}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			txtSifre.UseSystemPasswordChar = false;
			button2.Visible = true;
			button1.Visible = false;
			txtSifre.Focus();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			txtSifre.UseSystemPasswordChar = true;
			button1.Visible = true;
			button2.Visible = false;
			txtSifre.Focus();
		}

		private void FrmBaglanti_Load(object sender, EventArgs e)
		{

		}
	}
}