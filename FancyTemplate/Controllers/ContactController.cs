using FancyTemplate.Models;
using FancyTemplate.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FancyTemplate.Controllers
{
    public class ContactController : Controller
    {
        FancyDBEntities1 db = new FancyDBEntities1();
        public View_Model vm = new View_Model();
        // GET: Contact
        public ActionResult Index()
        {
            vm._contact = db.Contacts.Take(1).ToList();
            vm._category = db.Categories.ToList();
            vm._menu = db.Menus.ToList();
            return View(vm);
        }
        [HttpPost]
        public ActionResult Index(FormCollection frm)
        {
            Message msg = new Message();
            msg.message_name = frm["name"];
            msg.message_content = frm["message"];
            msg.message_email = frm["email"];
            msg.message_website_url = frm["subject"];
            db.Messages.Add(msg);
            db.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
    }
}