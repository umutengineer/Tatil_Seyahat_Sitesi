using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Tatil_Seyahat_Sitesi.Models.Class;

namespace Tatil_Seyahat_Sitesi.Controllers
{
    public class ContactController : Controller
    {
        private Context db = new Context();

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Index(Contact contact)
        {
            if (ModelState.IsValid)
            {
                db.İletisims.Add(contact); // iletisims kullanılıyor
                db.SaveChanges();

                ViewBag.Mesaj = "Mesajınız başarıyla gönderildi.";
                return RedirectToAction("Index");
            }

            return View(contact);
        }
        public ActionResult Index()
        {
            return View();
        }

    }
}