using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManager {
    public class EmailNotifyManager {
        public void Update(int id, OrderState state) {
            Console.WriteLine($"Email: Id : {id}, State: {state}");
        }
    }
}
