def isPalindrome(x):
        """
        :type x: int
        :rtype: bool
        """
        num = str(x)
        return num == num[::-1]

print(isPalindrome(121))
print(isPalindrome(-121))
print(isPalindrome(10))