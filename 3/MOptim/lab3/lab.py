class Lab:

    def __init__(self):
        self.x1 = -3
        self.x2 = -3
        self.lambda_var = 1
        self.eps1 = 0.01
        self.eps2 = 0.00001
        self.beta = 2
        self.e = 2,718
        self.k = 0
        self.h = 1
        return

    def f(self, x1, x2, e = 2.718):
        return pow(x1,2)+3*pow(x2, 2)+pow(e, x1+x2)

    def line(self, n=30):
        print("*" * n)

    def method(self):
        return