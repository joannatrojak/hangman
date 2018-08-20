function factorial(n){
    var factorial = 1; 
    
    if(n <= 1){
        return 1; 
    }
    for (var i = 1; i<n+1; i++){
        factorial = factorial*i; 
        console.log(factorial);
    }
    return factorial; 
}
console.log(factorial(4));
function countDigits(){
    var number = factorial(4); 
    console.log(number);
    
    if (number < 10){
        return '0'+ number.toString();
    }
    
    if (number > 10){
        var digits = number.toString().split();
        return digits.join();
    }
}
console.log(countDigits());