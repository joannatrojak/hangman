def nwd(n, m):
     while m != 0: 
        temp = m
        m = n%m
        n = temp
     return n

print(nwd(12, 48))

