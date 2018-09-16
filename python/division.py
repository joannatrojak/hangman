def division(n, x, y): 
    result = []
    for i in range(1, n): 
        if i % x == 0 and i % y != 0: 
            result.append(i)
    return result

print(division(7, 2, 4))