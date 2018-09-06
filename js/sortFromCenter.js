function sortFromCenter(distances) {
    result = []; 
    distanceFromCenter = function (X) {
        center = [0, 0]; 
        return Math.round(Math.sqrt((X[0] - center[0]) ** 2 + (X[1] - center[1]) ** 2)); 
    };
    for (var i = 0; i < distances.length; i++) {
        console.log(distanceFromCenter(distances[i]));
    }

}
distances = [[0, 0], [5, 5], [1, -1]];
console.log(sortFromCenter(distances));