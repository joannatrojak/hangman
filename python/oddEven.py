def oddEven(list): 
    result = []
    result2 = []
    for i in range(1, len(list)): 
        if i % 2 == 0: 
            result.append(list[i])
        else:
            result2.append(list[i])
    merged = result + result2
    return merged

print(oddEven([4, 1, 2, 3, 5]))
