package com.company;

public class CircularArea {
    public double area(int d, int r) {
        double pi =  3.141592654;
        return Math.round((((Math.pow(d, 2)) - (Math.pow(r, 2) / 4)) * pi)*100.0)/100.0;
    }
}
