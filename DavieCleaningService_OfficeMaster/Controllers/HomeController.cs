using DavieCleaningService_OfficeMaster.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DavieCleaningService_OfficeMaster.Controllers
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

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact Shane Overby";

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Contact(ContactMessage form)
        {
            if (!ModelState.IsValid)
            {
                return View(form);
            }

            var emailer = new EmailService();

            var mail = new IdentityMessage()
            {
                Destination = ConfigurationManager.AppSettings["PersonalEmail"],
                Subject = form.Subject,
                Body = "You have received a new contact form submission from " + form.Name + " (" + form.FromEmail + ") with the following contents:<br /><br /><br />" + form.Message
            };

            emailer.SendAsync(mail);

            ViewBag.Messagesent = "Your message has been delivered successfully.";

            return View();
        }

        public ActionResult Team()
        {
            return View();
        }

        public ActionResult Services()
        {
            return View();
        }
    }
}