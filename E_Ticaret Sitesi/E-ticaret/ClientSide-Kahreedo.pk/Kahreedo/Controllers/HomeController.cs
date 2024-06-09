using Khareedo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Khareedo.Controllers
{
    public class HomeController : Controller
    {
        KhareedoEntities db = new KhareedoEntities();

        // GET: Home
        public ActionResult Index()
        {
            ViewBag.utu = db.Products.Where(x => x.Category.Name.Equals("Ütü")).ToList();
            ViewBag.kahve = db.Products.Where(x => x.Category.Name.Equals("Kahve")).ToList();
            ViewBag.blender = db.Products.Where(x => x.Category.Name.Equals("Blender")).ToList();
            ViewBag.mikrodalgafirin = db.Products.Where(x => x.Category.Name.Equals("Mikrodalga Fırın")).ToList();
            ViewBag.esupurge = db.Products.Where(x => x.Category.Name.Equals("Elektrikli Süpürge")).ToList();
            ViewBag.tmakinesi = db.Products.Where(x => x.Category.Name.Equals("Tost Makinesi")).ToList();
            ViewBag.Slider = db.genMainSliders.ToList();
            ViewBag.PromoRight = db.genPromoRights.ToList();

            this.GetDefaultData();

            return View();
        }      

    }
}