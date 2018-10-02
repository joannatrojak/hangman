package com.company;

public class StringMerge {
    public String stringMerege(String s1[], String s2[]) {
        String finalResult = "";
        for (int i = 0; i < s1.length; i++){
            finalResult += s1[i];
            finalResult += s2[i];
        }
        return finalResult;
    }
}
