using HaberSitem.Business;
using HaberSitem.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HaberSitem.Web.Controllers
{
    public class ChildViewsController : Controller
    {
        [ChildActionOnly]
        public ActionResult Navbar()
        {
            KategorilerBusiness busiKategoriler = new KategorilerBusiness();
            List<Kategoriler> kategoriler = busiKategoriler.HepsiniGetir();

            return PartialView(kategoriler);
        }
    }
}