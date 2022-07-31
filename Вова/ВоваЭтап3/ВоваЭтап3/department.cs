// department 
using System;
using System.Collections.Generic;
using System.Text;

namespace Этап3

{
    class department
    {
        private string nameDep;//название департамента
        private int count;//Создание необходимых переменных 
        private List pFirst,pHelp, pHelpInFirst;//ссылка на первого сотрудника
        public department(string _nameDep)
        {
            this.nameDep = _nameDep;
            count = 0;
            pFirst = null;
            pHelp = null;
            pHelpInFirst = null;
        }
        public string getNameDep() { return nameDep; }
        public int getCount()
        {
            return count;
        }
        public void AddEmployee(string _Fam, string _work, int _exp, int _salary)
        {
            Employee newEmp = new Employee( _Fam, _work, _exp, _salary);
            List pTemp = new List(newEmp);
            count++;
            if (pFirst == null)
            {
                pFirst = pTemp;
                pFirst.Next = null;
                pFirst.Pred = null;
                pHelpInFirst = pFirst;
            }
            else
            {
                pHelp = pTemp;
                pHelp.Pred = pHelpInFirst;
                pHelpInFirst.Next = pHelp;
                pHelpInFirst = pHelpInFirst.Next;
            }
        }
        public void DeleteAll()
        {
            if (count != 0)
            {
                pFirst = null;
            }
        }
        public void DeleteEmployee(string _Fam)
        {
            pHelp = pFirst;
            while (pHelp != null)
            {
                List pTemp;
                if (pHelp == pFirst && pHelp.info.Fam.Equals(_Fam))
                {
                    if (pHelp.Next == null)
                    {
                        pFirst = null;
                    }
                    else
                    {
                        pTemp = pFirst.Next;
                        pHelp.Next.Pred = null;
                        pHelp.Next = null;
                        pFirst = pTemp;
                    }
                }
                else if(pHelp.info.Fam.Equals(_Fam))
                {
                    pHelp.Pred.Next = pHelp.Next;
                    pHelp.Next.Pred = pHelp.Pred;
                }
                pHelp = pHelp.Next;
            }
        }
        public string GetSumma()
        {
            string inform = "\nСумма запрплат у всех сотрудников в отделе " + nameDep + " равна: ";
            int summa = 0;
            pHelp = pFirst;
            while(pHelp != null)
            {
                summa += pHelp.info.Salary;
                pHelp = pHelp.Next;
            }
            inform += summa + "\n\n";
            return inform;
        }
        public int sum()
        {
            int summa = 0;
            pHelp = pFirst;
            while (pHelp != null)
            {
                summa += pHelp.info.Salary;
                pHelp = pHelp.Next;
            }
            return summa;
        }
        public string getInfo() 
        {
            string info = "------: " + nameDep + "------";
            pHelp = pFirst;
            while(pHelp != null)
            {
                info += "\n\nСотрудник: " + pHelp.info.Fam;
                info += "\nРазмер ЗП - " + pHelp.info.Salary;
                info += "\nСтаж - " + pHelp.info.Exp + " лет";
                info += "\nДолжность - " + pHelp.info.Work;
                pHelp = pHelp.Next;
            }
            info += GetSumma();
            return info; 
        }
        public Employee FindEmployee(string inameemployee)
        { pHelp = pFirst;
            while(pHelp!= null)
            {
                if (pHelp.info.Fam.Equals(inameemployee))
                {
                    return pHelp.info;
                }
                else pHelp = pHelp.Next;
            }
            return null;
        }
        public string getLoadInfo()
        {
            string infoLoad = "";
            int countLoad = count;
            pHelp = pFirst;
            infoLoad += "\n" + countLoad;
           
        
            while (pHelp != null)
            {
                infoLoad += "\n" + pHelp.info.Fam + "\n";
                infoLoad += pHelp.info.Salary + "\n";
                infoLoad += pHelp.info.Exp + "\n";
                infoLoad += pHelp.info.Work;
                pHelp = pHelp.Next;
            }    
            return  infoLoad; 
         
        }

    }
}
