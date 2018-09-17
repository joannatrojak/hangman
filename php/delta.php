<?php 
function delta($a, $b, $c){
    $delta = $b**2 - 4*$a*$c;
    
    switch (true){
        case $delta > 0: 
            $result = 2; 
            break; 
        case $delta == 0: 
            $result = 1; 
            break; 
        case $delta < 0: 
            $result = 0; 
            break;
    }
    return $result;
}
print_r(delta(0.3, 0.3, 0.4));
