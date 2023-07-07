using GameEnd.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEnd.Entity
{
    public class Customer : ICustomer
    {
        public int CustomerId { get; set; }

        public string NationalityNumber { get; set; }

        public string FirsName { get; set; }

        public string LastName { get; set; }

        public string BDate { get; set; }

        public void DeleteCustomer(Customer customer)
        {
            customer = null;
            Console.WriteLine("Müşteri başarı ile silindi");
        }

        public void EditCustomer(int customerId, string nationalityNumber, string firsName, string lastName, string bDate)
        {
            CustomerId = customerId;
            NationalityNumber = nationalityNumber;
            FirsName = firsName;
            LastName = lastName;
            BDate = bDate;
            Console.WriteLine("Müşterinin bilgileri başarı ile değiştirildi");
        }

        public void RegisterCustomer(int customerId, string nationalityNumber, string firsName, string lastName,string bDate)
        {
            CustomerId = customerId;
            NationalityNumber = nationalityNumber;
            FirsName = firsName;    
            LastName = lastName;
            BDate = bDate;
            Console.WriteLine("Müşteri kayıt edildi.");
        }
    }
}
