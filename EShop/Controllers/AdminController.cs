using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataAccessLayer.Context;
using PagedList;
using PagedList.Mvc;

namespace EShop.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        // GET: Admin
        private DataContext db = new DataContext();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CommentList(int sayfa = 1)
        {
            return View(db.Comments.ToList().ToPagedList(sayfa,5));
        }

        public ActionResult Delete(int id)
        {
            var delete = db.Comments.Where(x => x.Id == id).FirstOrDefault();
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult UserList()
        {
            var user = db.Users.Where(x => x.Role == "User").ToList();
            return View(user);
        }

        public ActionResult UserDelete(int id)
        {
            var userid = db.Users.Where(x => x.Id == id).FirstOrDefault();
            db.Users.Remove(userid);
            db.SaveChanges();
            return RedirectToAction("UserList");
        }
    }
}