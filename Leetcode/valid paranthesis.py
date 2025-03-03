s = "[()]"
stack = []
mapping = {")": "(", "}": "{", "]": "["}

# Iterate over each character in the string s
for char in s:
    # If the character is an opening bracket, push it onto the stack
    if char in mapping.values():
        stack.append(char)
    # If the character is a closing bracket, check if it matches the last opened bracket
    elif char in mapping.keys():
        if not stack or mapping[char] != stack.pop(): #check stack is empty or it matches the last opened bracket is not equal get break
            print("False")
            break  # We can stop here since the string is invalid

# After the loop, check if there are any unmatched opening brackets left
else:
    if not stack:
        print("True")
    else:
        print("False")
