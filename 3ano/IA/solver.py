from common import Coordinates, Map
from search import *
import math



class Agent:

    def __init__(self, state, selected, board):

        self.state = state
        self.target_piece = 'A'
        self.cursor = Coordinates(self.state.get("cursor")[0], state.get("cursor")[1])
        self.board = board
        self.dict = self.orientation(self.board)
        self.selected = selected
        self.update_game(self.state.get("grid"), self.cursor)

    def get_coordinates_cars(self, grid, car):
        result = []
        for index_y, y in enumerate(grid):
            if car in y:
                for index_x, x in enumerate(y):
                    if x == car:
                        result.append(Coordinates(index_x,index_y))
        return result

    def print_grid(self, grid):
        for row in grid:
            print(str(row))

    def update_game(self, grid, cursor):
        print("teste")
        self.cursor = cursor
        self.Game = Map(grid)
        self.print_grid(self.Game.grid)
        print("Target Piece: " + self.target_piece)
        # print the level you are playing
        print("Level: " + str(self.state.get("level")))

    def send_cursor(self, cursor, dest):
        if dest.x < cursor.x:
            return "a"
        elif dest.x > cursor.x:
            return "d"
        elif dest.y < cursor.y:
            return "w"
        elif dest.y > cursor.y:
            return "s"
        elif dest.x == cursor.x and dest.y == cursor.y:
            return None
        else:
            if dest.y < cursor.y:
                return "w"
            elif dest.y > cursor.y:
                return "s"
            if dest.x < cursor.x:
                return "a"
            elif dest.x > cursor.x:
                return "d"

    # orientation function prepared for grids with different sizes
    def orientation(self, g):
        dict_cars = {}
        for rows in g:
            for car in rows:
                if car != "x" and car != "o":
                    if g.index(rows) != len(g)-1:
                        if g[g.index(rows)+1][rows.index(car)] == car:
                            dict_cars[car] = "v"
                    if rows.index(car) != len(rows)-1:
                        if rows[rows.index(car)+1] == car:
                            dict_cars[car] = "h"
        return dict_cars

    def get_cursor_position(self, cursor, grid):
        return Coordinates(cursor.x, cursor.y)

    def get_car(self, cursor, grid):
        return grid[cursor.y][cursor.x]

    def run_solver(self):


        tree = SearchTree(Map(self.state.get("grid")), self.dict)
        path = tree.search()
        # print(path)
        for action in path:
            if self.selected == action[0]:
                return action[1]

            elif (self.get_cursor_position(self.cursor, self.board) != self.get_coordinates_cars(self.board, action[0])[0] and self.get_cursor_position(self.cursor, self.board) != self.get_coordinates_cars(self.board, action[0])[1]):
                if self.selected == "":
                    cursor_dest = self.send_cursor(self.cursor, self.get_coordinates_cars(self.board, action[0])[1])
                    if self.cursor == self.get_coordinates_cars(self.board, action[0])[1]:
                        return " "
                    return cursor_dest
                else:
                    return " "
            elif (self.get_cursor_position(self.cursor, self.board) == self.get_coordinates_cars(self.board, action[0])[0] or self.get_cursor_position(self.cursor, self.board) == self.get_coordinates_cars(self.board, action[0])[1] ):
                if self.selected == "":
                    return " "
            else:
                return ""








