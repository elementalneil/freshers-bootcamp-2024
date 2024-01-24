using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zeiss.DoorSimulatorPrototype {
    public class AutoCloser { 
        private DoorState currentState;
        public Operator doorOperator;
        private int durationTillAutoCloseSeconds;

        public AutoCloser() {
            // Setting a large value. No door is going to stay open that long.
            durationTillAutoCloseSeconds = 1000000000;
        }

        public AutoCloser(Operator operatorParam) {
            this.doorOperator = operatorParam;
        }

        public void Update(DoorState state) {
            this.currentState = state;
            Console.WriteLine($"Autocloser Notified: State Updated to {currentState}");
        }

        public void AutoClose() {
            // If state is continuously DoorState.OPEN for durationTillAlertSeconds seconds, autoclose door.
            doorOperator.Close();
        }

        public void ModifyTimer(int duration) {
            durationTillAutoCloseSeconds = duration;
        }
    }
}
