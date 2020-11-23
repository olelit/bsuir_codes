# 9 вариант
# методы деления пополам, (Пауэлла), Ньютона
from lab import Lab


class Lab2(Lab):

    def __init__(self, x, h):
        super().__init__()
        self.x = x
        self.h = h
        self.title = "Метод Пауэлла"

    def find_x(self, x1, x2, x3):
        a1 = (self.f(x2) - self.f(x1)) / (x2 - x1)
        a2 = (1 / (x3 - x2)) * ((self.f(x3) - self.f(x1)) / (x3 - x1) - (self.f(x2) - self.f(x1)) / (x2 - x1))
        out = ((x2 + x1) / 2) - (a1 / (2 * a2))
        return out

    def get_min_x(self, x1, x2, x3, min_f):
        if min_f == self.f(x1):
            return x1
        if min_f == self.f(x2):
            return x2
        if min_f == self.f(x3):
            return x3

    def step_4(self, x1, x2, x3):
        f_min = min([self.f(x1), self.f(x2), self.f(x3)])
        x_min = self.get_min_x(x1, x2, x3, f_min)

        # шаг 5
        x_main = self.find_x(x1, x2, x3)
        x0 = 0
        if abs(x_main - x_min) < self.eps:
            return x_main
        if self.f(x_main) < f_min:
            x0 = x_main
        else:
            x0 = x_min
        numbers = [x1, x2, x3]
        min_f = self.f(numbers[0])
        for key, item in enumerate(numbers):
            if self.f(item) < min_f:
                min_f = key
        numbers[min_f] = x0
        numbers.sort()
        x1, x2, x3 = numbers
        return self.step_4(x1, x2, x3)


    def payel(self, x1, h):
        self.count += 1
        # шаг 1
        x2 = x1 + h
        x3 = 0
        # шаг 2 и 3

        if self.f(x1) > self.f(x2):
            x3 = x1 + 2 * h
        else:
            x3 = x1 - h

        # шаг 4
        return self.step_4(x1, x2, x3)

    def start(self):
        return self.payel(self.x, self.h)
