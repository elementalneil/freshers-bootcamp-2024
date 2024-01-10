class ConsoleDisplayController:
  def __init__(self):
    self.__content = ""

  def set_content(self, message):
    self.__content = message

  def display(self):
    print(self.__content)


def main():
  display_controller = ConsoleDisplayController()
  display_controller.set_content('Hello World')
  display_controller.display()
