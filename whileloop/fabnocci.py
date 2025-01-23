first=0
second=1
print(f"{first}")
print(f"{second}")
i=3
while i<=10:
    third=first+second
    first=second
    second=third
    print(f"{third}")
    i=i+1