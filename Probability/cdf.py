#an approximation of the CDF

import math

def CDF(x):
    pi = 3.14
    sm = x
    value = x
    resolution = 100
    
    for i in range(resolution):
        value = value*x*x/(2*i+1)
        sm = sm + value
        
    return 0.5 + (sm/math.sqrt(x)*(2*pi))*math.exp(-(x*x)/2)

#test
for i in range(5):
    print CDF(i+1)
