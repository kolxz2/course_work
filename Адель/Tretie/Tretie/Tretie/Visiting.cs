// Visiting
using System;
using System.Collections.Generic;
using System.Text;

namespace Tretie
{
    class Visiting
    {
        private string date, service;//создание необходим переменных
        private int cost;
        public Visiting(string _date, string _service, int _cost)
        {
            date = _date;
            service = _service;
            cost = _cost;
        }
        public string Date//получение даты
        {
            get{ return date;}
            set { date = value; }
        }
        public string Service//получение оказанной услуги
        {
            get { return service; }
            set { service = value; }
        }
        public int Cost//получение стоимости услуги
        {
            get { return cost; }
            set { cost = value; }
        }
    }
}
