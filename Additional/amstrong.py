num=int(input("enter number:"))
temp=num
sum=0
digits=len(str(num))
while num!=0:
    quo=num%10
    pow=quo**digits
    sum=sum+pow
    num=num//10
if sum==temp:
    print(f"the {temp} is amstrong")
else:
    print(f"the {temp} is not an amstrong")
    
    