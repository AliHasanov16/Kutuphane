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
	public partial class Uyeler : Form
	{
		public Uyeler()
		{
			InitializeComponent();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void Uyeler_Load(object sender, EventArgs e)
		{
			dataGridView1.ReadOnly = true;
			dataGridView1.DataSource = UyelerBLL.UyeTopGetir();

			// Genel arka plan
			dataGridView1.BackgroundColor = Color.FromArgb(64, 64, 64); // orta gri
			dataGridView1.BorderStyle = BorderStyle.None;
			dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
			dataGridView1.GridColor = dataGridView1.BackgroundColor;

			// Satır yüksekliği
			dataGridView1.RowTemplate.Height = 30;

			// Sütun başlıkları (Header)
			dataGridView1.EnableHeadersVisualStyles = false; // default stil devre dışı
			dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(80, 80, 80); // header gri
			dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
			dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
			dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None; // kenar çizgisiz

			// Hücre stili
			dataGridView1.DefaultCellStyle.BackColor = Color.FromArgb(64, 64, 64); // hücre gri
			dataGridView1.DefaultCellStyle.ForeColor = Color.White;
			dataGridView1.DefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Regular);
			dataGridView1.DefaultCellStyle.SelectionBackColor = Color.FromArgb(96, 96, 96); // seçilen satır koyu gri
			dataGridView1.DefaultCellStyle.SelectionForeColor = Color.White;

			// AlternatingRows (opsiyonel ama sade olur)
			dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(70, 70, 70);

			// Satır başlıklarını gizle
			dataGridView1.RowHeadersVisible = false;

			// Otomatik sütun genişliği
			dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
	}
}
