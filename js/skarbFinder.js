function skarbFinder(coordinates, howMany) {
    information = [{ "y": 1 }, { 'y': 1 }, { 'x': 1 }, { 'x': -1 }]; 
    countY = 0
    countX = 0

    for (var i = 0; i < howMany; i++) {
        direction = information[coordinates[i][0]];

        if ('y' in direction) {
            countY += direction['y'] * coordinates[i][1];
        }

        if ('x' in direction) {
            countX += direction['x'] * coordinates[i][1];
        }
    }
    treasure = [countX, countY]; 
    return treasure;
}

coordinates = [[0, 1], [0, 2], [1, 2], [2, 3]]; 
howMany = coordinates.length;
console.log(skarbFinder(coordinates, howMany));