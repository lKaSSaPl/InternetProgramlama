using İlan_Sitesi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
namespace İlan_Sitesi.Controllers
{
    public class HomeController : Controller
    {
        DataContext db=new DataContext();
        // GET: Home
        public ActionResult Index()
        {
            var imgs=db.Resims.ToList();
            ViewBag.imgs = imgs;

            var ilan=db.İlans.Include(m=>m.Model).ToList();
            return View(ilan);
            
        }
        public ActionResult Detay(int id)
        {
           var ilan=db.İlans.Where(i=>i.İlanId==id).Include(m => m.Model).Include(m => m.Durum).Include(m => m.Şehir).FirstOrDefault();
           var imgs=db.Resims.Where(i=>i.İlanId==id).ToList();
            ViewBag.imgs = imgs;
            return View(ilan); 
        }

     
    }
}