<?php 
$circularArea = function($d, $r){
    $pi = 3.141592654; 
    return round((($r**2) - ($d**2/4))*$pi, 2);
};
print_r($circularArea(10, 10));