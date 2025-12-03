namespace Kutuphane
{
    partial class AnaMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaMenu));
			groupBox1 = new GroupBox();
			button7 = new Button();
			label5 = new Label();
			kullaniciAdSoyad = new Label();
			label1 = new Label();
			btnKapat = new Button();
			lblTitle = new Label();
			groupBox2 = new GroupBox();
			button4 = new Button();
			label4 = new Label();
			label3 = new Label();
			adminPanel = new GroupBox();
			button2 = new Button();
			button6 = new Button();
			button5 = new Button();
			button3 = new Button();
			button1 = new Button();
			btnCiks = new Button();
			btnRaporlar = new Button();
			btnEmanetler = new Button();
			btnKitaplar = new Button();
			btnUyeler = new Button();
			groupBox4 = new GroupBox();
			label2 = new Label();
			label11 = new Label();
			groupBox1.SuspendLayout();
			groupBox2.SuspendLayout();
			adminPanel.SuspendLayout();
			SuspendLayout();
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(button7);
			groupBox1.Controls.Add(label5);
			groupBox1.Controls.Add(kullaniciAdSoyad);
			groupBox1.Controls.Add(label1);
			groupBox1.Controls.Add(btnKapat);
			groupBox1.Controls.Add(lblTitle);
			groupBox1.Controls.Add(label11);
			groupBox1.Dock = DockStyle.Top;
			groupBox1.Location = new Point(0, 0);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(1171, 50);
			groupBox1.TabIndex = 0;
			groupBox1.TabStop = false;
			groupBox1.Enter += groupBox1_Enter;
			// 
			// button7
			// 
			button7.BackColor = Color.Transparent;
			button7.BackgroundImage = (Image)resources.GetObject("button7.BackgroundImage");
			button7.BackgroundImageLayout = ImageLayout.Stretch;
			button7.Cursor = Cursors.Hand;
			button7.FlatStyle = FlatStyle.Flat;
			button7.ForeColor = Color.Cornsilk;
			button7.ImageAlign = ContentAlignment.MiddleRight;
			button7.Location = new Point(1070, 15);
			button7.Name = "button7";
			button7.Size = new Size(28, 26);
			button7.TabIndex = 0;
			button7.TextAlign = ContentAlignment.MiddleLeft;
			button7.UseVisualStyleBackColor = false;
			button7.Click += button7_Click_2;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Segoe UI", 15F);
			label5.Location = new Point(1104, 11);
			label5.Name = "label5";
			label5.Size = new Size(17, 28);
			label5.TabIndex = 31;
			label5.Text = "|";
			// 
			// kullaniciAdSoyad
			// 
			kullaniciAdSoyad.AutoSize = true;
			kullaniciAdSoyad.Font = new Font("Trebuchet MS", 11F);
			kullaniciAdSoyad.Location = new Point(259, 19);
			kullaniciAdSoyad.Name = "kullaniciAdSoyad";
			kullaniciAdSoyad.Size = new Size(0, 20);
			kullaniciAdSoyad.TabIndex = 3;
			kullaniciAdSoyad.Click += kullaniciAdSoyad_Click;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 15F);
			label1.Location = new Point(249, 12);
			label1.Name = "label1";
			label1.Size = new Size(17, 28);
			label1.TabIndex = 2;
			label1.Text = "|";
			// 
			// btnKapat
			// 
			btnKapat.BackColor = Color.OldLace;
			btnKapat.BackgroundImage = (Image)resources.GetObject("btnKapat.BackgroundImage");
			btnKapat.BackgroundImageLayout = ImageLayout.Zoom;
			btnKapat.Cursor = Cursors.Hand;
			btnKapat.FlatAppearance.BorderColor = Color.OldLace;
			btnKapat.FlatAppearance.BorderSize = 0;
			btnKapat.FlatAppearance.MouseDownBackColor = Color.OldLace;
			btnKapat.FlatAppearance.MouseOverBackColor = Color.OldLace;
			btnKapat.FlatStyle = FlatStyle.Flat;
			btnKapat.ForeColor = Color.White;
			btnKapat.Location = new Point(1121, 12);
			btnKapat.Name = "btnKapat";
			btnKapat.Padding = new Padding(15, 0, 0, 0);
			btnKapat.Size = new Size(46, 32);
			btnKapat.TabIndex = 1;
			btnKapat.UseVisualStyleBackColor = false;
			btnKapat.Click += btnKapat_Click;
			btnKapat.MouseLeave += btnKapat_MouseLeave;
			btnKapat.MouseHover += btnKapat_MouseHover;
			// 
			// lblTitle
			// 
			lblTitle.AutoSize = true;
			lblTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
			lblTitle.ForeColor = Color.Black;
			lblTitle.Location = new Point(-13, 19);
			lblTitle.Name = "lblTitle";
			lblTitle.Padding = new Padding(15, 0, 0, 0);
			lblTitle.Size = new Size(268, 21);
			lblTitle.TabIndex = 0;
			lblTitle.Text = "📚  Kütüphane Yönetim Sistemi";
			// 
			// groupBox2
			// 
			groupBox2.Controls.Add(button4);
			groupBox2.Controls.Add(label4);
			groupBox2.Controls.Add(label3);
			groupBox2.Controls.Add(adminPanel);
			groupBox2.Controls.Add(btnCiks);
			groupBox2.Controls.Add(btnRaporlar);
			groupBox2.Controls.Add(btnEmanetler);
			groupBox2.Controls.Add(btnKitaplar);
			groupBox2.Controls.Add(btnUyeler);
			groupBox2.Dock = DockStyle.Left;
			groupBox2.Location = new Point(0, 50);
			groupBox2.Name = "groupBox2";
			groupBox2.Size = new Size(220, 530);
			groupBox2.TabIndex = 1;
			groupBox2.TabStop = false;
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
			button4.ImageAlign = ContentAlignment.MiddleLeft;
			button4.Location = new Point(9, 236);
			button4.Name = "button4";
			button4.RightToLeft = RightToLeft.Yes;
			button4.Size = new Size(200, 30);
			button4.TabIndex = 9;
			button4.Text = "Ayarlar";
			button4.UseVisualStyleBackColor = false;
			button4.Click += button4_Click;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Bahnschrift Condensed", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
			label4.Location = new Point(33, 17);
			label4.Name = "label4";
			label4.Size = new Size(139, 33);
			label4.TabIndex = 8;
			label4.Text = " - Ana Sayfa -";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
			label3.Location = new Point(5, 34);
			label3.Name = "label3";
			label3.Size = new Size(208, 24);
			label3.TabIndex = 5;
			label3.Text = "__________________";
			// 
			// adminPanel
			// 
			adminPanel.Controls.Add(button2);
			adminPanel.Controls.Add(button6);
			adminPanel.Controls.Add(button5);
			adminPanel.Controls.Add(button3);
			adminPanel.Controls.Add(button1);
			adminPanel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
			adminPanel.Location = new Point(0, 318);
			adminPanel.Name = "adminPanel";
			adminPanel.Size = new Size(220, 212);
			adminPanel.TabIndex = 6;
			adminPanel.TabStop = false;
			adminPanel.Text = "Admin Panel";
			adminPanel.Visible = false;
			adminPanel.Enter += adminPanel_Enter;
			// 
			// button2
			// 
			button2.BackColor = SystemColors.ButtonHighlight;
			button2.BackgroundImageLayout = ImageLayout.Stretch;
			button2.Cursor = Cursors.Hand;
			button2.FlatAppearance.BorderSize = 0;
			button2.FlatStyle = FlatStyle.Flat;
			button2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			button2.ForeColor = Color.Crimson;
			button2.ImageAlign = ContentAlignment.MiddleLeft;
			button2.Location = new Point(3, 63);
			button2.Name = "button2";
			button2.RightToLeft = RightToLeft.Yes;
			button2.Size = new Size(214, 31);
			button2.TabIndex = 7;
			button2.Text = "Kitap İşlemleri";
			button2.UseVisualStyleBackColor = false;
			button2.Click += button2_Click;
			// 
			// button6
			// 
			button6.BackColor = SystemColors.ButtonHighlight;
			button6.BackgroundImageLayout = ImageLayout.Stretch;
			button6.Cursor = Cursors.Hand;
			button6.FlatAppearance.BorderSize = 0;
			button6.FlatStyle = FlatStyle.Flat;
			button6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			button6.ForeColor = Color.Crimson;
			button6.ImageAlign = ContentAlignment.MiddleLeft;
			button6.Location = new Point(3, 176);
			button6.Name = "button6";
			button6.RightToLeft = RightToLeft.Yes;
			button6.Size = new Size(214, 30);
			button6.TabIndex = 10;
			button6.Text = "Panel Kapat";
			button6.UseVisualStyleBackColor = false;
			button6.Click += button6_Click;
			// 
			// button5
			// 
			button5.BackColor = SystemColors.ButtonHighlight;
			button5.BackgroundImageLayout = ImageLayout.Stretch;
			button5.Cursor = Cursors.Hand;
			button5.FlatAppearance.BorderSize = 0;
			button5.FlatStyle = FlatStyle.Flat;
			button5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			button5.ForeColor = Color.Crimson;
			button5.ImageAlign = ContentAlignment.MiddleLeft;
			button5.Location = new Point(3, 138);
			button5.Name = "button5";
			button5.RightToLeft = RightToLeft.Yes;
			button5.Size = new Size(214, 30);
			button5.TabIndex = 10;
			button5.Text = "Kayıtlı Kullanıcılar";
			button5.UseVisualStyleBackColor = false;
			button5.Click += button5_Click;
			// 
			// button3
			// 
			button3.BackColor = SystemColors.ButtonHighlight;
			button3.BackgroundImageLayout = ImageLayout.Stretch;
			button3.Cursor = Cursors.Hand;
			button3.FlatAppearance.BorderSize = 0;
			button3.FlatStyle = FlatStyle.Flat;
			button3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			button3.ForeColor = Color.Crimson;
			button3.ImageAlign = ContentAlignment.MiddleLeft;
			button3.Location = new Point(3, 101);
			button3.Name = "button3";
			button3.RightToLeft = RightToLeft.Yes;
			button3.Size = new Size(214, 30);
			button3.TabIndex = 8;
			button3.Text = "Emanet İşlemleri";
			button3.UseVisualStyleBackColor = false;
			button3.Click += button3_Click;
			// 
			// button1
			// 
			button1.BackColor = SystemColors.ButtonHighlight;
			button1.BackgroundImageLayout = ImageLayout.Stretch;
			button1.Cursor = Cursors.Hand;
			button1.Dock = DockStyle.Top;
			button1.FlatAppearance.BorderSize = 0;
			button1.FlatStyle = FlatStyle.Flat;
			button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			button1.ForeColor = Color.Crimson;
			button1.ImageAlign = ContentAlignment.MiddleLeft;
			button1.Location = new Point(3, 25);
			button1.Name = "button1";
			button1.RightToLeft = RightToLeft.Yes;
			button1.Size = new Size(214, 30);
			button1.TabIndex = 1;
			button1.Text = "Üye İşlemler";
			button1.UseVisualStyleBackColor = false;
			button1.Click += button1_Click;
			// 
			// btnCiks
			// 
			btnCiks.BackColor = SystemColors.ButtonHighlight;
			btnCiks.BackgroundImageLayout = ImageLayout.Stretch;
			btnCiks.Cursor = Cursors.Hand;
			btnCiks.FlatAppearance.BorderSize = 0;
			btnCiks.FlatStyle = FlatStyle.Flat;
			btnCiks.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			btnCiks.ForeColor = Color.Black;
			btnCiks.ImageAlign = ContentAlignment.MiddleLeft;
			btnCiks.Location = new Point(24, 280);
			btnCiks.Name = "btnCiks";
			btnCiks.RightToLeft = RightToLeft.Yes;
			btnCiks.Size = new Size(170, 30);
			btnCiks.TabIndex = 5;
			btnCiks.Text = "Çıkış";
			btnCiks.UseVisualStyleBackColor = false;
			btnCiks.Click += btnCiks_Click;
			// 
			// btnRaporlar
			// 
			btnRaporlar.BackColor = SystemColors.ButtonHighlight;
			btnRaporlar.BackgroundImageLayout = ImageLayout.Stretch;
			btnRaporlar.Cursor = Cursors.Hand;
			btnRaporlar.FlatAppearance.BorderSize = 0;
			btnRaporlar.FlatStyle = FlatStyle.Flat;
			btnRaporlar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			btnRaporlar.ForeColor = Color.Black;
			btnRaporlar.ImageAlign = ContentAlignment.MiddleLeft;
			btnRaporlar.Location = new Point(5, 148);
			btnRaporlar.Name = "btnRaporlar";
			btnRaporlar.RightToLeft = RightToLeft.Yes;
			btnRaporlar.Size = new Size(208, 30);
			btnRaporlar.TabIndex = 4;
			btnRaporlar.Text = "Veriler";
			btnRaporlar.UseVisualStyleBackColor = false;
			btnRaporlar.Click += btnRaporlar_Click;
			// 
			// btnEmanetler
			// 
			btnEmanetler.BackColor = SystemColors.ButtonHighlight;
			btnEmanetler.BackgroundImageLayout = ImageLayout.Stretch;
			btnEmanetler.Cursor = Cursors.Hand;
			btnEmanetler.FlatAppearance.BorderSize = 0;
			btnEmanetler.FlatStyle = FlatStyle.Flat;
			btnEmanetler.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			btnEmanetler.ForeColor = Color.Black;
			btnEmanetler.ImageAlign = ContentAlignment.MiddleLeft;
			btnEmanetler.Location = new Point(5, 105);
			btnEmanetler.Name = "btnEmanetler";
			btnEmanetler.RightToLeft = RightToLeft.Yes;
			btnEmanetler.Size = new Size(208, 30);
			btnEmanetler.TabIndex = 3;
			btnEmanetler.Text = "Emanetler";
			btnEmanetler.UseVisualStyleBackColor = false;
			btnEmanetler.Click += btnEmanetler_Click;
			// 
			// btnKitaplar
			// 
			btnKitaplar.BackColor = SystemColors.ButtonHighlight;
			btnKitaplar.BackgroundImageLayout = ImageLayout.Stretch;
			btnKitaplar.Cursor = Cursors.Hand;
			btnKitaplar.FlatAppearance.BorderSize = 0;
			btnKitaplar.FlatStyle = FlatStyle.Flat;
			btnKitaplar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			btnKitaplar.ForeColor = Color.Black;
			btnKitaplar.ImageAlign = ContentAlignment.MiddleLeft;
			btnKitaplar.Location = new Point(5, 61);
			btnKitaplar.Name = "btnKitaplar";
			btnKitaplar.RightToLeft = RightToLeft.Yes;
			btnKitaplar.Size = new Size(208, 30);
			btnKitaplar.TabIndex = 2;
			btnKitaplar.Text = "Kitaplar";
			btnKitaplar.UseVisualStyleBackColor = false;
			btnKitaplar.Click += btnKitaplar_Click;
			// 
			// btnUyeler
			// 
			btnUyeler.BackColor = SystemColors.ButtonHighlight;
			btnUyeler.BackgroundImageLayout = ImageLayout.Stretch;
			btnUyeler.Cursor = Cursors.Hand;
			btnUyeler.FlatAppearance.BorderSize = 0;
			btnUyeler.FlatStyle = FlatStyle.Flat;
			btnUyeler.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			btnUyeler.ForeColor = Color.Black;
			btnUyeler.ImageAlign = ContentAlignment.MiddleLeft;
			btnUyeler.Location = new Point(5, 191);
			btnUyeler.Name = "btnUyeler";
			btnUyeler.RightToLeft = RightToLeft.Yes;
			btnUyeler.Size = new Size(208, 30);
			btnUyeler.TabIndex = 1;
			btnUyeler.Text = "Üyeler";
			btnUyeler.UseVisualStyleBackColor = false;
			btnUyeler.Click += btnUyeler_Click;
			// 
			// groupBox4
			// 
			groupBox4.BackColor = Color.SeaShell;
			groupBox4.Location = new Point(226, 50);
			groupBox4.Name = "groupBox4";
			groupBox4.Size = new Size(938, 519);
			groupBox4.TabIndex = 2;
			groupBox4.TabStop = false;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Microsoft YaHei", 6F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label2.Location = new Point(226, 568);
			label2.Name = "label2";
			label2.Size = new Size(175, 11);
			label2.TabIndex = 1;
			label2.Text = "v0.8 .NET | © 2025 Kütüphane Uygulaması";
			// 
			// label11
			// 
			label11.AutoSize = true;
			label11.Cursor = Cursors.Hand;
			label11.Font = new Font("Yu Gothic", 14F, FontStyle.Bold | FontStyle.Underline);
			label11.Location = new Point(997, 16);
			label11.Name = "label11";
			label11.Size = new Size(76, 25);
			label11.TabIndex = 30;
			label11.Text = "Ayarlar";
			label11.Click += label11_Click;
			label11.MouseLeave += label11_MouseLeave;
			label11.MouseHover += label11_MouseHover;
			// 
			// AnaMenu
			// 
			AutoScaleDimensions = new SizeF(7F, 17F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.OldLace;
			ClientSize = new Size(1171, 580);
			ControlBox = false;
			Controls.Add(label2);
			Controls.Add(groupBox4);
			Controls.Add(groupBox2);
			Controls.Add(groupBox1);
			Font = new Font("Segoe UI", 10F);
			FormBorderStyle = FormBorderStyle.Fixed3D;
			Name = "AnaMenu";
			StartPosition = FormStartPosition.CenterScreen;
			FormClosing += AnaMenu_FormClosing;
			Load += AnaMenu_Load;
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			groupBox2.ResumeLayout(false);
			groupBox2.PerformLayout();
			adminPanel.ResumeLayout(false);
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private GroupBox groupBox1;
		private Label lblTitle;
		private GroupBox groupBox2;
		private Button btnUyeler;
		private Button btnCiks;
		private Button btnRaporlar;
		private Button btnEmanetler;
		private Button btnKitaplar;
		private Button button2;
		public GroupBox adminPanel;
		private Button button6;
		private Button button5;
		private Button button4;
		private Button button3;
		private Button button1;
		private GroupBox groupBox4;
		private Label label2;
		private Button btnKapat;
		private Label label4;
		private Label label3;
		private Label label1;
		public Label kullaniciAdSoyad;
		private Label label5;
		private Button button7;
		private Label label11;
	}
}
