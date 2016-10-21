import numpy as np
from scipy import stats
import math

def confidence_int(x, std):
    mean = x.mean(axis=0)
    part = std / math.sqrt(len(x))
    low = mean - 1.96 * part
    high = mean + 1.96 * part
    return low, high

number_of_values = int(raw_input())
raw_in = raw_input()
num = [int(x) for x in raw_in.split(" ")]
numbers = np.array(num)

mean = np.mean(numbers)
median = np.median(numbers)
modes, num_modes = stats.mode(numbers)
mode = modes.min()
standard_deviation = np.std(numbers)
low, high = confidence_int(numbers, standard_deviation)

try:
    print round(mean, 1)
    print round(median, 1)
    print mode
    print round(standard_deviation, 1)
    print round(low, 1), " ", round(high, 1)
except Exception as exp:
    print exp
