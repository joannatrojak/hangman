<?php 
Class Calculator{
    public $a; 
    public $b; 
    
    public function add($a, $b){
        return $a+$b;
    }
    public function substraction($a, $b){
        return $a - $b;
    }
    public function multiplication($a, $b){
        return $a*$b; 
    }
    public function division($a, $b){
        try{
            if ($a != 0 and $b != 0){
                return $a/$b;
            }
        } catch (Exception $ex) {
            echo $ex->getMessage();
        }
    }
    public function modulus($a, $b){
        return $a%$b;
    }
}
$c = new Calculator(); 
var_dump($c->add(2, 5));
var_dump($c->substraction(3, 1)); 
var_dump($c->multiplication(3, 5)); 
var_dump($c->division(1, 1)); 
var_dump($c->modulus(2, 2));