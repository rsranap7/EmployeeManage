using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeManage.Models
{
    public class Teacher
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public Nullable<int> StdID { get; set; }
        public virtual Standard Standard { get; set; }
    }
}