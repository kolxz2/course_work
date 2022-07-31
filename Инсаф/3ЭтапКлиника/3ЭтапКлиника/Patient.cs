using System;
using System.Collections.Generic;
using System.Text;

namespace _3ЭтапКлиника
{
    class Patient
    {
        private string name;//фамилия пациента
        private int visitCount;//количество посещений
        private int sum;//сумма потраченных денег
        private List pHead,pTemp;//ссылка на первый элемент

        public Patient(string _name)//создание конструктора
        {
            name = _name;//присваиваем имя пациенту
            pHead = new List(null);//создаем заголовок в списке с пустыми полезными данными
            pHead.First = null;//ссылка на первый элемент равну нулл
            pHead.Last = null;//ссылка на последний элемент равна нулл
            pTemp = null;//вспомогательная переменная так-же равна нулл
            visitCount = 0;//количество посещений клиники данным пациентом равна 0
        }
        public string getName() { return name; }//метод получения имени пациента
        public string setName { set { this.name = value; } get { return name; } }
        public List GetpHead()
        {
            return pHead.First;
        }
        public int VisitCount { get { return visitCount; } }
        public void addVisit(string _service, int _date, int _cost) //добавление посещения
        {
            Visiting newVisit = new Visiting(_date, _service, _cost);//создаем объект-посещение 
            List adds = new List(newVisit);//создаем ссылку в списке на посещение 
            visitCount++;//увеличиваем количество посещений
            if (pHead.First == null && pHead.Last == null)//1-е добавление в пустой список
            {
                pHead.First = adds;
                pHead.Last = adds;
            }
            else if (_service[0] < pHead.First.info.getService()[0])//упорядочиваем элемент, если он должен встать перед первым элементом
            {
                pTemp = pHead.First;
                pHead.First = adds;
                pHead.First.Next = pTemp;
            }
            else if (_service[0] >= pHead.Last.info.getService()[0])//упорядочиваем элемент, если он должен встать после последнего элемента
            {
                pTemp = pHead.Last;
                pHead.Last = adds;
                pTemp.Next = pHead.Last;
            }
            else//упорядочиваем элемент, если он должен встать куда то в середину списка
            {
                pTemp = pHead.First;
                for (int i = 0; i < visitCount; i++)
                {
                    if ((_service[0] > pTemp.info.getService()[0]) && (_service[0]< pTemp.Next.info.getService()[0]))
                    {
                        adds.Next = pTemp.Next;
                        pTemp.Next = adds;
                        break;
                    }
                    else
                    {
                        pTemp = pTemp.Next;
                    }

                }
                /*while ((pTemp.info.getService()[0] > _service[0]) && (pTemp.Next.info.getService()[0] <= _service[0]))
                {
                    pTemp = pTemp.Next;
                }*/
                
            }
        }
        public int SearchInt(string _service)
        {
            List vspom = pHead.First;
            for(int i = 0; i < visitCount;i++)
            {
                if(vspom.info.getService().Equals(_service))
                {
                    return i;
                }
                else { vspom = vspom.Next; }
            }
            return -1;
        }
        public void delVisit(int _date, string _service) //удаление посещения
        {
            pTemp = pHead.First;//вспомогательная переменная с ссылкой на первый элемент в списке
            while (pTemp.Next != null)
            {
                if (pTemp == pHead.First)//удаление первого элемента списка
                {
                    if (pTemp.info.getDate() == _date && pTemp.info.getService().Equals(_service))
                    {
                        pHead.First = pHead.First.Next;
                        visitCount--;
                    }
                    else pTemp = pTemp.Next;
                }
                else//удаление всех остальных элементов
                {
                    if (pTemp.Next.info.getDate() == _date && pTemp.Next.info.getService().Equals(_service))
                    {
                        pTemp.Next = pTemp.Next.Next;
                        visitCount--;
                    }
                    else pTemp = pTemp.Next;
                }
            }
        }
        public int summa() //сумма потраченных денег
        {
            sum = 0;
            pTemp = pHead.First;
            while (pTemp != null)
            {
                sum += pTemp.info.getCost();
                pTemp = pTemp.Next;
            }
            return sum;
        }
        public string print() //вывод информации о пациенте
        {
            string prints = "\n\nName patient - " + name;
            pTemp = pHead.First;
            while (pTemp != null)
            {
                prints += "\nService - " + pTemp.info.getService();
                prints += "\nDate visiting - " + pTemp.info.getDate();
                prints += " Cost service - " + pTemp.info.getCost();
                pTemp = pTemp.Next;
            }
            prints += "\nAmount of funds spent - " + summa();
            prints += "\nNumber of visits - " + visitCount;
            return prints; 
        }
        public string printLoad() //вывод информации о пациенте
        {
            string prints ="";
            pTemp = pHead.First;
            prints += visitCount;
            while (pTemp != null)
            {
                          
                prints += "\n" + pTemp.info.getService();
                prints += "\n"+pTemp.info.getDate();
                prints += "\n" + pTemp.info.getCost();
                pTemp = pTemp.Next;
            }
            return prints;
        }

    }
}
