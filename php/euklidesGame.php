<?php 
function euklidesGame($A, $B){
    $count = 0; 
    
    if ($A == $B){
        $count = $A + $B; 
        return $count; 
    }
    
    if ($A > $B){
        $difference = function($A, $B){
          return $A - $B;   
        };
        $count = $A - $difference($A, $B); 
        return $count; 
    }
    
    if ($B > $A){
        $difference = function($A, $B){
            return $B - $A; 
        };
        $count = $B - $difference($A, $B); 
        return $count; 
    }
}
print_r(euklidesGame(2, 4)); 