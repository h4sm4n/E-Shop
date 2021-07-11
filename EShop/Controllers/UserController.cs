using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using DataAccessLayer.Context;
using EntityLayer.Entity;

namespace EShop.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        DataContext db = new DataContext();
        public ActionResult Update()
        {
            var username = (string) Session["Mail"];
            var degerler = db.Users.FirstOrDefault(x => x.Email == username);
            return View(degerler);
        }

        [HttpPost]
        public ActionResult Update(User data)
        {
            var username = (string) Session["Mail"];
            var user = db.Users.FirstOrDefault(x => x.Email == username);
            user.Name = data.Name;
            user.Surname = data.Surname;
            user.Username = data.Username;
            user.Email = data.Email;
            user.Password = data.Password;
            user.UserTc = data.UserTc;
            user.Phone = data.Phone;
            user.Gender = data.Gender;
            user.Birthday = data.Birthday;
            user.City = data.City;
            user.County = data.County;
            user.Address = data.Address;
            user.PostalCode = data.PostalCode;
            db.SaveChanges();
            return RedirectToAction("Index", "Home");
        }

        public ActionResult PasswordReset()
        {
            return View();
        }

        [HttpPost]
        public ActionResult PasswordReset(string eposta)
        {
            var mail = db.Users.Where(x => x.Email == eposta).SingleOrDefault();

            if (mail != null)
            {
                Random rnd = new Random();
                int yenisifre = rnd.Next();
                User sifre = new User();
                mail.Password = Convert.ToString(yenisifre);
                db.SaveChanges();
                WebMail.SmtpServer = "smtp@gmail.com";
                WebMail.EnableSsl = true;
                WebMail.UserName= "insaatpamuk @gmail.com";
                WebMail.Password = "Pamuk.123";
                WebMail.SmtpPort = 587;
                WebMail.Send(eposta,"Giriş Şifreniz", "Şifreniz:" + " " + yenisifre);
                ViewBag.uyari = "Şifreniz başarıyla sıfırlanmıştır, mail adresinizi kontrol ediniz.";
            }
            else
            {
                ViewBag.uyari = "Hata oluştu tekrar deneyiniz.";
            }

            return View();
        }
    }
}