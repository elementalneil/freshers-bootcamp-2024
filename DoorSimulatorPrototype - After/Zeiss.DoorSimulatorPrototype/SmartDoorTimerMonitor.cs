﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Zeiss.DoorSimulatorPrototype {
    public class SmartDoorTimerMonitor {
        private Timer timer;
        SmartDoor door;

        public SmartDoorTimerMonitor(SmartDoor door) {
            this.door = door;
            timer = new Timer(CheckAlertRequired, null, TimeSpan.Zero, TimeSpan.FromSeconds(1));
        }

        private void CheckAlertRequired(object state) {
            if (door.State == DoorState.OPEN) {
                TimeSpan duration = DateTime.Now - door.OpenedTime;

                if (duration.TotalSeconds > door.DurationThresholdSec) {
                    door.SetAlertRequired(true);
                }
            }
        }
    }
}
