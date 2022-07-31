// Stack
using System;
using System.Collections.Generic;
using System.Text;

namespace Third
{
    class Stack
    {
        public Lawyer date;//Данные
        private Stack pred;//ссылка на предка
        public Stack(Lawyer _date, Stack _SP)//конструктор
        {
            this.date = _date;
            pred = _SP;
        }
        public Stack getLaw()//получение ссылки на предка
        {
            return pred;
        }
    }
}