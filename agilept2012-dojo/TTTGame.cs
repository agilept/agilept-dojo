﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace agilept2012
{
    class TTTGame
    {


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
    }
}
