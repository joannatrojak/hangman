package com.company;

public class Gluttons {
    double glutton(int time) {
        return 86400 / time;
    }
    double howManyBoxes(int box, int gluttons[]) {
        int sum = 0;
        for (int i = 0; i < gluttons.length; i++) {
            sum += glutton(gluttons[i]);
        }
        double boxes = sum / box;
        return boxes;
    }
}
