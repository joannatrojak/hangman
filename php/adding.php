<?php 
function adding($a, $b){
    if ($a and $b < 200){
        return $a + $b; 
    }
}
var_dump(adding(7, 9));