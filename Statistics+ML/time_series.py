import sys
import pandas as pd
import numpy as np
import statsmodels.api as sm

N = int(input())
raw = []
for i in range(N):
    raw.append(int(input()))
ts = pd.Series(raw)

last = 143
x = np.arange(N - last, N)
X = np.column_stack([x] + [np.arange(N - last, N) % 7 == i for i in range(7)])
res = sm.OLS(ts[-last:], X).fit()

xx = np.arange(N, N+30)
XX = np.column_stack([xx] + [xx % 7 == i for i in range(7)])
ans = res.predict(XX)

for x in ans:
    print("{:0.0f}".format(x))