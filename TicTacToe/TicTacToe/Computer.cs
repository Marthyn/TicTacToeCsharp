using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TicTacToe
{
    //Implements the Player interface, difference with Human is that Computer has a getMove function to generate a move.
    public class Computer : Player
    {
        private String name;
        private int number;
        private int wins, losses, ties;
        public Computer(String name, int number)
        {
            this.name = name;
            this.number = number;
        }

        public int getNumber()
        {
            return number;
        }
        public String getName()
        {
            return name;
        }

        public void win()
        {
            wins++;
        }
        public void tie()
        {
            ties++;
        }
        public void loss()
        {
            losses++;
        }
        public int getWins()
        {
            return wins;
        }
        public int getTies()
        {
            return ties;
        }
        public int getLosses()
        {
            return losses;
        }

        //At this moment move is just random.
        public int getMove(Game game)
        {
            Random randomGen = new System.Random();
            while(1==1)
            {
                int move = randomGen.Next(0, 8);
                if (game.getBoard()[move/3, move%3] == 0)
                {
                    return move;
                }
            }

        }
    }
}
