using System.Collections.Generic;

namespace Asp.NetHw6.Models.Courses
{
    public class CoursesRepository
    {
        private readonly static Dictionary<int, Course> _courses = new();
        public IEnumerable<Course> Courses { get { return _courses.Values; } }


        public CoursesRepository()
        {
            AddCourse(new Course(1, "Основы C#", 1500m));
            AddCourse(new Course(2, "ASP.NET Core MVC", 3000m));
            AddCourse(new Course(3, "Архитектура баз данных", 2500m));
        }


        public bool AddCourse(Course course)
        {
            return _courses.TryAdd(course.Id, course);
        }
    }
}
