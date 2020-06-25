using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using chefsndishes.Models;

namespace chefsndishes.Controllers
{
    public class HomeController : Controller
    {
        private MyContext DbContext {get;set;}
        public HomeController(MyContext context)
        {
            DbContext = context;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            List<Chef> allchefs =  DbContext.chefs.Include(c => c.dishes).OrderByDescending(c => c.CreatedAt).ToList();
            return View("Index", allchefs);
        }
        
        [HttpGet("addchef")]
        public IActionResult AddChef()
        {
            return View("new");

        }
        [HttpGet("dishes")]
        public IActionResult Dishes()
        {
            List<Dish> alldishes  = DbContext.dishes.Include(d => d.Maker).OrderByDescending(d => d.CreatedAt).ToList();
            return View("dishes", alldishes);

        }

        [HttpGet("adddish")]
        public IActionResult AddDish()
        {
            List<Chef> chefs = DbContext.chefs.ToList();
            ViewBag.allchefs = chefs;
        
            return View("dishesnew");

        }
        [HttpPost("submitchef")]
        public IActionResult submitchef(Chef newchef)
        {
            if(ModelState.IsValid)
            {
                DbContext.Add(newchef);
                DbContext.SaveChanges();

                return Redirect("/");
            }
            else
            {
                return View("new");
            }
        }
        [HttpPost("submitdish")]
        public IActionResult submitdish(Dish newdish)
        {
            if(ModelState.IsValid)
            {
                DbContext.Add(newdish);
                DbContext.SaveChanges();

                return Redirect("/dishes");
            }
            else
            {
                return View("dishesnew");
            }
        }
    }
    
}
