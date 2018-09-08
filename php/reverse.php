<?php 
$reversed = function($array){
    return array_reverse($array); 
};
print_r($reversed([3, 3, 2, 11])); 

$reversed2 = function($array){
    $reversed = []; 
    return array_push($reversed, array_pop($array));
};
print_r($reversed([3, 3, 2, 11])); 