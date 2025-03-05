def removeDuplicates(nums):
    if not nums:
        return 0

    k = 0
    for j in range(1,len(nums)):
        if nums[k] != nums[j]:
            k +=1
            nums[k] = nums [j]

    return k + 1

res = removeDuplicates([1,1,2])
print(res)
res = removeDuplicates([0,0,1,1,1,2,2,3,3,4])
print(res)
res = removeDuplicates([1,1,1,1,1,1,1,1,1,1])
print(res)
res = removeDuplicates([])
print(res)