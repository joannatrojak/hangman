<?php 
function add($howMany, $numbers){
    $result = 0; 
    
    for ($i = 0; $i< $howMany; $i++){
        $result = $result + $numbers[$i]; 
    }
    return $result;
}
print_r(add(3, [2, 2, 12]));