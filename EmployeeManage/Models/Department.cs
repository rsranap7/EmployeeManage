using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeManage.Models
{
    public class Department
    {
        public int ID { get; set; }
        public string DeptName { get; set; }
        public virtual HOD HOD { get; set; }
        //public virtual ICollection<Teacher> Teacher { get; set; }
    }
}