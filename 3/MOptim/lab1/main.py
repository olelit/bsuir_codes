from lab1_1 import Lab1
from lab1_2 import Lab2
from lab1_3 import Lab3


def main():
    #деление пополам
    lab1 = Lab1(1,2)
    #пауэл
    lab2 = Lab2(5,1)
    #ньютон
    lab3 = Lab3(4,5)

    lab1.method()
    lab2.method()
    lab3.method()

if __name__ == '__main__':
    main()