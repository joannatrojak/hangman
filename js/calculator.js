function addition(a, b) {
    return a + b
}
function substraction(a, b) {
    return a - b
}
function muliplication(a, b) {
    return a * b
}
function division(a, b) {
    try {
        return a / b
    }
    catch (e) {
        console.log(e.message)
    }
}
function modululo(a, b) {
    return a%b
}
a = 5
b = 2
console.log(addition(a, b))
console.log(substraction(a, b))
console.log(muliplication(a, b))
console.log(division(a, b))
console.log(modululo(a, b))