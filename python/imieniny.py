def nwd(n, m):
    while m != 0: 
        temp = m
        m = n%m
        n = temp
    return n
def imieniny(n,m): 
    cukierki =  n - m/nwd(n, m)*m
    if cukierki > 1: 
        return "Tak"
    return "Nie"
print(imieniny(55, 22))
