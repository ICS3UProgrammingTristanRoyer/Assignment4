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
		int MAX_VALUE = 100;

		public Form2()
		{
			InitializeComponent();
		}

		private void Form2_Load(object sender, EventArgs e)
		{


		}
			private void button1_Click(object sender, EventArgs e)
		{
			int valueOfProgressBar = 0;

			label1.Text = "loading...  %" + valueOfProgressBar;
				do
				{
				valueOfProgressBar = valueOfProgressBar + 5;

				this.prbProgressBar.Value = valueOfProgressBar;
				label1.Text = "loading...  %" + valueOfProgressBar;
				Thread.Sleep(500);
				this.Refresh();
			
				
					
				}
				while (prbProgressBar.Value < MAX_VALUE);
			if (prbProgressBar.Value == MAX_VALUE)
			{
				this.Hide();
				BlackJack Form2 = new BlackJack();
				Form2.ShowDialog();
			}

		}
				

		}
	}

