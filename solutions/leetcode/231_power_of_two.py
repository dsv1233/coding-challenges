def isPowerOfTwo(n: int) -> bool:
    return n > 0 and n & (n -1) == 0

def isPoerOfTwo_v2(n:int)-> bool:
    if n <= 0:
        return False
    x = 0
    while 2 ** x <= n:
        if 2 ** x ==n:
            return True
        x+=1
    return False