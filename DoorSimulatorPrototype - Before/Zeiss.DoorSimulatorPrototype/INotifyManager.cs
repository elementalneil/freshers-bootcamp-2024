using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Zeiss.DoorSimulatorPrototype {
    public interface INotifyManager {
        void Update(DoorState state);
        void ModifyTimer(int duration);
    }
}