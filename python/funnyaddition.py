def reverse(n): 
    n = list(str(n))
    m = n.copy()
    m.reverse()
    return int(''.join(m))

def palindrome(n): 
    count = 0
    while n != reverse(n): 
        n = n + reverse(n)
        count += 1
    return str(n) + ' ' + str(count)
print(palindrome(28))
        
    
