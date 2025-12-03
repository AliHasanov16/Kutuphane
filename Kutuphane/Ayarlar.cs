using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Kutuphane
{
	public partial class Ayarlar : Form
	{
		public Ayarlar()
		{
			InitializeComponent();
		}

		private void Ayarlar_Load(object sender, EventArgs e)
		{
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		//ArkaPlan Renk Ayarı
		private void button2_Click(object sender, EventArgs e)
		{
			using (ColorDialog renkDialog = new ColorDialog())
			{
				renkDialog.AllowFullOpen = true;
				renkDialog.ShowHelp = true;


				if (renkDialog.ShowDialog() == DialogResult.OK)
				{
					this.BackColor = renkDialog.Color;
					((AnaMenu)this.Owner).MenuArkaPlanRengi = renkDialog.Color;
				}

			}
		}

		//Buton Renk Ayarı
		private void button4_Click(object sender, EventArgs e)
		{
			using (ColorDialog renkDialog = new ColorDialog())
			{
				renkDialog.AllowFullOpen = true;
				renkDialog.ShowHelp = true;

				if (renkDialog.ShowDialog() == DialogResult.OK)
				{
					if (this.Owner != null)
					{
						button1.BackColor = renkDialog.Color;
						button2.BackColor = renkDialog.Color;
						button3.BackColor = renkDialog.Color;
						button4.BackColor = renkDialog.Color;
						((AnaMenu)this.Owner).TumButonlariRenkDegistir(this.Owner, renkDialog.Color);
					}
				}
			}
		}
		private void button3_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Kaydedildi ..","Başarılı",MessageBoxButtons.OK,MessageBoxIcon.Information);
			this.Close();
		}
	}
}
