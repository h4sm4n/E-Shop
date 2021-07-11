using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessLayer.Concrete;
using DataAccessLayer.Context;
using EntityLayer.Entity;
using PagedList;
using PagedList.Mvc;

namespace EShop.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        private ProductRepository productRepository = new ProductRepository();
        private DataContext db = new DataContext();
        public ActionResult Index(int sayfa =1)
        {
            return View(productRepository.List().ToPagedList(sayfa,9));
        }

        public ActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Contact(Contact data)
        {
            db.Contacts.Add(data);
            db.SaveChanges();
            return RedirectToAction("Index","Home");
        }
    }
}