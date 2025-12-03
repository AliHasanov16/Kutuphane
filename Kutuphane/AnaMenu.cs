using Kutuphane.DAL;
using System.Windows.Forms;



namespace Kutuphane
{
	public partial class AnaMenu : Form
	{
		private Point hedefKonum;
		public AnaMenu()
		{
			InitializeComponent();

			this.Opacity = 0;
			// Form ortadan baþlasýn
			this.StartPosition = FormStartPosition.CenterScreen;
			// Slide-in için baþlangýç konumu (yukarýdan)
			hedefKonum = this.Location;
			this.Location = new Point(hedefKonum.X, hedefKonum.Y - 100); // 100px yukarýdan baþla
																		 // Load olayýný yakala
			this.Load += AnaMenu_Load;
		}

		public void AnaMenu_Load(object sender, EventArgs e)
		{
			LoginFormm loginFormm = new LoginFormm(); loginFormm.Close();
			System.Windows.Forms.Timer t = new System.Windows.Forms.Timer();
			t.Interval = 20; // 20 ms aralýk

			t.Tick += (s, ev) =>
			{
				// Fade-in efekti
				if (this.Opacity < 1)
					this.Opacity += 0.05;

				// Slide-in efekti
				if (this.Top < hedefKonum.Y)
					this.Top += 5;

				// Her ikisi tamamlandý mý?
				if (this.Opacity >= 1 && this.Top >= hedefKonum.Y)
					t.Stop();
			};
			t.Start();
		}

		private void AnaMenu_FormClosing(object sender, FormClosingEventArgs e)
		{

		}

		private void btnCiks_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Çýkmak Ýstediðinize Emin misiniz ?", "Uyarý", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
				Application.Exit();
			else { }
		}

		private void btnAnaSayfa_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Ana Sayfa týklandý!");
		}
		private void btnUyeler_Click(object sender, EventArgs e)
		{
			Uyeler uyeler = new Uyeler();
			uyeler.Show();
		}
		private void btnKitaplar_Click(object sender, EventArgs e)
		{
			Kitaplar kitaplar = new Kitaplar();
			kitaplar.Show();
		}

		private void btnRaporlar_Click(object sender, EventArgs e)
		{
			Raporlar raporlar = new Raporlar();
			raporlar.Show();
		}


		private void button6_Click(object sender, EventArgs e)
		{
			adminPanel.Visible = false;
		}

		private void btnKapat_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Çýkmak Ýstediðinize Emin misiniz ?", "Uyarý", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
				Application.Exit();
		}

		private void btnEmanetler_Click(object sender, EventArgs e)
		{
			Emanetler emanetler = new Emanetler();
			emanetler.Show();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			AdminUyeIslemleri adminUyeIslemleri = new AdminUyeIslemleri();
			adminUyeIslemleri.Show();
		}

		private void button2_Click(object sender, EventArgs e)
		{

			AdminKitapIslemleri adminKitapIslemleri = new AdminKitapIslemleri();
			adminKitapIslemleri.Show();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			AdminEmanetIslemleri adminEmanetIslemleri = new AdminEmanetIslemleri();
			adminEmanetIslemleri.Show();
		}

		private void button5_Click(object sender, EventArgs e)
		{
			FrmKullanicilar frmKullanicilar = new FrmKullanicilar();
			frmKullanicilar.Show();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			Ayarlar ayarlar = new Ayarlar();
			ayarlar.Owner = this;
			ayarlar.Show();
		}

		private void groupBox1_Enter(object sender, EventArgs e)
		{
			// Form yüklenmeden önce
			this.StartPosition = FormStartPosition.Manual; // Manuel konumlandýrma
			this.Location = new Point(260, 197); // Sol üst köþeden x=50, y=100 konumu

		}

		private void button7_Click(object sender, EventArgs e)
		{

		}

		private void button7_Click_1(object sender, EventArgs e)
		{

		}


		private void kullaniciAdSoyad_Click(object sender, EventArgs e)
		{

		}

		private void adminPanel_Enter(object sender, EventArgs e)
		{

		}

		private void label11_Click(object sender, EventArgs e)
		{
			FrmAnlikKullaniciAyar frmAnlikKullaniciAyar = new FrmAnlikKullaniciAyar();
			frmAnlikKullaniciAyar.Show();
		}

		private void label11_MouseHover(object sender, EventArgs e)
		{
			label11.ForeColor = Color.Red;
		}

		private void label11_MouseLeave(object sender, EventArgs e)
		{
			label11.ForeColor = Color.Black;
		}

		#region ArkaPlan Ve Buton Rengi için
		public Color MenuArkaPlanRengi
		{
			get { return this.BackColor; }
			set { this.BackColor = value; }
		}
		public void TumButonlariRenkDegistir(Control parent, Color yeniRenk)
		{
			foreach (Control ctrl in parent.Controls)
			{
				if (ctrl is Button btn)
					btn.BackColor = yeniRenk;

				if (ctrl.HasChildren)
					TumButonlariRenkDegistir(ctrl, yeniRenk);
			}
		}
		#endregion

		private void btnKapat_MouseHover(object sender, EventArgs e)
		{
			btnKapat.BackColor = Color.Red;
			btnKapat.Width = 60;

		}
		private void btnKapat_MouseLeave(object sender, EventArgs e)
		{
			btnKapat.BackColor = Color.OldLace;
			btnKapat.Width = 40;
		}

		private void button7_Click_2(object sender, EventArgs e)
		{
			FrmAnlikKullaniciAyar frmAnlikKullaniciAyar = new FrmAnlikKullaniciAyar();
			frmAnlikKullaniciAyar.Show();
		}
	}
}
