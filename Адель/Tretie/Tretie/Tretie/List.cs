// List
using System;
using System.Collections.Generic;
using System.Text;

namespace Tretie
{
    class List
    {
        public Visiting data; //данные посещения
        private List next, first, last; //вспомогательная переменная-ссылка на потомка
        public List(Visiting _data) //конструктор
        {
            data = _data;
            next = null;
            first = null;
            last = null;
        } 
        public List Next { get => next; set => next = value; }
        public List First { get => first; set => first = value; }
        public List Last { get => last; set => last = value; }
    }
}
