using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem
{
    internal class Attendance
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int NoOfAbsents { get; set; }
        public string DayOfAbsent { get; set; }
    }
}
