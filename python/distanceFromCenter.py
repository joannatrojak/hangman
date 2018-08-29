import math
def distanceFromCenter(X): 
    center = (0, 0)
    return round(math.sqrt((X[0] - center[0])**2 + (X[1] - center[1])**2))
def sortDistance(distances):
    result = []
    for distance in distances:
        result.append(distanceFromCenter(distance))
    result.sort()
    return result
    
distances = []
distances = [(0, 0), (5, 5), (1, -1)]
print(sortDistance(distances))
