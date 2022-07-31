using System;
using System.Collections.Generic;
using System.Text;

namespace Third
{
    class EmploymentService
    {
        private Organizations[] stack;//массив типа Patient
        private int SP;//вспомогательная переменная для добавления/удаления
        private int startSize;//
        public EmploymentService(int _startSize)//конструктор
        {
            SP = 0;
            startSize = _startSize;
            stack = new Organizations[startSize];
        }
        public int getSP { get { return SP; } }
        public void addComp(string _nameOrganization)//добавление организаций
        {
            if(SP <= startSize)
            {
                Organizations newsdob = new Organizations(_nameOrganization);
                stack[SP] = newsdob;
                SP++;
            }
        }
        public Organizations FindComp(string _nameOrganization)//поиск организаций
        {
            for(int i = 0; i < SP; i++)
            { 
                if (stack[i].NameOrganization.Equals(_nameOrganization)) { return stack[i]; }
            }
            return null;
        }
        public string getName()
        {
            string info = Convert.ToString(SP);
            for(int i = 0; i<= SP; i++)
            {
                if (stack[i] != null)
                {
                    info += "\n" + stack[i].NameOrganization;
                }
            }
            return info;
        }
        public string getQueueFor()
        {
            string info = "";
            for(int i = 0; i < SP; i++)
            {
                info += "\n" + stack[i].getList();
            }
            return info;
        }
        public void delComp()//удаление организаций
        {
            if ( SP > 0)
            {
                stack[SP - 1] = null;
                SP--;
            }
        }
        public string getQueue()//вывод информации по всей службе трудоустройства
        {
            string information = "";
            for (int i = 0; i < SP; i++)
            {
                information += stack[i].chek();
            }
            information += "summ Vacantion = " + getSumQueue();
            return information;
        }
        public int getSumQueue()//количество вакансий по всей службе
        {
            int sum = 0;
            for (int i = 0; i < SP; i++)
            {
                sum += stack[i].SumVacantion();
            }
            return sum;
        }
    }
}
