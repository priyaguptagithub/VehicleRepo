/// <summary>
/// ================================================
/// 
/// CarSales - The VehicleManagement System
/// Copyright (c) 2021
/// Author: Priya Gupta
/// File: HomeController.cs 
/// Description: Home Controller Class
/// 
/// ================================================
/// </summary>
namespace CarSales.Web.UI.Controllers
{
    using System.Web.Mvc;

    /// <summary>
    /// Class HomeController.
    /// </summary>
    /// <seealso cref="System.Web.Mvc.Controller" />
    public class HomeController : Controller
    {
        /// <summary>
        /// Indexes this instance.
        /// </summary>
        /// <returns>ActionResult.</returns>
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Abouts this instance.
        /// </summary>
        /// <returns>ActionResult.</returns>
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        /// <summary>
        /// Contacts this instance.
        /// </summary>
        /// <returns>ActionResult.</returns>
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}