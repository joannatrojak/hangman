package com.company;

public class Addition {
    public int addition(int howMany, int[] array) {
        int result = 0;
        for (int i = 0; i < howMany; i++){
            result = result + array[i];
        }
        return result;
    }
}
