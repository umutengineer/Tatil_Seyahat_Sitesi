using System;
using System.Collections.Generic;
using System.Linq;

using System.Web;
using System.Web.Mvc;
using Tatil_Seyahat_Sitesi.Models.Class;
using System.Data.Entity;

namespace Tatil_Seyahat_Sitesi.Controllers
{
    public class YerlerController : Controller
    {
        // GET: Yerler
        Context c = new Context();
        public ActionResult Oteller()
        {
           var degerler = c.Otellers.ToList();
           return View(degerler);

        }
    }
}