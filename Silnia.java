package com.company;

public class Silnia {


    public int silnia(int n) {
        int factorial = 1;
        if (n <= 1)
        {
            return 1;
        }
        for (int i = 1; i < (n + 1); i++)
        {
            factorial = factorial * i;
        }
        return factorial;
    }
}
