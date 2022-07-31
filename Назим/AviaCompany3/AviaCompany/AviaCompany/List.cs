using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AviaCompany
{
    internal class List
    {
        public Polet info ;//важные данные
        private List last;//переменные-ссылки 
        private List first;
        private List second;
        public List(Polet _info)//конструктор
        {
            this.info = _info;
            first = null; last = null;
            second = null;
        }
        public List Second//методы доступа следующего элемента
        {
            get { return second; }
            set { this.second = value; }
        }
        public List Last//методы доступа для последнего элемента
        {
            get { return last; }
            set { this.last = value; }
        }
        public List First//методы доступа для первого элемента
        {
            get { return first; }
            set { this.first = value; }
        }
    }
}
