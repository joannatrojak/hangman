function delta(a, b, c) {
    var delta = b ** 2 - 4 * a * c
   
    switch (true) {
        case (delta > 0): 
            console.log('2');
            break;
        case (delta == 0): 
            console.log("1");
            break;
        case (delta < 0): 
            console.log("0");
            break;
    }

}
console.log(delta(0.3, 0.3, 0.4))