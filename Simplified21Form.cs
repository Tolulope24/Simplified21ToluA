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
        public frmSimplified21()
        {
            InitializeComponent();
            // Hide unknown labels
            picFireworks.Hide();
            lblComputerWins.Hide();
            lblPlayerWins.Hide();
            picFirstComputerCard.Hide();
            picsecondComputerCard.Hide();
            picThirdComputerCard.Hide();

        }

        private void lblPlayerWins_Click(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            const int MIN_NUMBER = 1;
            const int MAX_NUMBER = 10;
            int aRandomNumber;


        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
         
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
    }
}
