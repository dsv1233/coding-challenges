def merge(nums1, m, nums2, n):
    if m == 0:
        nums1[:] = nums2
        return
    if n == 0:
        return
    
    i = m - 1
    j = n - 1
    k = m + n - 1
    while i>=0 and j>=0:
        if nums1[i] > nums2[j]:
            nums1[k] = nums1[i]
            i -= 1
        else:
            nums1[k] = nums2[j]
            j -= 1
            
        k -= 1

    while j >= 0:
        nums1[k] = nums2[j]
        j -= 1
        k -= 1
    return

merge([1,2,3,0,0,0], 3, [2,5,6], 3)
merge([1], 1, [], 0)
merge([0], 0, [1], 1)
merge([1,0], 1, [2], 1)
merge([2,0], 1, [1], 1)