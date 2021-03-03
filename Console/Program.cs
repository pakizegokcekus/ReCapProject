using System;
using DataAccess;
using Entities;

namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Deneme");
            Car AddCar = new Car
            {
                Description = "Bmw",ColorId = 2,ModelYear = DateTime.Now,DailyPrice = 5,BrandId = 2
            };
           InMemoryCar inMemoryCar=new InMemoryCar();
           inMemoryCar.Add(AddCar);
           var getAll = inMemoryCar.GetAll();

        }
    }
}
