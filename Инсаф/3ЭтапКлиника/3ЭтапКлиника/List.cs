using System;
using System.Collections.Generic;
using System.Text;

namespace _3ЭтапКлиника
{
    class List
    {
        public Visiting info; //данные посещения
        private List tempNext; //вспомогательная переменная-ссылка на потомка
        private List last,first;//заголовок списка

        public List(Visiting ainfo) //конструктор
        {
            info = ainfo;
            tempNext = null;
            last = null;
            first = null;
        } 
        public List Next//get и set для переменной next
        { 
            get { return tempNext; }
            set { tempNext = value; }
        }
        public List Last//get и set для переменной last
        {
            get { return last;}
            set { last = value;}
        }
        public List First//get и set для переменной first
        {
            get { return first;}
            set { first = value;}
        }

    }
}
