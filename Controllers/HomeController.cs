using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Deneme1.Models.Film;

namespace Deneme1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var filmler = FilmDataSet.Items ?? new List<Film>();
            return View(filmler);
        }
    }
}