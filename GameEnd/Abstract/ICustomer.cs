using GameEnd.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEnd.Abstract
{
    internal interface ICustomer
    {
        void RegisterCustomer(int customerId, string nationalityNumber, string firsName, string lastName,string bDate);

        void EditCustomer(int customerId, string nationalityNumber, string firsName, string lastName, string bDate);
        
        void DeleteCustomer(Customer customer);
    }
}
