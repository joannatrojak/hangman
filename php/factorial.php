<?php
function factorial($n){
    $factorial = 1; 
    
    if ($n <= 1){
        return 1; 
    }
    for ($i = 1; $i<$n+1; $i++){
        $factorial = $factorial*$i; 
    }
    return $factorial; 
}
$fact = factorial(4); 
function countDigits($fact){
    if ($fact < 10){
        return '0'.strval($fact);
    }
    
    if ($fact > 10){
        $digits = str_split(strval($fact));
        return join(' ', $digits); 
    }
}
var_dump(countDigits($fact));