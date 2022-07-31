using System;
using System.Collections.Generic;
using System.Text;

namespace step3
{
    class taxpayer
    {
        private string surname; //фамилия налогоплательщика
        private long INN;
        private int count, vibor; //ИНН налогоплательщика
        private dinList pHead,Temp,vspom,Temp2;//ссылка на первый элемент

        public taxpayer(string _surname, long _INN) //конструктор
        {
            this.surname = _surname;
            this.INN = _INN;
            pHead = new dinList(null);
            pHead.First = null;
            pHead.Last = null;
        }
        public dinList PHead { get { return pHead.First; } }
        public string Surname 
        {
            get { return surname; }
            set { surname = value; }
        }
        public long IINN
        {
            get { return INN; }
            set { INN = value; }
        }
        public int Count
        {
            get { return count; }
        }
        public void addForUpload(string addTypeTax, int aMount)
        {
            tax add = new tax(addTypeTax, aMount);
            dinList dobav = new dinList(add);
            count++;
            if (pHead.Last == null)
            {
                pHead.First = dobav;
                pHead.Last = dobav;
            }
            else
            {
                Temp = pHead.Last;
                pHead.Last = dobav;
                Temp.Next = pHead.Last;
            }
        }
        public void addtaxVtoroe(string _choose,string addTypeTax, int aMount,int i) //добавление налога
        {
            tax add = new tax(addTypeTax, aMount);
            dinList dobav = new dinList(add);
            count++;
            if (i == 1)
            {
                vspom = SearchListBefore(_choose);
                dobav.Next = vspom.Next;
                vspom.Next = dobav;
            }
            else if(i== 2)
            {
                vspom = SearchListAfter(_choose);
                dobav.Next = vspom.Next;
                vspom.Next = dobav;
            }
            else if(i == 3)
            {
                Temp = pHead.First;
                pHead.First = dobav;
                pHead.First.Next = Temp;
            }
            else if(i == 4)
            {
                if (pHead.Last == null)
                {
                    pHead.First = dobav;
                    pHead.Last = dobav;
                }
            }
        }
        public dinList SearchListBefore(string aTypeTax)
        {
            Temp2 = pHead.First;
            Temp = pHead.First;
            for(int i = 0; i<count;i++)
            {
                if (Temp != null)
                {
                    if (Temp.typeTax.getTypeTax().Equals(aTypeTax))
                    {
                        return Temp2;
                    }
                    else
                    {
                        if (i != 0) { Temp2 = Temp2.Next; }
                        Temp = Temp.Next;
                    }
                }
            }
            return null;
        }
        public dinList SearchListAfter(string aTypeTax)
        {
            Temp = pHead.First;
            while (Temp != null)
            {
                if (Temp.typeTax.getTypeTax().Equals(aTypeTax))
                {
                    return Temp;
                }
                else { Temp = Temp.Next; }
            }
            return null;
        }
        public tax Search(string aTypeTax)
        {
            Temp = pHead.First;
            while(Temp != null)
            {
                if (Temp.typeTax.getTypeTax().Equals(aTypeTax))
                {
                    return Temp.typeTax;
                }
                else { Temp = Temp.Next; }
            }
            return null;
        }
        public bool delltax(String _typeTax, int _amount) //удаление налога
        {
            if (pHead != null)
            {
                dinList vspom = pHead.First;
                Temp = pHead.First;
                while(Temp != null)
                {
                    if (Temp == pHead.First)
                    {
                        if (Temp.typeTax.getTypeTax().Equals(_typeTax) && (Temp.typeTax.getAmount() == _amount))
                        {
                            count--;
                            pHead.First = pHead.First.Next;
                            return true;
                        }
                        else Temp = Temp.Next;
                    }
                    else
                    {
                        if (Temp.typeTax.getTypeTax().Equals(_typeTax) && (Temp.typeTax.getAmount() == _amount))
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
        public int sumTax() //сумма задолжности у одного плательщика
        {
            int sum = 0;
            Temp = pHead.First;
            while (Temp != null)
            {
                sum += Temp.typeTax.getAmount();
                Temp = Temp.Next;
            }
            return sum;
        } 
        public string getInfo() //получить информацию об одном налогоплательщике
        {
            string getinfo = "\nSurname taxpayer: " + surname;
            Temp = pHead.First;
            while(Temp != null)
            {
                getinfo += "\nType tax: " + Temp.typeTax.getTypeTax();
                getinfo += "\nAmount: " + Temp.typeTax.getAmount();
                Temp = Temp.Next;
            }
            getinfo += "\nsumm: " + sumTax() + "\n\n";
            return getinfo;
        }
        public string getInfoFor() //получить информацию об одном налогоплательщике
        {
            string getinfo = Convert.ToString(count);
            Temp = pHead.First;
            while (Temp != null)
            {
                getinfo += "\n" +Temp.typeTax.getTypeTax();
                getinfo += "\n" + Temp.typeTax.getAmount();
                Temp = Temp.Next;
            }
            return getinfo;
        }
    }


    class dinList //класс для записи элементов в список
    {
        public tax typeTax; //данные о налогоплательщике
        private dinList next,first,last; //ссылка на следующий элемент в списке
        public dinList(tax _typeTax)//конструктор
        {
            typeTax = _typeTax;
            next = null;
            first = null;
            last = null;
        } 
        public dinList Next { get => next; set => next = value; }
        public dinList First { get => first; set => first = value; }
        public dinList Last { get => last; set => last = value; }

    }

}
