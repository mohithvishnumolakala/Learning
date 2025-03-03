num=121
temp=num  #store num into temp
rev=0

while num>0:
    rem=num%10  #rem store the last digit
    rev=rev*10+rem
    num=num//10 #it will delete the last digit
if rev==temp:
    print("The number is palendrome",temp)
else:
    print("The number is not a palendrome",temp)

    