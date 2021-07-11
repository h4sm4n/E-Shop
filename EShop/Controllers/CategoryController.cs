﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessLayer.Concrete;

namespace EShop.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        private CategoryRepository categoryRepository = new CategoryRepository();

        public PartialViewResult CategoryList()
        {
            return PartialView(categoryRepository.List());
        }

        public ActionResult Details(int id)
        {
            var cat = categoryRepository.CategoryDetails(id);
            return View(cat);
        }
    }
}