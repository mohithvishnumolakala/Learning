array = [1, 2, 3, 1, 5, 6]
count=0
num = int(input("Enter number: "))
for i in range(len(array)):
    if num==array[i]:
        count=count+1
        
print(count)

#we can also use count function
# array = [1, 2, 3, 1, 5, 6]
# num = int(input("Enter number: "))
# count=array.count(num)
#         
# print(count)