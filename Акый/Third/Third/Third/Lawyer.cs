// Lawyer 
using System;
using System.Collections.Generic;
using System.Text;

namespace Third
{
    class Lawyer
    {
        private string lSurname;//фамилия юриста
        private long number;
        private Customers[] queue;//массив-очередь
        private int first;//ссылка на 1 элемент
        private int last;//ссылка на последний элемент
        private int sumCost, size,count;//сумма, потраченная на услуги
        public Lawyer(string _lSurname, long _number, int _size) //конструктор
        {
            this.lSurname = _lSurname;
            this.number = _number;
            this.size = _size;
            queue = new Customers[size];
            first = 0; last = 0; count = 0;
        }
        public Customers Search(string _lSurname)
        {
            for(int i = 0; i < count; i++)
            {
                if(queue[i].Surname.Equals(_lSurname))
                {
                    return queue[i];
                }
            }
            return null;
        }
        public long Number { get { return number; } set { this.number = value; } }
        public Customers[] Queue { get { return queue; } }
        public string Surname{ get { return lSurname; }set { this.lSurname = value; } }
        public int Count { get { return count; } }
        public void addCust(string _surname, string _service, int _cost) //добавление заказчика
        {
            if (size >= count)
            {
                if (first > 0 && last >= size) last = 0;
                Customers dobav = new Customers(_surname, _service, _cost);
                queue[last] = dobav;
                last++;
                count++;
            }
        }
        public void delCust() //удаление заказчика по переменной first
        { 
            if (count != 0)
            {
                if (first > size) first = 0;
                queue[first] = null;
                count--;
                first++;
            }
        }
        public int SumCost()//возвращает сумму потраченных денег
        {
            sumCost = 0;
            for( int i = 0; i < size; i++)
            {
                if (queue[i] != null)
                {
                    sumCost += queue[i].Cost;
                }
            }
            return sumCost;
        }
        public string getInfo() //получение информации об одном юристе и его заказчиках
        {
            string getinfo = "\n<=======Lawyer: " + lSurname + "=======>";
            Customers help;
            for (int i = 0; i < size; i++)
            {
                help = queue[i];
                if (help != null)
                {
                    getinfo += "\n\nCustomer: " + help.Surname;
                    getinfo += "\nService: " + help.Service;
                    getinfo += "\nCost: " + help.Cost + "\n";
                }    
            }
            getinfo += "\nsum of cost: " + SumCost(); 
            return getinfo;
        }
        public string getInfoFor()
        {
            string getinfo = Convert.ToString(Count);
            Customers help;
            for (int i = 0; i < size; i++)
            {
                help = queue[i];
                if (help != null)
                {
                    getinfo += "\n" + help.Surname;
                    getinfo += "\n" + help.Service;
                    getinfo += "\n" + help.Cost;
                }
            }
            return getinfo;
        }
    }
}
