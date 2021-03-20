using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /* List All Cars with EF */
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var cars in carManager.GetAll())
            {
                Console.WriteLine(cars.Description);
            }

            /* List All Car's Brands with EF */
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            foreach (var brands in brandManager.GetAll())
            {
                Console.WriteLine(brands.Name);
            }

            /* List All Car's Colors with EF*/
            ColorManager colorManager = new ColorManager(new EfColorDal());
            foreach (var colors in colorManager.GetAll())
            {
                Console.WriteLine(colors.Name);
            }

            /* Add new car to ReCap database */
            CarManager addToCarManager = new CarManager(new EfCarDal());

            addToCarManager.Add(new Car
            {
                BrandId = 14,
                ColorId = 2,
                ModelYear = 2021,
                DailyPrice = 306000,
                Description = "Civic Sedan"
            });

            /* Car Details */

            CarManager carManagerToListed = new CarManager(new EfCarDal());
            foreach (var carDetails in carManagerToListed.GetCarDetails())
            {
                Console.WriteLine("Car Name : " + carDetails.CarName +
                                  " - Brand Name : " + carDetails.BrandName +
                                  " - Car's Color Name : " + carDetails.ColorName+
                                  " - Car Daily Price : " + carDetails.DailyPrice);
            }
        } 
    }
}
