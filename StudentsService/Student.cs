using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentsService
{
    public class Student
    {

        public Student() { }
        public Student(string lastName, string firstName, int year)
        {
            this.lastName = lastName;
            this.firstName = firstName;
            this.year = year;
        }

        public string lastName { get; set; }
        public string firstName { get; set; }
        public int year { get; set; }
    }
}