using _1911066291_NguyenHoangPhuoc_BigSchool.Models;
using _1911066291_NguyenHoangPhuoc_BigSchool.ViewModels;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _1911066291_NguyenHoangPhuoc_BigSchool.Controllers
{
    public class CourseController : Controller
    {
        private readonly ApplicationDbContext dbContext ;
        public CourseController ()
        {
            dbContext = new ApplicationDbContext();
        }
        // GET: Course
        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create()
        {
            var ViewModels = new CourseViewModel
            {
                categories = dbContext.Categories.ToList()
            };
            return View(ViewModels);
        }
        // GET: Course
        [Authorize]
        
        public ActionResult Create(CourseViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                viewModel.categories = dbContext.Categories.ToList();
                return View("Create", viewModel);
            }
            var Course = new Course
            {
                LecturerId = User.Identity.GetUserId(),
                DateTime = viewModel.GetDateTime(),
                CategoryId = viewModel.Category,
                place = viewModel.Place
            };
            dbContext.Courses.Add(Course);
            dbContext.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
    }
}