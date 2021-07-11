using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessLayer.Concrete;
using EntityLayer.Entity;

namespace EShop.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminCategoryController : Controller
    {
        // GET: AdminCategory
        private CategoryRepository categoryRepository = new CategoryRepository();
        public ActionResult Index()
        {
            return View(categoryRepository.List());
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Category p)
        {
            if (ModelState.IsValid)
            {
                categoryRepository.Insert(p);
                return RedirectToAction("Index");
            }
            ModelState.AddModelError("","Bir hata oluştu.");
            return View();
        }

        public ActionResult Delete(int id)
        {
            var delete = categoryRepository.GetById(id);
            categoryRepository.Delete(delete);
            return RedirectToAction("Index");
        }

        public ActionResult Update(int id)
        {
            var update = categoryRepository.GetById(id);
            return View(update);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Update(Category p)
        {
            if (ModelState.IsValid)
            {
                var update = categoryRepository.GetById(p.Id);
                update.Name = p.Name;
                update.Description = p.Description;
                categoryRepository.Update(update);
                return RedirectToAction("Index");
            }
            ModelState.AddModelError("","Bir hata oluştu.");
            return View();
        }
    }
}