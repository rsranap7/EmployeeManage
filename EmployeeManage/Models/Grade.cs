using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeManage.Models
{
    public class Grade
    {
        public int ID { get; set; }
        public string GradeName { get; set; }
        public virtual ICollection<Student> Students { get; set; }
    }
}