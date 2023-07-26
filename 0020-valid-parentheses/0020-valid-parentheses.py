class Solution(object):
    def isValid(self, s):
        """
        :type s: str
        :rtype: bool
        """
        symbols = []
        
        for c in s:
            if c in ['(', '{', '[']:
                symbols.append(c)
            elif c == ')' and len(symbols) != 0 and symbols[-1] == '(':
                symbols.pop()
            elif c == '}' and len(symbols) != 0 and symbols[-1] == '{':
                symbols.pop()
            elif c == ']' and len(symbols) != 0 and symbols[-1] == '[':
                symbols.pop()
            else:
                return False
        return symbols == []
    
    #Explanation
    
    # Step 1:
        # symbols = []
            #an empty list symbols is initialized. This list will be used as a stack to keep track of the opening symbols encountered while iterating through the input string.
        
    #Step 2:
        #for c in s:
            #This line starts a for loop that iterates over each character c in the input string s. The loop will go through each character one by one, allowing us to process them individually.
            
    #Step 3:
        #if c in ['(', '{', '[']:
        #symbols.append(c)
            #In this if block, we check if the current character c is an opening symbol (i.e., '(', '{', or '['). If it is, we add it to the symbols list. This helps us keep track of the opening symbols encountered in the input string.
            
    #Step 4:
        #elif c == ')' and len(symbols) != 0 and symbols[-1] == '(':
        #symbols.pop()
            
            #In this elif block, we check if the current character c is a closing parenthesis ')'. We also check two conditions:
            
            #len(symbols) != 0: 
                #This condition checks if the symbols list is not empty, meaning there should be at least one opening parenthesis on the stack to match the closing parenthesis.
                
            #symbols[-1] == '(': 
            #This condition checks if the last element ([-1]) in the symbols list is the corresponding opening parenthesis '('.
            
            
            #If both conditions are true, it means that we have found a matching opening and closing parenthesis pair. So, we remove the corresponding opening parenthesis from the symbols list by using the pop() method. This operation effectively matches the opening and closing symbols.
            
            #This process is repeated for all closing symbols
            
    #Step 5:
        #else: return False
            #If none of the above conditions are met, it means that the current character c is either an unbalanced closing parenthesis or a character that is not part of the valid symbols (e.g., letters or numbers). In either case, the input string is not valid, and the function immediately returns False.
            
    #Step 6:
        #return symbols == []
            #After processing all the characters in the input string, we reach this line. Here, we check if the symbols list is empty using symbols == []. If the symbols list is empty, it means that all opening symbols were correctly matched and closed, and there are no unmatched parentheses in the input string. In that case, the function returns True, indicating that the input string is valid. Otherwise, if there are unmatched opening symbols left in the symbols list, the function returns False, indicating that the input string is not valid.
        