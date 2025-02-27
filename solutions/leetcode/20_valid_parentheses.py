def isValid(s: str) -> bool:
    pairs = {
        "(": ")",
        "{": "}",
        "[": "]"
    }
    stack = []
    for char in s:
        if char in pairs:
            stack.append(char)
        elif not stack or pairs[stack.pop()] != char:
            return False 

    return not stack

print(isValid("()"))
print(isValid("()[]{}"))
print(isValid("(]"))
print(isValid("([)]"))
print(isValid("([])"))
print(isValid("["))
print(isValid(""))