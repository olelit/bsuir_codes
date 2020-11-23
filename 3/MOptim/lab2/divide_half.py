def divide(a, b, eps, f, n = 0):
    x1 = (a+b-eps/2)/2
    f1 = f(x1)

    x2 = (a + b + eps / 2) / 2
    f2 = f(x2)

    n += 1

    if f2 > f1:
        b = x2
    if f2 < f1:
        a = x1

    if abs(b-a) > eps:
        x_main = min(f(x1), f(x2))
        print("x*: "+str(x_main))
        print("f(x*): "+str(f(x_main)))
        print("Количество итераций: " +str(n))

    if abs(b - a) < eps:
        return divide(a, b, eps, f, n)