using DataAccess.Abstract;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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
                new Car{CarId=1,ColorId=1,BrandId=1,ModelYear=2000,DailyPrice=5000,CarName="Porche",Description="Yeşil Araba"},
                new Car{CarId=2,ColorId=2,BrandId=1,ModelYear=2003,DailyPrice=5500,CarName="Renault",Description="Beyaz Araba"},
                new Car{CarId=3,ColorId=1,BrandId=4,ModelYear=2007,DailyPrice=5600,CarName="Wolkswagen",Description="Gri Araba"},
                new Car{CarId=4,ColorId=3,BrandId=1,ModelYear=2011,DailyPrice=5700,CarName="Range Rover",Description="Sarı Araba"},
                new Car{CarId=5,ColorId=1,BrandId=1,ModelYear=2022,DailyPrice=5900,CarName="BMW",Description="Kırmızı Araba"},

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

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Task, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAllById(int carId)
        {
            return _cars.Where(c => c.CarId==carId).ToList();
        }

      

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c=> c.CarId == car.CarId);
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.Description = car.Description;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.CarId = car.CarId;
            

        }

    }
}
