using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
            door = new SmartDoor();
            SmartDoor smartDoor = (SmartDoor)door;
            doorOperator = new Operator(smartDoor);

            // Adding Buzzer
            Buzzer buzzer = new Buzzer();
            Action<bool> buzzerObserver = new Action<bool>(buzzer.Update);
            smartDoor.alertRequiredChanged += buzzerObserver;

            // Adding Pager
            Pager pager = new Pager();
            Action<bool> pagerObserver = new Action<bool>(pager.Update);
            smartDoor.alertRequiredChanged += pagerObserver;

            // Adding Autocloser
            AutoCloser autoCloser = new AutoCloser(doorOperator);
            Action<bool> autoCloserObserver = new Action<bool>(autoCloser.Update);
            smartDoor.alertRequiredChanged += autoCloserObserver;

            doorOperator.Open();
            Thread.Sleep(2200);
            doorOperator.Close();
            Thread.Sleep(3000);
            doorOperator.Open();
            Thread.Sleep(6000);
            doorOperator.Close();

        }
    }
}
