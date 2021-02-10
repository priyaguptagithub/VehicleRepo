//// <summary>
/// ================================================
/// 
/// CarSales - The VehicleManagement System
/// Copyright (c) 2021
/// Author: Priya Gupta
/// File: Startup.cs 
/// Description: Startup Class.
/// 
/// ================================================
/// </summary>
[assembly: Microsoft.Owin.OwinStartupAttribute(typeof(CarSales.Web.UI.Startup))]
namespace CarSales.Web.UI
{
    /// <summary>
    /// Class Startup.
    /// </summary>
    public partial class Startup
    {
        /// <summary>
        /// Configurations the specified application.
        /// </summary>
        /// <param name="app">The application.</param>
        public void Configuration(Owin.IAppBuilder app)
        {
            //ConfigureAuth(app);
        }
    }
}
