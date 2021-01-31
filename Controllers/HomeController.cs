using leave_manager.App_Code;
using leave_manager.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace leave_manager.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public HomeController(ILogger<HomeController> logger, IHttpContextAccessor httpContextAccessor)
        {
            this._httpContextAccessor = httpContextAccessor;
            _logger = logger;
        }

        public IActionResult Index()
        {
            string cookieValueFromContext = _httpContextAccessor.HttpContext.Request.Cookies["layoutCookie"];
            //read cookie from Request object  
            Global.SiteLayout = Request.Cookies["layoutCookie"];
            return View();
        }
        //[HttpPost]
        //public ActionResult SetCookie(string value)
        ////public void SetCookie(string key, string value)
        //{
        //    Response.Cookies.Append("layoutCookie", value);
        //    return RedirectToAction(nameof(Index), "Home");
        //}
        [HttpPost]
        public IActionResult SetCookieAdmin()
        {
            Response.Cookies.Append("layoutCookie", "~/Views/Shared/_AdminLTE.cshtml");
            Global.SiteLayout= "~/ Views / Shared / _AdminLTE.cshtml";
            return RedirectToAction(nameof(Index), "Home");
        }
        
        [HttpPost]
        public IActionResult SetCookieFlic()
        { 
            Response.Cookies.Append("layoutCookie", "~/Views/Shared/_Layout.cshtml");
            Global.SiteLayout = "~/ Views / Shared / _Layout.cshtml";
            return RedirectToAction(nameof(Index), "Home");
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
