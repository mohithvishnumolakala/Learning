nums = [2, 7, 11, 15]
target = 9
dict = {}

for i in range(len(nums)):
    if nums[i] in dict:
        print(dict[nums[i]], i)
    else:
        dict[target - nums[i]] = i
