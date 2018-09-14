<?php 
function dwumian($n, $k){
    $silnia = function($n){
    $r = 1; 
    for ($i = 1;$i < $n +1; $i++ ){
        $r = $r*$i; 
    }
    return $r;
};
    return $silnia($n)/($silnia(($n - $k))*$silnia($k)); 
}
print_r(dwumian(7, 3));
