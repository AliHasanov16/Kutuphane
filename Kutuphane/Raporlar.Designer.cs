namespace Kutuphane
{
	partial class Raporlar
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
			label3 = new Label();
			label2 = new Label();
			button1 = new Button();
			button4 = new Button();
			button2 = new Button();
			button3 = new Button();
			chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
			chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
			chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
			((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
			((System.ComponentModel.ISupportInitialize)chart2).BeginInit();
			((System.ComponentModel.ISupportInitialize)chart3).BeginInit();
			SuspendLayout();
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Yu Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
			label3.Location = new Point(13, 16);
			label3.Name = "label3";
			label3.Size = new Size(98, 27);
			label3.TabIndex = 7;
			label3.Text = "Raporlar";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
			label2.Location = new Point(14, 24);
			label2.Name = "label2";
			label2.Size = new Size(164, 24);
			label2.TabIndex = 6;
			label2.Text = "______________";
			// 
			// button1
			// 
			button1.BackColor = SystemColors.ButtonHighlight;
			button1.BackgroundImageLayout = ImageLayout.Stretch;
			button1.Cursor = Cursors.Hand;
			button1.FlatAppearance.BorderSize = 0;
			button1.FlatStyle = FlatStyle.Flat;
			button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			button1.ForeColor = Color.Black;
			button1.ImageAlign = ContentAlignment.TopLeft;
			button1.Location = new Point(14, 49);
			button1.Name = "button1";
			button1.RightToLeft = RightToLeft.Yes;
			button1.Size = new Size(120, 30);
			button1.TabIndex = 8;
			button1.Text = "Kitaplar";
			button1.UseVisualStyleBackColor = false;
			button1.Click += button1_Click;
			// 
			// button4
			// 
			button4.BackColor = SystemColors.ButtonHighlight;
			button4.BackgroundImageLayout = ImageLayout.Stretch;
			button4.Cursor = Cursors.Hand;
			button4.FlatAppearance.BorderSize = 0;
			button4.FlatStyle = FlatStyle.Flat;
			button4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			button4.ForeColor = Color.Black;
			button4.ImageAlign = ContentAlignment.TopLeft;
			button4.Location = new Point(742, 49);
			button4.Name = "button4";
			button4.RightToLeft = RightToLeft.Yes;
			button4.Size = new Size(131, 30);
			button4.TabIndex = 11;
			button4.Text = "Ana Menüye Dön";
			button4.UseVisualStyleBackColor = false;
			button4.Click += button4_Click;
			// 
			// button2
			// 
			button2.BackColor = SystemColors.ButtonHighlight;
			button2.BackgroundImageLayout = ImageLayout.Stretch;
			button2.Cursor = Cursors.Hand;
			button2.FlatAppearance.BorderSize = 0;
			button2.FlatStyle = FlatStyle.Flat;
			button2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			button2.ForeColor = Color.Black;
			button2.ImageAlign = ContentAlignment.TopLeft;
			button2.Location = new Point(140, 49);
			button2.Name = "button2";
			button2.RightToLeft = RightToLeft.Yes;
			button2.Size = new Size(120, 30);
			button2.TabIndex = 9;
			button2.Text = "İade Durumları";
			button2.UseVisualStyleBackColor = false;
			button2.Click += button2_Click;
			// 
			// button3
			// 
			button3.BackColor = SystemColors.ButtonHighlight;
			button3.BackgroundImageLayout = ImageLayout.Stretch;
			button3.Cursor = Cursors.Hand;
			button3.FlatAppearance.BorderSize = 0;
			button3.FlatStyle = FlatStyle.Flat;
			button3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			button3.ForeColor = Color.Black;
			button3.ImageAlign = ContentAlignment.TopLeft;
			button3.Location = new Point(266, 49);
			button3.Name = "button3";
			button3.RightToLeft = RightToLeft.Yes;
			button3.Size = new Size(120, 30);
			button3.TabIndex = 10;
			button3.Text = "En Fazla Alinan";
			button3.UseVisualStyleBackColor = false;
			button3.Click += button3_Click;
			// 
			// chart1
			// 
			chartArea1.Name = "ChartArea1";
			chart1.ChartAreas.Add(chartArea1);
			legend1.Name = "Legend1";
			chart1.Legends.Add(legend1);
			chart1.Location = new Point(14, 110);
			chart1.Name = "chart1";
			series1.ChartArea = "ChartArea1";
			series1.Legend = "Legend1";
			series1.Name = "Series1";
			chart1.Series.Add(series1);
			chart1.Size = new Size(859, 300);
			chart1.TabIndex = 12;
			chart1.Text = "chart1";
			chart1.Visible = false;
			chart1.Click += chart1_Click;
			// 
			// chart2
			// 
			chartArea2.Name = "ChartArea1";
			chart2.ChartAreas.Add(chartArea2);
			legend2.Name = "Legend1";
			chart2.Legends.Add(legend2);
			chart2.Location = new Point(14, 110);
			chart2.Name = "chart2";
			series2.ChartArea = "ChartArea1";
			series2.Legend = "Legend1";
			series2.Name = "Series1";
			chart2.Series.Add(series2);
			chart2.Size = new Size(859, 300);
			chart2.TabIndex = 13;
			chart2.Text = "chart2";
			chart2.Visible = false;
			chart2.Click += chart2_Click;
			// 
			// chart3
			// 
			chartArea3.Name = "ChartArea1";
			chart3.ChartAreas.Add(chartArea3);
			legend3.Name = "Legend1";
			chart3.Legends.Add(legend3);
			chart3.Location = new Point(12, 110);
			chart3.Name = "chart3";
			series3.ChartArea = "ChartArea1";
			series3.Legend = "Legend1";
			series3.Name = "Series1";
			chart3.Series.Add(series3);
			chart3.Size = new Size(859, 300);
			chart3.TabIndex = 14;
			chart3.Text = "chart3";
			chart3.Visible = false;
			// 
			// Raporlar
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.Control;
			ClientSize = new Size(885, 482);
			ControlBox = false;
			Controls.Add(chart3);
			Controls.Add(chart2);
			Controls.Add(chart1);
			Controls.Add(button4);
			Controls.Add(button3);
			Controls.Add(button2);
			Controls.Add(button1);
			Controls.Add(label3);
			Controls.Add(label2);
			FormBorderStyle = FormBorderStyle.Fixed3D;
			Name = "Raporlar";
			StartPosition = FormStartPosition.CenterScreen;
			Load += Raporlar_Load;
			((System.ComponentModel.ISupportInitialize)chart1).EndInit();
			((System.ComponentModel.ISupportInitialize)chart2).EndInit();
			((System.ComponentModel.ISupportInitialize)chart3).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label3;
		private Label label2;
		private Button button1;
        private Button button4;
		private Button button2;
		private Button button3;
		private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
		private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
		private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
	}
}