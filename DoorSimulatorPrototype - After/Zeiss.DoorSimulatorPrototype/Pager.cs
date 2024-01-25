using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zeiss.DoorSimulatorPrototype {
    public class Pager : INotifyManager {
        public Pager() { }

        private void SendNotification() {
            Console.WriteLine("Notifying...");
        }

        public void Update(bool alertRequiredState) {
            if (alertRequiredState) { 
                this.SendNotification();
            }
        }
    }
}
