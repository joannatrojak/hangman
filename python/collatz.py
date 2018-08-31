def collatz(n): 
    while n>0: 
        if n %2 == 0: 
            n = 3*n+1
        else: 
            n/=2
        yield n

for i in collatz(4): 
    print(i)
