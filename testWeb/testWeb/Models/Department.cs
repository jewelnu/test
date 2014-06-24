using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Remoting;
using System.Web;
using System.Web.Configuration;
using System.Web.Mvc;

namespace testWeb.Models
{
    public class Department
    {
        public int DepartmentId { set; get; }
        public string Code { set; get; }
        public string Name { set; get; }
    }
}

