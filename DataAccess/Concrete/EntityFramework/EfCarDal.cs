using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.DTOs;
using Entities.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, SqlContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (var _context = new SqlContext())
            {
                return (from color in _context.Colors
                        join car in _context.Cars on color.ColorId equals car.ColorId
                        join brand in _context.Brands on car.BrandId equals brand.BrandId
                        select new CarDetailDto
                        {
                            CarId = car.CarId,
                            CarName = car.CarName,
                            ColorName = color.ColorName,
                            BrandName = brand.BrandName,
                            DailyPrice = car.DailyPrice
                        }).ToList();
            }
        }
    }

}
