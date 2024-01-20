using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FloppGame
{
    public partial class GameForm : Form
    {
        int gravity = 7;//variable for gravity(bird speed)
        int pipespeed = 7;//variable for pipe moving speed
        int score = 0;//variable for score
        
        public GameForm()
        {
            InitializeComponent();
        }

       

        private void GameKeyisDown(object sender, KeyEventArgs e)//event when you press the space(bird will fly up)
        {
            if(e.KeyCode == Keys.Space)
            {
                gravity = -10;
            }
        }

        private void GameKeyIsUp(object sender, KeyEventArgs e)//event when you release the space(bird will start dropping)
        {
            gravity = 10;
        }

        public void endGame()//function which shows the messagebox with the message if you hit any of the obstacles
        {
            TimerGame.Stop();
            if(DialogResult.OK == MessageBox.Show("Game over!\n Your score is: " + score, "Game over!", MessageBoxButtons.OK, MessageBoxIcon.Information))
            {
                this.Close();//gameform closes when you click ok in the messagebox
            }
           
            
        }

       

        private void GameTimerEvent(object sender, EventArgs e)//event which starts the timer when you start the game
        {
            pictureBird.Top += gravity;//bird starts dropping because of gravity
            picturePipeTop.Left -= pipespeed;//top pipe moving left towards the bird equal to the pipespeed
            picturePipeDown.Left -= pipespeed;//bottom pipe moving left toward the bird equal to the pipespeed
            label1.Text = "Score:" + score.ToString();//chaing label1 text  to show the score

            if (picturePipeDown.Left < -180)//reseting the position of the bottom pipe when it goes out of form
            {
                picturePipeDown.Left = 700;
                score++;
            }
            if (picturePipeTop.Left < -150)//reseting the position of the top pipe when it goes out of form
            {
                picturePipeTop.Left = 720;
                
            }
            if(score >= 3)//increasing the speed of the pipes when player reach score 3.
            {
                pipespeed = 12;
            }
            if(score >= 7)//increasing the speed of the pipes when player reach score 7.
            {
                pipespeed = 17;
            }

            //if statement that checks if bird touched any of the obstacles and calling fuction endgame if that is the case
            if (pictureBird.Bounds.IntersectsWith(picturePipeTop.Bounds) || 
                pictureBird.Bounds.IntersectsWith(picturePipeDown.Bounds) || 
                pictureBird.Bounds.IntersectsWith(pictureGround.Bounds) ||
                pictureBird.Top < - 25)
            {
                endGame();
            }

            



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
