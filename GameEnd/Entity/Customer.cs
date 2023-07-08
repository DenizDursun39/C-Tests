using GameEnd.Abstract;
using GameEnd.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEnd.Entity
{
    public class Customer : CustomerManager
    {
        public Customer(ICustomerCheck customerCheck) : base(customerCheck)
        {
        }

        public int CustomerId { get; set; }

        public string NationalityNumber { get; set; }

        public string FirsName { get; set; }

        public string LastName { get; set; }

        public string BDate { get; set; }

        
    }
}
