using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zeiss.DoorSimulatorPrototype {
    public class SmartDoor : SimpleDoor {
        public event Action<DoorState> StateChanged;

        public override void OpenDoor() {
            if (this.state == DoorState.CLOSED) {
                base.OpenDoor();
                if (StateChanged != null) {
                    StateChanged.Invoke(this.state);
                }
            }
        }

        public override void CloseDoor() {
            if (this.state == DoorState.OPEN) {
                base.CloseDoor();
                if (StateChanged != null) {
                    StateChanged.Invoke(this.state);
                }
            }
        }
    }
}
