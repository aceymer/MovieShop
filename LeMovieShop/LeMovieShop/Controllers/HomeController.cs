using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LeMovieShop.Controllers
{
    //Ost er psyko!
    //Smagsløg kan ikke drikke kamelaffald

    public class HomeController : Controller
    {
<<<<<<< HEAD
        //kidnap the santaclaus
=======
        // Se frontpage
>>>>>>> aae4808054e42c8021a357ed8fa7696a3938b4b6
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}