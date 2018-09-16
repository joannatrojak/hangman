def hexadecimal(number): 
    hexaNumbers = {0: 0, 1: 1, 2: 2, 3: 3, 4: 4, 5: 5, 6: 6, 7: 7, 8: 8, 9: 9, 10: 'A', 11: 'B', 12: 'C', 13: 'D', 14: 'E', 15: 'F'}
    convertedNumber = []
    result = []
    i = 1

    if number in hexaNumbers:
        print(hexaNumbers[number])
    else: 
        while number > 0: 
            remainder = number % 16
            number //= 16
            i += 1 
            convertedNumber.append(remainder)
        convertedNumber.reverse()
        for i in convertedNumber: 
            result.append(str(hexaNumbers[i]))
        return ''.join(result)       
print(hexadecimal(1263))