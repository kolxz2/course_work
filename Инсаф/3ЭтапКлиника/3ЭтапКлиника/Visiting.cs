using System;
using System.Collections.Generic;
using System.Text;

namespace _3ЭтапКлиника
{
    class Visiting
    {
        private int date;
        private string service;//создание необходим переменных
        private int cost;

        public Visiting(int _date, string _service, int _cost)//конструктор класса
        {
            this.date = _date;
            this.service = _service;
            this.cost = _cost;
        }
        public int getDate()//получение даты
        {
            return date;
        }
        public string getService()//получение оказанной услуги
        {
            return service;
        }
        public int getCost()//получение стоимости услуги
        {
            return cost;
        }
        public void setDate(int _date)//изменение даты
        { this.date = _date; }
        public void setService(string _service)//изменение оказанной услуги
        { this.service = _service; }
        public void setCost(int _cost)//изменение стоимости
        { this.cost = _cost; }
    }
}
