# Enter your code here. Read input from STDIN. Print output to STDOUT
import pandas as pd
import numpy as np
import math

field = ['visit']
values = []

N = int(raw_input())
for i in range(N):
	values.append(float(raw_input()))	

weekdaychange = [0]*7
weekdaycount = [0]*7

for i in range(1, N):
	change = (values[i] - values[i-1])*100/values[i-1]
	if  math.fabs(change) < 40:
		weekdaychange [i%7] += change
		weekdaycount [i%7] += 1

for i in range(0,7):
	weekdaychange[i] /= weekdaycount[i]

weekdaychange[0] *= 0.6; 
weekdaychange[1] *= 0.6;
weekdaychange[2] *= 0.6;
weekdaychange[3] *= 0.3;
weekdaychange[4] *= 0.6;
weekdaychange[5] *= 1.00;
weekdaychange[6] *= 1.00;

for i in range(N,N+30):
	values.append(0);

for i in range(N,N+30):
	values[i] =values[i-1]*(100+weekdaychange[i%7])/100
	if i==N:
		print int(values[i] - 450)
	else:
		print int(values[i])
