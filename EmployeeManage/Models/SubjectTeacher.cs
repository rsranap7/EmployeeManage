using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeManage.Models
{
    public class SubjectTeacher
    {
        public int ID { get; set; }
        public string SubjectName { get; set; }
        public virtual Teacher Teacher { get; set; }
    }
}