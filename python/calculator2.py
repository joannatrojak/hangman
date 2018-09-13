class Calculator: 
    def __init__(self, x, y): 
        self.x = x
        self.y = y
        self.memory = []
    def addition(self, op):
        if op == '+': 
            print(self.x + self.y)
    def substraction(self, op):
        if op == 'x': 
            print(self.x - self.y)
    def multiplication(self, op): 
        if op == '*': 
            print(self.x * self.y)
    def division(self, op): 
        if op == '/': 
            try: 
                print(self.x/self.y)
            except ZeroDivisionError: 
                print("Zero division not allowed")
    def modulus(self, op):
        if op == '%': 
            print(self.x % self.y)
    def memory(self, op): 
        if op == 'z': 
            self.memory.append(self.x, self.y)
            print(self.memory)

c = Calculator(1, 0)
print(c.division('/'))


