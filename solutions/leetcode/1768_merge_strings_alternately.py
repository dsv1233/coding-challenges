from itertools import zip_longest

class Solution(object):
    def mergeAlternately(self, word1, word2):
        return ''.join([x + y for x, y in zip_longest(word1, word2, fillvalue='')])

def mergeAlternately(word1, word2):
    merged = []
    len1, len2 = len(word1), len(word2)
    for i in range(max(len1, len2)):
        if i < len1:
            merged.append(word1[i])
        if i < len2:
            merged.append(word2[i])
    return ''.join(merged)

def mergeAlternately_v2(word1, word2):
    res =""
    len1, len2 = len(word1), len(word2)
    smaller = len1 <= len2
    for i in range(len1 if smaller else len2):
        res += word1[i] + word2[i]
    res += word2[len1:] if smaller else word1[len2:]
    return res

#obj = Solution()
#print(obj.mergeAlternately("abc", "pqr"))
#print(obj.mergeAlternately("ab", "pqrs"))
#print(obj.mergeAlternately("abcd", "pq"))
#
#print(mergeAlternately("abc", "pqr"))
#print(mergeAlternately("ab", "pqrs"))
#print(mergeAlternately("abcd", "pq"))

print(mergeAlternately_v2("abc", "pqr"))
print(mergeAlternately_v2("ab", "pqrs"))
print(mergeAlternately_v2("abcd", "pq"))