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
	public partial class Kitaplar : Form
	{
		public Kitaplar()
		{
			InitializeComponent();
		}
		private void Kitaplar_Load(object sender, EventArgs e)
		{
			dataGridView1.DataSource = KitapBLL.KitaplariGetir();
			dataGridView1.ReadOnly = true;
			dateTimePicker2.Enabled = false;
			this.dataGridView1.Columns["KitapID"].Visible = false;

		}

		//Listele
		private void btnListele_Click(object sender, EventArgs e)
		{
			textBox1.Text = "";
			textBox2.Text = "";
			textBox3.Text = "";
			textBox4.Text = "";
			textBox7.Text = "";
			dateTimePicker2.Value = DateTime.Now;
			dataGridView1.DataSource = KitapBLL.KitaplariGetir();
		}

		//KitapAra
		private void btnAra_Click(object sender, EventArgs e)
		{
			dataGridView1.DataSource = KitapBLL.KitaplariGetir();
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

		//KitapStokDurum
		private void button2_Click(object sender, EventArgs e)
		{
			dataGridView1.DataSource = KitapBLL.KitapStokDurum();
		}

		//Kitap Ödünç Al
		private void button3_Click(object sender, EventArgs e)
		{
			try
			{
				int anlikkullaniciID = AnlikKullanici.ID;
				//GİRİŞ YAPAN KULLANICININ ID'SI ALINIR VE BLL'DEN DAL KATMANITA GÖDNERIRLIR ONA GÖRE SECTİĞİ KİTAP INSERT EDİLİR
				string KitapIDText = textBox1.Text.Trim();
				
				if(string.IsNullOrEmpty(KitapIDText)) 
					MessageBox.Show("Lütfen KİTAP SEÇİNİZ ","Warning",MessageBoxButtons.OK, MessageBoxIcon.Warning);
				
				else
				{
					if (!int.TryParse(KitapIDText, out var KitapID))
						MessageBox.Show("Geçersiz ID ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

					else{
						var sonuc = KitapBLL.KitapOduncAlma(KitapID, anlikkullaniciID);
						if (sonuc > 0){
							MessageBox.Show("Kitap Başarılıyla Alındı .\n\nBizi Sectiğiniz İçin Teşekkürler ", "Succesful", MessageBoxButtons.OK, MessageBoxIcon.Information);
							dataGridView1.DataSource = KitapBLL.KitaplariGetir();
						}
						else 
							MessageBox.Show("Birdaha Deneyiniz ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					}
				}		
			}
			catch(Exception ex)
			{
				MessageBox.Show("HATA : \n "+ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		//Yardım 
		private void button4_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Yardım İçin \n💡 +90-(XXX)-XXX-XX-XX \n Numarasından iletişime geçebilrsiniz .", "Destek",MessageBoxButtons.OK,MessageBoxIcon.Information);
		}

		private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
		{

			textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
			textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
			textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
			textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
			dateTimePicker2.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
			textBox7.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();

		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void label2_Click(object sender, EventArgs e)
		{

		}
	}
}
