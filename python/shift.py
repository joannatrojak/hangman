import numpy

def shift(list, n): 
    array = numpy.asarray(list)
    return numpy.roll(array, n)

list = [7, 1, 2, 3, 4, 5, 6, 7]
print(shift(list, 2))
