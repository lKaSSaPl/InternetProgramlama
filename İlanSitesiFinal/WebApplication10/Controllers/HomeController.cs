using WebApplication10.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication10.Models;
using System.Data.Entity;

namespace WebApplication10.Controllers
{
    public class HomeController : Controller
    {
        DataContext db = new DataContext();
        // GET: Home
        public ActionResult Index()
        {
            var imgs = db.Resims.ToList();
            ViewBag.imgs = imgs;
            var ilan = db.İlans.Include(m => m.ModelId).ToList();
            return View(ilan);
        }
        public ActionResult Detay(int id)
        {
            var ilan = db.İlans.Where(i => ilan == id).Inculude(m => m.Model).Inculude(m => m.Durum).Inculude(m => m.Şehir).FirstOrDefault();
            var imgs = db.Resims.Where(i => ilan== id).ToList();
            ViewBag.imgs = imgs;
            return View(ilan);
        }
        public PartialViewResult Slider()
        {
            var ilan = db.İlans.ToList().Take(5);
            var imgs=db.Resims.ToList();
            ViewBag.imgs = imgs;
            return PartialView(ilan);
        }
    }
}