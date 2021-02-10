/// <summary>
/// ================================================
/// 
/// CarSales - The VehicleManagement System
/// Copyright (c) 2021
/// Author: Priya Gupta
/// File: Constants.cs 
/// Description: All public Constants 
/// 
/// ================================================
/// </summary>
namespace CarSales.VehicleManagement
{
    using System.Collections.Generic;
    using System.Web.Mvc;

    /// <summary>
    /// Class Constants.
    /// </summary>
    public static class Constants
    { 
        /// <summary>
        /// The body type
        /// </summary>
        //    public static List<string> BODY_TYPE = new List<string> { "Hatchback", "Sedan", "Coupe" };
        public static List<SelectListItem> BODY_TYPE = new List<SelectListItem>()
        {
            new SelectListItem() {Text="Hatchback", Value="Hatchback"},
            new SelectListItem() { Text="Sedan", Value="Sedan"},
            new SelectListItem() { Text="Coupe", Value="Coupe"},
         };

        /// <summary>
        /// The maximum door type cars
        /// </summary>
        /// <summary>
        /// The states
        /// </summary>
        public static int MAX_DOOR_TYPE_CARS = 5;

        /// <summary>
        /// The vehicle type
        /// </summary>
        public static List<SelectListItem> VEHICLE_TYPE = new List<SelectListItem>()
        {
        new SelectListItem() {Text="Car", Value="Car"},
        //new SelectListItem() { Text="Boat", Value="Boat"},
        //new SelectListItem() { Text="Bike", Value="Bike"},    
        };
    }
}
