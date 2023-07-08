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
        void RegisterCustomer(Customer customer);

        void EditCustomer(Customer customer);
        
        void DeleteCustomer(Customer customer);
    }
}
