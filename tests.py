import unittest
from dojo import *

class TestDojo(unittest.TestCase):
    def test_create_game(self):
        game = TTTGame()
        self.assertNotEqual(game, None)

    def test_make_move(self):
        game = TTTGame()
        game.make_move(TTTGame.x, 1, 1)


if __name__ == '__main__':
    unittest.main()
