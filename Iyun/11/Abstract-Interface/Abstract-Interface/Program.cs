using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            #region What is Abstract and Interface
            //BaseClass bc = new BaseClass();
            //bc.

            Customer customer = new Customer();
            customer.Test();
            //customer.show --error verecek
            #endregion

            #region Abstract methods
            Customer customer1 = new Customer();
            customer1.ShowTime();

            VipCustomer vip = new VipCustomer();
            vip.ShowTime();
            #endregion
        }
    }
}
