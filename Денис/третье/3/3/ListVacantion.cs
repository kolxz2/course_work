// ListVacantion
using System;
using System.Collections.Generic;
using System.Text;

namespace _3
{
    class ListVacantion
    {
        private string work;
        private int salary;
        public ListVacantion(string _work, int _salary)
        {
            this.work = _work;
            this.salary = _salary;
        }
        public string Work { get { return work; } set { this.work = value; } }
        public int Salary { get { return salary; } set { this.salary = value; } }
    }
}
