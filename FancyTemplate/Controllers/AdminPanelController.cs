using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FancyTemplate.Models;
namespace FancyTemplate.Controllers
{
    public class AdminPanelController : Controller
    {
        // GET: AdminPanel
        public ActionResult Index()

        {
            if (Check.Check_Login())
            {
                return View();
            }
            else
            {
                return RedirectToAction("LogIn");
            }
            
        }
        public ActionResult LogIn( string email, string password)
        {
           
                return View();
            
            
            
            
        }
        [HttpPost]
        public ActionResult LogIn(FormCollection Form)
        {
            
            Session["email"] = Form["email"];
            Session["password"] = Form["password"];
            if (Session["email"].ToString() == "admin" && Session["password"].ToString() == "admin1234")
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
           

           
        }
        
        
       
        public ActionResult LogOut()
        {
            if (Check.Check_Login())
            {
                Session.Abandon();
                return RedirectToAction("LogIn");
            }
           
                return RedirectToAction("LogIn");
            

        }
    }
}