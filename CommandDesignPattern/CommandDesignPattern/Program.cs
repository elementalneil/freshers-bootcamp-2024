using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Now we do multicast delegates
// Use this for observer design pattern
// Therefore, we can use delegates for event driven programming

/*
    In latest versions of .NET, we do not use delegates.
    We use the following functions to create delegate classes:
        Func: Has a return type. Can take 0-16 arguments.
        Action: Has no return type. Can take 0-16 arguments.

    Func Syntax:
        Func<int, int, string> delObj = new Func<int, int, string>(targetMethod);
        This creates string TergetMethod(int x, int y) { return ""; }

        Action<int, int, string> delObj = new Action<int, int, string>(targetMethod);
        Creates: void TargetMethod(int x, int y, string z) { }

        Action delObj = new Action(targetMethod);
        Creates: void TargetMethod()

    We use Func and Action to create CompositeDelegate objects directly without creating Delegate classes
*/

namespace CommandDesignPattern {
    internal class Program {
        static void Main(string[] args) {
            Target1 target = new Target1();
            Target2 target2 = new Target2();
            Target3 target3 = new Target3();

            Action compositeCommand = new Action(target.ExecuteTask);
            compositeCommand += new Action(target2.InvokeTask);
            compositeCommand += new Action(target3.DoTask);

            Source source = new Source();
            source.SetCommand(compositeCommand);
            source.TriggerCommand();
            
            Console.ReadLine();
        }
    }
}
