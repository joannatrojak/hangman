import math
def glutton(time): 
    return 86400/time
def howManyBoxes(box, gluttons): 
    sum = 0
    for i in range(0, len(gluttons)):
        sum += glutton(gluttons[i])
    boxes = sum/box
    return math.floor(boxes)

print(howManyBoxes(10, [3600, 1800]))


