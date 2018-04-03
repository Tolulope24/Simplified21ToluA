using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simplified21ToluA
{
    public partial class frmSimplified21 : Form
    {

        Random randomNumberGenerator = new Random();

        public frmSimplified21()
        {
            InitializeComponent();
            // Hide labels
            picFireworks.Hide();
            lblComputerWins.Hide();
            lblPlayerWins.Hide();
            picThirdComputerCard.Hide();
            picFirstComputerCard.Hide();
            picsecondComputerCard.Hide();
            picThirdComputerCard.Hide();
            picThirdPlayerCard.Hide();

        }

        private void lblPlayerWins_Click(object sender, EventArgs e)
        {

        }



        private void btnStart_Click(object sender, EventArgs e)
        {
            // Identify Constants
            double sumPlayerCard;
            double sumComputerCard;
            const int MIN_NUMBER = 1;
            const int MAX_NUMBER = 10;

            int playerFirstCardNumber;
            int playerSecondCardNumber;
            int playerThirdCardNumber;

            int computerFirstCardNumber;
            int computerSecondCardNumber;
            int computerThirdCardNumber;
            

            // assign the first player card number randomly
            playerFirstCardNumber = randomNumberGenerator.Next(MIN_NUMBER, MAX_NUMBER + 1);
            playerSecondCardNumber = randomNumberGenerator.Next(MIN_NUMBER, MAX_NUMBER + 1);
            playerThirdCardNumber = randomNumberGenerator.Next(MIN_NUMBER, MAX_NUMBER + 1);
            // Add the total 
            sumPlayerCard = playerFirstCardNumber + playerSecondCardNumber + playerThirdCardNumber;

            computerFirstCardNumber = randomNumberGenerator.Next(MIN_NUMBER, MAX_NUMBER + 1);
            computerSecondCardNumber = randomNumberGenerator.Next(MIN_NUMBER, MAX_NUMBER + 1);
            computerThirdCardNumber = randomNumberGenerator.Next(MIN_NUMBER, MAX_NUMBER + 1);
            // Add the total
            sumComputerCard = computerFirstCardNumber + computerSecondCardNumber + computerThirdCardNumber;


            // assign the card image to the first player card picture box
            if (playerFirstCardNumber == 1)
            {
                this.picFirstPlayerCard.Image = Properties.Resources.c01;
            }
            else if (playerFirstCardNumber == 2)
            {
                this.picFirstPlayerCard.Image = Properties.Resources.c02;
            }
            else if (playerFirstCardNumber == 3)
            {
                this.picFirstPlayerCard.Image = Properties.Resources.c03;
            }
            else if (playerFirstCardNumber == 4)
            {
                this.picFirstPlayerCard.Image = Properties.Resources.c04;
            }
            else if (playerFirstCardNumber == 5)
            {
                this.picFirstPlayerCard.Image = Properties.Resources.c05;
            }
            else if (playerFirstCardNumber == 6)
            {
                this.picFirstPlayerCard.Image = Properties.Resources.c06;
            }
            else if (playerFirstCardNumber == 7)
            {
                this.picFirstPlayerCard.Image = Properties.Resources.c07;
            }
            else if (playerFirstCardNumber == 8)
            {
                this.picFirstPlayerCard.Image = Properties.Resources.c08;
            }
            else if (playerFirstCardNumber == 9)
            {
                this.picFirstPlayerCard.Image = Properties.Resources.c09;
            }
            else if (playerFirstCardNumber == 10)
            {
                this.picFirstPlayerCard.Image = Properties.Resources.c10;
            }
            // assign the card image to the first player card picture box
            if (playerSecondCardNumber == 1)
            {
                this.picSecondPlayerCard.Image = Properties.Resources.c01;
            }
            else if (playerSecondCardNumber == 2)
            {
                this.picSecondPlayerCard.Image = Properties.Resources.c02;
            }
            else if (playerSecondCardNumber == 3)
            {
                this.picSecondPlayerCard.Image = Properties.Resources.c03;
            }
            else if (playerSecondCardNumber == 4)
            {
                this.picSecondPlayerCard.Image = Properties.Resources.c04;
            }
            else if (playerSecondCardNumber == 5)
            {
                this.picSecondPlayerCard.Image = Properties.Resources.c05;
            }
            else if (playerSecondCardNumber == 6)
            {
                this.picSecondPlayerCard.Image = Properties.Resources.c06;
            }
            else if (playerSecondCardNumber == 7)
            {
                this.picSecondPlayerCard.Image = Properties.Resources.c07;
            }
            else if (playerSecondCardNumber == 8)
            {
                this.picSecondPlayerCard.Image = Properties.Resources.c08;
            }
            else if (playerSecondCardNumber == 9)
            {
                this.picSecondPlayerCard.Image = Properties.Resources.c09;
            }
            else if (playerSecondCardNumber == 10)
            {
                this.picSecondPlayerCard.Image = Properties.Resources.c10;
            }
            // assign the card image to the third player card picture box
            if (playerThirdCardNumber == 1)
            {
                this.picThirdPlayerCard.Image = Properties.Resources.c03;
            }
            else if (playerThirdCardNumber == 2)
            {
                this.picThirdPlayerCard.Image = Properties.Resources.c02;
            }
            else if (playerThirdCardNumber == 3)
            {
                this.picThirdPlayerCard.Image = Properties.Resources.c03;
            }
            else if (playerThirdCardNumber == 4)
            {
                this.picThirdPlayerCard.Image = Properties.Resources.c04;
            }
            else if (playerThirdCardNumber == 5)
            {
                this.picThirdPlayerCard.Image = Properties.Resources.c05;
            }
            else if (playerThirdCardNumber == 6)
            {
                this.picThirdPlayerCard.Image = Properties.Resources.c06;
            }
            else if (playerThirdCardNumber == 7)
            {
                this.picThirdPlayerCard.Image = Properties.Resources.c07;
            }
            else if (playerThirdCardNumber == 8)
            {
                this.picThirdPlayerCard.Image = Properties.Resources.c08;
            }
            else if (playerThirdCardNumber == 9)
            {
                this.picThirdPlayerCard.Image = Properties.Resources.c09;
            }
            else if (playerThirdCardNumber == 10)
            {
                this.picThirdPlayerCard.Image = Properties.Resources.c10;
            }
           



            // Assign Random Numbers for first Computer card Picture box
            if (computerFirstCardNumber == 1)
            {
                this.picFirstComputerCard.Image = Properties.Resources.d01;
            }
            if (computerFirstCardNumber == 2)
            {
                this.picFirstComputerCard.Image = Properties.Resources.d02;
            }
            if (computerFirstCardNumber == 3)
            {
                this.picFirstComputerCard.Image = Properties.Resources.d03;
            }
            if (computerFirstCardNumber == 4)
            {
                this.picFirstComputerCard.Image = Properties.Resources.d04;
            }
            if (computerFirstCardNumber == 5)
            {
                this.picFirstComputerCard.Image = Properties.Resources.d05;
            }
            if (computerFirstCardNumber == 6)
            {
                this.picFirstComputerCard.Image = Properties.Resources.d06;
            }
            if (computerFirstCardNumber == 7)
            {
                this.picFirstComputerCard.Image = Properties.Resources.d07;
            }
            if (computerFirstCardNumber == 8)
            {
                this.picFirstComputerCard.Image = Properties.Resources.d08;
            }
            if (computerFirstCardNumber == 9)
            {
                this.picFirstComputerCard.Image = Properties.Resources.d09;
            }
            if (computerFirstCardNumber == 10)
            {
                this.picFirstComputerCard.Image = Properties.Resources.d10;
            }
            // Assign Random Numbers for second Computer card Picture box
            if (computerSecondCardNumber == 1)
            {
                this.picsecondComputerCard.Image = Properties.Resources.d01;
            }
            if (computerSecondCardNumber == 2)
            {
                this.picsecondComputerCard.Image = Properties.Resources.d03;
            }
            if (computerSecondCardNumber == 3)
            {
                this.picsecondComputerCard.Image = Properties.Resources.d03;
            }
            if (computerSecondCardNumber == 4)
            {
                this.picsecondComputerCard.Image = Properties.Resources.d04;
            }
            if (computerSecondCardNumber == 5)
            {
                this.picsecondComputerCard.Image = Properties.Resources.d05;
            }
            if (computerSecondCardNumber == 6)
            {
                this.picsecondComputerCard.Image = Properties.Resources.d06;
            }
            if (computerSecondCardNumber == 7)
            {
                this.picsecondComputerCard.Image = Properties.Resources.d07;
            }
            if (computerSecondCardNumber == 8)
            {
                this.picsecondComputerCard.Image = Properties.Resources.d08;
            }
            if (computerSecondCardNumber == 9)
            {
                this.picsecondComputerCard.Image = Properties.Resources.d09;
            }
            if (computerSecondCardNumber == 10)
            {
                this.picsecondComputerCard.Image = Properties.Resources.d10;
            }
            // Assign Random Numbers for third Computer card Picture box
            if (computerThirdCardNumber == 1)
            {
                this.picThirdComputerCard.Image = Properties.Resources.d01;
            }
            if (computerThirdCardNumber == 2)
            {
                this.picThirdComputerCard.Image = Properties.Resources.d02;
            }
            if (computerThirdCardNumber == 3)
            {
                this.picThirdComputerCard.Image = Properties.Resources.d04;
            }
            if (computerThirdCardNumber == 4)
            {
                this.picThirdComputerCard.Image = Properties.Resources.d04;
            }
            if (computerThirdCardNumber == 5)
            {
                this.picThirdComputerCard.Image = Properties.Resources.d05;
            }
            if (computerThirdCardNumber == 6)
            {
                this.picThirdComputerCard.Image = Properties.Resources.d06;
            }
            if (computerThirdCardNumber == 7)
            {
                this.picThirdComputerCard.Image = Properties.Resources.d07;
            }
            if (computerThirdCardNumber == 8)
            {
                this.picThirdComputerCard.Image = Properties.Resources.d08;
            }
            if (computerThirdCardNumber == 9)
            {
                this.picThirdComputerCard.Image = Properties.Resources.d09;
            }
            if (computerThirdCardNumber == 10)
            {
                this.picThirdComputerCard.Image = Properties.Resources.d10;
            }
           
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = true;
            btnStay.Enabled = true;
            btnHit.Enabled = true;
            picFirstComputerCard.Hide();
            picsecondComputerCard.Hide();
            picThirdComputerCard.Hide();
            picThirdPlayerCard.Hide();

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void picSecondPlayerCard_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnHit_Click(object sender, EventArgs e)
        {
            // Identify Constants
            double sumPlayerCard;
            double sumComputerCard;
            const int MIN_NUMBER = 1;
            const int MAX_NUMBER = 10;

            int playerFirstCardNumber;
            int playerSecondCardNumber;
            int playerThirdCardNumber;

            int computerFirstCardNumber;
            int computerSecondCardNumber;
            int computerThirdCardNumber;


            // assign the first player card number randomly
            playerFirstCardNumber = randomNumberGenerator.Next(MIN_NUMBER, MAX_NUMBER + 1);
            playerSecondCardNumber = randomNumberGenerator.Next(MIN_NUMBER, MAX_NUMBER + 1);
            playerThirdCardNumber = randomNumberGenerator.Next(MIN_NUMBER, MAX_NUMBER + 1);
            // Add the total 
            sumPlayerCard = playerFirstCardNumber + playerSecondCardNumber + playerThirdCardNumber;

            computerFirstCardNumber = randomNumberGenerator.Next(MIN_NUMBER, MAX_NUMBER + 1);
            computerSecondCardNumber = randomNumberGenerator.Next(MIN_NUMBER, MAX_NUMBER + 1);
            computerThirdCardNumber = randomNumberGenerator.Next(MIN_NUMBER, MAX_NUMBER + 1);
            // Add the total
            sumComputerCard = computerFirstCardNumber + computerSecondCardNumber + computerThirdCardNumber;

            // Add Ramdom Numbers  from the player card together 
            if ((sumPlayerCard > 21) && (sumComputerCard < 21))
            {
                lblComputerWins.Show();
                picFireworks.Show();
            }
            else if ((sumPlayerCard < 21) && (sumComputerCard > 21))
            {
                lblPlayerWins.Show();
                picFireworks.Show();
            }
            else if ((sumPlayerCard > 21) && (sumComputerCard > 21))
            {
                lblComputerWins.Show();
                picFireworks.Show();
            }


            btnHit.Enabled = false;
            btnStay.Enabled = false;
            btnStart.Enabled = false;
            picThirdPlayerCard.Show();
            picThirdPlayerCard.Hide();
            picFirstComputerCard.Show();
            picsecondComputerCard.Show();
            picThirdComputerCard.Show();
        }

        private void btnStay_Click(object sender, EventArgs e)
        {
            // Identify Constants
            double sumPlayerCard;
            double sumComputerCard;
            const int MIN_NUMBER = 1;
            const int MAX_NUMBER = 10;

            int playerFirstCardNumber;
            int playerSecondCardNumber;
            int playerThirdCardNumber;

            int computerFirstCardNumber;
            int computerSecondCardNumber;
            int computerThirdCardNumber;


            // assign the first player card number randomly
            playerFirstCardNumber = randomNumberGenerator.Next(MIN_NUMBER, MAX_NUMBER + 1);
            playerSecondCardNumber = randomNumberGenerator.Next(MIN_NUMBER, MAX_NUMBER + 1);
            playerThirdCardNumber = randomNumberGenerator.Next(MIN_NUMBER, MAX_NUMBER + 1);
            // Add the total 
            sumPlayerCard = playerFirstCardNumber + playerSecondCardNumber + playerThirdCardNumber;

            computerFirstCardNumber = randomNumberGenerator.Next(MIN_NUMBER, MAX_NUMBER + 1);
            computerSecondCardNumber = randomNumberGenerator.Next(MIN_NUMBER, MAX_NUMBER + 1);
            computerThirdCardNumber = randomNumberGenerator.Next(MIN_NUMBER, MAX_NUMBER + 1);
            // Add the total
            sumComputerCard = computerFirstCardNumber + computerSecondCardNumber + computerThirdCardNumber;

            // Add Ramdom Numbers  from the player card together 
            if ((sumPlayerCard > 21) && (sumComputerCard < 21))
            {
                lblComputerWins.Show();
                picFireworks.Show();
            }
            if ((sumPlayerCard < 21) && (sumComputerCard > 21))
            {
                lblPlayerWins.Show();
                picFireworks.Show();
            }
            if ((sumPlayerCard > 21) && (sumComputerCard > 21))
            {
                lblComputerWins.Show();
                picFireworks.Show();
            }
                
            btnStay.Enabled = false;
            btnHit.Enabled = false;
            btnStart.Enabled = false;
            picThirdPlayerCard.Hide();
            picFirstComputerCard.Show();
            picsecondComputerCard.Show();
            picThirdComputerCard.Show();
        }

        private void frmSimplified21_Load(object sender, EventArgs e)
        {

        }
    }
}
