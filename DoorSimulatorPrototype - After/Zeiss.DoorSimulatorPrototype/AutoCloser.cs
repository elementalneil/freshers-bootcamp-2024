using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zeiss.DoorSimulatorPrototype {
    public class AutoCloser : INotifyManager {
        public Operator doorOperator;

        public AutoCloser() { }

        public AutoCloser(Operator operatorParam) {
            this.doorOperator = operatorParam;
        }

        public void Update(bool thresholdExpiredState) {
            if (thresholdExpiredState) {
                this.AutoClose();
            }
        }

        public void AutoClose() {
            Console.WriteLine("Autoclosing...");
            doorOperator.Close();
        }
    }
}
