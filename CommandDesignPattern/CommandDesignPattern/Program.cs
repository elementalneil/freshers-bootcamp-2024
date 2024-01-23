using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Now we do multicast delegates
// Use this for observer design pattern
namespace CommandDesignPattern {
    internal class Program {
        static void Main(string[] args) {
            Target1 target = new Target1();
            Target2 target2 = new Target2();
            Target3 target3 = new Target3();

            // Demonstrating Command Pattern With Target 1 Class
            Command command1 = new Command(target.ExecuteTask);

            // Demonstrating Command Pattern With Target 2 Class
            Command command2 = new Command(target2.InvokeTask);

            // Demonstrating Command Pattern With Target 3 Class
            Command command3 = new Command(target3.DoTask);


            Command compositeCommand = Delegate.Combine(command1, command2, command3) as Command;
            // Also can write as Command compositeCommand = command1 + command2 + command3;
            // Also can use -= instead of Delegate.Remove();
            Source source = new Source();
            source.SetCommand(compositeCommand);
            source.TriggerCommand();
            
            Console.ReadLine();
        }
    }
}
