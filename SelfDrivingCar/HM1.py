colors1 = [['red', 'green', 'green', 'red' , 'red'],
          ['red', 'red', 'green', 'red', 'red'],
          ['red', 'red', 'green', 'green', 'red'],
          ['red', 'red', 'red', 'red', 'red']]

colors2 = [['red', 'red', 'red', 'red' , 'red'],
          ['red', 'red', 'green', 'green', 'red'],
          ['red', 'red', 'green', 'red', 'red'],
          ['red', 'green', 'green', 'red', 'red']]

colors3 = [['red', 'red', 'red', 'red' , 'red'],
          ['red', 'green', 'green', 'red', 'red'],
          ['red', 'red', 'green', 'red', 'red'],
          ['red', 'red', 'green', 'green', 'red']]

colors4 = [['red', 'red', 'green', 'green' , 'red'],
          ['red', 'red', 'green', 'red', 'red'],
          ['red', 'green', 'green', 'red', 'red'],
          ['red', 'red', 'red', 'red', 'red']]

measurements = ['green', 'green', 'green' ,'green', 'green']


motions1 = [[0,0],[0,1],[1,0],[1,0],[0,1]]
motions2 = [[0,0],[0,1],[-1,0],[-1,0],[0,1]]
motions3 = [[0,0],[0,-1],[-1,0],[-1,0],[0,-1]]
motions4 = [[0,0],[0,-1],[1,0],[1,0],[0,-1]]

#colors=[['green', 'green', 'green'],
#        ['green', 'red', 'red'],
#        ['green', 'green', 'green']]
#
#measurements=['red', 'red']
#motions=[[0, 0], [0, 1]]

sensor_right = 1.0
p_move = 1.0

def show(p):
    for i in range(len(p)):
        print p[i]

def sense(p, Z):
    q = []
    s = 0
    for i in range(len(p)):
        row = []
        for j in range(len(p[0])):
            hit = (Z == colors[i][j])
            row.append(p[i][j] * (hit * sensor_right + (1-hit) * (1 - sensor_right)))
        q.append(row)
        s += sum(row)
    for i in range(len(q)):
        for j in range(len(q[0])):
            q[i][j] = q[i][j] / s
    return q

def move(p, U):
    q = []
    rowCount = len(p)
    colCount = len(p[0])
    for i in range(rowCount):
        row = []
        for j in range(colCount):
            res = 0
            #movement vertically
            if (U[0] != 0):
                res += p[(i-U[0])%rowCount][j]*p_move
                res += (p[i][j]*(1-p_move))
            #movement horizontaly
            elif (U[1] != 0):
                res += p[i][(j-U[1])%colCount]*p_move
                res += (p[i][j]*(1-p_move))
            #no movement
            else: 
                res += (p[i][j])

            row.append(res)
        q.append(row)
    return q

colors = []
motions = []
for k in range(4):
    if (k == 0):
        colors = colors1
        motions = motions1
    elif (k == 1):
        colors = colors2
        motions = motions2
    elif (k == 2):
        colors = colors3
        motions = motions3
    elif (k == 3):
        colors = colors4
        motions = motions4

    #Create the a uniformed distribution
    p = []
    rows = len(colors)
    cols = len(colors[0])
    uni = 1./(rows*cols)
    
    for i in range(rows):
        row = []
        for j in range(cols):
            row.append(uni)
        p.append(row)
    
    #Move & sense
    for i in range(len(motions)):
        p = move(p, motions[i])
        p = sense(p, measurements[i])
    
    print k
    show(p)


