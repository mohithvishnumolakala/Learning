first=0
second=1
print(f"{first}")
print(f"{second}")
for i in range(3,11):
    third=first+second
    first=second
    second=third
    print(f"{third}")