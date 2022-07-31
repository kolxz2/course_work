using System;
using System.Collections.Generic;
using System.Text;

namespace Third
{
    class SList
    {
        public Vacantion data; //данные о организации
        private SList next; //ссылка на потомка
        private SList last, first;//заголовок списка
        public SList(Vacantion _data) //конструктор
        {
            data = _data;
            next = null;
            first = null;
            last = null;
        } 
        public SList NEXT//методы доступа к переменной next
        {
            get { return next; }
            set { this.next = value; }
        }
        public SList FIRST//методы доступа к переменной first
        {
            get { return first; }
            set { this.first = value; }
        }
        public SList LAST//методы доступа к переменной last
        {
            get { return last; }
            set { this.last = value; }
        }
    }
}
