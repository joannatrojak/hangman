function silnia(n) {
    r = 1
    for (var i = 1; i < n + 1; i++) {
        r = r*i
    }
    return r
}
function pascalTriangle(n, k) {
    return silnia(n) / (silnia((n - k)) * silnia(k))
}
console.log(pascalTriangle(7, 3))