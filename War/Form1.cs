using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Jasmine
//October 2022
//A simple game of card war

namespace War
{
    public partial class Form1 : Form
    {
        //random generator for picking new cards   
        Random randGen = new Random();

        //variables to hold card values 
        int playerCard, computerCard;

        //variables to hold scores, initialized to 0
        int playerScore = 0;
        int computerScore = 0; 

        public Form1()
        {
            InitializeComponent();
        }

        private void warButton_Click(object sender, EventArgs e)
        {
            //clear card back images
            playerCardLabel.Image = null;
            cpuCardLabel.Image = null;

            //get random value between 1 and 10 for both player and cpu
            playerCard = randGen.Next(1,11);
            computerCard = randGen.Next(1,11);

            //display card values to the labels
            playerCardLabel.Text = $"{playerCard}";
            cpuCardLabel.Text = $"{computerCard}";

            // if player value is greater then cpu card
            //    add to player score 
            //    show new player score 
            //    show message saying player won
            if (playerCard > computerCard)
            {
                playerScore++;
                playerScoreLabel.Text = $"{playerScore}";
                outputLabel.Text = "Player Won!!!";
            }
            else if (computerCard > playerCard)
            {
                computerScore++;
                cpuScoreLabel.Text = $"{computerScore}";
                outputLabel.Text = "Computer Won :(";
            }
            else
                {
                outputLabel.Text = "It's a tie";
            }


            }

            // if player value is less then cpu card
            //    add to cpu score
            //    show new cpu score
            //    show message saying cpu won

            // if player value is equal to cpu value 
            //    show message that this round is a tie.                  

        }


}

