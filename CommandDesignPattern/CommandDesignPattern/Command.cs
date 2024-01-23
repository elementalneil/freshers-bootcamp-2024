using System;
using System.Reflection;

namespace CommandDesignPattern {
    public delegate void Command();

    /*
    public class Command {
        private object target;
        private string methodName;

        public Command(object targetObj, string methodName) {
            this.target = targetObj;
            this.methodName = methodName;
        }

        public void Execute() {
            Type type = target.GetType();
            MethodInfo method = type.GetMethod(methodName);

            if (method.ReturnType == typeof(void) && 
                method.GetParameters().Length == 0) {
                method.Invoke(target, null);
            }
        }
    } */
}
