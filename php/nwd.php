<?php 
function nwd($n, $m){
    while ($m != 0){
        $temp = $m;
        $m = $n%$m;
        $n = $temp;
    }
    return $n;
}
print_r(nwd(12, 48));