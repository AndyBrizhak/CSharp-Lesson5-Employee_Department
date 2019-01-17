﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Windows;
using System.ComponentModel;

//ДЗ к занятию 5 по курсу C# продвинутый Брижак Андрей

namespace Employee_Department 
{
    public class Employee : INotifyPropertyChanged
    {
        
        private string _emp_name { get; set; }
        private Department _emp_dep { get; set; }

    //public string Name;
    public string Name
    {
        get { return this._emp_name; }
        set
        {
            if (this._emp_name != value)
            {
                this._emp_name = value;
                this.NotifyPropertyChanged("Name");
            }
        }
    }

    public event PropertyChangedEventHandler PropertyChanged;
    public void NotifyPropertyChanged(string propName)
    {
        if (this.PropertyChanged != null)
            this.PropertyChanged(this, new PropertyChangedEventArgs(propName));
    }



    public Department Dep;
        public Employee (string _emp_name, Department _emp_dep )
        {
            Name = _emp_name;
            Dep = _emp_dep;
        }



        public override string ToString()
        {
           
            return $"{Name}\t{Dep}";
        }
    }
}
