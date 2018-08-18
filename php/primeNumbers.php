<?php
function isPrime($n){
    if ($n <= 0){
        return 'NIE';
    }
    
    for ($i = 2; $i < $n; $i++){
        if ($n % $i == 0){
            return 'NIE'; 
        }
    }
    return 'TAK';        
}
print_r(isPrime(1)); 
print_r(isPrime(2)); 
print_r(isPrime(3)); 
print_r(isPrime(4)); 
print_r(isPrime(5));