# -*- coding: utf-8 -*-
"""
Created on Sun Aug 19 15:03:15 2018

@author: joasi
"""

def factorial(n): 
    factorial = 1
    if n <= 1: 
        return 1; 
    
    for i in range(1, n + 1): 
        factorial = factorial*i
    return factorial

def countNumbers(f, n): 
    result = f(n)
#    if f(n)<10:
#        return '0 '+str(f(n))
    
    if result > 10: 
        digits = list(str(result))
        return ' '.join(digits) 
            
    
    
print(countNumbers(factorial, 8))
