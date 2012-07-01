using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace agilept2012
{
    class TTTGame
    {
        private ArrayList<List<int>> plays = new ArrayList<List<int>>();
        private static string p1 = "x";
        private static string p2 = "o";


        static void Main(string[] args)
        {
        }

        private ArrayList board;

        public TTTGame()
        {
            board = new ArrayList(9);
            for(int i = 0; i < 9; ++i)
                board.Add(0);
        }

        internal ArrayList getBoard()
        {
            return board;
        }

        internal bool validMove(int l, int col)
        {
            //
            int pos = l*3 + col;
            if ((int)board[pos] == 0)
                return true;
            else
                return false;
        }
        internal bool makeMove(String player, int l, int col)
        {
            if (validMove(l, col))
            {
                plays[l][col] = player;
            }

        }




    }
}
