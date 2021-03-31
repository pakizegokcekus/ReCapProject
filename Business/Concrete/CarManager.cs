using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Business.Abstract;
using Core.Results;
using DataAccess.Abstract;
using DataAccess.ReCap.Models;

namespace Business.Concrete
{
    public class CarManager:ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
           
        }

        public IResult Add(Car car)
        {
            _carDal.Add(car);
            return new Result(true, "");
        }

        //public IDataResult<List<Car>> GetAll()
        //{
        //    var list = _carDal.GetAll().ToList();
            
        //}

    }
}
