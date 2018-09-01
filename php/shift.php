<?php 
function shift($array, $n){
    for ($i = 0; $i < $n; $i++){
        array_push($array, array_shift($array)); 
    }
    return $array;
}
var_dump(shift([1, 2, 3], 2));
