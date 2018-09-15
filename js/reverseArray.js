function reverseArray(array) {
    var reversed = []

    for (var i = array.length - 1; i >= 0; i--) {
        reversed.push(array.pop())
    }
    return reversed
}
console.log(reverseArray([1, 2, 3]))
