// Employee 
using System;
using System.Collections.Generic;
using System.Text;

namespace Этап3

{
    class Employee
    {
        private string fam, work;//Создание необходимых пременных 
        private int salary, exp;//Создание необходимых пременных 
        public Employee (string _Fam,string _work, int _exp, int _salary)
        {
            this.fam = _Fam;
            this.work = _work;
            this.exp = _exp;
            this.salary = _salary;
        }
        public string Fam
        {
            get { return fam; }
            set { this.fam = value; }
        }
        public string Work
        {
            get { return work; }
            set { this.work = value; }
        }
        public int Exp
        {
            get { return exp; }
            set { this.exp = value; }
        }
        public int Salary
        {
            get{ return salary; }
            set { this.salary = value; }
        }
        

    }
}
