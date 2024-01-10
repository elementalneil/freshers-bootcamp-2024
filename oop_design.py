## Please refer to the file 'string_filtering_oops.py' for the initial version of this program.

class ConsoleDisplayController:
  def __init__(self):
    self.__content = ""

  def set_content(self, message):
    self.__content = message

  def display(self):
    print(self.__content)


class StartsWithStrategy:
  def __init__(self):
    self.__starts_with = ""

  def set_starts_with(self, key):
    self.__starts_with = key

  def invoke(self, item):
    if item.startswith(self.__starts_with):
      return True
    else
      return False


class StringListFilterController:
  def __init__(self):
    self.__strategy = StartsWithStrategy()

  def filter(self, string_list, key):
    self.__strategy.set_starts_with(key)
    filtered_list = []

    for string in string_list:
      if self.__strategy.invoke(string):
        filtered_list.append(string)

    return filtered_list


def main():
  filter_controller = StringListFilterController()
  string_list = ['abc', 'def', 'ghi', 'jkl', 'abd']
  filtered_list = filter_controller.filter(string_list, 'a')

  display_controller = ConsoleDisplayController()
  display_controller.set_content(filtered_list)
  display_controller.display()
