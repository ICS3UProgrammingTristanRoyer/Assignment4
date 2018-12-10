namespace Simplified21TristanR
{
	partial class BlackJack
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
			this.button1 = new System.Windows.Forms.Button();
			this.btnHit = new System.Windows.Forms.Button();
			this.btnDoubleDown = new System.Windows.Forms.Button();
			this.btnStay = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(197, 28);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "Bet";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// btnHit
			// 
			this.btnHit.Location = new System.Drawing.Point(12, 208);
			this.btnHit.Name = "btnHit";
			this.btnHit.Size = new System.Drawing.Size(75, 23);
			this.btnHit.TabIndex = 1;
			this.btnHit.Text = "Hit";
			this.btnHit.UseVisualStyleBackColor = true;
			// 
			// btnDoubleDown
			// 
			this.btnDoubleDown.Location = new System.Drawing.Point(93, 208);
			this.btnDoubleDown.Name = "btnDoubleDown";
			this.btnDoubleDown.Size = new System.Drawing.Size(98, 23);
			this.btnDoubleDown.TabIndex = 2;
			this.btnDoubleDown.Text = "DoubleDown";
			this.btnDoubleDown.UseVisualStyleBackColor = true;
			// 
			// btnStay
			// 
			this.btnStay.Location = new System.Drawing.Point(197, 208);
			this.btnStay.Name = "btnStay";
			this.btnStay.Size = new System.Drawing.Size(75, 23);
			this.btnStay.TabIndex = 3;
			this.btnStay.Text = "Stay";
			this.btnStay.UseVisualStyleBackColor = true;
			// 
			// BlackJack
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.btnStay);
			this.Controls.Add(this.btnDoubleDown);
			this.Controls.Add(this.btnHit);
			this.Controls.Add(this.button1);
			this.Name = "BlackJack";
			this.Text = "BlackJack";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button btnHit;
		private System.Windows.Forms.Button btnDoubleDown;
		private System.Windows.Forms.Button btnStay;
	}
}