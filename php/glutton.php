<?php 
function howManyBoxes($box, $gluttons){
    $sum = 0; 
    $glutton = function($time){
      return 86400/$time;  
    };
    for ($i = 0; $i < count($gluttons); $i++){
        $sum += $glutton($gluttons[$i]); 
    }
    $boxes = $sum/$box; 
    return floor($boxes);
}
print_r(howManyBoxes(10, [3600, 1800]));