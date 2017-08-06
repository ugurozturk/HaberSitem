using HaberSitem.Business;
using HaberSitem.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HaberSitem.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View(kategoriler);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Erişim Sağlandı";

            return View();
        }

        KategorilerBusiness busiKategori;

        [HttpPost]
        public ActionResult Deneme()
        {
            busiKategori = new KategorilerBusiness();
            List<Kategoriler> kategoriler = busiKategori.HepsiniGetir();
            return RedirectToAction("Index");
        }
    }
}