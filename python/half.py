def half(number, strings): 
    for i in range(0, number): 
        if len(strings[i]) % 2 == 0: 
            string = strings[i]
            print(string[0:int(len(string)/2)])

strings = ['pierwszy', 'lubiec', 'ktotozrobi']
print(half(3, strings))