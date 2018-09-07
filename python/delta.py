def delta(a, b, c): 
    delta =  b**2 - 4*a*c
    
    if delta > 0: 
        return 2

    if delta == 0: 
        return 1

    if delta < 0: 
        return 0

print(delta(0.3, 0.3, 0.4))
