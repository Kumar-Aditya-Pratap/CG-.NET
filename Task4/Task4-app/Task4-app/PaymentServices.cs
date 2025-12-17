using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4_app
{
    class PaymentServices
    {
        public class PaymentService
        {
            
            public bool ProcessPayment(object payment)
            {
                if (payment == null) return false;  // null check branch

                // base logic
                return true;
            }

        }

    }
}
