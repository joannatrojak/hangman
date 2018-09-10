reversed = []
i = 1
while True: 
    number = input('Enter a number ')
    if number == '': 
        break

    reversed.append(int(number))
    i += 1
    if len(reversed) > 0: 
        reversed.reverse()
        print(reversed)