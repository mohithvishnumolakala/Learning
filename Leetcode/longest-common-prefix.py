str=["flight","flex","flood"]
ans = ""
v = sorted(str)
first = v[0]
last = v[-1]
for i in range(min(len(first), len(last))):
    if first[i] != last[i]:
        break
    ans =ans+first[i] #If the characters at position i match, we append the character to the ans string or else it break
print(ans)
        
