using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.ReCap;
using DataAccess.ReCap.Models;
using Entities.DTOs;
using Remotion.Linq.Parsing.Structure.IntermediateModel;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, RecapContext>, ICarDal
    {
        public List<CarDetailDto> GetCarsByBrandId()
        {
            using (RecapContext context = new RecapContext())
            {
                var result = from p in context.Cars
                             join c in context.Colors
                                          on p.ColorId equals c.Id
                             join b in context.Brands on p.BrandId equals b.Id
                             orderby p.BrandId
                             select new CarDetailDto
                             {
                                 CarId = p.Id,
                                 CarName = p.CarName,
                                 BrandName = b.BrandName,
                                 ColorName = c.ColorName
                             };
                return result.ToList();
            }
        }

        public List<CarDetailDto> GetCarsByColorId()
        {
            using (RecapContext context = new RecapContext())
            {
                var result = from p in context.Cars
                             join c in context.Colors
                                 on p.ColorId equals c.Id
                             join b in context.Brands on p.BrandId equals b.Id
                             orderby p.ColorId
                             select new CarDetailDto
                             {
                                 CarId = p.Id,
                                 CarName = p.CarName,
                                 BrandName = b.BrandName,
                                 ColorName = c.ColorName
                             };
                return result.ToList();
            }
        }
    }
}
