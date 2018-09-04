def euklidesGame(A, B): 
    count = 0

    if A == B: 
        count = A + B
        return count 

    if A > B: 
        difference = lambda A, B: A - B
        count = A - difference(A, B)
        return count

    if B > A: 
        difference = lambda A, B: B - A
        count = B - difference(A, B)
        return count

print(euklidesGame(2, 4))