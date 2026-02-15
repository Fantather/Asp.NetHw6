using Asp.NetHw6.Models.Courses;
using Asp.NetHw6.ViewModels.Courses;
using Microsoft.AspNetCore.Mvc;

namespace Asp.NetHw6.Controllers
{
    public class CoursesController : Controller
    {
        private readonly CoursesRepository _courses;
        private readonly User _user;

        public CoursesController(CoursesRepository courses, User user)
        {
            _courses = courses;
            _user = user;
        }

        public IActionResult Index(string id)
        {
            return View(new CoursesIndexViewModel(_courses.Courses, _user));
        }

        public IActionResult Add(int courseId)
        {
            Course course = _courses.Courses.FirstOrDefault(c => c.Id == courseId);
            _user.Subscribe(course);
            return RedirectToAction("Index");
        }
    }
}
