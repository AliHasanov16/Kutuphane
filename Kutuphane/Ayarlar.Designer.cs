namespace Kutuphane
{
	partial class Ayarlar
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
			label4 = new Label();
			label3 = new Label();
			button1 = new Button();
			label1 = new Label();
			button2 = new Button();
			button3 = new Button();
			label2 = new Label();
			button4 = new Button();
			SuspendLayout();
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Bahnschrift Condensed", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
			label4.Location = new Point(330, 9);
			label4.Name = "label4";
			label4.Size = new Size(116, 33);
			label4.TabIndex = 10;
			label4.Text = " - Ayarlar -";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Stencil", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
			label3.Location = new Point(-1, 10);
			label3.Name = "label3";
			label3.Size = new Size(810, 22);
			label3.TabIndex = 9;
			label3.Text = "________________________________________________________________________________";
			// 
			// button1
			// 
			button1.BackColor = Color.Khaki;
			button1.BackgroundImageLayout = ImageLayout.Stretch;
			button1.Cursor = Cursors.Hand;
			button1.FlatAppearance.BorderSize = 0;
			button1.FlatStyle = FlatStyle.Flat;
			button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			button1.ForeColor = Color.Black;
			button1.ImageAlign = ContentAlignment.MiddleLeft;
			button1.Location = new Point(685, 408);
			button1.Name = "button1";
			button1.RightToLeft = RightToLeft.Yes;
			button1.Size = new Size(111, 30);
			button1.TabIndex = 11;
			button1.Text = "Çık";
			button1.UseVisualStyleBackColor = false;
			button1.Click += button1_Click;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label1.Location = new Point(3, 55);
			label1.Name = "label1";
			label1.Size = new Size(49, 16);
			label1.TabIndex = 12;
			label1.Text = "Tema :";
			// 
			// button2
			// 
			button2.BackColor = Color.Lavender;
			button2.BackgroundImageLayout = ImageLayout.Stretch;
			button2.Cursor = Cursors.Hand;
			button2.FlatAppearance.BorderSize = 0;
			button2.FlatStyle = FlatStyle.System;
			button2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			button2.ForeColor = Color.Black;
			button2.ImageAlign = ContentAlignment.MiddleLeft;
			button2.Location = new Point(54, 52);
			button2.Name = "button2";
			button2.RightToLeft = RightToLeft.No;
			button2.Size = new Size(111, 23);
			button2.TabIndex = 14;
			button2.Text = "Seç....";
			button2.UseVisualStyleBackColor = false;
			button2.Click += button2_Click;
			// 
			// button3
			// 
			button3.BackColor = Color.Khaki;
			button3.BackgroundImageLayout = ImageLayout.Stretch;
			button3.Cursor = Cursors.Hand;
			button3.FlatAppearance.BorderSize = 0;
			button3.FlatStyle = FlatStyle.Flat;
			button3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			button3.ForeColor = Color.Black;
			button3.ImageAlign = ContentAlignment.MiddleLeft;
			button3.Location = new Point(568, 408);
			button3.Name = "button3";
			button3.RightToLeft = RightToLeft.Yes;
			button3.Size = new Size(111, 30);
			button3.TabIndex = 15;
			button3.Text = "Kaydet";
			button3.UseVisualStyleBackColor = false;
			button3.Click += button3_Click;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label2.Location = new Point(3, 97);
			label2.Name = "label2";
			label2.Size = new Size(80, 16);
			label2.TabIndex = 16;
			label2.Text = "Buton Renk :";
			// 
			// button4
			// 
			button4.BackColor = Color.Lavender;
			button4.BackgroundImageLayout = ImageLayout.Stretch;
			button4.Cursor = Cursors.Hand;
			button4.FlatAppearance.BorderSize = 0;
			button4.FlatStyle = FlatStyle.System;
			button4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			button4.ForeColor = Color.Black;
			button4.ImageAlign = ContentAlignment.MiddleLeft;
			button4.Location = new Point(89, 94);
			button4.Name = "button4";
			button4.RightToLeft = RightToLeft.No;
			button4.Size = new Size(111, 23);
			button4.TabIndex = 17;
			button4.Text = "Seç....";
			button4.UseVisualStyleBackColor = false;
			button4.Click += button4_Click;
			// 
			// Ayarlar
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			ControlBox = false;
			Controls.Add(button4);
			Controls.Add(label2);
			Controls.Add(button3);
			Controls.Add(button2);
			Controls.Add(label1);
			Controls.Add(button1);
			Controls.Add(label4);
			Controls.Add(label3);
			Name = "Ayarlar";
			StartPosition = FormStartPosition.CenterScreen;
			Load += Ayarlar_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label4;
		private Label label3;
		private Button button1;
		private Label label1;
		private Button button2;
		private Button button3;
		private Label label2;
		private Button button4;
	}
}