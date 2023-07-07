using GameEnd.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEnd.Abstract
{
    internal interface IDiscount
    {
        void ApplyDiscount(Sales sale);
        void AddDiscount(double discountRate,string discountName);

        void EditDiscount(double discountRate, string discountName);

        void RemoveDiscount(Discount discount);

    }
}
