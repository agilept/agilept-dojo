using System;
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
            board = new ArrayList();
        }

        internal ArrayList getBoard()
        {
            return board;
        }
    }
}
