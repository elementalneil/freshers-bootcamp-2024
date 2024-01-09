# comparator should be any function that takes two strings as input, returning a boolean output
def filter_(search_strings, key, comparator):    
    for search_string in search_strings:
        if comparator(search_string, key):
            return "Found"
    return "Not Found"
    
    
def check_from_start(search_string, key):
    if search_string.startswith(key):
        return True
    else:
        return False
        
        
def check_from_end(search_string, key):
    if search_string.endswith(key):
        return True
    else:
        return False
        
        
def check_equal(search_string, key):
    if search_string == key:
        return True
    else:
        return False
    
    
def main():
    search_strings = ['11', '159', '23', '42', '22', '428', '72', '53', '12', '43']
    
    # Starts With Demo
    key = '1'   # Positive Example
    print(filter_(search_strings, key, check_from_start))
    
    key = '32'  # Negative Example
    print(filter_(search_strings, key, check_from_start))
    
    
    # Ends With Demo
    key = '59'   # Positive Example
    print(filter_(search_strings, key, check_from_end))
    
    key = '7'   # Negative Example
    print(filter_(search_strings, key, check_from_end))
    
    
    # Equality Demo
    key = '159'  # Positive Example
    print(filter_(search_strings, key, check_equal))
    
    key = '123'  # Negative Example
    print(filter_(search_strings, key, check_equal))
    
    
if __name__ == '__main__':
    main()
