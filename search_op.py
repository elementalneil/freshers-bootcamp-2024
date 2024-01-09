def search(search_string, key):
    num_list = []
    string_list = search_string.split()
    
    for num in string_list:
        num_list.append(int(num))
    
    for num in num_list:
        if num == key:
            return "Found"
    return "Not Found"
    
    
def main():
    search_string = "11 159 23 42 22 428 72 53 12 43"
    key = 72
    
    result = search(search_string, key)
    print(result)
    
if __name__ == '__main__':
    main()
