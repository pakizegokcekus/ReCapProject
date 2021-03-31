using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using DataAccess.ReCap.Models;
using Entities;

namespace DataAccess
{
    public class InMemoryCar
    {
        List<Car> _car;
        public InMemoryCar()
        {
            _car = new List<Car>
            {
                new Car{Id = 1,ColorId = 3,BrandId = 5,DailyPrice = 220.000,Description = "Bmv",ModelYear = DateTime.Now},
                new Car{Id = 2,ColorId = 3,BrandId = 5,DailyPrice = 220.000,Description = "Sahin",ModelYear = DateTime.Now},
                new Car{Id = 3,ColorId = 3,BrandId = 5,DailyPrice = 220.000,Description = "Doblo",ModelYear = DateTime.Now},
                new Car{Id = 4,ColorId = 3,BrandId = 5,DailyPrice = 220.000,Description = "Range Rower Siyah",ModelYear = DateTime.Now},
                new Car{Id = 5,ColorId = 3,BrandId = 5,DailyPrice = 220.000,Description = "Range Rower Beyaz",ModelYear = DateTime.Now},
                new Car{Id = 6,ColorId = 3,BrandId = 5,DailyPrice = 220.000,Description = "Range Rower Kırmızı",ModelYear = DateTime.Now}
            };
        }

        public void Add(Car car)
        {
            _car.Add(car);
        }

        public void Delete(Car car)
        {
            Car carDelete = _car.SingleOrDefault(x => x.Id == car.Id);
            _car.Remove(carDelete);
        }

        public Car GetById(Car car)
        {
            return _car.FirstOrDefault(x => x.Id == car.Id);
        }

        public List<Car> GetAll()
        {
            return _car;
        }

        public void Update(Car car)
        {
            Car carToUpdate = _car.SingleOrDefault(x => x.Id == car.Id);
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.Description = car.Description;
        }
    }
}
