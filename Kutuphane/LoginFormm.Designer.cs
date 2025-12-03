namespace Kutuphane
{
	partial class LoginFormm
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
			textBox1 = new TextBox();
			textBox2 = new TextBox();
			button1 = new Button();
			label2 = new Label();
			label3 = new Label();
			label4 = new Label();
			kaydol = new GroupBox();
			button3 = new Button();
			label11 = new Label();
			label12 = new Label();
			label10 = new Label();
			comboBox1 = new ComboBox();
			label1 = new Label();
			textBox5 = new TextBox();
			label9 = new Label();
			textBox6 = new TextBox();
			label5 = new Label();
			textBox4 = new TextBox();
			label6 = new Label();
			button2 = new Button();
			textBox3 = new TextBox();
			button4 = new Button();
			label7 = new Label();
			label8 = new Label();
			label13 = new Label();
			label14 = new Label();
			kaydol.SuspendLayout();
			SuspendLayout();
			// 
			// textBox1
			// 
			textBox1.BackColor = Color.Snow;
			textBox1.ForeColor = Color.Red;
			textBox1.Location = new Point(156, 72);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(105, 23);
			textBox1.TabIndex = 0;
			// 
			// textBox2
			// 
			textBox2.BackColor = Color.Snow;
			textBox2.ForeColor = Color.Red;
			textBox2.Location = new Point(156, 103);
			textBox2.Name = "textBox2";
			textBox2.Size = new Size(105, 23);
			textBox2.TabIndex = 1;
			textBox2.UseSystemPasswordChar = true;
			// 
			// button1
			// 
			button1.BackColor = SystemColors.Info;
			button1.Cursor = Cursors.Hand;
			button1.FlatStyle = FlatStyle.Popup;
			button1.ForeColor = SystemColors.ActiveCaptionText;
			button1.Location = new Point(168, 131);
			button1.Name = "button1";
			button1.Size = new Size(80, 23);
			button1.TabIndex = 3;
			button1.Text = "Giriş";
			button1.UseVisualStyleBackColor = false;
			button1.Click += button1_Click;
			button1.Enter += button1_Enter;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(120, 76);
			label2.Name = "label2";
			label2.Size = new Size(35, 15);
			label2.TabIndex = 4;
			label2.Text = "İsim :";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(117, 107);
			label3.Name = "label3";
			label3.Size = new Size(36, 15);
			label3.TabIndex = 5;
			label3.Text = "Şifre :";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Cursor = Cursors.Hand;
			label4.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point, 162);
			label4.ForeColor = Color.Blue;
			label4.Location = new Point(167, 157);
			label4.Name = "label4";
			label4.Size = new Size(79, 15);
			label4.TabIndex = 6;
			label4.Text = "Hesabım Yok ";
			label4.Click += label4_Click;
			// 
			// kaydol
			// 
			kaydol.Controls.Add(button3);
			kaydol.Controls.Add(label11);
			kaydol.Controls.Add(label12);
			kaydol.Controls.Add(label10);
			kaydol.Controls.Add(comboBox1);
			kaydol.Controls.Add(label1);
			kaydol.Controls.Add(textBox5);
			kaydol.Controls.Add(label9);
			kaydol.Controls.Add(textBox6);
			kaydol.Controls.Add(label5);
			kaydol.Controls.Add(textBox4);
			kaydol.Controls.Add(label6);
			kaydol.Controls.Add(button2);
			kaydol.Controls.Add(textBox3);
			kaydol.Location = new Point(4, 12);
			kaydol.Name = "kaydol";
			kaydol.Size = new Size(405, 229);
			kaydol.TabIndex = 7;
			kaydol.TabStop = false;
			kaydol.Visible = false;
			kaydol.Enter += kaydol_Enter;
			// 
			// button3
			// 
			button3.BackColor = SystemColors.Info;
			button3.FlatStyle = FlatStyle.Flat;
			button3.Location = new Point(344, 198);
			button3.Name = "button3";
			button3.Size = new Size(55, 25);
			button3.TabIndex = 30;
			button3.Text = "Geri";
			button3.UseVisualStyleBackColor = false;
			button3.Click += button3_Click;
			// 
			// label11
			// 
			label11.AutoSize = true;
			label11.Font = new Font("Yu Gothic", 14F, FontStyle.Bold);
			label11.Location = new Point(154, 16);
			label11.Name = "label11";
			label11.Size = new Size(101, 25);
			label11.TabIndex = 29;
			label11.Text = "- Kaydol -";
			label11.Visible = false;
			// 
			// label12
			// 
			label12.AutoSize = true;
			label12.Font = new Font("Stencil", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
			label12.Location = new Point(149, 24);
			label12.Name = "label12";
			label12.Size = new Size(110, 22);
			label12.TabIndex = 28;
			label12.Text = "__________";
			label12.Visible = false;
			// 
			// label10
			// 
			label10.AutoSize = true;
			label10.Location = new Point(70, 151);
			label10.Name = "label10";
			label10.Size = new Size(56, 15);
			label10.TabIndex = 27;
			label10.Text = "Üye Tipi :";
			// 
			// comboBox1
			// 
			comboBox1.BackColor = Color.Snow;
			comboBox1.FormattingEnabled = true;
			comboBox1.Items.AddRange(new object[] { "Öğrenci", "Standart", "Akademisyen" });
			comboBox1.Location = new Point(140, 147);
			comboBox1.Name = "comboBox1";
			comboBox1.Size = new Size(129, 23);
			comboBox1.TabIndex = 26;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(263, 93);
			label1.Name = "label1";
			label1.Size = new Size(36, 15);
			label1.TabIndex = 16;
			label1.Text = "Şifre :";
			// 
			// textBox5
			// 
			textBox5.BackColor = Color.Snow;
			textBox5.Location = new Point(261, 67);
			textBox5.Name = "textBox5";
			textBox5.Size = new Size(129, 23);
			textBox5.TabIndex = 13;
			// 
			// label9
			// 
			label9.AutoSize = true;
			label9.Location = new Point(261, 49);
			label9.Name = "label9";
			label9.Size = new Size(88, 15);
			label9.TabIndex = 15;
			label9.Text = "Kullanici Adi :   ";
			// 
			// textBox6
			// 
			textBox6.BackColor = Color.Snow;
			textBox6.Location = new Point(261, 111);
			textBox6.Name = "textBox6";
			textBox6.Size = new Size(129, 23);
			textBox6.TabIndex = 14;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(6, 93);
			label5.Name = "label5";
			label5.Size = new Size(63, 15);
			label5.TabIndex = 12;
			label5.Text = "Soyadınız :";
			// 
			// textBox4
			// 
			textBox4.BackColor = Color.Snow;
			textBox4.Location = new Point(6, 67);
			textBox4.Name = "textBox4";
			textBox4.Size = new Size(129, 23);
			textBox4.TabIndex = 8;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(8, 49);
			label6.Name = "label6";
			label6.Size = new Size(46, 15);
			label6.TabIndex = 11;
			label6.Text = "Adınız :";
			// 
			// button2
			// 
			button2.BackColor = SystemColors.Info;
			button2.FlatStyle = FlatStyle.Flat;
			button2.Location = new Point(140, 188);
			button2.Name = "button2";
			button2.Size = new Size(129, 30);
			button2.TabIndex = 10;
			button2.Text = "Kaydol";
			button2.UseVisualStyleBackColor = false;
			button2.Click += button2_Click;
			// 
			// textBox3
			// 
			textBox3.BackColor = Color.Snow;
			textBox3.Location = new Point(6, 111);
			textBox3.Name = "textBox3";
			textBox3.Size = new Size(129, 23);
			textBox3.TabIndex = 9;
			// 
			// button4
			// 
			button4.BackColor = Color.Transparent;
			button4.FlatStyle = FlatStyle.Flat;
			button4.ForeColor = Color.Red;
			button4.Location = new Point(373, 0);
			button4.Name = "button4";
			button4.Size = new Size(39, 24);
			button4.TabIndex = 31;
			button4.Text = "X";
			button4.UseVisualStyleBackColor = false;
			button4.Click += button4_Click;
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
			label7.Location = new Point(173, 37);
			label7.Name = "label7";
			label7.Size = new Size(71, 21);
			label7.TabIndex = 9;
			label7.Text = "- Giriş -";
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Font = new Font("Stencil", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
			label8.Location = new Point(169, 45);
			label8.Name = "label8";
			label8.Size = new Size(90, 22);
			label8.TabIndex = 8;
			label8.Text = "________";
			// 
			// label13
			// 
			label13.AutoSize = true;
			label13.Cursor = Cursors.Hand;
			label13.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
			label13.Location = new Point(264, 104);
			label13.Name = "label13";
			label13.Size = new Size(22, 21);
			label13.TabIndex = 32;
			label13.Text = "--";
			label13.Click += label13_Click;
			// 
			// label14
			// 
			label14.AutoSize = true;
			label14.Cursor = Cursors.Hand;
			label14.Font = new Font("Segoe UI", 12F);
			label14.Location = new Point(265, 104);
			label14.Name = "label14";
			label14.Size = new Size(21, 21);
			label14.TabIndex = 33;
			label14.Text = "=";
			label14.Visible = false;
			label14.Click += label14_Click;
			// 
			// LoginFormm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.Info;
			ClientSize = new Size(412, 243);
			ControlBox = false;
			Controls.Add(button4);
			Controls.Add(kaydol);
			Controls.Add(label14);
			Controls.Add(label13);
			Controls.Add(label7);
			Controls.Add(label8);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(button1);
			Controls.Add(textBox2);
			Controls.Add(textBox1);
			FormBorderStyle = FormBorderStyle.Fixed3D;
			Name = "LoginFormm";
			ShowInTaskbar = false;
			StartPosition = FormStartPosition.CenterScreen;
			Load += LoginFormm_Load;
			kaydol.ResumeLayout(false);
			kaydol.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox textBox1;
		private TextBox textBox2;
		private Button button1;
		private Label label2;
		private Label label3;
		private Label label4;
		private GroupBox kaydol;
		private Label label5;
		private TextBox textBox4;
		private Label label6;
		private TextBox textBox3;
		private Button button2;
		private Label label7;
		private Label label8;
		private Label label1;
		private TextBox textBox5;
		private Label label9;
		private TextBox textBox6;
		private Label label10;
		private ComboBox comboBox1;
		private Label label11;
		private Label label12;
		private Button button3;
		private Button button4;
		private Label label13;
		private Label label14;
	}
}