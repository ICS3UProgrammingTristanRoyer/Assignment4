/*
 * Created by: Tristan Royer
 * Created on: 11 - 10 - 18
 * Created for: ICS3U Programming
 * Assignment #6b - Simplified 21
 * This program allows you to play a very simplified version of blackjack.
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Threading;


namespace Better21TristanR
{
	public partial class BlackJack : Form
	{
		// allows sound source:(https://stackoverflow.com/questions/18949385/c-sharp-sound-effect-added)
		System.Media.SoundPlayer backSound = new System.Media.SoundPlayer();
		System.Media.SoundPlayer shuffleSound = new System.Media.SoundPlayer();
		// allows a timer to be used.Source(https://stackoverflow.com/questions/12535722/what-is-the-best-way-to-implement-a-timer)
		System.Windows.Forms.Timer aTimer = new System.Windows.Forms.Timer();




		// declare global variables
		int cardIndex1;
		int cardIndex2;
		int cardIndex3;
		int dealerCardIndex1;
		int dealerCardIndex2;
		int dealerCardIndex3;
		int dealerCardIndex4;

		int MIN_CARD = 0;
		int balance = 100;
		int card1;
		int card2;
		int card3;
		int dealerCard1;
		int dealerCard2;
		int dealerCard3;
		int dealerCard4;
		int bet;
		int playerCardTotal;
		int dealerCardTotal;
		double Earnings;
		int intEarnings;
		bool hard = false;
		// creates the list where I will contain all my card images 
		List<Image> listOfCards = new List<Image>();

		List<int> listOfValues = new List<int>();


		// allows random function to be used.
		Random rnd = new Random();




		public BlackJack()
		{

			// gives the variable " backSound" the casino sound file
			backSound.SoundLocation = "Casino.wav";

			// gives the variable "shuffleSound" the shuffle sound file
			shuffleSound.SoundLocation = "shuffle.wav";






			InitializeComponent();
			// display the balance
			lblBalance.Text = "CA$100";
			// hide certain features.
			this.btnHit.Hide();
			this.btnStay.Hide();
			this.btnDoubleDown.Hide();
			this.picCard1.Hide();
			this.picCard2.Hide();
			this.picCard3.Hide();
			this.picDealerCard1.Hide();
			this.picDealerCard2.Hide();
			this.picDealerCard3.Hide();
			this.picDealerCard4.Hide();
			this.lblDealerTotal.Hide();


			// play music and disable the resume menu item.
			backSound.PlayLooping();
			resumeToolStripMenuItem.Enabled = false;
			muteToolStripMenuItem.Enabled = true;


		}

		private void IncrementTimer(object sender, EventArgs e)
		{
			// allows the counter to work
			int theCounter = 10;

			{
				for (int counter = 0; counter < 10; counter += 1)

					{

						theCounter = theCounter - 1;


						if (theCounter == 0)
						{
						aTimer.Stop();
						MessageBox.Show("You Lose." + "Your balance is now:" + balance , "The Winner Is");
							lblWinner.Text = "you Lose";
							
							// show the deal values 
							lblDealerTotal.Show();
							picDealerCard1.Show();
							picDealerCard2.Show();
							picDealerCard3.Show();
							// hide the buttons for the user's choices.
							this.btnHit.Hide();
							this.btnStay.Hide();
							this.btnDoubleDown.Hide();
							this.button1.Hide();
						}

				}
				
			}




		}
	

		private void ShuffleCards()
		{
			// clears the list
			listOfCards.Clear();
			listOfValues.Clear();
			// plays the shuffle sound
			shuffleSound.Play();

			// sends the images to their proper indexes
			listOfCards.Insert(0, Properties.Resources.heart1);
			listOfCards.Insert(1, Properties.Resources.heart2);
			listOfCards.Insert(2, Properties.Resources.heart3);
			listOfCards.Insert(3, Properties.Resources.heart4);			
			listOfCards.Insert(4, Properties.Resources.heart5);
			listOfCards.Insert(5, Properties.Resources.heart6);
			listOfCards.Insert(6, Properties.Resources.heart7);
			listOfCards.Insert(7, Properties.Resources.heart8);
			listOfCards.Insert(8, Properties.Resources.heart9);
			listOfCards.Insert(9, Properties.Resources.heart10);
			listOfCards.Insert(10, Properties.Resources.heartJ);
			listOfCards.Insert(11, Properties.Resources.heartQ);
			listOfCards.Insert(12, Properties.Resources.heartK);
			listOfCards.Insert(13, Properties.Resources.club1);
			listOfCards.Insert(14, Properties.Resources.club2);
			listOfCards.Insert(15, Properties.Resources.club3);
			listOfCards.Insert(16, Properties.Resources.club4);
			listOfCards.Insert(17, Properties.Resources.club5);
			listOfCards.Insert(18, Properties.Resources.club6);
			listOfCards.Insert(19, Properties.Resources.club7);
			listOfCards.Insert(20, Properties.Resources.club8);
			listOfCards.Insert(21, Properties.Resources.club9);
			listOfCards.Insert(22, Properties.Resources.club10);
			listOfCards.Insert(23, Properties.Resources.clubJ);
			listOfCards.Insert(24, Properties.Resources.clubQ);
			listOfCards.Insert(25, Properties.Resources.clubK);
			listOfCards.Insert(26, Properties.Resources.diamond1);
			listOfCards.Insert(27, Properties.Resources.diamond2);
			listOfCards.Insert(28, Properties.Resources.diamond3);
			listOfCards.Insert(29, Properties.Resources.diamond4);
			listOfCards.Insert(30, Properties.Resources.diamond5);
			listOfCards.Insert(31, Properties.Resources.diamond6);
			listOfCards.Insert(32, Properties.Resources.diamond7);
			listOfCards.Insert(33, Properties.Resources.diamond8);
			listOfCards.Insert(34, Properties.Resources.diamond9);
			listOfCards.Insert(35, Properties.Resources.diamond10);
			listOfCards.Insert(36, Properties.Resources.diamondJ);
			listOfCards.Insert(37, Properties.Resources.diamondQ);
			listOfCards.Insert(38, Properties.Resources.diamondK);
			listOfCards.Insert(39, Properties.Resources.spade1);
			listOfCards.Insert(40, Properties.Resources.spade2);
			listOfCards.Insert(41, Properties.Resources.spade3);
			listOfCards.Insert(42, Properties.Resources.spade4);
			listOfCards.Insert(43, Properties.Resources.spade5);
			listOfCards.Insert(44, Properties.Resources.spade6);
			listOfCards.Insert(45, Properties.Resources.spade7);
			listOfCards.Insert(46, Properties.Resources.spade8);
			listOfCards.Insert(47, Properties.Resources.spade9);
			listOfCards.Insert(48, Properties.Resources.spade10);
			listOfCards.Insert(49, Properties.Resources.spadeJ);
			listOfCards.Insert(50, Properties.Resources.spadeQ);
			listOfCards.Insert(51, Properties.Resources.spadeK);

			// sends the images to their proper indexes
			listOfValues.Insert(0, 1);
			listOfValues.Insert(1, 2);
			listOfValues.Insert(2, 3);
			listOfValues.Insert(3, 4);
			listOfValues.Insert(4, 5);
			listOfValues.Insert(5, 6);
			listOfValues.Insert(6, 7);
			listOfValues.Insert(7, 8);
			listOfValues.Insert(8, 9);
			listOfValues.Insert(9, 10);
			listOfValues.Insert(10, 10);
			listOfValues.Insert(11, 10);
			listOfValues.Insert(12, 10);
			listOfValues.Insert(13, 1);
			listOfValues.Insert(14, 2);
			listOfValues.Insert(15, 3);
			listOfValues.Insert(16, 4);
			listOfValues.Insert(17, 5);
			listOfValues.Insert(18, 6);
			listOfValues.Insert(19, 7);
			listOfValues.Insert(20, 8);
			listOfValues.Insert(21, 9);
			listOfValues.Insert(22, 10);
			listOfValues.Insert(23, 10);
			listOfValues.Insert(24, 10);
			listOfValues.Insert(25, 10);
			listOfValues.Insert(26, 1);
			listOfValues.Insert(27, 2);
			listOfValues.Insert(28, 3);
			listOfValues.Insert(29, 4);
			listOfValues.Insert(30, 5);
			listOfValues.Insert(31, 6);
			listOfValues.Insert(32, 7);
			listOfValues.Insert(33, 8);
			listOfValues.Insert(34, 9);
			listOfValues.Insert(35, 10);
			listOfValues.Insert(36, 10);
			listOfValues.Insert(37, 10);
			listOfValues.Insert(38, 10);
			listOfValues.Insert(39, 1);
			listOfValues.Insert(40, 2);
			listOfValues.Insert(41, 3);
			listOfValues.Insert(42, 4);
			listOfValues.Insert(43, 5);
			listOfValues.Insert(44, 6);
			listOfValues.Insert(45, 7);
			listOfValues.Insert(46, 8);
			listOfValues.Insert(47, 9);
			listOfValues.Insert(48, 10);
			listOfValues.Insert(49, 10);
			listOfValues.Insert(50, 10);
			listOfValues.Insert(51, 10);












		}
		private int ChangeCard (ref PictureBox thePictureBox )
		{
			int cardValue = 0;
			int randomIndex = rnd.Next(MIN_CARD, listOfCards.Count());

			
				thePictureBox.Image = listOfCards[randomIndex];
				listOfCards.RemoveAt(randomIndex);
				cardValue = cardValue + listOfValues[randomIndex];
				listOfValues.RemoveAt(randomIndex);
				
			
			

			return cardValue;



		}


		private void timer_Tick(object sender, EventArgs e)
		{
			lblTime.Text = DateTime.Now.ToString("HH:mm:ss tt");

		}

		
	   
		private void btnHit_Click(object sender, EventArgs e)
		{
			if (listOfCards.Count <= 7)
			{
				MessageBox.Show("Shuffling cards!", "ShuffleTime");
				ShuffleCards();
				this.Refresh();
			}
			// declare local variables and assign values and update text.
			const int STAY = 1;
			const int HIT = 2;
			const int DEALERMINIMUM = 1;
			const int DEALERMAXIMUM = 2;
			int dealerChoice;
			card3 = ChangeCard(ref picCard3);
			picCard3.Show();
			playerCardTotal = card1 + card2 + card3;
			dealerCardTotal = 0;
			lblPlayerTotal.Text = "Player Total:" + playerCardTotal;
			dealerChoice = rnd.Next(DEALERMINIMUM, DEALERMAXIMUM + 1);
			// if the dealer chooses to stay they will not gain another card.
			if (dealerChoice == STAY)
			{
				dealerCard4 = 0;
				dealerCardTotal = dealerCardTotal + dealerCard1 + dealerCard2 + dealerCard3 + dealerCard4;
				lblDealerTotal.Text = "Dealer Total:" + dealerCardTotal;
			}
			// or they can choose to gain a new card.
			else if (dealerChoice == HIT)
			{
				dealerCard4 = ChangeCard(ref picDealerCard4);
				dealerCardTotal = dealerCardTotal + dealerCard1 + dealerCard2 + dealerCard3 + dealerCard4;
				lblDealerTotal.Text = "Dealer Total:" + dealerCardTotal;
				this.picDealerCard4.Show();


			}
			// show the deal values 
			this.picDealerCard1.Show();
			this.picDealerCard2.Show();
			this.picDealerCard3.Show();
			this.lblDealerTotal.Show();
			lblDealerTotal.Show();
		
			// hide the buttons for the user's choices.
			this.btnHit.Hide();
			this.btnStay.Hide();
			this.btnDoubleDown.Hide();
			// checks the winner and displays the appropriate message while updating balance.
			if (playerCardTotal > 21)
			{
				lblWinner.Text = "you Lose";
			}
			else if (dealerCardTotal > 21)
			{
				lblWinner.Text = "you win";
				balance = balance + bet + intEarnings;
			}
			else if (playerCardTotal == dealerCardTotal)
			{
				lblWinner.Text = "You tied , dealer wins.";

			}
			else if (playerCardTotal > dealerCardTotal)
			{
				lblWinner.Text = "you win";
				balance = balance + bet + intEarnings;

			}
			else if (playerCardTotal < dealerCardTotal)
			{
				lblWinner.Text = "you Lose";
			}
			lblBalance.Text = String.Format("CA${0:0.00}", balance);

			if (playerCardTotal == 21)
			{
				lblBlackjack.Text = "BLACKJACK!";
			}


			// hides the bet button
			this.button1.Hide();
			MessageBox.Show(lblWinner.Text +"." + "Your balance is now:" + balance,"The Winner is...");

		

		}

		private void btnDoubleDown_Click(object sender, EventArgs e)
		{
			if (listOfCards.Count <= 7)
				{
				MessageBox.Show("Shuffling cards!", "ShuffleTime");
				ShuffleCards();
				this.Refresh();
			}
			//declare local variables
			const int STAY = 1;
			const int HIT = 2;
			const int DEALERMINIMUM = 1;
			const int DEALERMAXIMUM = 2;

			int dealerChoice;
			// checks if the user has sufficient funds to double the bet, if they do the bet is doubled
			if (balance >= bet)
			{
				// updates the values and text
				balance = balance - bet;
				card3 = ChangeCard(ref picCard3);
				picCard3.Show();

				playerCardTotal = card1 + card2 + card3;
				
				dealerCardTotal = 0;
				lblPlayerTotal.Text = "Player Total:" + playerCardTotal;
				dealerChoice = rnd.Next(DEALERMINIMUM, DEALERMAXIMUM + 1);
				// if the dealer's choice is to stay leave the value.
				if (dealerChoice == STAY)
				{
					dealerCard4 = 0;
					dealerCardTotal = dealerCardTotal + dealerCard1 + dealerCard2 + dealerCard3 + dealerCard4;
					lblDealerTotal.Text = "Dealer Total:" + dealerCardTotal;
				}
				// if the dealer's choice is to hit increase their value.
				else if (dealerChoice == HIT)
				{
					dealerCard4 = ChangeCard(ref picDealerCard4);
					dealerCardTotal = dealerCardTotal + dealerCard1 + dealerCard2 + dealerCard3 + dealerCard4;
					lblDealerTotal.Text = "Dealer Total:" + dealerCardTotal;
					this.picDealerCard4.Show();


				}
				// displays the dealer's values

				this.picDealerCard1.Show();
				this.picDealerCard2.Show();
				this.picDealerCard3.Show();
				this.lblDealerTotal.Show();
				// hide the buttons for the user's choices.
				this.btnHit.Hide();
				this.btnStay.Hide();
				this.btnDoubleDown.Hide();
				// checks the winner and displays the appropriate message and updates the balance.
				if (playerCardTotal > 21)

				{
					lblWinner.Text = "you Lose";
				}
				else if (dealerCardTotal > 21)
				{
					lblWinner.Text = "you win";
					balance = (intEarnings + bet) * 2 + balance;
				}
				else if (playerCardTotal == dealerCardTotal)
				{
					lblWinner.Text = "You tied , dealer wins.";

				}
				else if (playerCardTotal > dealerCardTotal)
				{
					lblWinner.Text = "you win";
					balance = (intEarnings + bet) * 2 + balance;

				}
				else if (playerCardTotal < dealerCardTotal)
				{
					lblWinner.Text = "you Lose";
				}
				lblBalance.Text = String.Format("CA${0:0.00}", balance);

				if (playerCardTotal == 21)
				{
					lblBlackjack.Text = "BLACKJACK!";
				}
			}
			else
			// otherwise an error message is displayed.
			{
				lblError.Text = "Insufficient funds";

			}
			//hides the bet button.
			this.button1.Hide();
			MessageBox.Show(lblWinner.Text +"." + "Your balance is now:" + balance, "The Winner Is...");


		}

		private void btnStay_Click(object sender, EventArgs e)
		{
			if (listOfCards.Count <= 7)
				{
				MessageBox.Show("Shuffling cards!", "ShuffleTime");
				ShuffleCards();
				this.Refresh();
			}
			// declare local variables and assign values and update text.
			const int STAY = 1;
			const int HIT = 2;
			const int DEALERMINIMUM = 1;
			const int DEALERMAXIMUM = 2;
			int dealerChoice;
			card3 = 0;
			playerCardTotal = card1 + card2 + card3;
			dealerCardTotal = 0;
			lblPlayerTotal.Text = "Player Total:" + playerCardTotal;
			dealerChoice = rnd.Next(DEALERMINIMUM, DEALERMAXIMUM + 1);
			// if the dealer's choice is to stay do not update the value
			if (dealerChoice == STAY)
			{
				dealerCard4 = 0;
				dealerCardTotal = dealerCardTotal + dealerCard1 + dealerCard2 + dealerCard3 + dealerCard4;
				lblDealerTotal.Text = "Dealer Total:" + dealerCardTotal;
			}
			// if the dealer's choice is to hit update the value.
			else if (dealerChoice == HIT)
			{
				dealerCard4 = ChangeCard(ref picDealerCard4);
				dealerCardTotal = dealerCardTotal + dealerCard1 + dealerCard2 + dealerCard3 + dealerCard4;
				lblDealerTotal.Text = "Dealer Total:" + dealerCardTotal;
				this.picDealerCard4.Show();


			}
			// show the dealer values
			this.picDealerCard1.Show();
			this.picDealerCard2.Show();
			this.picDealerCard3.Show();
			this.lblDealerTotal.Show();
			lblDealerTotal.Show();

			


			


			// hide the buttons for the user's choices.
			this.btnHit.Hide();
			this.btnStay.Hide();
			this.btnDoubleDown.Hide();
			// checks the winner and displays the appropriate message and updates the balance.
			if (playerCardTotal > 21)
			{
				lblWinner.Text = "you Lose";
				MessageBox.Show(lblWinner.Text + "And the change to the balance is: -" + bet);

			}
			else if (dealerCardTotal > 21)
			{
				lblWinner.Text = "you win";
				balance = intEarnings + balance + bet;

			}
			else if (playerCardTotal == dealerCardTotal)
			{
				lblWinner.Text = "You tied , dealer wins.";


			}
			else if (playerCardTotal > dealerCardTotal)
			{
				lblWinner.Text = "you win";
				balance = balance + intEarnings + bet;

			}
			else if (playerCardTotal < dealerCardTotal)
			{
				lblWinner.Text = "you Lose";
				MessageBox.Show(lblWinner.Text + " Your balance is now:" + balance);


			}
			lblBalance.Text = String.Format("CA${0:0.00}", balance);

			if (playerCardTotal == 21)
			{
				lblBlackjack.Text = "BLACKJACK!";
			}
			// hides the bet button.
			this.button1.Hide();
			MessageBox.Show(lblWinner.Text + " Your balance is now:" + balance);






		}
		private void btnDone_Click(object sender, EventArgs e)
		{


		}

		private void resumeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			// acts as a play button and plays the music in a loop
			backSound.PlayLooping();
			resumeToolStripMenuItem.Enabled = false;
			muteToolStripMenuItem.Enabled = true;

		}

		private void muteToolStripMenuItem_Click(object sender, EventArgs e)
		{
			// acts as a mute button and stops the music.
			backSound.Stop();
			resumeToolStripMenuItem.Enabled = true;
			muteToolStripMenuItem.Enabled = false;

		}

		private void button1_Click(object sender, EventArgs e)
		{
				// shuffles cards
				if (listOfCards.Count <= 7)
                {
				MessageBox.Show("Shuffling cards!", "ShuffleTime");
				ShuffleCards();
				this.Refresh();


				}

			

				// if the bet is less than or equal to the balance of the user execute the functions.
				if (this.nudBetAmount.Value <= balance)
					{
						listOfCards.Count();
						listOfValues.Count();
						timer1.Start();




				//makes the bet
				bet = bet + (int)(this.nudBetAmount.Value);
					// removes the bet from the balance 
					balance = balance - bet;
					//assigns the random cards and display's their values( dealer's values are hidden.)(using lists)
					card1 = ChangeCard(ref picCard1);
					card2 = ChangeCard(ref picCard2);


					dealerCard1 = ChangeCard(ref picDealerCard1);
					dealerCard2 = ChangeCard(ref picDealerCard2);
					dealerCard3 = ChangeCard(ref picDealerCard3);
					// updates player card total.
					playerCardTotal = card1 + card2 + card3;
					// shows the player card total.
					lblPlayerTotal.Show();
					// displays the player's card total.
					lblPlayerTotal.Text = "Player Total:" + playerCardTotal;
					// shows the cards for the user.
					picCard1.Show();
					picCard2.Show();



					// shows the buttons for the user's options.
					this.btnHit.Show();
					this.btnStay.Show();
					this.btnDoubleDown.Show();
					// updates the balance text
					lblBalance.Text = String.Format("CA${0:0.00}", balance);
					// acts as a storage of the earnings if you win (half of the bet)
					Earnings = bet * 1 / 2;
					// converts the earnings to an int preventing decimals.
					intEarnings = Convert.ToInt32(Earnings);
					this.button1.Hide();
					if (hard == true)
					{
					aTimer.Interval = 10000;
					aTimer.Tick += new EventHandler(IncrementTimer);
					aTimer.Start();
					




				}

			}
				else if (nudBetAmount.Value > balance)
				{
					// if the bet is over the balance display an error message.
					this.lblBetError.Text = "Your balance is too low";
				}
			}
			
		

		private void label4_Click(object sender, EventArgs e)
		{

		}

		private void label8_Click(object sender, EventArgs e)
		{

		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			// closes the program/
			this.Close();
		}

		private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
		{


			// resets all the values and hides the cards and resets the text except for the balance to allow the user to play another game.
			this.btnHit.Hide();
			bet = bet * 0;
			this.btnStay.Hide();
			this.btnDoubleDown.Hide();
			this.btnHit.Hide();
			this.btnStay.Hide();
			this.btnDoubleDown.Hide();
			this.picCard1.Hide();
			this.picCard2.Hide();
			this.picCard3.Hide();
			this.picDealerCard1.Hide();
			this.picDealerCard2.Hide();
			this.picDealerCard3.Hide();
			this.picDealerCard4.Hide();
			this.button1.Show();
			this.lblDealerTotal.Hide();

			cardIndex1 = cardIndex1 * 0;
			cardIndex2 = cardIndex2 * 0;
			cardIndex3 = cardIndex3 * 0;
			dealerCardIndex1 = dealerCardIndex1 * 0;
			dealerCardIndex2 = dealerCardIndex2 * 0;
			dealerCardIndex3 = dealerCardIndex3 * 0;
			dealerCardIndex4 = dealerCardIndex4 * 0;


			this.lblDealerTotal.Hide();
			this.lblError.Text = "--";
			this.lblWinner.Text = "--";
			this.lblBlackjack.Text = "--";
			lblPlayerTotal.Hide();
			card1 = card1 * 0;
			card2 = card2 * 0;
			card3 = card3 * 0;
			dealerCard1 = dealerCard1 * 0;
			dealerCard2 = dealerCard2 * 0;
			dealerCard3 = dealerCard3 * 0;
			dealerCard4 = dealerCard4 * 0;
			lblBetError.Text = "--";
			playerCardTotal = playerCardTotal * 0;
			dealerCardTotal = dealerCardTotal * 0;
		


		}

		private void resetProgressToolStripMenuItem_Click(object sender, EventArgs e)
		{
			// Shows the loading screen.
			this.Hide();
			Form2 frm2 = new Form2();
			frm2.ShowDialog();
			// resets every value therefore starting the game from the beginning.
			bet = bet * 0;
			this.btnHit.Hide();
			this.btnStay.Hide();
			this.btnDoubleDown.Hide();
			this.btnHit.Hide();
			this.btnStay.Hide();
			this.btnDoubleDown.Hide();
			this.picCard1.Hide();
			this.picCard2.Hide();
			this.picCard3.Hide();
			this.picDealerCard1.Hide();
			this.picDealerCard2.Hide();
			this.picDealerCard3.Hide();
			this.picDealerCard4.Hide();
			this.lblDealerTotal.Hide();

			cardIndex1 = 0;
			cardIndex2 = 0;
			cardIndex3 = 0;
			dealerCardIndex1 = 0;
			dealerCardIndex2 = 0;
			dealerCardIndex3 = 0;
			dealerCardIndex4 = 0;

			this.lblDealerTotal.Hide();
			this.lblError.Text = "--";
			this.lblWinner.Text = "--";
			this.lblBlackjack.Text = "--";
			lblPlayerTotal.Hide();
			card1 = card1 * 0;
			card2 = card2 * 0;
			card3 = card3 * 0;
			dealerCard1 = dealerCard1 * 0;
			dealerCard2 = dealerCard2 * 0;
			dealerCard3 = dealerCard3 * 0;
			dealerCard4 = dealerCard4 * 0;
			playerCardTotal = playerCardTotal * 0;
			dealerCardTotal = dealerCardTotal * 0;
			lblBetError.Text = "--";
			this.button1.Show();
			balance = balance * 0 + 100;
			lblBalance.Text = String.Format("CA${0:0.00}", balance);

		}

		private void lblTime_Click(object sender, EventArgs e)
		{

		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{

		}

		private void challengingToolStripMenuItem_Click(object sender, EventArgs e)
		{
			// changes the bool to be true to allow the timer to start making the game more difficult.
			hard = true;
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void regularToolStripMenuItem_Click(object sender, EventArgs e)
		{
			// changes the bool to be false to change the game to regular mode.
			hard = false;
		}

		private void lblBetError_Click(object sender, EventArgs e)
		{

		}

		private void btnShuffle_Click(object sender, EventArgs e)
		{ 
			
					

		}
	}
}
