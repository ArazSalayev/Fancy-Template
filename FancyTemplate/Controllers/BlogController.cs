using FancyTemplate.Models;
using FancyTemplate.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FancyTemplate.Controllers
{
    public class BlogController : Controller
    {
        FancyDBEntities1 db = new FancyDBEntities1();
        public View_Model vm = new View_Model();
        // GET: Blog
        public ActionResult Index()
        {
            vm._contact = db.Contacts.Take(1).ToList();
            vm._category = db.Categories.ToList();
            vm._menu = db.Menus.ToList();
            vm._blog = db.Blogs.Take(4).ToList();
            vm._all_blog = db.Blogs.ToList();
            return View(vm);
        }
    }
}