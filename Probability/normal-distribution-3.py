
from scipy.stats import norm

distribution = norm(70, 10)

print("%.4f" % (1.0 - distribution.cdf(80)))
print("%.4f" % (1.0 - distribution.cdf(60)))
print("%.4f" % distribution.cdf(60))
