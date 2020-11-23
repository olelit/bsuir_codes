import math

def golden_ratio(a, b, eps, f, n = 0):
    n+=1
    fi = 1 + (math.sqrt(5))/2
    x1 = b - (b-a)/fi
    x2 = a + (b-a)/fi
    x_main = 0

    if f(x1) > f(x2):
        a = x1
    if f(x1) < f(x2):
        b = x2

    if abs(b-a) < eps:
        print("Метод золотого сечения: {0}".format((a+b)/2))
        print("Кол-во итераций: {0}".format(n))
        return

    return golden_ratio(a,b,eps,f)