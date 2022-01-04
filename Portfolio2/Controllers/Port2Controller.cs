using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Portfolio2.Controllers
{
    public class Port2Controller : Controller
    {
        // default page - about
        [HttpGet("")]

        public ViewResult About()
        {
            return View();
        }

        //project page
        [HttpGet("projects")]
        public ViewResult Projects()
        {
            return View();
        }

        //contact page
        [HttpGet("contact")]
        public ViewResult Contact()
        {
            return View("contact");
        }

        //redirecting 
        [HttpGet("/redirectAbout")]
        public RedirectToActionResult RedirectToAbout()
        {
            return RedirectToAction("About");
        }

        [HttpGet("/redirectProject")]
        public RedirectToActionResult RedirectToProject()
        {
            return RedirectToAction("projects");
        }

        [HttpGet("/redirectContact")]
        public RedirectToActionResult RedirectToContact()
        {
            return RedirectToAction("contact");
        }
        
    }

}