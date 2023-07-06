using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusteriTakip
{
    public class CustomerManager
    {   
        public CustomerManager() { 
          
        }
        public Customer addCustomer(string customerName,int customerId,double customerSocialSecNum)
        {
            Customer customer = new Customer();
            customer.customerId = customerId;
            customer.customerName = customerName;
            customer.customerSocialSecNum = customerSocialSecNum;
            return customer;
        }
        public Customer removeCustomer(Customer customer)
        {
            customer.customerName = null;
            customer.customerSocialSecNum = 0;
            customer.customerId = 0;
            return customer = null;
        }
        public void listCustomers(params Customer[] customer)
        {
            foreach (Customer cust in customer)
            {
                Console.WriteLine("Müşterinin adı: " + cust.customerName + "\n" + "Müşteri ID: " + cust.customerId + "\n" + "Müşteri sosyal güvenlik numarası: " + cust.customerSocialSecNum);
            }
        }



    }
}
