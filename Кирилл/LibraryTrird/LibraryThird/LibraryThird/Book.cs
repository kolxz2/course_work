using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryThird
{
    internal class Book
    {
        private string title;
        private string author;
        private List pFirst;
        private List pLast, pTemp;
        private int i = 0;
        private int count = 0, summDay = 0;

        public Book(string _title, string _author)
        {
            this.title = _title;
            this.author = _author;
            pFirst = null;
            pLast = null;
            pTemp = null;
        }
        public List PFirst { get { return pFirst; } }
        public string Title { get { return title; }set { title = value; } }
        public string Author { get { return author; }set { author = value; } }
        public int Count { get { return count; } }

        public int addReader(string _surname, int _days)
        {
            Reader newReader = new Reader(_surname, _days);
            List helper = new List(newReader);
            count++;
            if (pFirst == null)//1-е
            {
                pFirst = helper;
                pLast = pFirst;
                pLast.setNext(pFirst);
            }
            else if (_surname[0] < pFirst._surname.Surname[0])
            {
                pTemp = pFirst;
                pFirst = helper;
                pFirst.setNext(pTemp);
                pLast.setNext(pFirst);//ссылка у последнего элемента на следующий обновляется
            }
            else if (_surname[0] >= pLast._surname.Surname[0])
            {
                pTemp = pLast;
                pLast = helper;
                pLast.setNext(pFirst);//у ставшего последним элементом ссылка на следующий становится на first
                pTemp.setNext(pLast);
            }
            else
            {
                pTemp = pFirst;
                while (pTemp._surname.Surname[0] >= _surname[0])
                {
                    pTemp = pTemp.getNext();
                }
                helper.setNext(pTemp.getNext());
                pTemp.setNext(helper);
            }
            return count-1;
        }
        public Reader FindReader(string _surname)
        {
            List vspom = pFirst;
            while (vspom != null)
            {
                if (vspom._surname.Surname.Equals(_surname))
                {
                    return vspom._surname;
                }
                vspom = vspom.getNext();
            }
            return null;
        }
        public int FindReaderIndex(string _surname)
        {
            List vspom = pFirst;
            int chet = 0;
            while (vspom != null)
            {
                chet++;
                if (vspom._surname.Surname.Equals(_surname))
                {
                    return chet;
                }
                else
                {
                    vspom = vspom.getNext();
                }
            }
            return 0;
        }
        public bool delReader(string _surname)
        {
            pTemp = pFirst;
            if (pFirst._surname.Surname.Equals(_surname))
            {
                pFirst = pFirst.getNext();
                pLast.setNext(pFirst);
                count--;
            }
            else
            {
                for (int j = 1; j < count; j++)
                {
                    if (pTemp.getNext()._surname.Surname.Equals(_surname))
                    {
                        pTemp.setNext(pTemp.getNext().getNext());
                        count--;
                    }
                    else { pTemp = pTemp.getNext(); }
                }
            }

            return false;
        }
        public string getInfo()
        {
            string info = "'" + title + "'," + author + ":" + "\n";
            List pTemp = pFirst;
            for (int j = 0; j < count; j++)
            {
                info += "Книга у читателя с фамилией " + pTemp._surname.Surname + "\n была дней: " + pTemp._surname.Days + "\n\n";
                pTemp = pTemp.getNext();
            }
            info += "Общее количество пользования книгой - " + sumUse() + " дня(ей)";
            return info;
        }
        public string getInfoList()
        {
            string data = Convert.ToString(Count);
            List pTemp = pFirst;
            for (int j = 0; j < Count; j++)
            {
                if (pTemp != null)
                {
                    data += "\n" + pTemp._surname.Surname;
                    data += "\n" + pTemp._surname.Days;
                    pTemp = pTemp.getNext();
                }
            }
            return data;
        }

        public int sumUse()
        {
            summDay = 0;
            pTemp = pFirst;
            for (int j = 0; j < count; j++)
            {
                summDay += pTemp._surname.Days;
                pTemp = pTemp.getNext();
            }
            return summDay;
        }
    }

    /*
     Класс List, для реализации адресного списка.
     переменные : _surname(данные о читателе), next - ссылка на следующий элемент списка.
     конструктор List принимает объект-читателя.
     методы: get/set Next - получение/изменение ссылки на следующего пользователя.
     */
    class List
    {
        public Reader _surname;
        private List next;
        public List(Reader _date)
        {
            _surname = _date;
            next = null;
        }
        public List getNext() { return next; }
        public void setNext(List tempReader)
        {
            next = tempReader;
        }
    }
}