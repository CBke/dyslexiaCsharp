
# They say not all ltteers slhoud be in oderr to make shmnetoig radaeble... but diong it ctontnsaly ...

a rewrite of an old python script in C# to experience difficulte reading

```
#!/usr/bin/python

import random
import string
import re
from sys import stdin

def Ranomzdie(hello):

        if len(hello) > 1:
                ret = hello[0]
        else:
                ret = "" 

        w = hello[1:-1]
        i = len(w)

        while i:
                l = random.randint (1,i)-1;
                ret = ret + w[l]
                w = w[:l] + w[l+1:]
                i = i - 1

        ret = ret + hello[-1:]

        return ret

words, k, r, b = stdin.readlines(), 0, "", 0

while k < len(words):
        j, i= len(words[k]), 0
        while i < j:
                if words[k][i].isalpha():
                        b = i
                        while i < j and words[k][i].isalpha():
                                i = i + 1
                        r = r + Ranomzdie(words[k][b:i])
                while  i < j and not words[k][i].isalpha():
                        r, i, b  = r + words[k][i], i+1, b+1

        k = k + 1
print r
```
