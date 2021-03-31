using System;
using System.Collections.Generic;
using System.Text;
using Core.Results;
using DataAccess.ReCap.Models;

namespace Business.Abstract
{
    public interface ICarService
    {
        IResult Add(Car car);
    }
}
