﻿namespace WebUI.Controllers
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
        /// Error Action
        /// </summary>
        /// <returns>Error View</returns>
        public IActionResult Error()
        {
            return this.View();
        }
    }
}
