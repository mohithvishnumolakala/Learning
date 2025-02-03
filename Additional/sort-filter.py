len=int(input("enter the length of array:"))
names=[]
for i in range(len):
    names.append(input("enter names:"))
    names.sort()
print(names)
key=input("enter key:")
for name in names:
    if key in name:
        print(f"key found at {name}")