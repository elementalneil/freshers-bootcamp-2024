# comparator should be any function that takes two strings as input, returning a boolean output
def filter_(search_strings, key, comparator):    
    for search_string in search_strings:
        if comparator(search_string, key):
            return "Found"
    return "Not Found"
    
    
def starts_with(search_string, key):
    if search_string.startswith(key):
        return True
    else:
        return False
        
        
def ends_with(search_string, key):
    if search_string.endswith(key):
        return True
    else:
        return False
        
        
def equal_to(search_string, key):
    if search_string == key:
        return True
    else:
        return False
    
    
def main():
    search_strings = ['11', '159', '23', '42', '22', '428', '72', '53', '12', '43']
    
    # Starts With Demo
    key = '1'   # Positive Example
    print(filter_(search_strings, key, starts_with))
    
    key = '32'  # Negative Example
    print(filter_(search_strings, key, starts_with))
    
    
    # Ends With Demo
    key = '59'   # Positive Example
    print(filter_(search_strings, key, ends_with))
    
    key = '7'   # Negative Example
    print(filter_(search_strings, key, ends_with))
    
    
    # Equality Demo
    key = '159'  # Positive Example
    print(filter_(search_strings, key, equal_to))
    
    key = '123'  # Negative Example
    print(filter_(search_strings, key, equal_to))
    
    
if __name__ == '__main__':
    main()
