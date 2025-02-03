arr = [1, 12, 3, 5, 2, 1]
largest=arr[0]
for i in range(len(arr)):
    if arr[i]>largest:
        largest=arr[i]
print(largest)

#largest index
# arr = [1, 12, 3, 5, 2, 1]
# largest=arr[0]
# largest_index=0
# for i in range(len(arr)):
#     if arr[i]>largest:
#         largest=arr[i]
#         largest_index=i
# print(largest)
# print(largest_index)