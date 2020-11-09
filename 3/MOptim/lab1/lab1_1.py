# 9 вариант
# (методы деления пополам) Пауэлла, Ньютона
from math import fabs
from lab import Lab


class Lab1(Lab):

    def __init__(self, a, b):
        super().__init__()
        self.a = a
        self.b = b
        self.title = "Метод деления пополам"

    def dihotomia(self, a, b):
        self.count += 1
        ksi = (a + b) / 2.0
        if (fabs(self.f(a) - self.f(b)) <= self.eps) or (fabs(self.f(ksi)) <= self.eps):
            return (a + b) / 2.0
        if (self.f(a) * self.f(ksi) <= 0.0):
            return self.dihotomia(a, ksi)
        else:
            return self.dihotomia(ksi, b)

    def start(self):
        return self.dihotomia(self.a, self.b)




