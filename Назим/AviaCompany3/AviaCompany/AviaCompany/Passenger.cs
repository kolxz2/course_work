using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AviaCompany
{
    internal class Passenger
    {
        private string surname;
        private int count;
        private int sum;
        private List Gol, vspom;
        public Passenger(string _surname)
        {
            this.surname = _surname;
            Gol = new List(null);
            Gol.First = null;
            Gol.Last = null;
            vspom = null;
            this.count = 0;
        }
        public string Surname
        { get { return surname; } set { surname = value; } }
        public List getListGol { get { return Gol.First; } }
        public Polet Search(DateTime _data)
        {
            List pTemp = Gol.First;
            while(pTemp != null)
            {
                if (_data.Year == pTemp.info.Date.Year)
                {
                    return pTemp.info;
                }
                else pTemp = pTemp.Second;
            }
            return null;
        }
        public void AddPolet(DateTime _date, int _cost) 
        {
            Polet dob = new Polet(_date, _cost);
            List help = new List(dob);
            count++;
            int ochered = 0;
            if (Gol.First == null)//1-е
            {
                Gol.First = help;
                Gol.Last = help;
            }
            else if ((_date.Day < Gol.First.info.Date.Day) && (_date.Month <= Gol.First.info.Date.Month))
            {
                vspom = Gol.First;
                Gol.First = help;
                Gol.First.Second = vspom;
            }
            else if ((_date.Day > Gol.Last.info.Date.Day) && (_date.Month >= Gol.Last.info.Date.Month))
            {
                vspom = Gol.Last;
                Gol.Last = help;
                vspom.Second = Gol.Last;
            }
            else
            {
                vspom = Gol.First;
                for (int i = 0; i < Count; i++)
                {
                    if (vspom.info.Date.Day < _date.Day && vspom.info.Date.Month <= _date.Month && (vspom.Second.info.Date.Day > _date.Day && vspom.Second.info.Date.Month >= _date.Month))
                    {
                        help.Second = vspom.Second;
                        vspom.Second = help;
                        break;
                    }
                    else
                    {
                        vspom = vspom.Second;
                    }
                }
            }
        }
        public bool DelPolet(DateTime _date) 
        {
            if (Gol != null)
            {
                List pTemp = Gol.First;
                vspom = Gol.First;//вспомогательная переменная с ссылкой на первый элемент в списке
                while (vspom != null)
                {
                    if (vspom == Gol.First)//удаление первого элемента списка
                    {
                        if (vspom.info.Date.Year == _date.Year)
                        {
                            Gol.First = Gol.First.Second;
                            count--;
                            return true;
                        }
                        else vspom = vspom.Second;
                    }
                    else//удаление всех остальных элементов
                    {
                        if (vspom != null)
                        {
                            if (vspom.info.Date.Year == _date.Year)
                            {
                                pTemp.Second = vspom.Second;
                                count--;
                                return true;
                            }
                            else { vspom = vspom.Second; pTemp = pTemp.Second; }
                        }
                    }
                }
            }
            return false;
        }
        public int Sum() 
        {
            sum = 0;
            vspom = Gol.First;
            while (vspom != null)
            {
                sum += vspom.info.Cost;
                vspom = vspom.Second;
            }
            return sum;
        }
        public int getIndex(DateTime _date)
        {
            int index = 0;
            vspom = Gol.First;
            while (vspom != null)
            {
                if(vspom.info.Date.Day == _date.Day && vspom.info.Date.Month == _date.Month)
                {
                    return index;
                }
                else { index++; vspom = vspom.Second; }
            }
            return -1;
        }
        public int Count { get { return count; } }
        public string getForCom()
        {
            string info = Convert.ToString(Count);
            vspom = Gol.First;
            while(vspom != null)
            {
                info += "\n" + vspom.info.Date.Year;
                info += "\n" + vspom.info.Date.Month;
                info += "\n" + vspom.info.Date.Day;
                info += "\n" + vspom.info.Cost;
                vspom = vspom.Second;
            }
            return info;
        }
        public string GetInfo() 
        {
            string inform = "\n\nSurname " + surname;
            vspom = Gol.First;
            while(vspom != null)
            {
                inform += "\nDate Poleta " + vspom.info.Date.ToLongDateString();
                inform += "\nCost Poleta " + vspom.info.Cost;
                vspom = vspom.Second;
            }
            inform += "\nAmount Cost " + Sum();
            return inform;
        }
    }
}
