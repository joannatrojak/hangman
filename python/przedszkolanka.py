def nwd(n, m):
    while m != 0: 
        temp = m
        m = n%m
        n = temp
        
    return n

def nww(n, m): 
    return (n*m)/nwd(n, m)

print(nww(12, 15))