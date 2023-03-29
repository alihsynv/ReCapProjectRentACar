using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    public class Program
    {
        static void Main(string[] args)
        {
            //GetAll();
            //GetById();
            //Delete(); 
            //Add();
        }

        private static void Add()
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());
            Car car = new Car { Id = 6, BrandID = 2, ColorId = 1, DailyPrice = 100, ModelYear = 2019, Description = "Mercedes EQS" };

            carManager.Add(car);
            foreach (var c in carManager.GetAll())
            {
                Console.WriteLine(c.Description);
            }
            Console.WriteLine("Car Added");

        }

        private static void Delete()
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());
            Car car = new Car();
            carManager.Delete(car);
            Console.WriteLine("Deleted Car");
        }

        private static void GetById()
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());
            foreach (var car in carManager.GetById(2))
            {
                Console.WriteLine(car.Description);
            }
        }

        private static void GetAll()
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description);
            }
        }
    }
}