using Asp.NetHw6.Models.Courses;
using Asp.NetHw6.ViewModels.Courses;
using Microsoft.AspNetCore.Mvc;

namespace Asp.NetHw6.Controllers
{
    public class CoursesController : Controller
    {
        private readonly CoursesRepository _courses;
        private readonly CoursesRepository _subscribedCourses;

        public CoursesController(CoursesRepository courses, CoursesRepository subscribedCourses)
        {
            _courses = courses;
            _subscribedCourses = subscribedCourses;
        }

        public IActionResult Index(string id)
        {
            return View(new CoursesIndexViewModel(_courses.Courses, _subscribedCourses.Courses));
        }

        //public IAct   ionResult Add(int courseId)
        //{
            
        //}
    }
}
