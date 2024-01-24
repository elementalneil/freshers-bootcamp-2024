using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zeiss.DoorSimulatorPrototype {
    public class Pager {
        private DoorState currentState;
        private int durationTillNotifySeconds;

        public Pager() {
            // Setting a large value. No door is going to stay open that long.
            durationTillNotifySeconds = 1000000000;
        }

        public void Update(DoorState state) {
            this.currentState = state;
            Console.WriteLine($"Pager Notified: State Updated to {currentState}");
        }

        public void SendNotification() {
            // If state is continuously DoorState.OPEN for durationTillAlertSeconds seconds, send notification.
        }

        public void ModifyTimer(int duration) {
            durationTillNotifySeconds = duration;
        }
    }
}
