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

  def filter(self, string_list):
    self.__strategy.set_starts_with('AB')
    filtered_list = []

    for string in string_list:
      if self.__strategy.invoke(string):
        filtered_list.append(string)

    return filtered_list
