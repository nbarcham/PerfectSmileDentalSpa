namespace WebUI.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;

    /// <summary>
    /// Home controller
    /// </summary>
    public class HomeController : Controller
    {
        /// <summary>
        /// Index action
        /// </summary>
        /// <returns>Index view</returns>
        public IActionResult Index()
        {
            return this.View();
        }

        /// <summary>
        /// About Action
        /// </summary>
        /// <returns>About View</returns>
        public IActionResult About()
        {
            this.ViewData["Message"] = "Your application description page.";

            return this.View();
        }

        /// <summary>
        /// Contact Action
        /// </summary>
        /// <returns>Contact View</returns>
        public IActionResult Contact()
        {
            this.ViewData["Message"] = "Your contact page.";

            return this.View();
        }

        /// <summary>
        /// Error Action
        /// </summary>
        /// <returns>Error View</returns>
        public IActionResult Error()
        {
            return this.View();
        }
    }
}
