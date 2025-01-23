num=int(input("enter number:"))
temp=num
rev=0
while num!=0:
    rem=num%10
    num=num//10
    rev=rev*10+rem
print(f"{rev}")
if temp==rev:
    print("the number is palendrome")
else:
    print("the number is not a palendrome")
    