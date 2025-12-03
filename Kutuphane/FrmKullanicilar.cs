using Kutuphane.EL.Kullanicilar;
using KutuphaneBLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Kutuphane
{
	public partial class FrmKullanicilar : Form
	{
		public FrmKullanicilar()
		{
			InitializeComponent();
		}

		private void FrmKullanicilar_Load(object sender, EventArgs e)
		{
			dataGridView1.ReadOnly = true;
			dataGridView1.DataSource = KullanicilarBLL.KullanicilarGetir();
			this.dataGridView1.Columns["ID"].Visible = false;
			this.dataGridView1.Columns["UyeID"].Visible = false;
			this.dataGridView1.Columns["YetkiDurumu"].Visible = false;
			this.dataGridView1.Columns["TipID"].Visible = false;
			this.dataGridView1.Columns["Tipi"].Visible = false;
			this.dataGridView1.Columns["KullaniciTipID"].Visible = false;
		}

		//Listele
		private void button7_Click(object sender, EventArgs e)
		{
			textBox1.Clear();
			textBox2.Clear();
			textBox3.Clear();
			textBox4.Clear();
			textBox5.Clear();
			textBox6.Clear();
			textBox7.Clear();
			dateTimePicker2.Value = DateTime.Now;
			dataGridView1.DataSource = KullanicilarBLL.KullanicilarGetir();
		}

		//KullanıcılarListele
		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
			textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
			textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
			dateTimePicker2.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
			textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
			textBox5.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
			textBox6.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
			textBox7.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
		}

		//KullanıcılarSil
		private void button2_Click(object sender, EventArgs e)
		{
			int ID;
			if (!int.TryParse(textBox1.Text, out ID)) MessageBox.Show("Geçerli İD Giriniz .", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			int sonuc = KullanicilarBLL.KullaniciSil(ID);
			if (sonuc < 0) MessageBox.Show("Eşleşme bulunamadı .", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			else MessageBox.Show("Kullanıcı Silindi .", "Basarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
			dataGridView1.DataSource = KullanicilarBLL.KullanicilarGetir();
		}

		//KullanıcılarGuncelle
		private void btnn_Click(object sender, EventArgs e)
		{
			Kullanicilar k = new Kullanicilar();
			k.ID = Convert.ToInt32(textBox1.Text);
			k.KullaniciAdi = textBox2.Text;
			k.KullaniciSifre = textBox3.Text;
			k.KayitTarihi = dateTimePicker2.Value;
			k.UyeID = Convert.ToInt32(textBox4.Text);
			k.UyeAdi = textBox5.Text;
			k.UyeSoyadi = textBox6.Text;
			k.KullaniciTipID = Convert.ToInt32(textBox7.Text);

			if (k.KullaniciAdi == "" || k.KullaniciSifre == "" || k.UyeAdi == "" || k.UyeSoyadi == "")
				MessageBox.Show("Boş Alan Bırakmayınız .", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);

			int sonuc = KullanicilarBLL.KullaniciGuncelle(k);
			if (sonuc > 0) MessageBox.Show("Kullanıcı Güncellendi .", "Succesfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
			else MessageBox.Show("Hatalı İşlem Yaptınız", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			dataGridView1.DataSource = KullanicilarBLL.KullanicilarGetir();

		}

		//KullanıcıArama
		private void button5_Click(object sender, EventArgs e)
		{
			string aranan = "";
			if (!string.IsNullOrWhiteSpace(textBox2.Text)) aranan = textBox2.Text.Trim();
			else if (!string.IsNullOrWhiteSpace(textBox5.Text)) aranan = textBox5.Text.Trim();
			else if (!string.IsNullOrWhiteSpace(textBox6.Text)) aranan = textBox6.Text.Trim();

			if (string.IsNullOrWhiteSpace(aranan))
			{
				MessageBox.Show("Lütfen aramak istediğiniz bir Kullanıcı Adı , Uye Adı/Soyadı , Tip Giriniz ", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}


			var sonuc = KullanicilarBLL.KullaniciAra(aranan);
			if (sonuc == null || sonuc.Count == 0) MessageBox.Show("Eşleşme Bulunamadı ...", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);

			else dataGridView1.DataSource = sonuc;

		}
		
		private void button1_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void textBox3_TextChanged(object sender, EventArgs e)
		{

		}

	}
}
