<?php 
function hexadecimal($number){
    $hexaNumbers = [0=> 0, 1=> 1, 2=> 2, 3=> 3, 4=> 4, 5=> 5, 6=> 6, 7=> 7, 8=> 8, 9=> 9, 10=> 'A', 11=> 'B', 12=> 'C', 13=> 'D', 14=> 'E', 15=> 'F'];
    $convertedNumber = []; 
    $result = []; 
    $i = 1; 
    
    if (in_array($number, $hexaNumbers)){
        print_r($hexaNumbers[$number]);
    }
    else{
        while($number > 0){
            $remainder = $number % 16; 
            $number = floor($number/16);
            $i += 1; 
            array_push($convertedNumber, $remainder); 
        }
        //print_r($convertedNumber);
        foreach (array_reverse($convertedNumber) as $i){
            array_push($result, strval($hexaNumbers[$i]));
        }
        return join("", $result);
    }
}
print_r(hexadecimal(1263));