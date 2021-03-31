using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using Core.Results;
using DataAccess.Abstract;
using DataAccess.ReCap.Models;

namespace Business.Concrete
{
   public class ColorManager:IColorService
   {
       private IColorDal _colorDal;

       public ColorManager(IColorDal colorDal)
       {
           _colorDal = colorDal;
       }

       public IResult Add(Color color)
        {
            _colorDal.Add(color);
            return new SuccessResult("");
        }

        public IResult Update(Color color)
        {
            _colorDal.Update(color);
            return new SuccessResult("");
        }

        public IDataResult<List<Color>> GetAll()
        {
            var result=_colorDal.GetAll();
            return new SuccessDataResult<List<Color>>(result);
        }

        public IDataResult<Color> GetById(int colorId)
        {
            var result = _colorDal.Get(x => x.Id == colorId);
            return new SuccessDataResult<Color>(result);
        }
    }
}
