﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Better21TristanR
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void lblUnderage_Click(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			int age;

			age = (int)(nudAge.Value);

			if (age >= 21)
			{
				this.Hide();
				BlackJack Form2 = new BlackJack();
				Form2.ShowDialog();
			}
			else if (age < 21)
			{ lblUnderage.Text = "you need to be 21 years of age to gamble"; }

		}
	}
}