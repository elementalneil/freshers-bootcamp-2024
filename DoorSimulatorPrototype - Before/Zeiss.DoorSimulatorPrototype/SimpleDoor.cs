using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zeiss.DoorSimulatorPrototype {
    public enum DoorState {
        CLOSED,
        OPEN
    }
    public class SimpleDoor {
        protected DoorState state;
        public String Model { get; private set; }

        public SimpleDoor() {
            this.state = DoorState.CLOSED;
            this.Model = Guid.NewGuid().ToString();
        }

        public virtual void OpenDoor() {
            this.state = DoorState.OPEN;
        }

        public virtual void CloseDoor() {
            this.state = DoorState.CLOSED;
        }

        public SmartDoor convertToSmartDoor() {
            SmartDoor smartDoor = new SmartDoor();
            smartDoor.Model = this.Model;
            smartDoor.state = this.state;

            return smartDoor;
        }

        public DoorState State { get { return state; } }
    }
}
