using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zeiss.DoorSimulatorPrototype {
    public class Buzzer : INotifyManager {
        public Buzzer() { }

        public void Update(bool alertRequiredState) {
            if (alertRequiredState) {
                this.Alert();
            }
        }

        public void Alert() {
            Console.WriteLine("Buzzing...");
        }
    }
}
