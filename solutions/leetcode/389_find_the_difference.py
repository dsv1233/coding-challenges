def findTheDifference(s, t):
    """
    :type s: str
    :type t: str
    :rtype: str
    """
    return chr(sum(map(ord, t)) - sum(map(ord, s)))

res = findTheDifference("abcd", "abcde")
print(res)