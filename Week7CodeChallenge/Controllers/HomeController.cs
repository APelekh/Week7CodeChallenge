using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Week7CodeChallenge.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return PartialView();
        }
        [HttpGet]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return PartialView();
        }

        [HttpPost]
        public ActionResult Contact(Week7CodeChallenge.Models.ContactFormsW7 contactForm)
        {
            try
            {
                contactForm.CreationDate = DateTime.Now;
                Models.ContactFormW7Entities db = new Models.ContactFormW7Entities();
                db.ContactFormsW7.Add(contactForm);
                db.SaveChanges();
            }
            catch (Exception exception)
            {

                ViewBag.Error = exception.Message;
                return View("Error");
            }

            return View("ThankYou");

        }

        //public ActionResult ThankYou()
        //{
        //    return PartialView();
        //}

        public ActionResult Work()
        {
            return PartialView();
        }

        public ActionResult Careers()
        {
            return PartialView();
        }

        public ActionResult Who()
        {
            return PartialView();
        }
        public ActionResult What()
        {
            return PartialView();
        }
        public ActionResult Why()
        {
            return PartialView();
        }
        public ActionResult How()
        {
            return PartialView();
        }
        public ActionResult Where()
        {
            return PartialView();
        }
    }
}