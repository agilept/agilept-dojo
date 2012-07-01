using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using NUnit.Framework;
using System.Collections;

namespace agilept2012
{
    [TestFixture]
    class TestTicTacToe
    {

        [Test]
        public void testBoard() {
            ArrayList board = new TTTGame().getBoard();
            Assert.AreEqual(9, board.Count);
            foreach (int b in board)
            {
                Assert.AreEqual(0, b);
            }
        }

        [Test]
        public void testValidMove()
        {
            TTTGame g = new TTTGame();

            Assert.True(g.validMove(0, 0));
        }

        [Test]
        public void testMakeMove()
        {
            TTTGame g = new TTTGame();
            Assert.True(g.makeMove("x",0, 0));
        }
        [Test]
        public void testInvalidMove()
        {
            TTTGame g = new TTTGame();

            Assert.False(g.validMove(0, 0));
        }
    }
}
