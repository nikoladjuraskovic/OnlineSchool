using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CoursesService
{
    public class Course
    {
        public Course() { }
        public Course(string title, int points)
        {
            Title = title;
            Points = points;
        }

        public string Title { get; set; }
        public int Points { get; set; }
    }
}