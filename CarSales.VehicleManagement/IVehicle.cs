//// <summary>
/// ================================================
/// 
/// CarSales - The VehicleManagement System
/// Copyright (c) 2021
/// Author: Priya Gupta
/// File: IVehicle.cs 
/// Description: Interfaces
/// 
/// ================================================
/// </summary>
namespace CarSales.VehicleManagement
{
    using System.Collections.Generic;

    /// <summary>
    /// Interface IVehicle
    /// </summary>
    public interface IVehicle
    {
        /// <summary>
        /// Gets or sets the vehicle identifier.
        /// </summary>
        /// <value>The vehicle identifier.</value>
        int VehicleId { get; set; }

        /// <summary>
        /// Gets or sets the type of the vehicle.
        /// </summary>
        /// <value>The type of the vehicle.</value>
        List<string> VehicleType { get; set; }

        /// <summary>
        /// Gets or sets the vehicle make.
        /// </summary>
        /// <value>The vehicle make.</value>
        string VehicleMake { get; set; }

        /// <summary>
        /// Gets or sets the vehicle model.
        /// </summary>
        /// <value>The vehicle model.</value>
        string VehicleModel { get; set; }

        /// <summary>
        /// Gets or sets the vehicle engine.
        /// </summary>
        /// <value>The vehicle engine.</value>
        string VehicleEngine { get; set; }

    }
   
}
