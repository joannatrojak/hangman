function isPrime(n){
    if (n <= 0){
        return 'NIE';
    }
    
    for (var i = 2; i<n; i++){
        if (n % i == 0){
            return 'NIE';
        }
    }
    return 'TAK'; 
}
console.log(isPrime(1)); 
console.log(isPrime(2)); 
console.log(isPrime(3)); 
console.log(isPrime(4)); 
console.log(isPrime(5));