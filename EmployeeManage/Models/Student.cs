using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeManage.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public virtual StudentAddress StudentAddress { get; set; }
        public virtual ICollection<Grade> Grades { get; set; }
    }
}