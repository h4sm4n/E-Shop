using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataAccessLayer.Context;
using EntityLayer.Entity;
using PagedList;
using PagedList.Mvc;

namespace EShop.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminSalesController : Controller
    {
        // GET: AdminSales
        DataContext db = new DataContext();
        public ActionResult Index(int sayfa=1)
        {
            return View(db.Sales.ToList().ToPagedList(sayfa, 5));
        }

        public ActionResult AddTrackNumber(int id)
        {
            var contact = db.Sales.FirstOrDefault(x => x.Id == id);
            return View(contact);
        }

        [HttpPost]
        public ActionResult AddTrackNumber(Sales data)
        {
            var contact = db.Sales.FirstOrDefault(x => x.Id == data.Id);
            contact.TrackNumber = data.TrackNumber;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}