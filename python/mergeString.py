def mergeString(l1, l2): 
    merged = []
    
    while len(l1) or len(l2) > 0: 
        if len(l1) > 0: 
            merged.append(l1.pop(0))
        if len(l2) > 0: 
            merged.append(l2.pop(0))
    return ''.join(merged)
    

l1 = ["a", "b", "c"]
l2 = ["f", "d", "s"]
print(mergeString(l1, l2))
