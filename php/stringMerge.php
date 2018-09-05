<?php 
function stringMerge($L1, $L2){
    $merged = [];
    while (count($L1) || count($L2) > 0){
        if (count($L1) > 0){
            array_push($merged, array_shift($L1)); 
        }
        
        if (count($L2) > 0){
            array_push($merged, array_shift($L2)); 
        }
    }
    return join("", $merged);
}
$L1 = ["a", "b", "c"];
//print_r(array_shift($L1));
$L2 = ["f", "d", "s"];
print_r(stringMerge($L1, $L2));
        