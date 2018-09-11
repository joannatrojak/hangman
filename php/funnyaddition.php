<?php 
function reverse($n){
    $n = str_split(strval($n)); 
    $m = $n;
    return intval(join("",array_reverse($m)));
}
function palindrome($n){
    $count = 0; 
    while ($n != reverse($n)){
         $n = $n + reverse($n); 
         $count += 1; 
    } 
    return strval($n).' '.strval($count);
}
print_r(palindrome(28));