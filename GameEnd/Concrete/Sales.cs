using GameEnd.Abstract;
using GameEnd.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEnd.Concrete
{
    public class Sales : ISales

    {
        public int GameId { get; set; }
        public string GameName { get; set; }
        public int Price { get; set; }

        public void AddGame(string gameName, int gameId, int price)
        {
            GameId = gameId;
            GameName = gameName;
            Price = price;
        }

        public void ComplateTransaction(Customer cust, Discount disc)
        {
            Console.WriteLine(cust.FirsName + " isimli müşteri " + disc.DiscountName + " İndirimini kullanarak satın alım yaptı.");
        }
    }
}
