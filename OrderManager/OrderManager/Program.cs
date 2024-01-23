using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Event Driven Programming in C# using delegates

namespace OrderManager {
    internal class Program {
        static void Main(string[] args) {
            // infinte loop
            // generates random numbers between 0-9
            // for one number, assign a state, randomly shuffle and assign a state.

            Random random = new Random();
            Order order = new Order();
            EmailNotifyManager emailNotifyManager = new EmailNotifyManager();
            SMSNotifyManager smsNotifyManager = new SMSNotifyManager();

            Action<int, OrderState> emailObserver = new Action<int, OrderState> (emailNotifyManager.Update);
            Action<int, OrderState> smsObserver = new Action<int, OrderState> (smsNotifyManager.Update);

            order.Changed += emailObserver;
            order.Changed += smsObserver;
            while(true) {
                int stateNum = random.Next(0, 11);
                OrderState state = (OrderState)(stateNum % 6 + 1);
                order.ChangeState(state);
                Console.WriteLine(order.State.ToString());
            }
        }
    }
}