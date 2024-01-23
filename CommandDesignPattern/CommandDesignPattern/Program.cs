using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDesignPattern {
    internal class Program {
        static void Main(string[] args) {
            Target1 target = new Target1();
            Target2 target2 = new Target2();
            Target3 target3 = new Target3();

            // Demonstrating Command Pattern With Target 1 Class
            Command command = new Command(target.ExecuteTask);
            Source source = new Source();
            source.SetCommand(command);
            source.TriggerCommand();

            // Demonstrating Command Pattern With Target 2 Class
            command = new Command(target2.InvokeTask);
            source.SetCommand(command);
            source.TriggerCommand();

            // Demonstrating Command Pattern With Target 3 Class
            command = new Command(target3.DoTask);
            source.SetCommand(command);
            source.TriggerCommand();

            
            Console.ReadLine();
        }
    }
}
