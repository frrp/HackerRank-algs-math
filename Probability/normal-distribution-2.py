
from scipy.stats import norm

distribution = norm(20, 2)

print("%.3f" % distribution.cdf(19.5))
print("%.3f" % (distribution.cdf(22) - (1.0 - distribution.cdf(20))))

#print(distribution.cdf(20))
# = 0.5
