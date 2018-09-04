def silnia(n): 
    r = 1
    for i in range(1, n +1): 
        r = r*i
    return r

def pascalTriangle(n, k):
    return silnia(n)/(silnia((n - k))*silnia(k))

print(pascalTriangle(7, 3))