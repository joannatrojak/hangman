def skarbFinder(coordinates, howMany): 
    well = {'x': 0, 'y': 0}
    information = [{'y': +1}, {'y': -1}, {'x': 1}, {'x': -1}]
    countY = 0
    countX = 0

    for i in range (0, howMany): 
       direction = information[coordinates[i][0]]
       keys = direction.keys()
       if 'y' in direction: 
           countY += direction['y']*coordinates[i][1]
       if 'x' in direction: 
           countX += direction['x']*coordinates[i][1]
    treasure = (countX, countY)
    return treasure
coordinates = [(0, 1), (0, 2), (1, 2), (2, 3)]
howMany = len(coordinates)
print(skarbFinder(coordinates, howMany))

    




