using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetMvc_1.Data;
using AspNetMvc_1.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspNetMvc_1.Controllers
{
    public class CourseController : Controller
    {

        private readonly DataContext db;

        public CourseController(DataContext context)
        {
            db = context;
        }

        /// <summary>
        /// Get Section of course model
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Index()
        {
          List<Course> courses =  db.Courses.ToList();
            return View(courses);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            Course course = db.Courses.Where(w => w.Id == id).FirstOrDefault();
            return View(course);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            Course course = db.Courses.Where(w => w.Id == id).FirstOrDefault();
            return View(course);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            Course course = db.Courses.Where(w => w.Id == id).FirstOrDefault();
            return View(course);
        }

        /// <summary>
        /// Post Section of course model
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Create(Course model)
        {
            db.Courses.Add(model);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Edit(Course model)
        {
            db.Courses.Update(model);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Delete(Course model)
        {
            db.Courses.Remove(model);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}