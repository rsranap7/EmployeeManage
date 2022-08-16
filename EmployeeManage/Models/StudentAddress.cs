using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeManage.Models
{
    public class StudentAddress
    {
        public int ID { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public int City { get; set; }
        public virtual Student Student { get; set; }
    }
}