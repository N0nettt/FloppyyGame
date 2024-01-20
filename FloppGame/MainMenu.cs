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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }
        public static FontFamily Arial = new FontFamily("Arial"); // FontFamily i'm going to use.
        public static Font font = new Font(Arial, 24, FontStyle.Bold | FontStyle.Underline); // Font when you hover the lables.
        public static Font font1 = new Font(Arial, 24, FontStyle.Bold); // Font when you dont hover the labels.


        

      

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

       


        private void lblStartMouseEnter(object sender, EventArgs e)
        {
            lblStartGame.Font = font; //Event to change font when you hover label Start Game
        }

        private void lblStartMouseLeave(object sender, EventArgs e)
        {
            lblStartGame.Font = font1; //Event to change font when you stop hovering label Start Game
        }

        private void lblQuitMouseEnter(object sender, EventArgs e)
        {
            lblQuitGame.Font = font; //Event to change font when you hover label Quit Game
        }

        private void lblQuitMouseLeave(object sender, EventArgs e)
        {
            lblQuitGame.Font = font1; //Event to change font when you stop hovering label Quit Game
        }

        private void lblStartGame_MouseClick(object sender, MouseEventArgs e) //Event on mosue click to Start game when you click label Start Game
        {
            GameForm game = new GameForm(); 
            game.ShowDialog();

        }

        private void lblQuitGame_Click(object sender, EventArgs e) // Event on mouse click to startin closing game when you click QuitGame
        {
            this.Close();
        }

        private void MainMenu_FormClosing(object sender, FormClosingEventArgs e)//Event to confirm closing the game or stop it
        {
            if (DialogResult.Yes == MessageBox.Show("Are you really surrendering?", "Quiting the game", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {

            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
