namespace MusteriTakip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            CustomerManager customerManager = new CustomerManager();
            Customer cust1 = customerManager.addCustomer("Denizhan Dursun", 1, 11111111111);
            Customer cust2 = customerManager.addCustomer("Taha Yavuz", 2, 11111111112);
            Customer cust3 = customerManager.addCustomer("Mert Tanrıverdi", 3, 11111111113);
            customerManager.removeCustomer(cust1);
            GC.Collect();
            customerManager.listCustomers(cust1,cust2,cust3);
            
            
           
            
            
            
        }
    }
}