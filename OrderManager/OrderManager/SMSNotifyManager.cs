using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManager {
    public class SMSNotifyManager {
        public void Update(int id, OrderState state) {
            Console.WriteLine($"SMS: Id : {id}, State: {state}");
        }
    }
}
