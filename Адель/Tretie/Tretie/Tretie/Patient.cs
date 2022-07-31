// Patient
using System;
using System.Collections.Generic;
using System.Text;

namespace Tretie
{
    class Patient
    {
        private string name;//фамилия пациента
        private int count;//количество посещений
        private int sum;//сумма потраченных денег
        private List Header,Temp;//ссылка на первый элемент

        public Patient(string _name)//создание конструктора
        {
            name = _name;
            Header = new List(null);
            Header.First = null;
            Header.Last = null;
        }
        public string Name { get { return name; } set { name = value; } }
        public int Count { get { return count; } }
        public List GHeader { get { return Header.First; } }
        public void addVisit(string _date, string _service, int _cost)//добавление посещения
        {
            Visiting adds = new Visiting(_date, _service, _cost);
            List dob = new List(adds);
            count++;
            if( Header.First == null )
            {
                Header.First = dob;
                Header.Last = dob;
            }
            else
            {
                Temp = Header.Last;
                Header.Last = dob;
                Temp.Next = Header.Last;
                Header.Last.Next = Header.First;
            }
        }
        public bool delVisit(string _date) //удаление посещения
        {
            if (Header != null)
            {
                List vspom = Header.First;
                Temp = Header.First;
                for(int i = 0; i < count; i++)
                {
                    if (Temp == Header.First)
                    {
                        if (Temp.data.Date.Equals(_date))
                        {
                            count--;
                            Header.First = Header.First.Next;
                            return true;
                        }
                        else Temp = Temp.Next;
                    }
                    else
                    {
                        if (Temp.data.Date.Equals(_date))
                        {
                            count--;
                            vspom.Next = Temp.Next;
                            return true;
                        }
                        else { Temp = Temp.Next; vspom = vspom.Next; }
                    }
                } 
            }
            return false;
        }
        public int Summa() //сумма потраченных денег
        {
            sum = 0;
            Temp = Header.First;
            for (int i = 0; i < count; i++)
            {
                sum += Temp.data.Cost;
                Temp = Temp.Next;
            }
            return sum;
        }
        public string infoForSave()
        {
            string infoSave = Convert.ToString(Count);
            Temp = Header.First;
            for(int i = 0; i < Count;i++)
            {
                infoSave += "\n" + Temp.data.Date;
                infoSave += "\n" + Temp.data.Service;
                infoSave += "\n" + Temp.data.Cost;
            }
            return infoSave;
        }
        public string Print() //вывод информации о пациенте
        {
            string print = "\n\nName patient - " + name;
            Temp = Header.First;
            for (int i = 0; i < count; i++)
            {
                print += "\nDate visit: " + Temp.data.Date;
                print += "\nService: " + Temp.data.Service;
                print += "\nCost: " + Temp.data.Cost;
                Temp = Temp.Next;
            }
            print += "\nTotal cost of patient services " + name + ": " + Summa(); 
            return print;
        }
        public Visiting search(string _date, string _service)
        {
            List vspom = Header.First;
            for(int i = 0; i < count; i++)
            {
                if(vspom.data.Date.Equals(_date) && vspom.data.Service.Equals(_service))
                {
                    return vspom.data;
                }
            }
            return null;
        }
    }
}
