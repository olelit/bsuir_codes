from  lab import Lab

class HukJiws(Lab):

    def __init__(self):
        super().__init__()
        return

    def huk_jivs(self, x1, x2, f0, eps, k = 0):
        f0 = self.f(x1, x2)
        return self.step2(x1, x2, eps, f0)

    def step2(self, x1, x2, eps, f0):
        self.k += 1
        new_x1 = x1 + self.h
        new_x2 = x2 + self.h
        new_f = self.f(new_x1, new_x2)

        return self.step3(x1, x2, eps, f0, new_x1, new_x2, new_f)

    def step3(self, x1, x2, eps, f0, new_x1, new_x2, new_f):
        if new_f > f0:
            return self.step4(x1, x2, eps, f0, new_x1, new_x2, new_f)
        if new_f < f0:
            return self.step5(x1, x2, eps, f0, new_x1, new_x2, new_f)

    def step4(self, x1, x2, eps, f0, new_x1, new_x2, new_f):
        if abs(self.h) > eps:
            self.h = self.h / self.beta
            return self.step2(x1, x2, eps, f0)
        if abs(self.h) < eps:
            return new_x1, new_x2, new_f
        return

    def step5(self, x1, x2, eps, f0, new_x1, new_x2, new_f):

        x1p = new_x1 + (new_x1 - x1)
        x2p = new_x2 + (new_x2 - x2)

        return self.step6(x1, x2, eps, f0, x1p, x2p, new_f, new_x1, new_x2)

    def step6(self, x1, x2, eps, f0, x1p, x2p, new_f, new_x1, new_x2):
        if self.f(x1p,x2p) > self.f(x1, x2):
            return self.step4(x1, x2, eps, f0, new_x1, new_x2, new_f)

        if self.f(x1p,x2p) < self.f(x1, x2):
            return self.step5(x1p, x2p, eps, f0, new_x1, new_x2, new_f)



    def method(self):
        k = 0
        f0 = self.f(self.x1, self.x2)

        x1, x2, f = self.huk_jivs(self.x1, self.x2, f0, self.eps1)
        self.line()
        print("Метод Хука-Дживса")
        self.line()
        print("Точность: "+str(self.eps1))
        print("f(x*): "+str(f))
        print("Кол-во итераций: "+str(self.k))
        self.line()
        self.k = 0
        x1, x2, f = self.huk_jivs(self.x1, self.x2, f0, self.eps2)
        print("Точность: "+str(self.eps2))
        print("f(x*): "+str(f))
        print("Кол-во итераций: "+str(self.k))
        self.line()
        return