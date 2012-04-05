using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TicTacToe
{
    public interface Player
    {
        int getNumber();
        String getName();
        void win();
        void tie();
        void loss();
        int getWins();
        int getTies();
        int getLosses();
    }
}
