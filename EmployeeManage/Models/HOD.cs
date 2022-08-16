using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeManage.Models
{
    public class HOD
    {
        public int ID { get; set; }
        public string HODName { get; set; }
        public virtual ICollection<Teacher> Teachers { get; set; }
    }
}