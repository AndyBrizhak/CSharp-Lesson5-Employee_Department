using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Department
{
    public class Employee
    {
        private string _emp_name { get; set; }
        private Department _emp_dep { get; set; }

        public string Name;
        public Department Dep;
        public Employee (string _emp_name, Department _emp_dep )
        {
            Name = _emp_name;
            Dep = _emp_dep;
        }

        public override string ToString()
        {
            //return $"Emp { this.Name} ";
            return $"{Name}\t{Dep}";
        }
    }
}
