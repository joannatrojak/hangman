# -*- coding: utf-8 -*-
"""
Created on Fri Aug 17 16:15:29 2018

@author: joasi
"""

def isPrime(n): 
    #Corner case 
    
    try:     
        for i in range(2, n-1):
            if n % i == 0: 
                return 'NIE'
    
        return 'TAK' 
    except: 
            if n <= 1: 
                return 'NIE' 

print(isPrime(1))
print(isPrime(2))
print(isPrime(3))
print(isPrime(4))