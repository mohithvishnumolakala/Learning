arr = [1, 3, 2, 4, 3, 5]
arr.sort()
total_sum=sum(arr)
min_sum=total_sum-arr[-1]
max_sum=total_sum-arr[0]
print(min_sum)
print(max_sum)