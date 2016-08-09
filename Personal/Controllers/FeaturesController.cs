using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Personal.Controllers
{
    public class FeaturesController : Controller
    {
        // GET: Features
        public ActionResult Index()
        {
            return View();
        }

        // Echo's a string passed in the URL following /print/
        public ActionResult Print(string word)
        {
            //var word = RouteData.Values["word"];
            //var message = string.Format("{0}", word);

            var message = Server.HtmlEncode(word);
            return Content(message);
        }

        // Returns a File type, specifically my CV in PDF format.
        public ActionResult CV()
        {
            return File(Server.MapPath("~/Content/CV.pdf"), "application/pdf");
        }

        // An alias for the ActionResult method, have to reach the method as an Action named "JsonGreeting"
        [ActionName("JsonGreeting")]
        
        // Returns the Json greeting.
        public ActionResult SimpleJson()
        {
            var message = "This is a simple Json return message";
            return Json(new { Greeting = "Hello!", Message = message }, JsonRequestBehavior.AllowGet); 
        }
    }
}