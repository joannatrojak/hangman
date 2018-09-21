function hexanumbers(number) {
    hexaNumbers = { 0: 0, 1: 1, 2: 2, 3: 3, 4: 4, 5: 5, 6: 6, 7: 7, 8: 8, 9: 9, 10: 'A', 11: 'B', 12: 'C', 13: 'D', 14: 'E', 15: 'F' }
    convertedNumber = []
    result = []
    i = 1

    if (number in hexaNumbers) {
        console.log(number)
    }
    else {
        while (number > 0) {
            remainder = number % 16
            number = Math.floor(number / 16)
            i += 1
            convertedNumber.push(remainder)
        }
        convertedNumber.reverse()
        convertedNumber.forEach(function (i) {
            result.push(hexaNumbers[i].toString())
        })
        return result.join("")
    }
}
console.log(hexanumbers(1263))