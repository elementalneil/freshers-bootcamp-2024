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
        public String Model { get; private set; }

        public SimpleDoor() {
            this.Model = Guid.NewGuid().ToString();
        }

        public virtual void OpenDoor() {
            // Simulate Opening the Door
        }

        public virtual void CloseDoor() {
            // Simulate Closing the Door
        }
    }
}
