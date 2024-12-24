using Deneme1.Models.Film;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace Deneme1.Areas.Yonetim.Controllers
{
    public class FilmController : Controller
    {
        // GET: Yonetim/Film
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult List()
        {
            Thread.Sleep(1000);
            return PartialView("_FilmList", FilmDataSet.Items);
        }

        public PartialViewResult FilmEkleGuncelle(int id = 0)
        {
            Film item = FilmDataSet.Items.FirstOrDefault(x => x.Id == id) ?? new Film();  
            return PartialView("_FilmEkleGuncelle", item);
        }

        [HttpPost, ActionName("Kaydet")]
        public JsonResult FilmKaydet(Film film)
        {
            if(film.Id == 0)
            {
                FilmDataSet.Ekle(film);
            } else
            {
                FilmDataSet.Guncelle(film);
            }

            return Json(new { success = true });
        }

        public PartialViewResult FilmSil(int id)
        {
            Film film = FilmDataSet.Items.FirstOrDefault(x => x.Id == id);
            if(film != null)
            {
                return PartialView("_FilmSil", film);
            } else
            {
                throw new Exception("Film bulunamadı.");
            }
        }

        [HttpPost, ActionName("Sil")]
        public JsonResult FilmSilOnay(Film film)
        {
            FilmDataSet.Sil(film.Id);
            return Json(new { success = true });    
        }
    }
}