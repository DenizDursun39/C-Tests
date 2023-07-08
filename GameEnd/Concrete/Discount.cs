using GameEnd.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEnd.Concrete
{
    public class Discount : IDiscount
    {
        public double DiscountRate { get; set; }

        public string DiscountName { get; set; }



        public void AddDiscount(double discountRate, string discountName)
        {
            DiscountName = discountName;
            DiscountRate = discountRate;
            Console.WriteLine("İndirim eklendi");
        }

        public void ApplyDiscount(Sales sale)
        {
            Console.WriteLine(DiscountName + "isimli indirim" + sale.GameName + " isimli ürüne uygulandı"); ;
        }

        public void EditDiscount(double discountRate, string discountName)
        {
            DiscountRate = discountRate;
            DiscountName = discountName;
            Console.WriteLine("İndirim başarı ile değiştirildi");

        }

        public void RemoveDiscount(Discount discount)
        {
            discount = null;
            Console.WriteLine("İndirim başarı ile silindi");
        }
    }
}
