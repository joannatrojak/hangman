package com.company;

import java.util.HashMap;
import java.util.Map;

public class Flamaster {

    public String lettersCount(String someString) {
        char[] lettersArray = someString.toCharArray();
        String finalResult = "";
        Map<Character, Long> occurences = new HashMap<>();
        for (int i = 0; i < lettersArray.length; i++){
            int finalI = i;
            long count = someString.chars().filter(ch -> ch == lettersArray[finalI]).count();
            occurences.put(lettersArray[i], count);
        }
        for (Map.Entry<Character, Long> entry : occurences.entrySet()) {
            if (entry.getValue() == 2){
                finalResult += entry.getKey();
                finalResult += entry.getKey();
            }
            else if(entry.getValue() == 1){
                finalResult += entry.getKey();
            }
            else{
                finalResult += entry.getKey();
                finalResult += entry.getValue();
            }
        }
        System.out.print(finalResult);
        return finalResult;
    }
}
