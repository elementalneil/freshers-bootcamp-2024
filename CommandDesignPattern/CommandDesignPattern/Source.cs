using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDesignPattern {
    public class Source {
        private Action command;

        public void SetCommand(Action commandObj) {
            command = commandObj;
        }

        public void TriggerCommand() {
            command.Invoke();
        }
    }
}
