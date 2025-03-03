s="MCMXCIV"

romans={
    "I":1,
    "V":5,
    "X":10,
    "L": 50,
    "C": 100,
    "D": 500,
    "M": 1000
    }
total=0
curr=0
prev=0
for i in range(len(s)):
    curr=romans[s[i]] #current value be s[0]=M then M is correspoing to romans
    if curr>prev:
        total=total+curr-2*prev
    else:
        total=total+curr
    prev=curr   #changing current value to previous
print(total)
    