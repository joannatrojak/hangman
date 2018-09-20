<?php 
function halfString($number, $strings){
    for ($i = 0; $i< $number; $i++){
        if (strlen($strings[$i]) % 2 == 0){
            $string = $strings[$i]; 
            print_r(substr($string, 0, strlen($string)/2));
            echo "<br>";
        }
    }
}
$strings = ['pierwszy', 'lubiec', 'ktotozrobi']; 
print_r(halfString(3, $strings));