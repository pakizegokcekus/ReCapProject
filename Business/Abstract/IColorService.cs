using System;
using System.Collections.Generic;
using System.Text;
using Core.Results;
using DataAccess.ReCap.Models;

namespace Business.Abstract
{
    public interface IColorService
    {
        IResult Add(Color color);
        IResult Update(Color color);
        IDataResult<List<Color>> GetAll();
        IDataResult<Color> GetById(int colorId);
    }
}
