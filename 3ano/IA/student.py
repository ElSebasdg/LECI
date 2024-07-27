"""Example client."""
import asyncio
import getpass
import json
import os

# Next 4 lines are not needed for AI agents, please remove them from your code!
import pygame
import websockets
from common import Coordinates, Map
from solver import *



def grid(grid_levels):
    grid = []
    if len(grid_levels) == 36:
        # print("this is a 6x6 grid"")
        for i in range(6):
            grid.append(grid_levels[i * 6 : (i + 1) * 6])
        return grid
    elif len(grid_levels) == 64:
        # print("this is a 8x8 grid")
        for i in range(8):
            grid.append(grid_levels[i * 8 : (i + 1) * 8])
        return grid
    elif len(grid_levels) == 16:
        # print("this is a 4x4 grid")
        for i in range(4):
            grid.append(grid_levels[i * 4 : (i + 1) * 4])
        return grid
    else:
        print("Not prepared for this grid size")
        return None



async def agent_loop(server_address="localhost:8000", agent_name="student"):
    """Example client loop."""
    async with websockets.connect(f"ws://{server_address}/player") as websocket:

        # Receive information about static game properties
        await websocket.send(json.dumps({"cmd": "join", "name": agent_name}))


        while True:
            try:
                state = json.loads(
                    await websocket.recv()
                )  # receive game update, this must be called timely or your game will get out of sync with the server
                selected = state.get("selected")
                cars = []
                board = grid(state.get("grid").split(" ")[1])
                agent = Agent(state, selected,board)
                key = agent.run_solver()
                #print(key)
                await websocket.send(
                    json.dumps({"cmd": "key", "key" : key})
                )

            except websockets.exceptions.ConnectionClosedOK:
                print("Server has cleanly disconnected us")
                return

        


# DO NOT CHANGE THE LINES BELLOW
# You can change the default values using the command line, example:
# $ NAME='arrumador' python3 client.py
loop = asyncio.get_event_loop()
SERVER = os.environ.get("SERVER", "localhost")
PORT = os.environ.get("PORT", "8000")
NAME = os.environ.get("NAME", getpass.getuser())
loop.run_until_complete(agent_loop(f"{SERVER}:{PORT}", NAME))
