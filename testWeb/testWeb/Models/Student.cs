﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Razor.Generator;

namespace testWeb.Models
{
    public class Student
    {
        public string StudentId { get; set; }
        public string Name { get; set; }
        public string Email { set; get; }
        public string Contact { set; get; }
        public DateTime RegistrationDate { set; get; }
        public string Address { set; get; }
        public int DepartmentId { set; get; }
        public virtual Department Department { set; get; }


    }
}