// ListCompany
using System;
using System.Collections.Generic;
using System.Text;

namespace _3
{
    class ListCompany
    {

        private string nameCompany;
        private ListVacantion[] Queue;
        private int size;
        private int first;
        private int last;
        private int count;


        public ListCompany(string _nameCompany, int _arrSize)
        {
            this.size = _arrSize;
            this.nameCompany = _nameCompany;
            Queue = new ListVacantion[size];
            first = 0;
            last = 0;
            count = 0;
        }
        public int Count { get { return count; } }
        public ListVacantion[] QUeue { get { return Queue; } }
        public string NameCompany{ get { return nameCompany; } set { this.nameCompany = value; } }
        public void AddVacantion(string _work, int _salary)
        {
            ListVacantion newList = new ListVacantion(_work, _salary);
            if (count >= (0.75 * size)) { recizeArray(); }
            Queue[last] = newList;
            last++;
            count++;
        }
        public ListVacantion FindVacantion(string _work)
        {
            for (int i = 0; i < count; i++)
            {
                if (Queue[i] != null)
                {
                    if (Queue[i].Work.Equals(_work))
                    {
                        return Queue[i];
                    }
                }
            }
            return null;
        }
        public void DeleteVacantion()
        {
            if (count != 0)
            {
                Queue[first] = null;
                count--;
                for (int i = (first + 1); i < last; i++)
                {
                    Queue[i - 1] = Queue[i];
                }
                last--;
                Queue[last] = null;
                if (count > 3 && count <= (0.25 * size)) { recizeArray(); }
            }
        }
        public int SumVacantion()
        {
            return count;
        }
        public string chekFor()
        {
            string date = Convert.ToString(count);
            for (int i = 0; i < count; i++)
            {
                date += "\n" + Queue[i].Work;
                date += "\n" + Queue[i].Salary;
            }
            return date;
        }
        public string chek() 
        {
            string date = "\n\n#####     Organization " + nameCompany + "\n";
            for ( int i = 0; i < count; i++)
            {
                date += "\n\nvacantion: " + Queue[i].Work;
                date += "\nSalary: " + Queue[i].Salary;
            }
            date +="\n\ncount vocation - " + SumVacantion();
            date +="\n#####################################";
            return date; 
        }
        public void recizeArray()
        {
            if (count >= (0.75 * size))
            {
                ListVacantion[] pTemp = new ListVacantion[size * 2];
                for (int i = 0; i < count; i++)
                {
                    pTemp[i] = Queue[i];
                }
                size *= 2;
                Queue = new ListVacantion[size];
                for (int i = 0; i < size; i++)
                {
                    Queue[i] = pTemp[i];
                }
            }
            else if (count <= (0.25 * size))
            {
                ListVacantion[] pTemp = new ListVacantion[size / 2];
                for (int i = 0; i < count; i++)
                {
                    pTemp[i] = Queue[i];
                }
                size /= 2;
                Queue = new ListVacantion[size];
                for (int i = 0; i < size; i++)
                {
                    Queue[i] = pTemp[i];
                }
            }
        }
    }
}
