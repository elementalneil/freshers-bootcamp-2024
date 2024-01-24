using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zeiss.DoorSimulatorPrototype {
    public class Buzzer {
        private DoorState currentState;
        private int durationTillAlertSeconds;

        public Buzzer() {
            // Setting a large value. No door is going to stay open that long.
            durationTillAlertSeconds = 1000000000;
        }

        public void Update(DoorState state) {
            this.currentState = state;
            Console.WriteLine($"Buzzer Notified: State Updated to {currentState}");
        }

        public void Alert() {
            // If state is continuously DoorState.OPEN for durationTillAlertSeconds seconds, generate alert.
        }

        public void ModifyTimer(int duration) {
            durationTillAlertSeconds = duration;
        }
    }
}
