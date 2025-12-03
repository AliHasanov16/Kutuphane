namespace Kutuphane
{
	partial class Uyeler
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
			dataGridView1 = new DataGridView();
			button4 = new Button();
			label3 = new Label();
			label2 = new Label();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			SuspendLayout();
			// 
			// dataGridView1
			// 
			dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Location = new Point(12, 52);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.Size = new Size(868, 423);
			dataGridView1.TabIndex = 2;
			dataGridView1.CellContentClick += dataGridView1_CellContentClick;
			// 
			// button4
			// 
			button4.BackColor = Color.White;
			button4.BackgroundImageLayout = ImageLayout.Stretch;
			button4.Cursor = Cursors.Hand;
			button4.FlatAppearance.BorderSize = 0;
			button4.FlatStyle = FlatStyle.Flat;
			button4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			button4.ForeColor = Color.Black;
			button4.ImageAlign = ContentAlignment.TopLeft;
			button4.Location = new Point(757, 12);
			button4.Name = "button4";
			button4.RightToLeft = RightToLeft.Yes;
			button4.Size = new Size(123, 30);
			button4.TabIndex = 8;
			button4.Text = "Ana Menüye Dön";
			button4.UseVisualStyleBackColor = false;
			button4.Click += button4_Click;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Yu Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
			label3.ForeColor = SystemColors.Control;
			label3.Location = new Point(312, 9);
			label3.Name = "label3";
			label3.Size = new Size(311, 27);
			label3.TabIndex = 5;
			label3.Text = "En fazla kitap alan Üyelerimiz";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
			label2.ForeColor = SystemColors.Control;
			label2.Location = new Point(299, 18);
			label2.Name = "label2";
			label2.Size = new Size(329, 24);
			label2.TabIndex = 4;
			label2.Text = "_____________________________";
			// 
			// Uyeler
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.ControlDarkDark;
			ClientSize = new Size(892, 494);
			ControlBox = false;
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(button4);
			Controls.Add(dataGridView1);
			FormBorderStyle = FormBorderStyle.Fixed3D;
			Name = "Uyeler";
			StartPosition = FormStartPosition.CenterScreen;
			Load += Uyeler_Load;
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private DataGridView dataGridView1;
		private Button button4;
		private Label label3;
		private Label label2;
	}
}