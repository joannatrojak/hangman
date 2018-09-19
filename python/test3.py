b = int(input())
print(b)
c = 0
while True: 
    a = int(input())
    if a == 42 and b != 42: 
        c+=1
    print(a)
    b = a
    if c == 3:
        break

