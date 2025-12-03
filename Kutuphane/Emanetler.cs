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
	public partial class Emanetler : Form
	{
		public Emanetler()
		{
			InitializeComponent();
		}

		private void Emanetler_Load(object sender, EventArgs e)
		{
			dataGridView1.DataSource = EmanetlerBLL.EnFazlaAlinanGetir();
			dataGridView1.ReadOnly = true;
		}

		private void button5_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnListele_Click(object sender, EventArgs e)
		{
			dataGridView1.DataSource = EmanetlerBLL.EnFazlaAlinanGetir();
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
			textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
			textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
			textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
			textBox8.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
		}

		//Emanet Kitap Arama
		private void button1_Click(object sender, EventArgs e)
		{
			string tur = "", yazar = "", kadi = "";
			if (!string.IsNullOrWhiteSpace(textBox1.Text)) kadi = textBox1.Text.Trim();
			if (!string.IsNullOrWhiteSpace(textBox2.Text)) tur = textBox2.Text.Trim();
			if (!string.IsNullOrWhiteSpace(textBox3.Text)) yazar = textBox3.Text.Trim();



			var sonuc = EmanetlerBLL.EnFazlaAlinanAra(kadi, tur, yazar);

			if (sonuc == null || sonuc.Count == 0) MessageBox.Show("Eşleşme Bulunamadı", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
			else dataGridView1.DataSource = sonuc;

		}

		//Yardım
		private void button4_Click(object sender, EventArgs e)
		{
			MessageBox.Show(
			"📘 **Kitap Ödünç Alma **\n\n" +
			"1️⃣ Anasayfa sekmesine gidin.\n" +
			"2️⃣ 'Kitaplar' menüsüne tıklayın.\n" +
			"3️⃣ Listeden istediğiniz kitabı seçin.\n" +
			"4️⃣ 'Kitap Ödünç Al' butonuna basın.\n\n" +
			"💡 İpucu : Stokta olmayan kitaplar yenilenecektir .",
			"Yardım", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		//Aldığım Kitaplar
		private void button2_Click(object sender, EventArgs e)
		{
			int anlikkullaniciID = AnlikKullanici.ID; // Giriş Yapan Kullanıcın İDsi
			var sonuc = EmanetlerBLL.AldigimKitaplar(anlikkullaniciID);

			if(sonuc.Count==null || sonuc.Count == 0)
				MessageBox.Show("Aldığınız Herhangi Bir Yoktur","Bilgilendirme",MessageBoxButtons.OK, MessageBoxIcon.Information);
			else
				dataGridView1.DataSource = sonuc;
		}
	}
}
