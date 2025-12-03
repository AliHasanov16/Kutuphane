namespace Kutuphane
{
	partial class FrmBaglanti
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBaglanti));
			label1 = new Label();
			txtSunucuAdi = new TextBox();
			label9 = new Label();
			txtSifre = new TextBox();
			label5 = new Label();
			txtDataSource = new TextBox();
			label6 = new Label();
			txtİnitialCatalog = new TextBox();
			btnBaglan = new Button();
			btnCik = new Button();
			label4 = new Label();
			label2 = new Label();
			button1 = new Button();
			button2 = new Button();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(210, 216);
			label1.Name = "label1";
			label1.Size = new Size(36, 15);
			label1.TabIndex = 24;
			label1.Text = "Şifre :";
			// 
			// txtSunucuAdi
			// 
			txtSunucuAdi.BackColor = Color.Snow;
			txtSunucuAdi.Location = new Point(164, 187);
			txtSunucuAdi.Name = "txtSunucuAdi";
			txtSunucuAdi.Size = new Size(129, 23);
			txtSunucuAdi.TabIndex = 21;
			txtSunucuAdi.TextAlign = HorizontalAlignment.Center;
			// 
			// label9
			// 
			label9.AutoSize = true;
			label9.Location = new Point(187, 167);
			label9.Name = "label9";
			label9.Size = new Size(83, 15);
			label9.TabIndex = 23;
			label9.Text = "Sunucu Adı :   ";
			// 
			// txtSifre
			// 
			txtSifre.BackColor = Color.Snow;
			txtSifre.Location = new Point(164, 235);
			txtSifre.Name = "txtSifre";
			txtSifre.Size = new Size(129, 23);
			txtSifre.TabIndex = 22;
			txtSifre.TextAlign = HorizontalAlignment.Center;
			txtSifre.UseSystemPasswordChar = true;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(154, 116);
			label5.Name = "label5";
			label5.Size = new Size(148, 15);
			label5.TabIndex = 20;
			label5.Text = "İnitialCatalog ( Database ) :";
			// 
			// txtDataSource
			// 
			txtDataSource.BackColor = Color.Snow;
			txtDataSource.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
			txtDataSource.Location = new Point(119, 83);
			txtDataSource.Name = "txtDataSource";
			txtDataSource.Size = new Size(219, 25);
			txtDataSource.TabIndex = 17;
			txtDataSource.TextAlign = HorizontalAlignment.Center;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(192, 62);
			label6.Name = "label6";
			label6.Size = new Size(73, 15);
			label6.TabIndex = 19;
			label6.Text = "DataSource :";
			// 
			// txtİnitialCatalog
			// 
			txtİnitialCatalog.BackColor = Color.Snow;
			txtİnitialCatalog.Location = new Point(135, 137);
			txtİnitialCatalog.Name = "txtİnitialCatalog";
			txtİnitialCatalog.Size = new Size(187, 23);
			txtİnitialCatalog.TabIndex = 18;
			txtİnitialCatalog.TextAlign = HorizontalAlignment.Center;
			// 
			// btnBaglan
			// 
			btnBaglan.BackColor = Color.PaleGoldenrod;
			btnBaglan.ForeColor = Color.Black;
			btnBaglan.Location = new Point(163, 278);
			btnBaglan.Name = "btnBaglan";
			btnBaglan.Size = new Size(130, 34);
			btnBaglan.TabIndex = 30;
			btnBaglan.Text = "Bağlan";
			btnBaglan.UseVisualStyleBackColor = false;
			btnBaglan.Click += btnBaglan_Click;
			// 
			// btnCik
			// 
			btnCik.BackColor = SystemColors.Info;
			btnCik.FlatStyle = FlatStyle.Flat;
			btnCik.Location = new Point(400, 0);
			btnCik.Name = "btnCik";
			btnCik.Size = new Size(61, 30);
			btnCik.TabIndex = 33;
			btnCik.Text = "Çık";
			btnCik.UseVisualStyleBackColor = false;
			btnCik.Click += btnCik_Click;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Segoe UI Symbol", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label4.Location = new Point(108, 18);
			label4.Name = "label4";
			label4.Size = new Size(241, 25);
			label4.TabIndex = 36;
			label4.Text = "- SQL Server Bağlanma -";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI Symbol", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label2.Location = new Point(119, 28);
			label2.Name = "label2";
			label2.Size = new Size(219, 25);
			label2.TabIndex = 37;
			label2.Text = "_______________________";
			// 
			// button1
			// 
			button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
			button1.BackgroundImageLayout = ImageLayout.Zoom;
			button1.FlatStyle = FlatStyle.Popup;
			button1.Location = new Point(299, 236);
			button1.Name = "button1";
			button1.Size = new Size(23, 22);
			button1.TabIndex = 38;
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// button2
			// 
			button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
			button2.BackgroundImageLayout = ImageLayout.Zoom;
			button2.FlatStyle = FlatStyle.Popup;
			button2.Location = new Point(299, 236);
			button2.Name = "button2";
			button2.Size = new Size(23, 22);
			button2.TabIndex = 39;
			button2.UseVisualStyleBackColor = true;
			button2.Visible = false;
			button2.Click += button2_Click;
			// 
			// FrmBaglanti
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.Info;
			ClientSize = new Size(461, 342);
			ControlBox = false;
			Controls.Add(button2);
			Controls.Add(button1);
			Controls.Add(label4);
			Controls.Add(label2);
			Controls.Add(btnCik);
			Controls.Add(btnBaglan);
			Controls.Add(label1);
			Controls.Add(txtSunucuAdi);
			Controls.Add(label9);
			Controls.Add(txtSifre);
			Controls.Add(label5);
			Controls.Add(txtDataSource);
			Controls.Add(label6);
			Controls.Add(txtİnitialCatalog);
			Name = "FrmBaglanti";
			StartPosition = FormStartPosition.CenterScreen;
			Load += FrmBaglanti_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private TextBox txtSunucuAdi;
		private Label label9;
		private TextBox txtSifre;
		private Label label5;
		private TextBox txtDataSource;
		private Label label6;
		private TextBox txtİnitialCatalog;
		private Button btnBaglan;
		private Button btnCik;
		private Label label4;
		private Label label2;
		private Button button1;
		private Button button2;
	}
}