using GameEnd.Concrete;
using GameEnd.Entity;

namespace GameEnd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Discount dis1 = new Discount();
            dis1.AddDiscount(0.2,"Genç indirimi");
            dis1.RemoveDiscount(dis1);
            dis1.EditDiscount(0.4, "Başarı İndirimi");
            Sales sales = new Sales();
            sales.AddGame("Fallout",1,400);
            Customer customer = new Customer();
            customer.RegisterCustomer(1, "12345678910", "Denizhan", "Dursun","2000");
            CustomerCheckManager customerCheckManager = new CustomerCheckManager();
            customerCheckManager.CheckCustomer(customer);
            customer.EditCustomer(1,"1234565783","Denzhan","Dursun","2003");
            customer.DeleteCustomer(customer);
            sales.ComplateTransaction(customer, dis1);
            

        }
    }
}