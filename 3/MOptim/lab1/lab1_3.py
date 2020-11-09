# 9 вариант
# методы деления пополам, Пауэлла, (Ньютона)

import math
from lab import Lab


class Lab3(Lab):

    def __init__(self, a, b):
        super().__init__()
        self.a = a
        self.b = b
        self.title = "Метод Ньютона"

    # производная от функции f(x)
    def f1(self,x):
        return 5*pow(x, 4)-2*x


    def niuton(self, a, b):
        try:
            x0 = (a + b) / 2
            xn = self.f(x0)
            xn1 = xn - self.f(xn) / self.f1(xn)
            while abs(xn1 - xn) > math.pow(10, -5):
                self.count += 1
                xn = xn1
                xn1 = xn - self.f(xn) / self.f1(xn)
            return xn1
        except ValueError:
            print("Value not invalidate")

    def start(self):
        return self.niuton(self.a, self.b)
