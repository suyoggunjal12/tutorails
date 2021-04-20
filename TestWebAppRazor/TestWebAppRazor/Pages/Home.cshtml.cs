using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TestWebAppRazor.Pages
{
    public class HomeModel : PageModel
    {
        ILog _log;
        public HomeModel(ILog log)
        {
            _log = log;
        }
        public void OnGet()
        {
            ViewData["Info"] = _log.Info("Hello, Logger !!!");

            //we Can We can access dependent services configures with built-in container
            //manually using RequestServices property of HttpContext

            //IServiceProvider services = this.HttpContext.RequestServices;
            //ILog log = (ILog)services.GetService(typeof(ILog));

            //ViewData["Info"] = log.Info("Hello, Logger !!!");
        }
        //Method Injection
        //public void OnGet([FromServices] ILog log)
        //{
        //    ViewData["Info"] = _log.Info("Hello, Logger !!!");
        //}
    }
}
