from tkinter import *
import random
import time


class Ball:
    def __init__(self, canvas, paddle, color):
        self.canvas = canvas
        self.paddle = paddle
        self.id = canvas.create_oval(10, 10, 25, 25, fill=color)
        self.canvas.move(self.id, 245, 100)
        starts = [-3, -2, -1, 1, 2, 3]
        random.shuffle(starts)
        self.x = starts[0]
        self.y = -3
        self.canvas_height = self.canvas.winfo_height()
        self.canvas_width = self.canvas.winfo_width()
        self.hit_bottom =  False

    def hit_paddle(self, pos):
        paddle_pos = self.canvas.coords(self.paddle.id)
        if pos[3] >= paddle_pos[1] and pos[3] <= paddle_pos[3]:
            if pos[2] >= paddle_pos[0] and pos[0] <= paddle_pos[2]:
                return True
        return False

    def draw(self):
        self.canvas.move(self.id, self.x, self.y)
        pos = self.canvas.coords(self.id)
        if pos[1] <= 0:
            self.y = 3
        if pos[3] >= self.canvas_height:
            self.y = -3
        if self.hit_paddle(pos) == True:
            self.x = 3
        if pos[0] <=0:
            # self.hit_bottom = True
            self.x = 3
        if pos[2] >= self.canvas_width:
            self.x = -3

    
class Paddle:
    def __init__(self, canvas, color, posx):
        self.canvas = canvas
        self.id = canvas.create_rectangle(0, 0, 10, 100, fill=color)
        self.canvas.move(self.id, posx, 200)
        self.x = 0
        self.canvas_height = self.canvas.winfo_height()
        self.canvas.bind_all('<KeyPress-Left>', self.turn_left)
        self.canvas.bind_all('<KeyPress-Right>', self.turn_right)

    def draw(self):
        self.canvas.move(self.id, 0, self.x)
        pos = self.canvas.coords(self.id)
        if pos[1] <= 0:
            self.x = 0
        elif pos[3] >= self.canvas_height:
            self.x = 0

    def turn_left(self, evt):
        self.x = -2

    def turn_right(self, evt):
        self.x = 2


tk = Tk()
tk.title('Game')
tk.wm_attributes('-topmost', 1)
canvas = Canvas(tk, width=700, height=400, highlightthickness=0)
canvas.pack()
tk.update()

paddle1 = Paddle(canvas, 'blue', 50)
# paddle2 = Paddle(canvas, 'blue', 650)
ball = Ball(canvas, paddle1, 'red')

while 1:
    if ball.hit_bottom == False:
        ball.draw()
        paddle1.draw()
    tk.update_idletasks()
    tk.update()
    time.sleep(0.01)



