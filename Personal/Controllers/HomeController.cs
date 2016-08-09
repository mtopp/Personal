using Personal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Personal.Controllers
{
    public class HomeController : Controller
    {
        OdeToFoodDb _db = new OdeToFoodDb();

        public ActionResult Index()
        {
            var model = _db.Restaurants.ToList();

            //var controller = RouteData.Values["controller"];
            //var action = RouteData.Values["action"];
            //var id = RouteData.Values["id"];

            //var routeMessage = string.Format("Controller: {0}, Action: {1}, Id: {2}", controller, action, id);

            //ViewBag.Message = routeMessage;

            return View(model);
        }

        public ActionResult About()
        {
            // Uses strongly-typed Model
            var model = new AboutModel();
            model.Name = "Mike";
            model.Location = "Worthing, West Sussex";

            return View(model);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        protected override void Dispose(bool disposing)
        {
            if (_db != null)
            {
                _db.Dispose();
            }
            base.Dispose(disposing);    
        }
    }
}