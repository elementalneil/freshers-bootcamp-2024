using System;
using System.Reflection;

namespace CommandDesignPattern {
    public delegate void Command();

    /*
       This creates the class as follows:
        sealed class Command { 
            public void Invoke() { }
        }
    */

    /*
     Let's say we have a delegate as:
     public delegate string Command(int arg1, number arg2);

     This creates the class:
        sealed class Command {
            public string Invoke(int arg1, number arg2) { };
        }


     We can also use type-generics for this as:
     public delegate RT Command<T1, T2, RT>(T1 arg1, T2 arg2);

     This creates the class:
        sealed class Command {
            public RT Invoke(T1 arg1, T2 arg2) { };
        }
     */
}
