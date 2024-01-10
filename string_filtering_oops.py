class String_evaluator:
    # comparator should be any function that takes two strings as input, returning a boolean output
    @staticmethod
    def filter_(search_strings, key, comparator):    
        for search_string in search_strings:
            if comparator(search_string, key):
                return "Found"
        return "Not Found"
    
    
class Filtering_criteria:
    @staticmethod
    def check_from_start(search_string, key):
        if search_string.startswith(key):
            return True
        else:
            return False
    
    @staticmethod
    def check_from_end(search_string, key):
        if search_string.endswith(key):
            return True
        else:
            return False
            
    @staticmethod  
    def check_equal(search_string, key):
        if search_string == key:
            return True
        else:
            return False
            
            
class Filter_functionality_tester:
    def __init__(self):
        self.search_strings = []
        self.key = ''
    
    def take_input(self):
        input_size = int(input('Enter Input Size: '))
        print('Enter String: ')
        for i in range(input_size):
            search_string_input = input()
            self.search_strings.append(search_string_input)
            
        self.key = input('Enter Key: ')
        
    def invoke_string_evaluator(self):
        string_evaluator_obj = String_evaluator()
        criterion_obj = Filtering_criteria()
        
        print('Checking from Start:', string_evaluator_obj.
                                    filter_(self.search_strings, self.key, criterion_obj.check_from_start))
        print('Checking from End:', string_evaluator_obj.
                                    filter_(self.search_strings, self.key, criterion_obj.check_from_end))
        print('Checking for Exact Match:', string_evaluator_obj.
                                    filter_(self.search_strings, self.key, criterion_obj.check_equal))
            
            
def main():
    functionality_tester_obj = Filter_functionality_tester()
    functionality_tester_obj.take_input()
    functionality_tester_obj.invoke_string_evaluator()
    
    
if __name__ == '__main__':
    main()
