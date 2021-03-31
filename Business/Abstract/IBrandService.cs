using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Core.Results;
using DataAccess.ReCap.Models;

namespace Business.Abstract
{
    public interface IBrandService
    {
        IResult Add(Brand brand);
        IResult Update(Brand brand);
        IDataResult<List<Brand>> GetAll();
        IDataResult<Brand> GetById(int brandId);
        IResult Delete(Brand brand);
    }
}
