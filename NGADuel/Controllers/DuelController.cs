using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NGADuel.Controllers
{
    public class DuelController : Controller
    {
        //
        // GET: /Duel/

        public ActionResult Index()
        {
            using (var db = new dbduelEntities())
            {
                return View(db.duelinfo);
            }
        }

        public ActionResult CreateDuel()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateDuel(duelinfo duel)
        {
            using (var db=new dbduelEntities())
            {
                db.duelinfo.Add(duel);
                db.SaveChanges();
            }
            return Redirect("Index");
        }

    }
}
