using Kutuphane.EL.Emanetler;
using KutuphaneBLL;
using Microsoft.Data.SqlClient;
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
	public partial class AdminEmanetIslemleri : Form
	{
		public AdminEmanetIslemleri()
		{
			InitializeComponent();
		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
			textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
			textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
			dateTimePicker1.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
			dateTimePicker2.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
			textBox7.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
		}

		private void AdminEmanetIslemleri_Load(object sender, EventArgs e)
		{
			dataGridView1.DataSource = EmanetlerBLL.EmanetleriGetir();
			dataGridView1.ReadOnly = true;
			this.dataGridView1.Columns["EmanetID"].Visible = false;
		}

		//EmanetlerEkleme
		private void button6_Click(object sender, EventArgs e)
		{
			try
			{
				Kutuphane.EL.Emanetler.Emanetler ee = new Kutuphane.EL.Emanetler.Emanetler();
				ee.KitapID = Convert.ToInt32(textBox2.Text);
				ee.UyeID = Convert.ToInt32(textBox3.Text);
				ee.AlinanTarih = dateTimePicker1.Value;
				ee.İadeTarihi = dateTimePicker2.Value;
				ee.Ceza = Convert.ToInt32(textBox7.Text);

				var sonuc = EmanetlerBLL.EmanetlerEkle(ee);

				if (sonuc > 0) MessageBox.Show("İşlem Başarılı ", "Succesful", MessageBoxButtons.OK, MessageBoxIcon.Information);
				else MessageBox.Show("Hatalı İşlem", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);

			}
			catch (Exception ex)
			{
				MessageBox.Show("Boş Alan Bırakmayınız .", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		//EmanetlerSİLME
		private void button2_Click(object sender, EventArgs e)
		{
			int EmanetID;

			if (!int.TryParse(textBox1.Text, out EmanetID)) { MessageBox.Show("Geçerli Bir İD Girin .", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
			int sonuc = EmanetlerBLL.EmanetlerSil(EmanetID);
			if (sonuc < 0) MessageBox.Show("Silinecek İD Eşleşeni bulunamadı", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			else
			{
				MessageBox.Show("Başarıyla Silindi", "Succesful", MessageBoxButtons.OK, MessageBoxIcon.Stop);
				dataGridView1.DataSource = EmanetlerBLL.EmanetleriGetir();
			}
		}

		//EmanetlerGüncelleme
		private void btnn_Click(object sender, EventArgs e)
		{
			try
			{
				Kutuphane.EL.Emanetler.Emanetler ee = new Kutuphane.EL.Emanetler.Emanetler();
				ee.EmanetID = Convert.ToInt32(textBox1.Text);
				ee.KitapID = Convert.ToInt32(textBox2.Text);
				ee.UyeID = Convert.ToInt32(textBox3.Text);
				ee.AlinanTarih = dateTimePicker1.Value;
				ee.İadeTarihi = dateTimePicker2.Value;
				ee.Ceza = Convert.ToInt32(textBox7.Text);

				var sonuc = EmanetlerBLL.EmanetGuncelle(ee);

				if (sonuc < 0) MessageBox.Show("Hatalı işlem yaptınız Kontrol Edınız", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Information);
				else
				{
					MessageBox.Show("İşlem Başarılı .", "Succesful", MessageBoxButtons.OK, MessageBoxIcon.Information);
					dataGridView1.DataSource = EmanetlerBLL.EmanetleriGetir();
				}

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		//EmanetlerArama
		private void button5_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(textBox2.Text))
			{
				MessageBox.Show("Lütfen aramak istediğiniz KitapID veya ÜyeID değerini giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			if (!int.TryParse(textBox2.Text.Trim(), out int aranan))
			{
				MessageBox.Show("Lütfen sadece sayı giriniz.", "Hatalı Giriş", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
			}

			var sonuc = EmanetlerBLL.EmanetlerAra(aranan);

			if (sonuc == null || sonuc.Count == 0)
			{
				MessageBox.Show("Eşleşme bulunamadı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				dataGridView1.DataSource = sonuc;
			}
		}

		//EmanetlerCeza çağırma sadece 1 satır . Butona Basıldığında UI(Buton.Click) --> BLL --> DAL (Veritabanı İşlemleri)--> BLL --> UI
		private void button3_Click(object sender, EventArgs e)
		{
			dataGridView1.DataSource = EmanetlerBLL.EmanetlerCeza();
		}

		private void button7_Click(object sender, EventArgs e)
		{
			dataGridView1.DataSource = EmanetlerBLL.EmanetleriGetir();
		}
	}
}
