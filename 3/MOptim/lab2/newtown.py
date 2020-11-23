from math import sin, cos
from typing import Callable
import unittest

def f_prime(x):
    return -2*x-1/pow(x, 2)

def newton(f: Callable[[float], float], x0: float,
           eps: float = 1e-7, kmax: int = 1e3) -> float:
    x, x_prev, i = x0, x0 + 2 * eps, 0
    n = 0
    while abs(x - x_prev) >= eps and i < kmax:
        n+=1
        x, x_prev, i = x - f(x) / f_prime(x), x, i + 1
    print("Кол-во итераций: {0}".format(n))
    return x


def method(f, x0, eps):
    print("Метод Ньютона-Рафмана: ", newton(f, x0, eps))
    return