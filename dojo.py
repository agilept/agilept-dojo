class TTTGame(object):

    x = "player1"
    o = "player2"

    def __init__(self):
        self.plays = [[0,0,0],[0,0,0],[0,0,0]]

    def make_move(self,player, posx, posy):
        if self.plays[posx][posy] == 0:
            self.plays[posx][posy] = player
            return True
        else:
            return False

    def game_over(self):
        for l in plays:
            player = playys
            for c in plays:

                if c == player