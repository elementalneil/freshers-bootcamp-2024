using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zeiss.DoorSimulatorPrototype {
    public class Operator {
        private SimpleDoor Door;
        public Operator(SimpleDoor Door) {
            this.Door = Door;
        }

        public void Open() {
            Door.OpenDoor();
        }

        public void Close() {
            Door.CloseDoor();
        }
    }
}
