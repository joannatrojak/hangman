<?php 
function skarbFinder($coordinates, $howMany){
    $information = [['y' => 1], ['y' => -1], ['x' => 1], ['x' => -1]];
    $countY = 0; 
    $countX = 0; 
    
    for ($i = 0; $i < $howMany; $i++){
        $direction = $information[$coordinates[$i][0]];
        
        if(array_key_exists('y', $direction)){
            $countY += $direction['y']*$coordinates[$i][1];
        }
        
        if (array_key_exists('x', $direction)){
            $countX = $direction['x']*$coordinates[$i][1];
        } 
    }
    $treasure = [$countX, $countY]; 
    return $treasure;
}
$coordinates = [[0, 1], [0, 2], [1, 2], [2, 3]]; 
$howMany = count($coordinates); 
var_dump(skarbFinder($coordinates, $howMany));