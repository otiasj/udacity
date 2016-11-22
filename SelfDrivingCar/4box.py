from math import *
import random


init = random.random() * random.random() * 10
hasEmpty = 0.
nonEmpty = 0.

for i in range(1000000):
    box = [0, 0, 0, 0]
    for i in range(12):
        index = random.randint(0,3)
        box[index] += 1

    for i in range(4):
        if box[i] == 0:
            hasEmpty += 1
            break
        if i == 3:
            nonEmpty += 1

print box
print "nonEmpty ", nonEmpty
print "hasEmpty ", hasEmpty

print nonEmpty/(hasEmpty+nonEmpty)
