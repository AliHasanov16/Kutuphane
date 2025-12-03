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
using System.Windows.Forms.DataVisualization.Charting;
namespace Kutuphane
{
	public partial class Raporlar : Form
	{
		public Raporlar()
		{
			InitializeComponent();
		}

		private void Raporlar_Load(object sender, EventArgs e)
		{

		}

		//Kitaplar Chart'ı
		private void button1_Click(object sender, EventArgs e)
		{
			chart2.Visible = false;
			chart3.Visible = false;

			var sonuc = KitapBLL.KitapChart1();

			// Chart temizleme
			chart1.Series.Clear();
			chart1.ChartAreas.Clear();
			chart1.Legends.Clear();

			// ChartArea oluştur ve arka planı formun arka planıyla aynı yap
			ChartArea area = new ChartArea();
			area.BackColor = SystemColors.Control;
			area.AxisX.MajorGrid.Enabled = false;  // X eksen çizgilerini kapat
			area.AxisY.MajorGrid.LineColor = Color.LightGray; // Y eksen çizgilerini açık gri yap
			area.AxisX.LabelStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
			area.AxisY.LabelStyle.Font = new Font("Segoe UI", 9, FontStyle.Regular);
			chart1.ChartAreas.Add(area);

			// Series oluştur
			Series series = new Series();
			series.Name = "Stok";
			series.ChartType = SeriesChartType.Column;
			series.IsXValueIndexed = true;
			series.Color = Color.FromArgb(0, 120, 215); // mavi, şık ve kontrast
			series["PixelPointWidth"] = "30"; // sütun genişliği

			// Veri ekleme
			foreach (var k in sonuc)
			{
				series.Points.AddXY(k.KitapAdi, k.Stok);
			}

			// Series’i Chart’a ekle
			chart1.Series.Add(series);

			// Legend kapat (opsiyonel)
			chart1.Legends.Clear();

			// Hover efekti (fare üstüne gelince renk değişmesi)
			chart1.MouseMove += (s, e) =>
			{
				HitTestResult result = chart1.HitTest(e.X, e.Y);
				if (result.ChartElementType == ChartElementType.DataPoint)
				{
					foreach (DataPoint dp in series.Points)
						dp.Color = Color.FromArgb(0, 120, 215); // önce tümünü resetle
					result.Series.Points[result.PointIndex].Color = Color.BurlyWood; // hover rengi
				}
				else
				{
					foreach (DataPoint dp in series.Points)
						dp.Color = Color.FromArgb(0, 120, 215); // normal renk
				}
			};

			chart1.Visible = true;
		}

		//İade Durum Chart'ı
		private void button2_Click(object sender, EventArgs e)
		{
			chart1.Visible = false;
			chart3.Visible=false;

			var sonuc = UyelerBLL.UyelerChart2();

			// Chart temizleme
			chart2.Series.Clear();
			chart2.ChartAreas.Clear();
			chart2.Legends.Clear();

			// ChartArea oluştur ve arka planı formun arka planıyla aynı yap
			ChartArea area = new ChartArea();
			area.BackColor = SystemColors.Control;
			area.AxisX.MajorGrid.Enabled = false;  // X eksen çizgilerini kapat
			area.AxisY.MajorGrid.LineColor = Color.LightGray; // Y eksen çizgilerini açık gri yap
			area.AxisX.LabelStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
			area.AxisY.LabelStyle.Font = new Font("Segoe UI", 9, FontStyle.Regular);
			chart2.ChartAreas.Add(area);

			// Series oluştur
			Series series = new Series();
			series.Name = "Stok";
			series.ChartType = SeriesChartType.Column;
			series.IsXValueIndexed = true;
			series.Color = Color.FromArgb(0, 120, 215); // mavi, şık ve kontrast
			series["PixelPointWidth"] = "30"; // sütun genişliği

			// Veri ekleme
			foreach (var k in sonuc)
			{
				series.Points.AddXY(k.Durum, k.Sayisi);
			}

			// Series’i Chart’a ekle
			chart2.Series.Add(series);

			// Legend kapat (opsiyonel)
			chart2.Legends.Clear();

			// Hover efekti (fare üstüne gelince renk değişmesi)
			chart2.MouseMove += (s, e) =>
			{
				HitTestResult result = chart2.HitTest(e.X, e.Y);
				if (result.ChartElementType == ChartElementType.DataPoint)
				{
					foreach (DataPoint dp in series.Points)
						dp.Color = Color.FromArgb(0, 120, 215); // önce tümünü resetle
					result.Series.Points[result.PointIndex].Color = Color.BurlyWood; // hover rengi
				}
				else
				{
					foreach (DataPoint dp in series.Points)
						dp.Color = Color.FromArgb(0, 120, 215); // normal renk
				}
			};

			chart2.Visible = true;

		}

		//En Fazla Alınan Kitap Chart'ı
		private void button3_Click(object sender, EventArgs e)
		{
			chart1.Visible = false;
			chart2.Visible = false;

			var sonuc = EmanetlerBLL.EnFazlaAlinanGetir();

			// Chart temizleme
			chart3.Series.Clear();
			chart3.ChartAreas.Clear();
			chart3.Legends.Clear();

			// ChartArea oluştur ve arka planı formun arka planıyla aynı yap
			ChartArea area = new ChartArea();
			area.BackColor = SystemColors.Control;
			area.AxisX.MajorGrid.Enabled = false;  // X eksen çizgilerini kapat
			area.AxisY.MajorGrid.LineColor = Color.LightGray; // Y eksen çizgilerini açık gri yap
			area.AxisX.LabelStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
			area.AxisY.LabelStyle.Font = new Font("Segoe UI", 9, FontStyle.Regular);
			chart3.ChartAreas.Add(area);

			// Series oluştur
			Series series = new Series();
			series.Name = "Stok";
			series.ChartType = SeriesChartType.Column;
			series.IsXValueIndexed = true;
			series.Color = Color.FromArgb(0, 120, 215); // mavi, şık ve kontrast
			series["PixelPointWidth"] = "30"; // sütun genişliği

			// Veri ekleme
			foreach (var k in sonuc)
			{
				series.Points.AddXY(k.KitapAdi, k.EnFazlaAlinan);
			}

			// Series’i Chart’a ekle
			chart3.Series.Add(series);

			// Legend kapat (opsiyonel)
			chart3.Legends.Clear();

			// Hover efekti (fare üstüne gelince renk değişmesi)
			chart3.MouseMove += (s, e) =>
			{
				HitTestResult result = chart3.HitTest(e.X, e.Y);
				if (result.ChartElementType == ChartElementType.DataPoint)
				{
					foreach (DataPoint dp in series.Points)
						dp.Color = Color.FromArgb(0, 120, 215); // önce tümünü resetle
					result.Series.Points[result.PointIndex].Color = Color.BurlyWood; // hover rengi
				}
				else
				{
					foreach (DataPoint dp in series.Points)
						dp.Color = Color.FromArgb(0, 120, 215); // normal renk
				}
			};

			chart3.Visible = true;
		}

		private void button4_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void chart2_Click(object sender, EventArgs e)
		{

		}
		private void chart1_Click(object sender, EventArgs e)
		{

		}
	}
}
