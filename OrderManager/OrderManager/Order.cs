using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManager {
    public enum OrderState {
        CREATED,
        ACCEPTED,
        VERIFIED,
        CONFIRMED,
        PROCESSING,
        COMPLETED,
        REJECTED
    };
    public class Order {
        public int Id { get; private set; }
        private OrderState state;

        /*Action<int, OrderState> Changed;*/

        /*public void AddChanged(Action<int, OrderState> observer) {
            Changed += observer;
        }

        public void RemoveChanged(Action<int, OrderState> observer) {
            Changed -= observer;
        }*/

        public event Action<int, OrderState> Changed;


        public Order() {
            Random random = new Random();
            Id = random.Next(0, 100000);
            state = OrderState.CREATED;
        }

        public void ChangeState(OrderState state) {
            this.state = state;
            if (Changed != null) {
                Changed.Invoke(Id, State);
            }
        }

        public OrderState State { get { return state; } }
    }
}
