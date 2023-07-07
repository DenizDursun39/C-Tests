using GameEnd.Concrete;
using GameEnd.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEnd.Abstract
{
    public interface ISales
    {
        void ComplateTransaction(Customer cust,Discount disc);

        void AddGame(string gameName,int gameId,int price);
    }
}
