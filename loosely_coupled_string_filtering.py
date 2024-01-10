from abc import ABC, abstractmethod

class StringListFilterController:
    def __init__(self):
        self.__strategy = SearchStrategy()

    def filter(self, string_list, key):
        filtered_list = []
    
        for string in string_list:
          if self.__strategy.invoke(string, key):
            filtered_list.append(string)
    
        return filtered_list


class SearchStrategyBlueprint(ABC):
    @abstractmethod
    def invoke(item, key):
        pass


class SearchFromStart(SearchStrategyBlueprint):
    def invoke(item, key):
        if item.startswith(key):
            return True
        else:
            return False


class ConsoleDisplayController:
  def __init__(self):
    self.__content = ""

  def set_content(self, message):
    self.__content = message

  def display(self):
    print(self.__content)


def main():
  filter_controller = StringListFilterController()
  string_list = ['abc', 'def', 'ghi', 'jkl', 'abd']
  filtered_list = filter_controller.filter(string_list, 'a')

  display_controller = ConsoleDisplayController()
  display_controller.set_content(filtered_list)
  display_controller.display()
