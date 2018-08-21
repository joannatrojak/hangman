def lettersCount(string): 
    letters = list(string)
    result = {}
    finalresult = []
    
    for letter in letters: 
        if letters.count(letter) > 2: 
            result[letter] = str(letters.count(letter))
        
        if letters.count(letter) <= 2: 
            result[letter] = str(letters.count(letter))
    
    
    for items in result.items(): 
        if int(items[1]) <=2: 
            finalresult.append(items[0])
        else: 
            for item in items: 
                finalresult.append(item)
    
    return ''.join(finalresult)
    


print(lettersCount('ABBCCCDDDDEEEEEFGGHIIJKKKL'))