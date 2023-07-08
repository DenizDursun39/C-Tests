using GameEnd.Abstract;
using GameEnd.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEnd.Concrete
{
    public class CustomerManager : ICustomer
    {
        ICustomerCheck customerCheck;

        public CustomerManager(ICustomerCheck customerCheck)
        {
            this.customerCheck = customerCheck;
        }
       

        public void DeleteCustomer(Customer customer)
        {
            Console.WriteLine("Başarıile silindi");
        }

        public void EditCustomer(Customer customer)
        {
            Console.WriteLine("Başarı ile güncellendi");
        }

        public void RegisterCustomer(Customer customer)
        {
            if (customerCheck.CheckCustomer(customer)==true)
            {
                Console.WriteLine("Başarı ile kayıt oldu");
            }
        }
    }
}
