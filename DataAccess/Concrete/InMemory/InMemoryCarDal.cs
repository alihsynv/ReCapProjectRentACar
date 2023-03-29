using DataAccess.Abstarct;
using Entities.Concrete;
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
                new Car {Id=1, BrandID=1, ColorId=1, DailyPrice=150, ModelYear=2020, Description="BMW M5"},
                new Car {Id=2, BrandID=2, ColorId=2, DailyPrice=250, ModelYear=2023, Description="Mercedes GLS"},
                new Car {Id=3, BrandID=1, ColorId=1, DailyPrice=50, ModelYear=2009, Description="Toyota Corolla"},
                new Car {Id=4, BrandID=3, ColorId=2, DailyPrice=75, ModelYear=2015, Description="Hyundai i30"},
                new Car {Id=5, BrandID=5, ColorId=3, DailyPrice=500, ModelYear=2024, Description="Bentley"},
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetByID(int id)
        {
            return _cars.Where(c => c.Id == id).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.Id = car.Id;
            carToUpdate.BrandID = car.BrandID;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
    }
}
