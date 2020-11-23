from lab1_1 import Lab1
from lab1_2 import Lab2
from lab1_3 import Lab3


def main():
    #деление пополам
    lab1 = Lab1(4, 1)
    lab1.method()
    #пауэл
    lab2 = Lab2(4, 1)
    lab2.method()
    #ньютон
    lab3 = Lab3(4,1)
    lab3.method()

if __name__ == '__main__':
    main()