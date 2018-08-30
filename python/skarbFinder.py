def skarbFinder(coordinates, howMany): 
    well = {'x': 0, 'y': 0}
    information = [{'y': +1}, {'y': -1}, {'x': 1}, {'x': -1}]
    count = 0
    for i in range (0, howMany): 
       direction = information[coordinates[i][0]]
       if direction['y']: 
           count += direction['y']*coordinates[i][1]
    
       

        
        
        

   
print(skarbFinder([(0, 1), (0, 2)], 2))
    




