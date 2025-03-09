def hammingWeight(n: int) -> int:
    cnt = 0
    while n:
        cnt += n & 1
        n >>= 1
    return cnt

def hammingWeight_v2(n:int)-> int:
    return bin(n).count('1')