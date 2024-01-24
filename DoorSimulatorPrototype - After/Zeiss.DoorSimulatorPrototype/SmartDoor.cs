using System;
using System.Threading;


namespace Zeiss.DoorSimulatorPrototype {
    public class SmartDoor : SimpleDoor {
        private DoorState state;
        private bool alertRequired;
        private int durationThresholdSec;
        private DateTime openedTime;
        public event Action<bool> alertRequiredChanged;

        private SmartDoorTimerMonitor monitor;

        public SmartDoor() {
            alertRequired = false;
            durationThresholdSec = 2;
            // Since the door is closed at the beginning,
            // setting openedTime to the future ensures that timer doesn't exceed threshold
            openedTime = DateTime.MaxValue;
            monitor = new SmartDoorTimerMonitor(this);  // Gets the monitor, and its async thread running
        }

        public override void OpenDoor() {
            if (this.state == DoorState.CLOSED) {
                base.OpenDoor();
                this.state = DoorState.OPEN;
                openedTime = DateTime.Now;
            }
        }

        public override void CloseDoor() {
            if (this.state == DoorState.OPEN) {
                base.CloseDoor();
                this.state = DoorState.CLOSED;
            }
        }

        public DoorState State { get { return state; } }

        public DateTime OpenedTime { get { return openedTime; } }

        public int DurationThresholdSec { get { return durationThresholdSec; } }

        public void SetAlertRequired(bool flag) { 
            alertRequired = flag;
            if (alertRequired) {
                alertRequiredChanged.Invoke(alertRequired);
                alertRequired = false;
            }
        }
    }
}
