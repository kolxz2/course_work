using System;
using System.Collections.Generic;
using System.Text;

namespace Third
{
    class Vacantion
    {
        private string work;//стаж работы
        private int salary;//зарплата
        private string name;//название вакансии
        public Vacantion(string _work, int _salary,string _name)//конструктор
        {
            this.work = _work;
            this.salary = _salary;
            this.name = _name;
        }
        public string GetWork()//методы доступа для переменной work
        {
            return work;
        }
        public void SetWork(string newWork)
        {
            this.work = newWork;
        }
        public int GetSalary()////методы доступа для переменной salary
        { 
            return salary;
        }
        public void SetSalary( int newSalary)
        {
            this.salary = newSalary;
        }
        public void SetName(string _name)////методы доступа для переменной name
        {
            this.name = _name;
        }
        public string GetName()
        {
            return name;
        }

    }
}
