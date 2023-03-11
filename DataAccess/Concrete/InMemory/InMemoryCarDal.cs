using DataAccess.Abstract;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{CarId=1,ColorId=1,BrandId=1,ModelYear=2000,DailyPrice=5000,Description="Porche"},
                new Car{CarId=2,ColorId=2,BrandId=1,ModelYear=2003,DailyPrice=5500,Description="Renault"},
                new Car{CarId=3,ColorId=1,BrandId=4,ModelYear=2007,DailyPrice=5600,Description="Wolkswagen"},
                new Car{CarId=4,ColorId=3,BrandId=1,ModelYear=2011,DailyPrice=5700,Description="Range Rover"},
                new Car{CarId=5,ColorId=1,BrandId=1,ModelYear=2022,DailyPrice=5900,Description="BMW"},

            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c=> c.CarId==car.CarId);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAllByBrand(int brandId)
        {
            return _cars.Where(c => c.BrandId==brandId).ToList();
        }

      

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c=> c.CarId == car.CarId);
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.Description = car.Description;

        }

    }
}
