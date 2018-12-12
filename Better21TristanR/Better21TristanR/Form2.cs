using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Better21TristanR
{
	public partial class Form2 : Form
	{
		public Form2()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			int valueOfProgressBar = 0;
			do
			{ 
				{
					this.prbProgressBar.Value = valueOfProgressBar;
					valueOfProgressBar = valueOfProgressBar + 10;
					Thread.Sleep(100);
					this.Refresh();
				}
			}
			while (valueOfProgressBar < 100);

			if (valueOfProgressBar == 100)
			{
				this.Hide();
				BlackJack Form2 = new BlackJack();
				Form2.ShowDialog();
			}
		}
	}
}
