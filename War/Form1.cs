using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//header info

namespace War
{
    public partial class Form1 : Form
    {
        //random generator for picking new cards   

        //variables to hold card values 

        //variables to hold scores, initialized to 0


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

            
            //display card values to the labels


            // if player value is greater then cpu card
            //    add to player score 
            //    show new player score 
            //    show message saying player won
              
            // if player value is less then cpu card
            //    add to cpu score
            //    show new cpu score
            //    show message saying cpu won
              
            // if player value is equal to cpu value 
            //    show message that this round is a tie.                  

        }
    }
}
