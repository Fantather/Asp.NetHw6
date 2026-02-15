using System.Collections;
using System.Collections.Generic;

namespace Asp.NetHw6.Models.Courses
{
    public class User
    {
        public string Name { get; set; }
        public List<Course> Courses { get; set; } = new List<Course>();

        public User (string name = "")
        {
            Name = name;
        }

        public void Subscribe(Course course)
        {
            Courses.Add(course);
        }
    }
}
