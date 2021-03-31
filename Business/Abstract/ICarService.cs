﻿using System;
using System.Collections.Generic;
using System.Text;
using Core.Results;
using DataAccess.ReCap.Models;

namespace Business.Abstract
{
    public interface ICarService
    {
        IResult Add(Car car);
        IResult Update(Car car);
        IResult Delete(int carId);
        IDataResult<Car> GetById(int carId);
        IDataResult<List<Car>> GetAll();
        IDataResult<List<Car>> GelAllByColorId(int id);
    }
}
