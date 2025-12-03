using Kutuphane.EL.Kitap;
using Kutuphane.EL.Uyeler;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Kutuphane
{
	public partial class AdminUyeIslemleri : Form
	{
		public AdminUyeIslemleri()
		{
			InitializeComponent();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
			textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
			textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
			comboBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();

		}

		private void AdminUyeIslemleri_Load(object sender, EventArgs e)
		{
			dataGridView1.DataSource = UyelerBLL.UyelerGetir();
			dataGridView1.ReadOnly = true;
			this.dataGridView1.Columns["UyeID"].Visible = false;
		}

		//Uye EKle
		//BLL'den veri alındı ve tabloya işlendi.
		private void btnUyeEkle_Click(object sender, EventArgs e)
		{

			Kutuphane.EL.Uyeler.Uyeler u = new Kutuphane.EL.Uyeler.Uyeler();
			u.UyeAdi = textBox2.Text;
			u.UyeSoyadi = textBox3.Text;
			u.UyeTipi = comboBox1.Text;

			if (u.UyeAdi == "" || u.UyeTipi == "" || u.UyeSoyadi == "") MessageBox.Show("Boş Alan Bırakmayınız . ", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);

			int sonuc = UyelerBLL.UyeEkle(u);
			if (sonuc > 0) MessageBox.Show("Üye Başarıyla Eklendi . ", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
			else MessageBox.Show("Hatalı Ekleme Yapıtınız . ", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);

			dataGridView1.DataSource = UyelerBLL.UyelerGetir();

		}
		
		//Üye SİLME
		private void button1_Click(object sender, EventArgs e)
		{

			int UyeID;
			if (!int.TryParse(textBox1.Text, out UyeID)) { MessageBox.Show("Geçerli Bir İD Girin .", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

			int sonuc = UyelerBLL.UyeSil(UyeID);
			if (sonuc > 0) MessageBox.Show("Üye Silindi . ", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
			else MessageBox.Show("Hatalı İşlem Yaptınız . ", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

			dataGridView1.DataSource = UyelerBLL.UyelerGetir();

		}
		//Uye Guncelleme
		private void button2_Click(object sender, EventArgs e)
		{
			try
			{
				Kutuphane.EL.Uyeler.Uyeler u = new Kutuphane.EL.Uyeler.Uyeler();
				u.UyeAdi = textBox2.Text;
				u.UyeSoyadi = textBox3.Text;
				u.UyeTipi = comboBox1.Text;
				u.UyeID = Convert.ToInt32(textBox1.Text);

				var sonuc = UyelerBLL.UyeGuncelle(u);
				if (sonuc <= 0) MessageBox.Show("Hatalı İŞLEM .", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				else MessageBox.Show("İşlem Başarılı", "Succesful", MessageBoxButtons.OK, MessageBoxIcon.Information);

				dataGridView1.DataSource = UyelerBLL.UyelerGetir();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Hata", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		//Uye Arama
		private void button3_Click(object sender, EventArgs e)
		{
			string aranan = "";

			if (!string.IsNullOrWhiteSpace(textBox2.Text)) aranan = textBox2.Text.Trim();
			else if (!string.IsNullOrWhiteSpace(textBox3.Text)) aranan = textBox3.Text.Trim();
			else if (!string.IsNullOrWhiteSpace(comboBox1.Text)) aranan = comboBox1.Text.Trim();

			if (string.IsNullOrWhiteSpace(aranan)) { MessageBox.Show("Lütfen aramak istediğiniz bir Kitap Adı , Tür , Yazar girin ", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }


			var sonuc = UyelerBLL.UyeAra(aranan);

			if (sonuc.Count == 0) MessageBox.Show("Eşleşen Kayıt Bulunamadı ", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
			else dataGridView1.DataSource = sonuc;

		}

		private void btnYenile_Click(object sender, EventArgs e)
		{
			textBox1.Text = "";
			textBox2.Text = "";
			textBox3.Text = "";
			comboBox1.Text = "";
			dataGridView1.DataSource = UyelerBLL.UyelerGetir();
		}
	}
}
