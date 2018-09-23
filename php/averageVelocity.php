<?php 
function averageVelocity($v1, $v2){
    return (2*($v1*$v2))/($v1+$v2);
}
print_r(averageVelocity(60, 40));