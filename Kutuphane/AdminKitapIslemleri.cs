using Kutuphane.EL.Kitap;
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
	public partial class AdminKitapIslemleri : Form
	{
		public AdminKitapIslemleri()
		{
			InitializeComponent();
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
			textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
			dateTimePicker1.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
			textBox7.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();

		}

		private void AdminKitapIslemleri_Load(object sender, EventArgs e)
		{
			dataGridView1.DataSource = KitapBLL.KitaplariGetir();
			dataGridView1.Columns[0].Visible = false;
			dataGridView1.ReadOnly = true;
		}

		//Kitap Ekleme
		private void btnListele_Click(object sender, EventArgs e)
		{
			try
			{
				Kitap k = new Kitap();
				k.KitapAdi = textBox2.Text;
				k.Tur = textBox3.Text;
				k.Yazar = textBox4.Text;
				k.BasimYili =dateTimePicker1.Value;
				k.Stok = int.Parse(textBox7.Text);
				

				int sonuc = KitapBLL.KitapEkle(k);

				if (sonuc > 0)
				{
					MessageBox.Show("Kitap başarıyla eklendi .", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
					dataGridView1.DataSource = KitapBLL.KitaplariGetir();
					
				}
				else
				{
					MessageBox.Show("Ekleme başarısız. Bilgileri kontrol edin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Hata: " + ex.Message);
			}
		}

		//Kitap Sil
		private void btnAra_Click(object sender, EventArgs e)
		{
			int KitapID;
			if (!int.TryParse(textBox1.Text, out KitapID))
			{
				MessageBox.Show("Lütfen geçerli bir Kitap ID girin.");
				return;
			}

			int sonuc = KitapBLL.KitapSil(KitapID);

			if (sonuc > 0)
			{
				MessageBox.Show("Kitap Silindi ", "Uyarı", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
			}
			else
			{
				MessageBox.Show("Kitap Silinmedi  ", "Hata", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
			}
			dataGridView1.DataSource = KitapBLL.KitaplariGetir();
		}

		//Kitap Guncelle
		private void button2_Click(object sender, EventArgs e)
		{
			try
			{
				Kitap k = new Kitap();
				k.KitapID = int.Parse(textBox1.Text);
				k.KitapAdi = textBox2.Text;
				k.Tur = textBox3.Text;
				k.Yazar = textBox4.Text;
				k.BasimYili = dateTimePicker1.Value;
				k.Stok = int.Parse(textBox7.Text);

				if (string.IsNullOrWhiteSpace(k.KitapAdi) || string.IsNullOrWhiteSpace(k.Tur) || string.IsNullOrWhiteSpace(k.Yazar))
					MessageBox.Show("Eksik Yer Bırakıldı .", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);

				else
				{
					var sonuc = KitapBLL.KitapGuncelle(k);
					MessageBox.Show(sonuc.Icerik, "Uyarı", MessageBoxButtons.OK);
					dataGridView1.DataSource = KitapBLL.KitaplariGetir();
				}
			}
			catch
			{
				MessageBox.Show("Güncellenmesini İstediğiniz Bir Kitabı Seçiniz .", "Uyarı", MessageBoxButtons.OK);

			}
		}

		//Kitap Arama
		private void button3_Click(object sender, EventArgs e)
		{
			string aranan = "";

			// Hangi textbox doluysa onu kullan
			if (!string.IsNullOrWhiteSpace(textBox2.Text)) aranan = textBox2.Text.Trim();
			else if (!string.IsNullOrWhiteSpace(textBox4.Text)) aranan = textBox4.Text.Trim();
			else if (!string.IsNullOrWhiteSpace(textBox3.Text)) aranan = textBox3.Text.Trim();

			if (string.IsNullOrWhiteSpace(aranan)) { MessageBox.Show("Lütfen aramak istediğiniz bir Kitap Adı , Tür , Yazar girin ", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
		

			var sonuc = KitapBLL.KitapAra(aranan);

			if (sonuc.Count == 0) MessageBox.Show("Eşleşen kayıt bulunamadı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
			else dataGridView1.DataSource = sonuc;

		}

		private void button4_Click(object sender, EventArgs e)
		{
			textBox1.Text = "";
			textBox2.Text = "";
			textBox3.Text = "";
			textBox4.Text = "";
			textBox7.Text = "";
			dateTimePicker1.Text = "";
			dataGridView1.DataSource = KitapBLL.KitaplariGetir();

		}
	}
}
