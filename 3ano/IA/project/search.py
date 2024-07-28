import copy
from common import Coordinates, Map
import math


class SearchNode:

    def __init__(self, Map, parent, action, cost):
        self.Map = Map 
        self.parent: SearchNode = parent  
        self.action = action  
        self.cost = cost
        self.actual_cost = 0 


    def in_parent(self, Map):

        if self.parent is None:
            return False
        if self.parent.Map.grid == Map.grid:
            return True

        return self.parent.in_parent(Map)
        
class SearchTree:
    
    def __init__(self, newlvl, all_cars: dict):
        root = SearchNode(newlvl, None, None, 0)
        self.open_nodes = [root]
        self.solution = None
        self.non_terminals = 0
        self.cars = all_cars
        self.all_grids = []


    def heuristic(self, node: SearchNode) -> int:
        
        red_car_coords = node.Map.piece_coordinates('A')

        distance = abs(red_car_coords[0].x - node.Map.grid_size + 1)
        blocking_cars = 0
        for i in range(red_car_coords[0].x + 1, node.Map.grid_size):
            if node.Map.grid[red_car_coords[0].y][i] != 'o':
                blocking_cars += 1

        return distance + blocking_cars + node.cost


    def search(self):
        
        
        while self.open_nodes != []:
            #self.open_nodes.sort(key=lambda node: self.heuristic(node))
            
            node = self.open_nodes.pop(0)
            if node.Map.test_win():
                self.solution = node
                return self.get_path(node)

            self.non_terminals += 1
            lnewnodes = []

            for car, orientation in self.cars.items():
                if orientation == "h":
                    if node.Map.piece_coordinates(car)[-1].x < node.Map.grid_size - 1 and node.Map.grid[node.Map.piece_coordinates(car)[-1].y][node.Map.piece_coordinates(car)[-1].x + 1] == 'o':
                        lnewnodes = self.change_grid(node, (car, "d"), lnewnodes)
                    if node.Map.piece_coordinates(car)[0].x > 0 and node.Map.grid[node.Map.piece_coordinates(car)[0].y][node.Map.piece_coordinates(car)[0].x - 1] == 'o':
                        lnewnodes = self.change_grid(node, (car, "a"), lnewnodes)
                elif orientation == "v":
                    if node.Map.piece_coordinates(car)[-1].y < node.Map.grid_size - 1 and node.Map.grid[node.Map.piece_coordinates(car)[-1].y + 1][node.Map.piece_coordinates(car)[-1].x] == 'o':
                        lnewnodes = self.change_grid(node, (car, "s"), lnewnodes)
                    if node.Map.piece_coordinates(car)[0].y > 0 and node.Map.grid[node.Map.piece_coordinates(car)[0].y - 1][node.Map.piece_coordinates(car)[0].x] == 'o':
                        lnewnodes = self.change_grid(node, (car, "w"), lnewnodes)
                

            self.open_nodes.extend(lnewnodes)
            self.open_nodes.sort(key=lambda no: no.cost + self.heuristic(no))
        return None

    def change_grid(self, node, action, lnewnodes):
        new_matrix = copy.deepcopy(node.Map.grid)
        if action[1] == "d":
            new_matrix[node.Map.piece_coordinates(action[0])[-1].y][node.Map.piece_coordinates(action[0])[-1].x + 1] = action[0]
            new_matrix[node.Map.piece_coordinates(action[0])[0].y][node.Map.piece_coordinates(action[0])[0].x] = "o"
        elif action[1] == "a":
            new_matrix[node.Map.piece_coordinates(action[0])[-1].y][node.Map.piece_coordinates(action[0])[-1].x] = "o"
            new_matrix[node.Map.piece_coordinates(action[0])[0].y][node.Map.piece_coordinates(action[0])[0].x - 1] = action[0]

        elif action[1] == "s":
            new_matrix[node.Map.piece_coordinates(action[0])[-1].y + 1][node.Map.piece_coordinates(action[0])[-1].x] = action[0]  
            new_matrix[node.Map.piece_coordinates(action[0])[0].y][node.Map.piece_coordinates(action[0])[0].x] = "o"

        elif action[1] == "w":
            new_matrix[node.Map.piece_coordinates(action[0])[-1].y][node.Map.piece_coordinates(action[0])[-1].x] = "o"
            new_matrix[node.Map.piece_coordinates(action[0])[0].y - 1][node.Map.piece_coordinates(action[0])[0].x] = action[0]

        new_Map = copy.deepcopy(node.Map)
        new_Map.grid = new_matrix

        if new_matrix not in self.all_grids:
            newnode = SearchNode(new_Map,node,action,node.cost)
            lnewnodes.append(newnode)
            self.all_grids.append(new_matrix)
        return lnewnodes


    def get_path(self, node):
        if node.parent is None:
            return []
        return self.get_path(node.parent) + [node.action]