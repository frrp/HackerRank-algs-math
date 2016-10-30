import numpy

def calc(gpa):
    score = [float(e) for e in input().split()]
    coef = numpy.corrcoef(gpa, score)[0, 1]
    return 0 if numpy.isnan(coef) else coef

for t in range(int(input())):
    adm = int(input())
    gpa = [float(e) for e in input().split()]
    m = max([calc(gpa), i] for i in range(1, adm+1))[1]
    print(m)
