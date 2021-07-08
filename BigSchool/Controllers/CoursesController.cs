using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BigSchool.Controllers
{
    public class CoursesController : Controller
    {
        private readonly ApplicationDbContext_dbContext
        public 
        
        
        // GET: Courses
        public ActionResult Create()
        {
            var viewModel = new CoursesViewModel
            {
                Categories =_dbC
            }
            return View();
        }
    }
}