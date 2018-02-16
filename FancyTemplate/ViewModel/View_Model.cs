using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FancyTemplate.Models;

namespace FancyTemplate.ViewModel
{
    public class View_Model
    {       
       public IEnumerable<Blog> _blog { get; set; }
       public IEnumerable<Feature_Boxes> _feauture_box { get; set; }
       public IEnumerable<Industry> _industry { get; set; }
       public IEnumerable<Blog> _blog_partial { get; set; }
       public IEnumerable<Slider> _slider { get; set; }
       public IEnumerable<Service_Area> _service_area { get; set; }
       public IEnumerable<Service_Area_Contents> _service_area_content { get; set; }
       public IEnumerable<Testimonials_Slider> _testimonials_slider { get; set; }
       public IEnumerable<Contact> _contact { get; set; }
       public IEnumerable<Category> _category { get; set; }
       public IEnumerable<Menu> _menu { get; set; }
       public IEnumerable<Blog> _current_blog { get; set; }
        public IEnumerable<Blog> _all_blog { get; set; }
    }
}