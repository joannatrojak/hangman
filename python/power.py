# -*- coding: utf-8 -*-
"""
Created on Mon Aug 20 18:29:29 2018

@author: joasi
"""

def powerToExp(base, exp):
    result = base
    for i in range(1, exp): 
        result = result*base
    return result%10
                

print(powerToExp(2, 4))