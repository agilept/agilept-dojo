import unittest
from dojo import *

class TestDojo(unittest.TestCase):
    def test_create_game(self):
        game = TTTGame()
        self.assertNotEqual(game, None)

    def test_execute_move_valid(self):
        game = TTTGame()
        result = game.make_move(TTTGame.x, 1, 1)
        self.assertEqual(result, True)

    def test_execute_move_invalid(self):
        game = TTTGame()
        result = game.make_move(TTTGame.x, 1, 1)
        self.assertEqual(result, True)
        result = game.make_move(TTTGame.x, 1, 1)
        self.assertEqual(result, False)

    def test_game_over(self):
        game = TTTGame()
        game.make_move(TTTGame.x, 0, 0)
        game.make_move(TTTGame.x, 1, 1)
        game.make_move(TTTGame.x, 2, 2)
        winner = game.game_over()
        self.assertEqual(winner, TTTGame.x)

if __name__ == '__main__':
    unittest.main()
