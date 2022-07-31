// Company
using System;
using System.Collections.Generic;
using System.Text;

namespace Third
{
    class Company
    {
        private string nameComp;//название юр.фирмы
        private Stack firstElenem,SP;//первый элемент в стеке
        private int countElem;//количество элементов

        public Company(string _nameComp) //конструктор
        {
            this.nameComp = _nameComp;
            SP = null;
            firstElenem = null;
            countElem = 0;
        }
        public string Info()
        {
            string info = Convert.ToString(Count);
            Stack vspom = SP;
            while(vspom != null)
            {
                info += "\n" + vspom.date.Surname;
                info += "\n" + vspom.date.Number;
                vspom = vspom.getLaw();
            }
            return info;
        }
        public int Count { get { return countElem; } }
        public void addLaw(string _lSurname, long _number, int _size) //добавление юриста
        {
            Lawyer dobLaw = new Lawyer(_lSurname, _number, _size);
            Stack help = new Stack(dobLaw, SP);
            if (SP == null) firstElenem = help;
            SP = help;
            countElem++;
        }
        public void delLaw() //удаление юриста
        {
            if(SP != null)
            {
                SP = SP.getLaw();
                countElem--;
            }
        }
        public Lawyer searchLaw(string _lSurname) //поиск юриста по фамилии
        {
            Stack vspom = SP;
            while(vspom != null)
            {
                if (vspom.date.Surname.Equals(_lSurname))
                {
                    return vspom.date;
                }
                else vspom = vspom.getLaw();
            }
            return null;
        }
        public int SumCostLaw()//заработок всей компании
        {
            int summ = 0;
            Stack vspom = SP;
            while (vspom != null)
            {
                summ += vspom.date.SumCost();
                vspom = vspom.getLaw();
            }
            return summ;
        }
        public string getInfoComp() //получение всей информации о компании
        {
            string getInfoAll = "\n\nName Company: " + nameComp;
            Stack vspom = SP;
            while(vspom != null)
            {
                getInfoAll += "\n" + vspom.date.getInfo() + "\n";
                vspom = vspom.getLaw();
            }
            getInfoAll += "\n[summ Cost all company: " + SumCostLaw() + "]";
            return getInfoAll;
        }
        public string getInfoFor() //получение всей информации о компании
        {
            string getInfoAll = "";
            Stack vspom = SP;
            while (vspom != null)
            {
                getInfoAll += "\n" + vspom.date.getInfoFor();
                vspom = vspom.getLaw();
            }
            return getInfoAll;
        }

    }
}
