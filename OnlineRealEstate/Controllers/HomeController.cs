using System.Collections.Generic;
using System.Web.Mvc;
using OnlineRealEstateEntity;
using OnlineRealEstateRepositary;

namespace OnlineRealEstate.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            LandRepositary landRepositary = new LandRepositary();
            List<Land> land=landRepositary.GetLandDetail();
            ViewData["land"] = land;
            return View();
        }
    }
}