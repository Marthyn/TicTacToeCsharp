using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace TicTacToe
{
    public partial class MainWindow : Form
    {
        
        private Button[] buttons = new Button[9];
        private Game game;
        private Player player1 = null;
        private Player player2 = null;
        public MainWindow()
        {
            InitializeComponent();

            //Put all the buttons in an array
            for (int i = 0; i < buttons.Length; i++)
            {
                switch (i)
                {
                    case 0:
                        buttons[i] = veld0;
                        break;
                    case 1:
                        buttons[i] = veld1;
                        break;
                    case 2:
                        buttons[i] = veld2;
                        break;
                    case 3:
                        buttons[i] = veld3;
                        break;
                    case 4:
                        buttons[i] = veld4;
                        break;
                    case 5:
                        buttons[i] = veld5;
                        break;
                    case 6:
                        buttons[i] = veld6;
                        break;
                    case 7:
                        buttons[i] = veld7;
                        break;
                    case 8:
                        buttons[i] = veld8;
                        break;

                }
            }
        }

        public Player getPlayer(int number)
        {
            if (number == 1)
            {
                return player1;
            }
            else
            {
                return player2;
            }
            
        }

        static void showMsg(String msg)
        {
            MessageBox.Show(msg);
        }

        public void setPlayers(String name1, bool ai1, String name2, bool ai2)
        {
            if (ai1)
            {
                player1 = new Computer(name1, 1);
            }
            else
            {
                player1 = new Human(name1, 1);
            }

            if (ai2)
            {
                player2 = new Computer(name2, 2);
            }
            else
            {
                player2 = new Human(name2, 2);
            }

            p1namelbl.Text = player1.getName();
            p2namelbl.Text = player2.getName();
        }

        public void newGame(object sender, EventArgs e)
        {
            if (player1 == null || player2 == null)
            {
                MessageBox.Show("Set the playernames first, if you need help click on the help button");
            }
            else
            {
                game = new Game(player1, player2);
                updateField();
                //If the starting player is controlled by AI the play method get's called with a generated move from the AI
                //else the program will wait for user input
                if (game.getCurrentPlayer().GetType() == new Computer("none", 0).GetType())
                {
                    Computer c = (Computer)game.getCurrentPlayer();
                    play(c.getMove(game));
                }
            }
        }

        private void updateField()
        {
            //Retrieve the board layout from the game object and update the fields in the window
            int[,] board = game.getBoard();
            for (int i = 0; i < board.Length; i++)
            {
                switch (board[i/3,i%3])
                {
                    case 0:
                        buttons[i].Text = "-";
                        break;
                    case 1:
                        buttons[i].Text = "X";
                        break;
                    case 2:
                        buttons[i].Text = "O";
                        break;
                }
            }
            currentplayerlbl.Text = game.getCurrentPlayer().getName();
        }

        private void updateResults()
        {
            p1losses.Text = player1.getLosses().ToString();
            p1ties.Text = player1.getTies().ToString();
            p1wins.Text = player1.getWins().ToString();

            p2losses.Text = player2.getLosses().ToString();
            p2ties.Text = player2.getTies().ToString();
            p2wins.Text = player2.getWins().ToString();

            currentplayerlbl.Text = "Game ended";
        }

        //Overloaded function, if a Player is given as parameter to the GameOver method it means that that player has won, else it's a tie.
        private void GameOver(Player p)
        {
            if (p.getNumber() == 1)
            {
                player1.win();
                player2.loss();
            }
            else
            {
                player1.loss();
                player2.win();
            }
            
            updateField();
            updateResults();
            MessageBox.Show(p.getName() + " won the game");
            game = null;
        }
        private void GameOver()
        {
            player1.tie();
            player2.tie();
            updateField();
            updateResults();
            MessageBox.Show("Game resulted in a tie");
            game = null;
        }   

        private void play(int n)
        {
            if (game.changeField(n))
            {
                GameOver(game.getCurrentPlayer());

            }
            else if (game.boardFull())
            {
                GameOver();
            }
            else
            {
                updateField();
                if (game.getCurrentPlayer().GetType() == new Computer("none", 0).GetType())
                {
                    Computer c = (Computer)game.getCurrentPlayer();
                    play(c.getMove(game));
                }
            }
            
        }

        private void play(object sender, EventArgs e)
        {
            if (game != null)
            {

                Button btn = (Button)sender;
                int fieldNumber = Int16.Parse(btn.Name.Substring(4));
                play(fieldNumber);
            }
            else
            {
                MessageBox.Show("Start a new game");
            }
        }

        private void gameSettingsMenu_Click(object sender, EventArgs e)
        {
            OptionsWindow settings = new OptionsWindow(this);
            settings.ShowDialog();
            
        }

        private void AboutMenu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Copyright 2012 Marthyn Olthof©, all rights reserved. Unauthorized distribution is prohibited.", "About", MessageBoxButtons.OK, MessageBoxIcon.Information); 
        }

        private void howToPlayMenu_Click(object sender, EventArgs e)
        {
            HelpWindow helpwindow = new HelpWindow();
            helpwindow.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       

       
    }
}
