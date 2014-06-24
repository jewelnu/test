using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace testWeb.Models
{
    public class StudentRegistration
    {
        public int StudentRegistrationId { set; get; }
        public string RegistrationNumber { set; get; }
        public string Name { set; get; }
        public string Email { set; get; }
        public string ContactNumber { set; get; }
        public string Address { set; get; }
        public DateTime Date { set; get; }
        public int DepartmentId { set; get; }
        public virtual Department Department { set; get; }
    }
}