using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeManage.Models
{
    public class Standard
    {
        public int ID { get; set; }
        public string StdName { get; set; }
        public virtual ICollection<Teacher> Teachers { get; set; } 
    }
}