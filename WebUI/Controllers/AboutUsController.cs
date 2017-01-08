namespace WebUI.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;

    /// <summary>
    /// About Us Controller
    /// </summary>
    public class AboutUsController : Controller
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
