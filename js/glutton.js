var glutton = function (time) {
    return 86400 / time
}
function howManyBoxes(box, gluttons) {
    sum = 0
    for (var i = 0; i < gluttons.length; i++) {
        sum += glutton(gluttons[i])
    }
    boxes = sum / box
    return Math.floor(boxes)
}
console.log(howManyBoxes(10, [3600, 1800]))