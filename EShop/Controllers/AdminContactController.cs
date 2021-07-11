using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataAccessLayer.Context;

namespace EShop.Controllers
{
    public class AdminContactController : Controller
    {
        // GET: AdminContact
        private DataContext db = new DataContext();
        public ActionResult Index()
        {
            var user = db.Contacts.ToList();
            return View(user);
        }

        public ActionResult Delete(int id)
        {
            var userid = db.Contacts.Where(x => x.Id == id).FirstOrDefault();
            db.Contacts.Remove(userid);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}