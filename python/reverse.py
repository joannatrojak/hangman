def reverseList(list): 
    reversed = []
    
    while len(list) > 0: 
        reversed.append(list.pop())
    
    return reversed

print(reverseList([3, 3, 2, 11]))
