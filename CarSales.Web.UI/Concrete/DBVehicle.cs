/// <summary>
/// ================================================
/// 
/// CarSales - The VehicleManagement System
/// Copyright (c) 2021
/// Author: Priya Gupta
/// File: DbVehicle.cs 
/// Description: All public Constants 
/// 
/// ================================================
/// </summary>
namespace CarSales.Web.UI.Concrete
{
    using System.Collections.Generic;
    using CarSales.VehicleManagement;

    /// <summary>
    /// Class DBVehicle.
    /// </summary>
    public static class DBVehicle
    {
        static List<Car> carList = null;
        static DBVehicle()
        {
            carList = new List<Car>(){
            new Car()
            {
                VehicleId = 1,
             SelectedVehicleType = "Car",
            VehicleYear = "2015",
            VehicleMake = "Abarth",
            VehicleModel = "Punto",
            VehicleEngine= "1.4",
            NoOfDoors = 4,
            NoOfWheels=4,
            SelectedBodyType= "Hatchback",
            },
               new Car()
            {
                VehicleId = 1,
             SelectedVehicleType = "Car",
             VehicleYear = "2016",
            VehicleMake = "Volkswagen",
            VehicleModel = "Polo GTI",
            VehicleEngine= "1.4",
            NoOfDoors = 4,
            NoOfWheels=4,
            SelectedBodyType= "Hatchback",
            }
        };
    }

        /// <summary>
        /// Selects the car list.
        /// </summary>
        /// <returns>List&lt;Car&gt;.</returns>
        public static List<Car> SelectCarList()
        {
            return carList;
        }

        /// <summary>
        /// Inserts the car list.
        /// </summary>
        /// <param name="car">The car.</param>
        public static void InsertCarList(Car car)
        {
            carList.Add(car);
        }
    }
}