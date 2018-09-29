package com.company;

import jdk.nashorn.internal.runtime.regexp.joni.exception.ValueException;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class Main {

    public static <string> void main(String[] args) throws IOException {
        // write your code here
        BufferedReader in;
        in = new BufferedReader(
                new InputStreamReader(System.in));
        System.out.print("Give me a number: ");
        Integer n = Integer.valueOf(in.readLine());

        if (n < 2) {
            System.out.print("NIE");
        }
        for (int i = 2; i < n; i++) {
            if (n % i == 0) {
                System.out.print("NIE");
            }
            System.out.print("TAK");
        }
    }
}
