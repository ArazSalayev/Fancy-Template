using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FancyTemplate.Models;
using FancyTemplate.ViewModel;


namespace FancyTemplate.Controllers
{
    public class HomeController : Controller
    {
        FancyDBEntities1 db = new FancyDBEntities1();
        public View_Model vm = new View_Model();
        public ActionResult Index()
        {
            vm._blog = db.Blogs.Take(3).ToList();
            vm._feauture_box = db.Feature_Boxes.Take(3).ToList();
            vm._industry = db.Industries.Take(1).ToList();
            vm._blog_partial = db.Blogs.Take(1).ToList();
            vm._slider = db.Sliders.Take(3).ToList();
            vm._service_area = db.Service_Area.Take(1).ToList();
            vm._service_area_content = db.Service_Area_Contents.Take(3).ToList();
            vm._testimonials_slider = db.Testimonials_Slider.Take(3).ToList();
            vm._contact = db.Contacts.Take(1).ToList();
            vm._category = db.Categories.ToList();
            vm._menu = db.Menus.ToList();

            return View(vm);
            
        }
        public ActionResult current_blog(int id)
        {
            vm._contact = db.Contacts.Take(1).ToList();           
            vm._menu = db.Menus.ToList();
            vm._category = db.Categories.ToList();
            vm._blog = db.Blogs.Take(3).ToList();
            vm._current_blog = db.Blogs.Where(t => t.blog_id == id).ToList();

            return View(vm);
        }

        
    }
}