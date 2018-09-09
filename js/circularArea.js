function circularArea(d, r) {
    pi = 3.141592654
    return Math.round(((r ** 2) - (d ** 2 / 4)) * pi, 2)
}
console.log(circularArea(10, 10))