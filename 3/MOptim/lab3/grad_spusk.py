from  lab import Lab

class GradSpusk(Lab):

    def __init__(self):
        super().__init__()
        return

    def grad_spusk(self, eps):

        return self.step2(eps, self.x1, self.x2)

    def step2(self, eps, x1, x2):
        self.k += 1
        f0 = self.f(x1, x2)
        return self.step3(f0, eps, x1, x2)

    def step3(self, f0, eps, x1, x2):
        if f0 < eps:
            return f0, x1, x2

        return self.step4(x1, x2, eps, f0)

    def step4(self, x1, x2, eps, f0):

        self.k += 1
        x1n =  x1-self.h*f0
        x2n =  x2-self.h*f0
        return self.step5(x1, x2, x1n, x2n, eps)

    def step5(self, x1, x2, x1n, x2n, eps):

        if self.f(x1, x2) > self.f(x1n, x2n):
            self.step2(eps, x1n, x2n)

        else:
            self.h = self.h / 2
            return self.step2(eps, x1n, x2n)



    def method(self):

        self.grad_spusk(self.eps2)
        self.line()
        print("Метод Градиентного спуска")
        self.line()
        f, x1, x2 = self.grad_spusk(self.eps1)
        print("Точность: "+str(self.eps1))
        print("f(x*): "+str(f))
        print("Кол-во итераций: "+str(self.k))
        self.line()
        self.k = 0
        f, x1, x2 = self.grad_spusk(self.eps2)
        print("Точность: "+str(self.eps2))
        print("f(x*): "+str(f))
        print("Кол-во итераций: "+str(self.k))
        self.line()
        return