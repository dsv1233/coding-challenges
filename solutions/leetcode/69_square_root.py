def mySqrt(x):
    if x == 0: return 0
    if x == 1: return 1
    
    left,right = 1,x
    while left < right:
        mid = left + (right -left) // 2
        if mid * mid == x: return mid
        elif mid * mid > x: right = mid
        else: left = mid + 1
    return left - 1

res = mySqrt(8)
print(res)
res = mySqrt(4)
print(res)
res = mySqrt(0)
print(res)
res = 5 ** 0.5
print(res)
res = mySqrt(5)
print(res)
res = 1 ** 0.5
print(res)
res = mySqrt(1)
print(res)