using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDesignPattern {
    public class Target1 {
        public void ExecuteTask() {
            Console.WriteLine("Task Executed");
        }
    }

    public class Target2 {
        public void InvokeTask() {
            Console.WriteLine("Task Executed");
        }
    }

    public class Target3 {
        public void DoTask() {
            Console.WriteLine("Task Executed");
        }
    }
}
