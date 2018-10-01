package com.company;

public class FunnyAddition {
    public String reverse(int n){
        return new StringBuilder(String.valueOf(n)).reverse().toString();
    }

    public String palindrome(int number) {
        int count = 0;
        while (number != Integer.valueOf(reverse(number))){
            number = number + Integer.valueOf(reverse(number));
            count += 1;
        }
        System.out.print(String.valueOf(number));
        return String.valueOf(number);
    }
}
