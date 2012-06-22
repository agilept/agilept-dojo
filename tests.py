import unittest
from dojo import *

class TestDojo(unittest.TestCase):
    def test_create_game(self):
        game = TTTGame()
        self.assertNotEqual(game, None)

if __name__ == '__main__':
    unittest.main()
