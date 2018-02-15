using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FancyTemplate.Models
{
    public class Check
    {
        public static bool Check_Login()
        {
            if (HttpContext.Current.Session["email"] != null)
            {  return true;
            }
            else
            {               
                return false;
            }
        }
    }
}