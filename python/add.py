def add(howMany, numbers): 
    result = 0
    
    for i in range(0, howMany): 
        result = result + numbers[i]
    
    return result


print(add(3, [2, 2, 12]))