namespace WebUI.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;

    public class OurServicesController : Controller
    {
        /// <summary>
        /// Index Action
        /// </summary>
        /// <returns>Index View</returns>
        public IActionResult Index()
        {
            return this.View();
        }
    }
}
