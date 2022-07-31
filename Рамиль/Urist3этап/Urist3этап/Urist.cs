using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Urist3этап
{
    internal class Urist
    {
        private string surnameUrist;//фамилия юриста
        private int sum, count;//сумма полученных денег этим юристом
        private List head, pTemp,pHelp;//заголовок списка и вспомогательная переменная

        public Urist (string _surnameUrist)//конструктор класса
        {
            this.surnameUrist = _surnameUrist;
            head = new List(null);
            head.First = null;
            head.Last = null;
        }
        public int Count { get { return count; } }
        public List Head { get { return head.First; } }
        public string SurnameUrist { get { return surnameUrist; } set { this.surnameUrist = value; } }
        public void AddClient(string _surname, string _service, int _cost)
        {
            Client dobav = new Client(_surname, _service, _cost);
            List dobavs = new List(dobav);
            count++;
            if (head.First == null)
            {
                head.First = dobavs;
                head.First.Pred = null;
                head.First.Second = head.Last;
                head.Last = dobavs;
            }
            else
            {
                pHelp = head.Last;
                head.Last = dobavs;
                pHelp.Second = head.Last;
                head.Last.Pred = pHelp;
            }
        }
        public void DellClient(string _surname)
        {
            pHelp = head.First;
            while (pHelp != null)
            {
                List pTemp;
                if (pHelp == head.First && pHelp.cClient.Surname.Equals(_surname))
                {
                    if (pHelp.Second == null)
                    {
                        head.First = null;
                    }
                    else
                    {
                        pTemp = head.First.Second;
                        pHelp.Second.Pred = null;
                        pHelp.Second = null;
                        head.First = pTemp;
                    }
                }
                else if (pHelp.cClient.Surname.Equals(_surname))
                {
                    if (pHelp.Pred != null && pHelp.Second != null)
                    {
                        pHelp.Pred.Second = pHelp.Second;
                        pHelp.Second.Pred = pHelp.Pred;
                    }
                    else 
                    {
                        head.Last = head.Last.Pred;
                    }
                }
                pHelp = pHelp.Second;
            }
        }
        public Client SearchCl(string _surname)
        {
            List vspom = head.First;
            while(vspom != null)
            {
                if (vspom.cClient.Surname.Equals(_surname))
                {
                    return vspom.cClient;
                }
                else { vspom = vspom.Second; }
            }
            return null;
        }
        public int Sum()
        {
            sum = 0;
            List vspom = head.First;
            while(vspom != null)
            {
                sum += vspom.cClient.Cost;
                vspom = vspom.Second;
            }
            return sum;
        }
        public string GetInfo()
        {
            string info = "";
            List vspom = head.First;
            while (vspom != null)
            {
                info += vspom.cClient.Surname;
                info += vspom.cClient.Cost;
            }
            info += Sum();
            return info;
        }
        public string getInfoFor()
        {
            string info = Convert.ToString(count);
            List vspom = head.First;
            while (vspom != null)
            {
                info += $"\n{vspom.cClient.Surname}";
                info += $"\n{vspom.cClient.Service}";
                info += $"\n{vspom.cClient.Cost}";
                vspom = vspom.Second;
            }
            return info;
        }
    }
}
