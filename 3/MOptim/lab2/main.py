import matplotlib.pyplot as plt
import divide_half as dh
import golder_ratio as gr
import newtown as nt

def line(n = 30):
    print("*" * n)

def f(x):
    return 5-pow(x, 2)+1/x

def double_proizv(x):
    return -2+2/pow(x, 3)

def first_proizv(x):
    return -2*x - 1/pow(x, 2)

def find_min_x():
    # -2*x - 1/pow(x, 2) = 0
    # (-2 * x3 - 1)/x^2 = 0
    # -2 * x3 = 1
    # x3 = -0.5
    # x =  0.793

    return 0.793

min = 1
max = 2.5
eps1 = 0.001
eps2 = 0.00001

type="min"

y_coords = []
x_coords = []

check = True
unimod = True

extremum = None

dh.divide(min, max, eps1, f)
line()
dh.divide(min, max, eps2, f)
line()
gr.golden_ratio(min, max, eps1, f)
line()
gr.golden_ratio(min, max, eps2, f)
line()
nt.method(f, min, eps1)
line()
nt.method(f, min, eps2)
line()

while min < max:
    y_coords.append(f(min))
    x_coords.append(min)

    if check:
        check = f((f(min)+min)/2) <= f((f(f(min)))+f(min))/2
    if unimod:
        unimod = double_proizv(f(min)) >= 0
    min+=0.1

print("выпукла/вогнута: {0}".format("вогнута" if check else "выгнута"))
print("унимодальна?: {0}".format("да" if unimod else "нет"))

min_x = 0.793

if f(min_x) > f(2.5) and f(min) < f(1):
    print("экстремулы: f(min)={0} и f(max)={1}".format(f(2.5), f(1)))

plt.figure(figsize=(12, 7))
plt.plot(x_coords, y_coords, 'o-b', alpha=1, label="", lw=1, mec='b', mew=1, ms=1)
plt.legend()
plt.grid(True)
plt.show()
