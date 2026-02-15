using Asp.NetHw6.Models.Courses;

namespace Asp.NetHw6.ViewModels.Courses
{
    public record class CoursesIndexViewModel(IEnumerable<Course> Courses, IEnumerable<Course> SubscribedCourses);
}
