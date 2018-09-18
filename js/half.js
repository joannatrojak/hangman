function half(number, strings) {
    for (var i = 0; i < strings.length; i++) {
        if (strings[i].length % 2 == 0) {
            string = strings[i]
            console.log(string.substring(0, string.length/2))
        }
    }
}
strings = ['pierwszy', 'lubiec', 'ktotozrobi']
console.log(half(3, strings))