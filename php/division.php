<?php 
function division($n, $x, $y){
    $result = [];
    for ($i = 0; $i<$n; $i++){
        if ($i % $x == 0 && $i % $y != 0){
            array_push($result, $i);
        }
    }
    return $result;
}
print_r(division(7, 2, 4));