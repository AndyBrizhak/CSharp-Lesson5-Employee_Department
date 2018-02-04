﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Department
{
   public class Department
    {
        private string _name { get; set; }

        public string Name;

        public Department()
        { }

        public Department (string _name)
        {
            Name = _name;
        }

        public override string ToString()
        {
            return $"Dep {this.Name}";
        }
    }
}
