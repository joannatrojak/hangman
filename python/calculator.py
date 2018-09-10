class Calculator: 
    def __init__(self, x, y): 
        self.x = x
        self.y = y

    def addition(self): 
        print(self.x + self.y)
    def substraction(self): 
        print(self.x - self.y) 
    def multiplication(self): 
        print(self.x*self.y)
    def division(self): 
        try: 
            print(self.x/self.y)
        except ZeroDivisionError: 
            print("Zero division not allowed")

c1 = Calculator(6, 8)
print(c1.addition())
