using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Need to include to use threading
using System.Threading;

namespace CS3280Homework2
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Function to roll the dice
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rollDice_Click(object sender, EventArgs e)
        {
            int playerGuess = 0;
            int dice = 0;

            int.TryParse(userGuess.Text, out playerGuess);

            if (verifyUserInput(playerGuess))
            {
                pbImage.SizeMode = PictureBoxSizeMode.StretchImage;

                Random random = new Random();
                int rolls = random.Next(5, 8);

                for (int i = 1; i < rolls; i++) // randomly displays 5-7 pictures
                {
                    dice = random.Next(1, 7);
                    pbImage.Image = Image.FromFile("die" + dice.ToString() + ".gif");
                    pbImage.Refresh();
                    Thread.Sleep(300);
                }
                Compare(playerGuess, dice);
                updateTotals(playerGuess, dice);
            }
        }

        /// <summary>
        /// Verifies that the users input is between 1 and 6.
        /// </summary>
        /// <param name="userInput"></param>
        /// <returns></returns>
        private bool verifyUserInput(int playerGuess)
        {
            if (playerGuess <= 6 && playerGuess >= 1)
            {
                resultLabel.Text = "";
                return true;
            }
            else
            {
                resultLabel.BackColor = System.Drawing.Color.Red;
                resultLabel.Text = "Invalid input. Please try a number between 1 and 6.";
                return false;
            }
        }

        /// <summary>
        /// Updates the tables showing the statistics
        /// </summary>
        /// <param name="playerGuess"></param>
        /// <param name="dice"></param>
        private void updateTotals(int playerGuess, int dice)
        {
            played.Text = (int.Parse(played.Text) + 1).ToString(); // increments the times played
            if (playerGuess == dice) // increments the times right or times wrong
            {
                right.Text = (int.Parse(right.Text) + 1).ToString();
            }
            else
            {
                wrong.Text = (int.Parse(wrong.Text) + 1).ToString();
            }
            updateTimesLandedOnColumn(dice);
            updateTimesPlayerGuessedColumn(playerGuess);
            updatePercentsColumn();
        }

        /// <summary>
        /// Compares the players guess and the rolled dice to see if they were correct. 
        /// It then will print a statement and return either true or false.
        /// </summary>
        /// <param name="playerGuess"></param>
        /// <param name="dice"></param>
        /// <returns></returns>
        private bool Compare(int playerGuess, int dice)
        {
            if (playerGuess == dice)
            {
                resultLabel.BackColor = System.Drawing.Color.Green;
                resultLabel.Text = "That is correct!";
                return true;
            }
            else
            {
                resultLabel.BackColor = System.Drawing.Color.Red;
                resultLabel.Text = "You chose....poorly...";
                return false;
            }
        }

        private void updateTimesLandedOnColumn(int dice)
        {
            switch (dice) // increments the times landed on column in the table
            {
                case 1:
                    timesLandedOn1.Text = (int.Parse(timesLandedOn1.Text) + 1).ToString();
                    break;
                case 2:
                    timesLandedOn2.Text = (int.Parse(timesLandedOn2.Text) + 1).ToString();
                    break;
                case 3:
                    timesLandedOn3.Text = (int.Parse(timesLandedOn3.Text) + 1).ToString();
                    break;
                case 4:
                    timesLandedOn4.Text = (int.Parse(timesLandedOn4.Text) + 1).ToString();
                    break;
                case 5:
                    timesLandedOn5.Text = (int.Parse(timesLandedOn5.Text) + 1).ToString();
                    break;
                case 6:
                    timesLandedOn6.Text = (int.Parse(timesLandedOn6.Text) + 1).ToString();
                    break;
                default:
                    break;
            }
        }

        private void updatePercentsColumn()
        {
            Percent1.Text = ((float.Parse(timesLandedOn1.Text) / float.Parse(played.Text)) * 100).ToString();
            Percent2.Text = ((float.Parse(timesLandedOn2.Text) / float.Parse(played.Text)) * 100).ToString();
            Percent3.Text = ((float.Parse(timesLandedOn3.Text) / float.Parse(played.Text)) * 100).ToString();
            Percent4.Text = ((float.Parse(timesLandedOn4.Text) / float.Parse(played.Text)) * 100).ToString();
            Percent5.Text = ((float.Parse(timesLandedOn5.Text) / float.Parse(played.Text)) * 100).ToString();
            Percent6.Text = ((float.Parse(timesLandedOn6.Text) / float.Parse(played.Text)) * 100).ToString();
        }

        private void updateTimesPlayerGuessedColumn(int playerGuess)
        {
            switch (playerGuess) // increments the times player guessed column in the table
            {
                case 1:
                    timesPlayerGuessed1.Text = (int.Parse(timesPlayerGuessed1.Text) + 1).ToString();
                    break;
                case 2:
                    timesPlayerGuessed2.Text = (int.Parse(timesPlayerGuessed2.Text) + 1).ToString();
                    break;
                case 3:
                    timesPlayerGuessed3.Text = (int.Parse(timesPlayerGuessed3.Text) + 1).ToString();
                    break;
                case 4:
                    timesPlayerGuessed4.Text = (int.Parse(timesPlayerGuessed4.Text) + 1).ToString();
                    break;
                case 5:
                    timesPlayerGuessed5.Text = (int.Parse(timesPlayerGuessed5.Text) + 1).ToString();
                    break;
                case 6:
                    timesPlayerGuessed6.Text = (int.Parse(timesPlayerGuessed6.Text) + 1).ToString();
                    break;
                default:
                    break;
            }
        }
    }
}
