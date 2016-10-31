import numpy as np
from scipy import interpolate
import random

n = int(input())
months = []
num = []
sol = []

for i in range(n):
	l = input()
	l_l = l.split('\t')
	months.append(l_l[1])

for i in months:
	b = int(i)
	num.append(b)

# create normally distributed values
a = np.array(num)
counts, bins = np.histogram(a, bins=11, density=True)
counts = np.cumsum(counts)
bin_widths = (bins[1:] - bins[:-1])

# generate values with the same distribution
x = counts*bin_widths
y = bins[1:]
inverse_density_function = interpolate.interp1d(x, y)
b = np.zeros(n+12)

for i in range(len( b )):
    u = random.uniform( x[0], x[-1] )
    b[i] = inverse_density_function( u )
    
for i in range(12 ):
    u = random.uniform( x[0], x[-1] )
    sol.append(inverse_density_function( u ))

for i in sol:
	print(int(i))
