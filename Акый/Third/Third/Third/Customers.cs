// Сustomer 
using System;
using System.Collections.Generic;
using System.Text;

namespace Third
{
    class Customers
    {
        private string surname;//фамилия заказчика
        private string service;//оказанная услуга
        private int cost;//стоимость услуги
        public Customers(string _surname, string _service, int _cost)//конструктор
        {
            this.surname = _surname;
            this.service = _service;
            this.cost = _cost;
        }
        public string Surname //get/set для фамилии
        {
            get { return surname; }
            set { this.surname = value; }
        }
        public string Service//get/set для оказанной услуги
        {
            get { return service; }
            set { this.service = value; }
        }
        public int Cost//get/set для стоимости
        {
            get { return cost; }
            set { this.cost = value; }
        }
    }
}
