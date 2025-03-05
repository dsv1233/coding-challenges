def isSubsequence(s,t):
    i = 0
    for c in s:
        i = t.find(c,i)
        if(i== -1):
            return False
        i += 1
    return True


res = isSubsequence("abc", "ahbgdc")
print(res)
res = isSubsequence("axc", "ahbgdc")
print(res)