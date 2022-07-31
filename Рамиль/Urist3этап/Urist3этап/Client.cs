using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Urist3этап
{
    internal class Client
    {
        private string surname, service;//фамилия клиента, оказанные услуги
        private int cost;//стоимость услуг
        public Client(string _surname, string _service, int _cost)
        {
            this.surname = _surname;
            this.service = _service;
            this.cost = _cost;
        }
        public string Surname//методы доступа для фамилии
        { get { return surname; } set { surname = value; } }
        public int Cost //методы доступа для стоимости
        { get { return cost; } set { cost = value; } }
        public string Service //методы доступа для оказанной услуги
        { get { return service; } set { service = value; } }
    }
}
