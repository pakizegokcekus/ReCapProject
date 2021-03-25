using System;
using System.Collections.Generic;
using System.Text;
using Core.DataAccess;
using Entities;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Abstract
{
    public interface ICarDal:IEntityRepository<Car>
    {
        List<CarDetailDto> GetCarsByBrandId();
        List<CarDetailDto> GetCarsByColorId();
    }
}
