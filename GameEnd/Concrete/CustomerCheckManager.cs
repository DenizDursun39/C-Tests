using GameEnd.Abstract;
using GameEnd.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEnd.Concrete
{
    public class CustomerCheckManager : ICustomerCheck
    {
        public bool CheckCustomer(Customer customer)
        {
            Console.WriteLine("Müşteri kontrol edildi");
            return true;
        }
    }
}
