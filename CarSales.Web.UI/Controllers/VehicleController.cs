/// <summary>
/// ================================================
/// 
/// CarSales - The VehicleManagement System
/// Copyright (c) 2021
/// Author: Priya Gupta
/// File: VehicleController.cs 
/// Description: Vehicle Controller Class
/// 
/// ================================================

namespace CarSales.Web.UI.Controllers
{
    using System.Web.Mvc;
    using CarSales.VehicleManagement;


    /// <summary>
    /// Class VehicleController.
    /// </summary>
    /// <seealso cref="System.Web.Mvc.Controller" />
    public class VehicleController : Controller
    {
        IVehicle _IVehicle;

        /// <summary>
        /// Initializes a new instance of the <see cref="VehicleController"/> class.
        /// </summary>
        public VehicleController()
        {
            ViewBag.VehicleType = Constants.VEHICLE_TYPE;
            ViewBag.BodyType = Constants.BODY_TYPE;
            _IVehicle = new Vehicle();
            
        }

        /// <summary>
        /// Details this instance.
        /// </summary>
        /// <returns>ActionResult.</returns>
        public ActionResult Details()
        {
         return View(Concrete.DBVehicle.SelectCarList());

        }


        /// <summary>
        /// Creates this instance.
        /// </summary>
        /// <returns>ActionResult.</returns>
        public ActionResult Create()
        {
         
            return View();
         
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Car carModels)
        {
            try
            {
                Concrete.DBVehicle.InsertCarList(carModels);
                return RedirectToAction("Details");
            }
            catch
            {
                return View();
            }
        }
       
    }
}
