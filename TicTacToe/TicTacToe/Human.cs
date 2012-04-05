using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TicTacToe
{
    public class Human : Player
    {
        private String name;
        private int number;
        private int wins, losses, ties;
        public Human(String name, int number)
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
    }
}
