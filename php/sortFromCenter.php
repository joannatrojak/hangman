<?php 
function sortDistanceFromCenter($distances){
    $result = []; 
    $distanceFromCenter = function($X){
        $center = [0, 0]; 
        return round(sqrt(($X[0] - $center[0])**2 + ($X[1] - $center[1])**2)); 
    };
    foreach($distances as $distance){
        array_push($result, $distanceFromCenter($distance));
    }
    sort($result);
    return $result; 
}
$distances = [[0, 0], [5, 5], [1, -1]];
print_r(sortDistanceFromCenter($distances));