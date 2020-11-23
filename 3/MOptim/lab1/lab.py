class Lab:

    def __init__(self):
        self.eps = 0.1
        self.count = 0
        self.title = ""

    def f(self, x):
        return pow(x, 5) - pow(x, 2)

    def start(self):
        return

    def method(self):
        print("Метод: "+self.title)
        print("Результат: " + str(self.start()))
        print("Кол-во вычислений: " + str(self.count))
        print('_______________________________________')
        return
