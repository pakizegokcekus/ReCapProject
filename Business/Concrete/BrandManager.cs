using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using Core.Results;
using DataAccess.Abstract;
using DataAccess.ReCap.Models;

namespace Business.Concrete
{
    public class BrandManager:IBrandService
    {
        private IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public IResult Add(Brand brand)
        {
            _brandDal.Add(brand);
            return new SuccessResult("Başarılı");
        }

        public IResult Update(Brand brand)
        {
            _brandDal.Update(brand);
            return new SuccessResult("Başarılı");
        }

        public IDataResult<List<Brand>> GetAll()
        {
            var result=_brandDal.GetAll();
            return new DataResult<List<Brand>>(result, true, "");
        }

        public IDataResult<Brand> GetById(int brandId)
        {
            return new SuccessDataResult<Brand>(_brandDal.Get(x => x.Id == brandId));
        }

        public IResult Delete(Brand brand)
        {
            _brandDal.Delete(brand);
            return new SuccessResult("Başarılı");
        }
    }
}
