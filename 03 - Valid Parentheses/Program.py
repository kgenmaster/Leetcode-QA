def isValid(s):
    stack = []
    brackets = {"(": ")", "{": "}", "[": "]"}  # Mapping of opening to closing brackets

    for char in s:
        if char in brackets.keys():  # If it's an opening bracket
            stack.append(char)  # Push it onto the stack
        elif char in brackets.values():  # If it's a closing bracket
            if not stack or brackets[stack.pop()] != char:  # Check if it matches the top of the stack
                return False
        else:
            return False  # Optional: Reject invalid characters (if needed)

    return not stack  # True if the stack is empty (all brackets matched)

# Test cases
print(isValid("()"))       # Output: True
print(isValid("(]"))       # Output: False
print(isValid("{[]}"))     # Output: True
print(isValid("({[)]}"))  # Output: False