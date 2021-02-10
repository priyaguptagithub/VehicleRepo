//// <summary>
/// ================================================
/// 
/// CarSales - The VehicleManagement System
/// Copyright (c) 2021
/// Author: Priya Gupta
/// File: Vehicle.cs 
/// Description: Vehicles Base Class.
/// 
/// ================================================
/// </summary>
namespace CarSales.VehicleManagement
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// Class Vehicle.
    /// </summary>
    /// <seealso cref="CarSales.VehicleManagement.IVehicle" />
    public class Vehicle : IVehicle
    {

        /// <summary>
        /// Gets or sets the vehicle identifier.
        /// </summary>
        /// <value>The vehicle identifier.</value>
        public int VehicleId
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the vehicle engine.
        /// </summary>
        /// <value>The vehicle engine.</value>
        [Display(Name = "Engine")]
        public string VehicleEngine
        {
            get; set;
        }


        /// <summary>
        /// Gets or sets the vehicle year.
        /// </summary>
        /// <value>The vehicle year.</value>
        [Display(Name = "Year")]
        public string VehicleYear
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the vehicle make.
        /// </summary>
        /// <value>The vehicle make.</value>
        [Display(Name = "Make")]
        public string VehicleMake
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the vehicle model.
        /// </summary>
        /// <value>The vehicle model.</value>
        [Display(Name = "Model")]
        public string VehicleModel
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the type of the vehicle.
        /// </summary>
        /// <value>The type of the vehicle.</value>
        public List<string> VehicleType
        {
            get; set;
        }
        /// <summary>
        /// Gets or sets the type of the selected vehicle.
        /// </summary>
        /// <value>The type of the selected vehicle.</value>
        [Display(Name = "Vehicle Type")]
        public string SelectedVehicleType
        {
            get; set;
        }

    }

    /// <summary>
    /// Class Car.
    /// </summary>
    /// <seealso cref="CarSales.VehicleManagement.Vehicle" />
    public class Car : Vehicle
    {

        /// <summary>
        /// Gets or sets the no of doors.
        /// </summary>
        /// <value>The no of doors.</value>
        [Display(Name = "Doors")]
        public int NoOfDoors
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the no of wheels.
        /// </summary>
        /// <value>The no of wheels.</value>
        [Display(Name = "Wheels")]
        public int NoOfWheels
        {
            get; set;
        }

      
        public List<string> BodyType
        {
            get; set;
        }
        [Display(Name = "Body Type")]
        public string SelectedBodyType
        {
            get; set;
        }
        /// <summary>
        /// Gets the vehicle details.
        /// </summary>
        /// <returns>System.String.</returns>
        public string GetVehicleDetails()
        {
            return "NoOfDoors=" + NoOfDoors + " BodyType: " + BodyType;
        }
     
    }
}
