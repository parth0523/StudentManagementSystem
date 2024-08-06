using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem
{
    internal class Course
    {
        public int CourseID { get; set; }
        public int CourseName { get; set; }   

        public int StudentsEnrolled { get; set; }   // No of students enrolled in the specific course 
        public int CoursePrice { get; set; }

    }
}
