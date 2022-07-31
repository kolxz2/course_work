// StructList
using System;
using System.Collections.Generic;
using System.Text;

namespace _3
{
    class StructList
    {
        public ListCompany name; //данные о организации
        private StructList next; //ссылка на потомка
        private StructList last;
        private StructList first;
        public StructList(ListCompany _date) 
        {
            name = _date;
            next = null;
            first = null;
            last = null;
        } 
        public ListCompany Name { get { return name; } }
        public StructList Next 
        {
            get { return next; }
            set { this.next = value; }
        }
        public StructList Last
        {
            get { return last; }
            set { this.last = value; }
        }
        public StructList First
        {
            get { return first; }
            set { this.first = value; }
        }
    }
}
