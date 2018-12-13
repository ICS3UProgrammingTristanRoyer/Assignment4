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





		// declare global variables
		int MIN_CARD = 1;
		int MAX_CARD = 10;
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
			this.lblCard1.Hide();
			this.lblCard2.Hide();
			this.lblCard3.Hide();
			this.lblDealerCard1.Hide();
			this.lblDealerCard2.Hide();
			this.lblDealerCard3.Hide();
			this.lblDealerCard4.Hide();
			this.lblDealerTotal.Hide();


			// play music and disable the resume menu item.
			backSound.PlayLooping();
			resumeToolStripMenuItem.Enabled = false;
			muteToolStripMenuItem.Enabled = true;


		}

		private void StartTimer()
		{
			int theCounter = 10;

			{
				for (int counter = 10; counter > 0; counter += -1)

					{

						theCounter = theCounter - 1;
						lblTimer.Text = "Time Left:" + theCounter;
						Thread.Sleep(1000);
						this.Refresh();


						if (theCounter == 0)
						{
							
							MessageBox.Show(lblWinner.Text + "Your balance is now:" + balance);
							lblWinner.Text = "you Lose";
							
							// show the deal values 
							lblDealerTotal.Show();
							lblDealerCard1.Show();
							lblDealerCard2.Show();
							lblDealerCard3.Show();
							// hide the buttons for the user's choices.
							this.btnHit.Hide();
							this.btnStay.Hide();
							this.btnDoubleDown.Hide();
							this.button1.Hide();
						}

				}
				
			}




		}

		private void ShuffleCards(ref List<Image> theListOfCards)
		{
			// plays the shuffle sound
			shuffleSound.Play();

			theListOfCards.Insert(0, Properties.Resources.heart1);
			theListOfCards.Insert(1, Properties.Resources.heart2);
			theListOfCards.Insert(2, Properties.Resources.heart3);
			theListOfCards.Insert(3, Properties.Resources.heart4);			
			theListOfCards.Insert(4, Properties.Resources.heart5);
			theListOfCards.Insert(5, Properties.Resources.heart6);
			theListOfCards.Insert(6, Properties.Resources.heart7);
			theListOfCards.Insert(7, Properties.Resources.heart8);
			theListOfCards.Insert(8, Properties.Resources.heart9);
			theListOfCards.Insert(9, Properties.Resources.heart10);
			theListOfCards.Insert(10, Properties.Resources.heartJ);
			theListOfCards.Insert(11, Properties.Resources.heartQ);
			theListOfCards.Insert(12, Properties.Resources.heartK);
			theListOfCards.Insert(13, Properties.Resources.club1);
			theListOfCards.Insert(14, Properties.Resources.club2);
			theListOfCards.Insert(15, Properties.Resources.club3);
			theListOfCards.Insert(16, Properties.Resources.club4);
			theListOfCards.Insert(17, Properties.Resources.club5);
			theListOfCards.Insert(18, Properties.Resources.club6);
			theListOfCards.Insert(19, Properties.Resources.club7);
			theListOfCards.Insert(20, Properties.Resources.club8);
			theListOfCards.Insert(21, Properties.Resources.club9);
			theListOfCards.Insert(22, Properties.Resources.club10);
			theListOfCards.Insert(23, Properties.Resources.clubJ);
			theListOfCards.Insert(24, Properties.Resources.clubQ);
			theListOfCards.Insert(25, Properties.Resources.clubK);
			theListOfCards.Insert(26, Properties.Resources.diamond1);
			theListOfCards.Insert(27, Properties.Resources.diamond2);
			theListOfCards.Insert(28, Properties.Resources.diamond3);
			theListOfCards.Insert(29, Properties.Resources.diamond4);
			theListOfCards.Insert(30, Properties.Resources.diamond5);
			theListOfCards.Insert(31, Properties.Resources.diamond6);
			theListOfCards.Insert(32, Properties.Resources.diamond7);
			theListOfCards.Insert(33, Properties.Resources.diamond8);
			theListOfCards.Insert(34, Properties.Resources.diamond9);
			theListOfCards.Insert(35, Properties.Resources.diamond10);
			theListOfCards.Insert(36, Properties.Resources.diamondJ);
			theListOfCards.Insert(37, Properties.Resources.diamondQ);
			theListOfCards.Insert(38, Properties.Resources.diamondK);
			theListOfCards.Insert(39, Properties.Resources.spade1);
			theListOfCards.Insert(40, Properties.Resources.spade2);
			theListOfCards.Insert(41, Properties.Resources.spade3);
			theListOfCards.Insert(42, Properties.Resources.spade4);
			theListOfCards.Insert(43, Properties.Resources.spade5);
			theListOfCards.Insert(44, Properties.Resources.spade6);
			theListOfCards.Insert(45, Properties.Resources.spade7);
			theListOfCards.Insert(46, Properties.Resources.spade8);
			theListOfCards.Insert(47, Properties.Resources.spade9);
			theListOfCards.Insert(48, Properties.Resources.spade10);
			theListOfCards.Insert(49, Properties.Resources.spadeJ);
			theListOfCards.Insert(50, Properties.Resources.spadeQ);
			theListOfCards.Insert(51, Properties.Resources.spadeK);
			
	









		}
		private int ChangeCard (ref List<Image>theListOfCards, thePictureBox , theIndex)
		{
			int cardValue;
			if (theIndex = 1)
			{
				thePictureBox.Image = theListOfCards[1]
				theListOfCards.RemoveAt(1);
				cardValue = 1;
			}


		}

			// do bankrupt idea for extra partial
			// ** if balance = 0 **//
		private void timer_Tick(object sender, EventArgs e)
		{
			lblTime.Text = DateTime.Now.ToString("HH:mm:ss tt");

		}

		
	   
		private void btnHit_Click(object sender, EventArgs e)
		{
			// declare local variables and assign values and update text.
			const int STAY = 1;
			const int HIT = 2;
			const int DEALERMINIMUM = 1;
			const int DEALERMAXIMUM = 2;
			int dealerChoice;
			card3 = rnd.Next(MIN_CARD, MAX_CARD + 1);
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
				dealerCard4 = rnd.Next(MIN_CARD, MAX_CARD + 1);
				dealerCardTotal = dealerCardTotal + dealerCard1 + dealerCard2 + dealerCard3 + dealerCard4;
				lblDealerTotal.Text = "Dealer Total:" + dealerCardTotal;
			

			}
			// show the deal values 
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
			MessageBox.Show(lblWinner.Text + "Your balance is now:" + balance);


		}

		private void btnDoubleDown_Click(object sender, EventArgs e)
		{
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
				card3 = rnd.Next(MIN_CARD, MAX_CARD + 1);
				
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
					dealerCard4 = rnd.Next(MIN_CARD, MAX_CARD + 1);
					dealerCardTotal = dealerCardTotal + dealerCard1 + dealerCard2 + dealerCard3 + dealerCard4;
					lblDealerTotal.Text = "Dealer Total:" + dealerCardTotal;
					lblDealerCard4.Text = " " + dealerCard4;
					lblDealerCard4.Show();

				}
				// displays the dealer's values
				lblDealerTotal.Show();
				lblDealerCard1.Show();
				lblDealerCard2.Show();
				lblDealerCard3.Show();
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
			// hides the bet button.
			this.button1.Hide();
			MessageBox.Show(lblWinner.Text + "Your balance is now:" + balance);


		}

		private void btnStay_Click(object sender, EventArgs e)
		{
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
				dealerCard4 = rnd.Next(MIN_CARD, MAX_CARD + 1);
				dealerCardTotal = dealerCardTotal + dealerCard1 + dealerCard2 + dealerCard3 + dealerCard4;
				lblDealerTotal.Text = "Dealer Total:" + dealerCardTotal;
			

			}
			// show the dealer values
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

			}
			lblBalance.Text = String.Format("CA${0:0.00}", balance);

			if (playerCardTotal == 21)
			{
				lblBlackjack.Text = "BLACKJACK!";
			}
			// hides the bet button.
			this.button1.Hide();
			MessageBox.Show(lblWinner.Text + "Your balance is now:" + balance);






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

			// if the bet is less than or equal to the balance of the user execute the functions.
			if (this.nudBetAmount.Value <= balance)
			{
				// bool to let the timer start
				//makes the bet
				bet = bet + (int)(this.nudBetAmount.Value);
				// removes the bet from the balance 
				balance = balance - bet;
				//assigns the random cards and display's their values( dealer's values are hidden.)
				card1 = rnd.Next(MIN_CARD, MAX_CARD + 1);
				card2 = rnd.Next(MIN_CARD, MAX_CARD + 1);
			
				dealerCard1 = rnd.Next(MIN_CARD, MAX_CARD + 1);
				dealerCard2 = rnd.Next(MIN_CARD, MAX_CARD + 1);
				dealerCard3 = rnd.Next(MIN_CARD, MAX_CARD + 1);
			
				// updates player card total.
				playerCardTotal = card1 + card2 + card3;
				// shows the player card total.
				lblPlayerTotal.Show();
				// displays the player's card total.
				lblPlayerTotal.Text = "Player Total:" + playerCardTotal;
				// shows the cards for the user.
				
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
				timer1.Start();
				if (hard == true)
				{
					StartTimer();
				
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
		
			
			this.lblDealerTotal.Hide();
			this.lblError.Text = "--";
			this.lblWinner.Text = "--";
			this.lblBlackjack.Text = "--";
			lblPlayerTotal.Hide();
			this.button1.Show();
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
			// resets every value therefore starting the game from the beginning.
			bet = bet * 0;
			this.btnHit.Hide();
			this.btnStay.Hide();
			this.btnDoubleDown.Hide();
			
			this.lblDealerTotal.Hide();
			this.lblError.Text = "--";
			this.lblWinner.Text = "--";
			this.lblBlackjack.Text = "--";
			lblPlayerTotal.Hide();
			this.button1.Show();
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
			balance = balance * 0 + 100;
			lblBalance.Text = String.Format("CA${0:0.00}", balance);
			this.Hide();
			Form2 frm2 = new Form2();
			frm2.ShowDialog();

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
	}
}
