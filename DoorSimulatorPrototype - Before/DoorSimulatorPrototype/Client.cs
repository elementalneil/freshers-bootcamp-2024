using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zeiss.DoorSimulatorPrototype;

namespace DoorSimulatorPrototype {
    public class Client {
        public static void Main(string[] args) {
            Operator doorOperator;

            // Testing Simple Door Functionality
            SimpleDoor door = new SimpleDoor();
            doorOperator = new Operator(door);
            doorOperator.Open();
            doorOperator.Close();

            // Testing Smart Door Functionality by Upgrading Simple Door
            door = door.convertToSmartDoor();
            if (door is SmartDoor) {
                Console.WriteLine("Door is Upgraded to Smart Door");
                SmartDoor smartDoor = (SmartDoor)door;
                doorOperator = new Operator(smartDoor);

                // Adding Buzzer
                Buzzer buzzer = new Buzzer();
                buzzer.ModifyTimer(20);
                Action<DoorState> buzzerObserver = new Action<DoorState>(buzzer.Update);
                smartDoor.StateChanged += buzzerObserver;

                // Adding Pager
                Pager pager = new Pager();
                pager.ModifyTimer(20);
                Action<DoorState> pagerObserver = new Action<DoorState>(pager.Update);
                smartDoor.StateChanged += pagerObserver;

                // Adding Autocloser
                AutoCloser autoCloser = new AutoCloser();
                autoCloser.ModifyTimer(20);
                Action<DoorState> autoCloserObserver = new Action<DoorState>(autoCloser.Update);
                smartDoor.StateChanged += autoCloserObserver;

                doorOperator.Open();
                doorOperator.Close();
                doorOperator.Open();
            }
        }
    }
}
