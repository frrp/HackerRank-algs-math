import sys
charge = float(sys.stdin.readline())

cutoff_time = 4.01 # estimate for min time to get full battery

if charge >= cutoff_time:
    print 8.00
else:
    print round(float(charge*2), 2)
