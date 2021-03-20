using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, CarsDbContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (CarsDbContext context = new CarsDbContext())
            {
                var result = from cars in context.Cars
                             join brands in context.Brands
                             on cars.BrandId equals brands.Id
                             join colors in context.Colors
                             on cars.ColorId equals colors.Id
                             select new CarDetailDto
                             {
                                 CarName = cars.Description,
                                 BrandName = brands.Name,
                                 ColorName = colors.Name,
                                 DailyPrice = cars.DailyPrice
                             };
                return result.ToList();
            }
        }
    }
}
