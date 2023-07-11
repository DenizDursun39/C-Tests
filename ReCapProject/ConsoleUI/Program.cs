using Business.Concrete;
using DataAccess.Concrete.EntityFramework;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetAll()) {
                Console.WriteLine("{0} {1} {2} {3}",car.Description,car.ModelYear,car.CarId,car.DailyPrice);
            }
        }
    }
}