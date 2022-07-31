using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3rdstep
{
    internal class List  //класс List для реализации адресного списка
    {
        public ThemeSection data; //переменная для записи полезных данных
        private List next; //переменная-ссылка на следующий элемент в списке
        public List(ThemeSection _data) //конструктор, где входные параметры - объект класса ThemeSection
        {
            this.data = _data;
            next = null;
        }       
        public List Next //сеттер и геттер для переменной Next
        {
            get => next; set => next = value; 
        }
    }
}
