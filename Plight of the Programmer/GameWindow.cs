using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices; // Command Line

namespace Plight_of_the_Programmer
{
    public partial class GameWindow : Form
    {
        /*-----Constants-----*/
        public const int CANVAS_HEIGHT = 600;
        public const int CANVAS_WIDTH = 800;

        /*-----Variables-----*/
        private bool inMenu = true;
        private int selectedButton = 0;

        /*-----Members-----*/
        private Game game = new Game();   
        
        /**/

        public GameWindow()
        {
            InitializeComponent();
        }

        // Canvas paint function - launches paint functionality.
        private bool gameRunning = false; // Prevents function from relaunching.
        private void pnlCanvas_Paint(object sender, PaintEventArgs e)
        {
            if (gameRunning == false)
            {
                gameRunning = true;
                Graphics g = pnlCanvas.CreateGraphics();
                game.startGame(g);
            }
        }

        // Allows the command line to be seen during normal execution.
        private void GameWindow_Load(object sender, EventArgs e)
        {
            AllocConsole();
        }

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAsAttribute(UnmanagedType.Bool)]
        static extern bool AllocConsole();


        private void btnPlay_Click(object sender, EventArgs e)
        {
            inMenu = false;
            btnPlay.Visible = false;
            btnPlay.Enabled = false;
            btnCharacter.Visible = false;
            btnCharacter.Enabled = false;
            pbCharacter.Visible = false;
            pbCharacter.Enabled = false;
            pnlCanvas.Enabled = true;
            pnlCanvas.Visible = true;
            pbMenu.Visible = false;
            pbMenu.Enabled = false;
        }

        int charCount = 0;
        private void btnCharacter_Click(object sender, EventArgs e)
        {
            charCount++;
            switch (charCount % 2)
            {
                case 0:
                    Player.Skin = "Jordan";
                    pbCharacter.Image = Plight_of_the_Programmer.Properties.Resources.jordanRun;
                    break;
                case 1:
                    Player.Skin = "Michael";
                    pbCharacter.Image = Plight_of_the_Programmer.Properties.Resources.michaelRun;
                    break;
            }
        }

        private void btnPlay_MouseEnter(object sender, EventArgs e)
        {
            btnPlay.ForeColor = Color.FromArgb(12, 191, 0);
            PlaySelect();
        }

        private void btnPlay_MouseLeave(object sender, EventArgs e)
        {
            btnPlay.ForeColor = Color.Green;
        }

        private void btnCharacter_MouseEnter(object sender, EventArgs e)
        {
            btnCharacter.ForeColor = Color.FromArgb(12, 191, 0);
            CharacterSelect();
        }

        private void btnCharacter_MouseLeave(object sender, EventArgs e)
        {
            btnCharacter.ForeColor = Color.Green;
        }

        private void GameWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!inMenu)
            {
                game.stopGame();
            }
        }

        /*------------------------------------------------------------------
          Eventually make it so Up/Down Arrow Keys call following functions.
          ------------------------------------------------------------------ */

        private void PlaySelect()
        {
            btnCharacter.Text = "Character";
            btnPlay.Text = "> Play";
            btnPlay.Select();
            selectedButton = 0;
        }

        private void CharacterSelect()
        {
            btnPlay.Text = "Play";
            btnCharacter.Text = "> Character";
            btnCharacter.Select();
            selectedButton = 1;
        }
    }
}
