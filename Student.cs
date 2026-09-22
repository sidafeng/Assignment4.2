using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment4._2
{

    internal class Student
    {
        public int studentID { get; set; }
        public string studentName { get; set; }

        public string? Email { get; set; }
        public float GPA { get; set; }

        public string emailGenerator(string name)
        {
            return name + "@College.com";
        }

    }
}
