using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    public class Program
    {
        static void Main(string[] args)
        {
            //GetAllCar();
            //GetByIdCar();
            //GetCarsByBrandId();
            //GetCarsByColorId();
            //AddCar();

            //BrandTestGetAll();
            //BrandTestGetById();
            //BradTestAdd();

            ColorTestGetAll();
            //ColorTestGetById();
            //ColorTestAdd();
        }
        private static void ColorTestAdd()
        {
            ColorManager colorManager= new ColorManager(new EfColorDal());
            colorManager.Add(new Color
            {
                Name = "Black",
            });
            Console.WriteLine("Color Added");
        }

        private static void ColorTestGetById()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            Console.WriteLine(colorManager.GetById(1).Name);
        }

        private static void ColorTestGetAll()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            foreach (var color in colorManager.GetAll())
            {
                Console.WriteLine(color.Name);
            }
        }

        private static void BradTestAdd()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            brandManager.Add(new Brand
            {
                Name = "Audi",
            });
            Console.WriteLine("Brand Added");
        }

        private static void BrandTestGetById()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            Console.WriteLine(brandManager.GetById(1).Name);
        }

        private static void BrandTestGetAll()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            foreach (var brand in brandManager.GetAll())
            {
                Console.WriteLine(brand.Name);
            }
        }

        private static void AddCar()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Add(new Car
            {
                Name = "Audi A4",
                BrandId = 1,
                ColorId = 3,
                DailyPrice = 300,
                ModelYear = 2021,
                Description = "Audi's luxury sedan"
            });
        }

        private static void GetCarsByColorId()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetCarsByColorId(2))
            {
                Console.WriteLine(car.Name);
            }
        }

        private static void GetCarsByBrandId()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetCarsByBrandId(2))
            {
                Console.WriteLine(car.Name);
            }
        }

        private static void GetByIdCar()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            Console.WriteLine(carManager.GetById(1).Name);
        }

        private static void GetAllCar()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Name);
            }
        }
    }
}