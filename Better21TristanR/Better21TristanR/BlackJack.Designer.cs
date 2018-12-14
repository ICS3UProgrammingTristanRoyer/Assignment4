namespace Better21TristanR
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BlackJack));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.resetProgressToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.musicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.resumeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.muteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.difficultyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.regularToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.challengingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.lblError = new System.Windows.Forms.Label();
			this.lblWinner = new System.Windows.Forms.Label();
			this.lblDealerTotal = new System.Windows.Forms.Label();
			this.lblPlayerTotal = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.btnHit = new System.Windows.Forms.Button();
			this.btnDoubleDown = new System.Windows.Forms.Button();
			this.btnStay = new System.Windows.Forms.Button();
			this.nudBetAmount = new System.Windows.Forms.NumericUpDown();
			this.lblBetAmount = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.lblPlayer = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.lblBalance = new System.Windows.Forms.Label();
			this.lblBetError = new System.Windows.Forms.Label();
			this.lblBlackjack = new System.Windows.Forms.Label();
			this.lblTitle = new System.Windows.Forms.Label();
			this.lblTime = new System.Windows.Forms.Label();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.picCard1 = new System.Windows.Forms.PictureBox();
			this.picCard2 = new System.Windows.Forms.PictureBox();
			this.picCard3 = new System.Windows.Forms.PictureBox();
			this.picDealerCard1 = new System.Windows.Forms.PictureBox();
			this.picDealerCard2 = new System.Windows.Forms.PictureBox();
			this.picDealerCard3 = new System.Windows.Forms.PictureBox();
			this.picDealerCard4 = new System.Windows.Forms.PictureBox();
			this.lblTimer = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudBetAmount)).BeginInit();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picCard1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picCard2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picCard3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picDealerCard1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picDealerCard2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picDealerCard3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picDealerCard4)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.musicToolStripMenuItem,
            this.difficultyToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(800, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// menuToolStripMenuItem
			// 
			this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.resetProgressToolStripMenuItem,
            this.exitToolStripMenuItem});
			this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
			this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
			this.menuToolStripMenuItem.Text = "Menu";
			// 
			// newGameToolStripMenuItem
			// 
			this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
			this.newGameToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
			this.newGameToolStripMenuItem.Text = "New Game";
			this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
			// 
			// resetProgressToolStripMenuItem
			// 
			this.resetProgressToolStripMenuItem.Name = "resetProgressToolStripMenuItem";
			this.resetProgressToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
			this.resetProgressToolStripMenuItem.Text = "Reset Progress";
			this.resetProgressToolStripMenuItem.Click += new System.EventHandler(this.resetProgressToolStripMenuItem_Click);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
			this.exitToolStripMenuItem.Text = "Exit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// musicToolStripMenuItem
			// 
			this.musicToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resumeToolStripMenuItem,
            this.muteToolStripMenuItem});
			this.musicToolStripMenuItem.Name = "musicToolStripMenuItem";
			this.musicToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
			this.musicToolStripMenuItem.Text = "Music";
			// 
			// resumeToolStripMenuItem
			// 
			this.resumeToolStripMenuItem.Name = "resumeToolStripMenuItem";
			this.resumeToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
			this.resumeToolStripMenuItem.Text = "Resume";
			this.resumeToolStripMenuItem.Click += new System.EventHandler(this.resumeToolStripMenuItem_Click);
			// 
			// muteToolStripMenuItem
			// 
			this.muteToolStripMenuItem.Name = "muteToolStripMenuItem";
			this.muteToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
			this.muteToolStripMenuItem.Text = "Mute";
			this.muteToolStripMenuItem.Click += new System.EventHandler(this.muteToolStripMenuItem_Click);
			// 
			// difficultyToolStripMenuItem
			// 
			this.difficultyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.regularToolStripMenuItem,
            this.challengingToolStripMenuItem});
			this.difficultyToolStripMenuItem.Name = "difficultyToolStripMenuItem";
			this.difficultyToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
			this.difficultyToolStripMenuItem.Text = "Difficulty";
			// 
			// regularToolStripMenuItem
			// 
			this.regularToolStripMenuItem.Name = "regularToolStripMenuItem";
			this.regularToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
			this.regularToolStripMenuItem.Text = "Regular";
			this.regularToolStripMenuItem.Click += new System.EventHandler(this.regularToolStripMenuItem_Click);
			// 
			// challengingToolStripMenuItem
			// 
			this.challengingToolStripMenuItem.Name = "challengingToolStripMenuItem";
			this.challengingToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
			this.challengingToolStripMenuItem.Text = "Challenging";
			this.challengingToolStripMenuItem.Click += new System.EventHandler(this.challengingToolStripMenuItem_Click);
			// 
			// lblError
			// 
			this.lblError.AutoSize = true;
			this.lblError.Location = new System.Drawing.Point(266, 495);
			this.lblError.Name = "lblError";
			this.lblError.Size = new System.Drawing.Size(13, 13);
			this.lblError.TabIndex = 1;
			this.lblError.Text = "--";
			// 
			// lblWinner
			// 
			this.lblWinner.AutoSize = true;
			this.lblWinner.Location = new System.Drawing.Point(266, 524);
			this.lblWinner.Name = "lblWinner";
			this.lblWinner.Size = new System.Drawing.Size(13, 13);
			this.lblWinner.TabIndex = 2;
			this.lblWinner.Text = "--";
			// 
			// lblDealerTotal
			// 
			this.lblDealerTotal.AutoSize = true;
			this.lblDealerTotal.BackColor = System.Drawing.Color.HotPink;
			this.lblDealerTotal.Location = new System.Drawing.Point(12, 302);
			this.lblDealerTotal.Name = "lblDealerTotal";
			this.lblDealerTotal.Size = new System.Drawing.Size(68, 13);
			this.lblDealerTotal.TabIndex = 4;
			this.lblDealerTotal.Text = "Dealer Total:";
			// 
			// lblPlayerTotal
			// 
			this.lblPlayerTotal.AutoSize = true;
			this.lblPlayerTotal.BackColor = System.Drawing.Color.LawnGreen;
			this.lblPlayerTotal.Location = new System.Drawing.Point(7, 120);
			this.lblPlayerTotal.Name = "lblPlayerTotal";
			this.lblPlayerTotal.Size = new System.Drawing.Size(62, 13);
			this.lblPlayerTotal.TabIndex = 5;
			this.lblPlayerTotal.Text = "Player total:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Red;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(595, 24);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(79, 20);
			this.label3.TabIndex = 6;
			this.label3.Text = "Balance:";
			// 
			// btnHit
			// 
			this.btnHit.BackColor = System.Drawing.Color.Lime;
			this.btnHit.Location = new System.Drawing.Point(164, 469);
			this.btnHit.Name = "btnHit";
			this.btnHit.Size = new System.Drawing.Size(75, 23);
			this.btnHit.TabIndex = 7;
			this.btnHit.Text = "Hit";
			this.btnHit.UseVisualStyleBackColor = false;
			this.btnHit.Click += new System.EventHandler(this.btnHit_Click);
			// 
			// btnDoubleDown
			// 
			this.btnDoubleDown.BackColor = System.Drawing.Color.Green;
			this.btnDoubleDown.Location = new System.Drawing.Point(269, 469);
			this.btnDoubleDown.Name = "btnDoubleDown";
			this.btnDoubleDown.Size = new System.Drawing.Size(80, 23);
			this.btnDoubleDown.TabIndex = 8;
			this.btnDoubleDown.Text = "DoubleDown";
			this.btnDoubleDown.UseVisualStyleBackColor = false;
			this.btnDoubleDown.Click += new System.EventHandler(this.btnDoubleDown_Click);
			// 
			// btnStay
			// 
			this.btnStay.BackColor = System.Drawing.Color.Aqua;
			this.btnStay.Location = new System.Drawing.Point(392, 469);
			this.btnStay.Name = "btnStay";
			this.btnStay.Size = new System.Drawing.Size(75, 23);
			this.btnStay.TabIndex = 9;
			this.btnStay.Text = "Stay";
			this.btnStay.UseVisualStyleBackColor = false;
			this.btnStay.Click += new System.EventHandler(this.btnStay_Click);
			// 
			// nudBetAmount
			// 
			this.nudBetAmount.Location = new System.Drawing.Point(680, 56);
			this.nudBetAmount.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
			this.nudBetAmount.Name = "nudBetAmount";
			this.nudBetAmount.Size = new System.Drawing.Size(120, 20);
			this.nudBetAmount.TabIndex = 10;
			// 
			// lblBetAmount
			// 
			this.lblBetAmount.AutoSize = true;
			this.lblBetAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblBetAmount.Location = new System.Drawing.Point(554, 58);
			this.lblBetAmount.Name = "lblBetAmount";
			this.lblBetAmount.Size = new System.Drawing.Size(120, 18);
			this.lblBetAmount.TabIndex = 11;
			this.lblBetAmount.Text = "Make your bet:";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(680, 110);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 12;
			this.button1.Text = "Bet";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// lblPlayer
			// 
			this.lblPlayer.AutoSize = true;
			this.lblPlayer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
			this.lblPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPlayer.Location = new System.Drawing.Point(11, 83);
			this.lblPlayer.Name = "lblPlayer";
			this.lblPlayer.Size = new System.Drawing.Size(58, 20);
			this.lblPlayer.TabIndex = 16;
			this.lblPlayer.Text = "Player";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.BackColor = System.Drawing.Color.Red;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(12, 269);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(62, 20);
			this.label5.TabIndex = 17;
			this.label5.Text = "Dealer";
			// 
			// lblBalance
			// 
			this.lblBalance.AutoSize = true;
			this.lblBalance.BackColor = System.Drawing.Color.Green;
			this.lblBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblBalance.Location = new System.Drawing.Point(711, 29);
			this.lblBalance.Name = "lblBalance";
			this.lblBalance.Size = new System.Drawing.Size(54, 16);
			this.lblBalance.TabIndex = 21;
			this.lblBalance.Text = "CA$100";
			// 
			// lblBetError
			// 
			this.lblBetError.AutoSize = true;
			this.lblBetError.Location = new System.Drawing.Point(554, 147);
			this.lblBetError.Name = "lblBetError";
			this.lblBetError.Size = new System.Drawing.Size(13, 13);
			this.lblBetError.TabIndex = 22;
			this.lblBetError.Text = "--";
			this.lblBetError.Click += new System.EventHandler(this.lblBetError_Click);
			// 
			// lblBlackjack
			// 
			this.lblBlackjack.AutoSize = true;
			this.lblBlackjack.Location = new System.Drawing.Point(266, 547);
			this.lblBlackjack.Name = "lblBlackjack";
			this.lblBlackjack.Size = new System.Drawing.Size(13, 13);
			this.lblBlackjack.TabIndex = 24;
			this.lblBlackjack.Text = "--";
			// 
			// lblTitle
			// 
			this.lblTitle.AutoSize = true;
			this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitle.Location = new System.Drawing.Point(10, 37);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(144, 25);
			this.lblTitle.TabIndex = 26;
			this.lblTitle.Text = "BLACKJACK";
			// 
			// lblTime
			// 
			this.lblTime.AutoSize = true;
			this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTime.Location = new System.Drawing.Point(6, 16);
			this.lblTime.Name = "lblTime";
			this.lblTime.Size = new System.Drawing.Size(28, 25);
			this.lblTime.TabIndex = 27;
			this.lblTime.Text = "--";
			this.lblTime.Click += new System.EventHandler(this.lblTime_Click);
			// 
			// timer1
			// 
			this.timer1.Interval = 1000;
			this.timer1.Tick += new System.EventHandler(this.timer_Tick);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.lblTime);
			this.groupBox1.Location = new System.Drawing.Point(631, 162);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(169, 53);
			this.groupBox1.TabIndex = 28;
			this.groupBox1.TabStop = false;
			// 
			// picCard1
			// 
			this.picCard1.Image = global::Better21TristanR.Properties.Resources.spadeQ;
			this.picCard1.Location = new System.Drawing.Point(0, 136);
			this.picCard1.Name = "picCard1";
			this.picCard1.Size = new System.Drawing.Size(98, 130);
			this.picCard1.TabIndex = 29;
			this.picCard1.TabStop = false;
			// 
			// picCard2
			// 
			this.picCard2.Image = global::Better21TristanR.Properties.Resources.spadeQ;
			this.picCard2.Location = new System.Drawing.Point(132, 136);
			this.picCard2.Name = "picCard2";
			this.picCard2.Size = new System.Drawing.Size(98, 130);
			this.picCard2.TabIndex = 30;
			this.picCard2.TabStop = false;
			this.picCard2.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// picCard3
			// 
			this.picCard3.Image = global::Better21TristanR.Properties.Resources.spadeQ;
			this.picCard3.Location = new System.Drawing.Point(269, 136);
			this.picCard3.Name = "picCard3";
			this.picCard3.Size = new System.Drawing.Size(98, 130);
			this.picCard3.TabIndex = 31;
			this.picCard3.TabStop = false;
			// 
			// picDealerCard1
			// 
			this.picDealerCard1.Image = global::Better21TristanR.Properties.Resources.spadeQ;
			this.picDealerCard1.Location = new System.Drawing.Point(0, 333);
			this.picDealerCard1.Name = "picDealerCard1";
			this.picDealerCard1.Size = new System.Drawing.Size(98, 130);
			this.picDealerCard1.TabIndex = 32;
			this.picDealerCard1.TabStop = false;
			// 
			// picDealerCard2
			// 
			this.picDealerCard2.Image = global::Better21TristanR.Properties.Resources.spadeQ;
			this.picDealerCard2.Location = new System.Drawing.Point(132, 333);
			this.picDealerCard2.Name = "picDealerCard2";
			this.picDealerCard2.Size = new System.Drawing.Size(98, 130);
			this.picDealerCard2.TabIndex = 33;
			this.picDealerCard2.TabStop = false;
			// 
			// picDealerCard3
			// 
			this.picDealerCard3.Image = global::Better21TristanR.Properties.Resources.spadeQ;
			this.picDealerCard3.Location = new System.Drawing.Point(251, 333);
			this.picDealerCard3.Name = "picDealerCard3";
			this.picDealerCard3.Size = new System.Drawing.Size(98, 130);
			this.picDealerCard3.TabIndex = 34;
			this.picDealerCard3.TabStop = false;
			// 
			// picDealerCard4
			// 
			this.picDealerCard4.Location = new System.Drawing.Point(392, 333);
			this.picDealerCard4.Name = "picDealerCard4";
			this.picDealerCard4.Size = new System.Drawing.Size(98, 130);
			this.picDealerCard4.TabIndex = 35;
			this.picDealerCard4.TabStop = false;
			// 
			// lblTimer
			// 
			this.lblTimer.AutoSize = true;
			this.lblTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTimer.Location = new System.Drawing.Point(6, 16);
			this.lblTimer.Name = "lblTimer";
			this.lblTimer.Size = new System.Drawing.Size(24, 24);
			this.lblTimer.TabIndex = 36;
			this.lblTimer.Text = "--";
			this.lblTimer.Click += new System.EventHandler(this.label1_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.lblTimer);
			this.groupBox2.Location = new System.Drawing.Point(631, 221);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(169, 45);
			this.groupBox2.TabIndex = 37;
			this.groupBox2.TabStop = false;
			// 
			// BlackJack
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.DodgerBlue;
			this.ClientSize = new System.Drawing.Size(800, 560);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.picDealerCard4);
			this.Controls.Add(this.picDealerCard3);
			this.Controls.Add(this.picDealerCard2);
			this.Controls.Add(this.picDealerCard1);
			this.Controls.Add(this.picCard3);
			this.Controls.Add(this.picCard2);
			this.Controls.Add(this.picCard1);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.lblTitle);
			this.Controls.Add(this.lblBlackjack);
			this.Controls.Add(this.lblBetError);
			this.Controls.Add(this.lblBalance);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.lblPlayer);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.lblBetAmount);
			this.Controls.Add(this.nudBetAmount);
			this.Controls.Add(this.btnStay);
			this.Controls.Add(this.btnDoubleDown);
			this.Controls.Add(this.btnHit);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.lblPlayerTotal);
			this.Controls.Add(this.lblDealerTotal);
			this.Controls.Add(this.lblWinner);
			this.Controls.Add(this.lblError);
			this.Controls.Add(this.menuStrip1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "BlackJack";
			this.Text = "Form2";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudBetAmount)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.picCard1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picCard2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picCard3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picDealerCard1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picDealerCard2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picDealerCard3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picDealerCard4)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem resetProgressToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.Label lblError;
		private System.Windows.Forms.Label lblWinner;
		private System.Windows.Forms.Label lblDealerTotal;
		private System.Windows.Forms.Label lblPlayerTotal;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnHit;
		private System.Windows.Forms.Button btnDoubleDown;
		private System.Windows.Forms.Button btnStay;
		private System.Windows.Forms.ToolStripMenuItem musicToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem resumeToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem muteToolStripMenuItem;
		private System.Windows.Forms.NumericUpDown nudBetAmount;
		private System.Windows.Forms.Label lblBetAmount;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label lblPlayer;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label lblBalance;
		private System.Windows.Forms.Label lblBetError;
		private System.Windows.Forms.Label lblBlackjack;
		private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.Label lblTime;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.PictureBox picCard1;
		private System.Windows.Forms.PictureBox picCard2;
		private System.Windows.Forms.PictureBox picCard3;
		private System.Windows.Forms.PictureBox picDealerCard1;
		private System.Windows.Forms.PictureBox picDealerCard2;
		private System.Windows.Forms.PictureBox picDealerCard3;
		private System.Windows.Forms.PictureBox picDealerCard4;
		private System.Windows.Forms.ToolStripMenuItem difficultyToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem regularToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem challengingToolStripMenuItem;
		private System.Windows.Forms.Label lblTimer;
		private System.Windows.Forms.GroupBox groupBox2;
	}
}