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

