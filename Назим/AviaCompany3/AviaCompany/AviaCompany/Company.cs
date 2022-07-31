using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AviaCompany
{
    internal class Company
    {
        private string name;
        private int first,last,startsize,count,fullness,sum;
        private Passenger[] Pas;
        public Company(string _name, int _startsize)
        {
            this.name = _name;
            this.startsize = _startsize;
            Pas = new Passenger[startsize];
            first = 0; last = 0; count = 0;
        }
        public void AddPas(string _surname)
        {
            Passenger newPas = new Passenger(_surname);
            Pas[last] = newPas;
            last++; count++;
            if((count % startsize) >= (0.7 * startsize)) { recizeArray(); }
        }
        public void DelPas() 
        {
            if(count > 0)
            {
                Pas[first] = null;
                count--;
                for(int i = (first+1); i < last; i++)
                {
                    Pas[i - 1] = Pas[i];
                }
                Pas[last-1] = null;
                last--;
                if ((count % startsize) <= (0.3 * startsize)) { recizeArray(); }
            }
        }
        public Passenger Search(string _surname) 
        {
            for (int i = 0; i < count; i++)
            {
                if (Pas[i].Surname.Equals(_surname))
                {
                    return Pas[i];
                }
            }
            return null;
        }
        public int Count { get { return count; } }
        public int Sum()
        {
            sum = 0;
            for(int i = 0; i< count; i++)
            {
                if(Pas[i] != null)
                { 
                sum += Pas[i].Sum();
                }
            }
            return sum;
        }
        public string GetInfoCompany()
        {
            string info = Convert.ToString(Count);
            for(int i = 0; i < count; i++)
            {
                if (Pas[i] != null)
                {
                    info += "\n" + Pas[i].Surname;
                }
            }
            info += "\n";
            for (int i = 0; i < count; i++)
            {
                info += Pas[i].getForCom();
            }
            return info;
        }
        public string GetInfoCom()
        {
            string info = "\n\n  ^NAME^ ";
            info += name;
            for(int i = 0; i < count; i++)
            {
                if (Pas[i] != null)
                {
                    info += "\n" + Pas[i].GetInfo();
                }
            }
            info += "Summ all: " + Sum();
            return info;
        }
        public void recizeArray()
        {
            if ((count % startsize) >= (0.7 * startsize))
            {
                Passenger[] pTemp = new Passenger[startsize * 2];
                for (int i = 0; i < count; i++)
                {
                    pTemp[i] = Pas[i];
                }
                startsize *= 2;
                Pas = new Passenger[startsize];
                for (int i = 0; i < startsize; i++)
                {
                    Pas[i] = pTemp[i];
                }
            }
            else if ((count % startsize) <= (0.3 * startsize))
            {
                Passenger[] pTemp = new Passenger[startsize / 2];
                for (int i = 0; i < count; i++)
                {
                    pTemp[i] = Pas[i];
                }
                startsize /= 2;
                Pas = new Passenger[startsize];
                for (int i = 0; i < startsize; i++)
                {
                    Pas[i] = pTemp[i];
                }
            }
        }


    }
}
