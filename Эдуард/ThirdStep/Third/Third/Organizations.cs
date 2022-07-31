using System;
using System.Collections.Generic;
using System.Text;

namespace Third
{
    class Organizations
    {
        
        private string nameOrganization;//название организации
        private int count;//количество вакансий
        private SList Header,pTemp;//первый элемент
        

        public Organizations(string _nameOrganization)//конструктор
        {
            nameOrganization = _nameOrganization;
            Header = new SList(null);
            Header.FIRST = null;
            Header.LAST = null;
            pTemp = null;
        }
        public string NameOrganization 
        { 
            get { return nameOrganization; }
            set { this.nameOrganization = value; } 
        }
        public SList SHeader { get { return Header.FIRST; } }
        public int Count { get { return count; } }
        public Vacantion search(string _name)
        {
            SList vspom = Header.FIRST;
            while(vspom!= null)
            {
                if(vspom.data.GetName().Equals(_name))
                {
                    return vspom.data;
                }
                else { vspom = vspom.NEXT; }
            }
            return null;
        }

        public string getList()
        {
            string data = Convert.ToString(count);
            SList pTemp = Header.FIRST;
            for (int j = 0; j < count; j++)
            {
                if (pTemp != null)
                {
                    data += "\n" + pTemp.data.GetName();
                    data += "\n" + pTemp.data.GetWork();
                    data += "\n" + pTemp.data.GetSalary();
                    pTemp = pTemp.NEXT;
                }
            }
            return data;
        }

        public void AddVacantion(string _work, int _salary, string _name)//Метод добавдения вакансии
        {
            Vacantion news = new Vacantion(_work, _salary, _name);
            SList dob = new SList(news);
            count++;
            if(Header.FIRST == null && Header.LAST == null)
            {
                Header.FIRST = dob;
                Header.LAST = dob;
            }
            else
            {
                pTemp = Header.LAST;
                Header.LAST = dob;
                pTemp.NEXT = Header.LAST;
            }
            
        }
        public bool DeleteVacantion(string _work)//метод удаления
        {
            if (Header != null)
            {
                pTemp = Header.FIRST;
                while (pTemp != null)
                {
                    if (pTemp == Header.FIRST)
                    {
                        if (pTemp.data.GetName().Equals(_work))
                        {
                            count--;
                            Header.FIRST = Header.FIRST.NEXT;
                            return true;
                        }
                        else pTemp = pTemp.NEXT;
                    }
                    else
                    {
                        SList vspom = Header.FIRST;
                            if (pTemp.data.GetName().Equals(_work))
                            {
                                count--;
                                vspom.NEXT = pTemp.NEXT;
                            return true;
                            }
                            else { pTemp = pTemp.NEXT; vspom = vspom.NEXT; }
                        
                    }
                }
            }
            return false;
        }
        public int SumVacantion()//суммарное кол-во вакансий
        { 
            return count;
        }
        public string chek() //вывод данных
        {
            string info = "\n------" + nameOrganization + " present";
            pTemp = Header.FIRST;
            while (pTemp != null)
            {
                info += "\nVacantion - " + pTemp.data.GetName() + ". Required lenght of service - " + pTemp.data.GetWork();
                info += "\nSalary - " + pTemp.data.GetSalary();
                pTemp = pTemp.NEXT;
            }
            info += "\nSumm count vacantion - " + SumVacantion() + "\n\n";
            return info; 
        }
    }
}
