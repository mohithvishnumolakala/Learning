name=input("enter name:")
vowels='aeiou'
count=0
for char in name:
    if char.lower() in vowels:
        count=count+1
print(count)