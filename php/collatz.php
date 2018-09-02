<?php 
function collatz($n){
    while ($n > 0){
        if ($n % 2 == 0){
            return collatz($n / 2);
        }
        else{
             return collatz(3 * $n + 1);
        }
    }
}
var_dump(collatz(2));