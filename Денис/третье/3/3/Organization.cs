// Organization
using System;
using System.Collections.Generic;
using System.Text;

namespace _3
{
    class Organization
    {
        private string nameOrganization;//название организации
        private StructList pHead;
        private int count;
        public Organization(string _nameOrganization)
        {
            this.nameOrganization = _nameOrganization;
            pHead = new StructList(null);
            pHead.First = null;
            pHead.Last = null;
        }
        public string NameOrganization { get; }
        public int Count { get { return count; } }
        public StructList PHead { get { return pHead; } }
        public void addComp(string _nameCompany, int _arrSize)
        {
            ListCompany newComp = new ListCompany(_nameCompany, _arrSize);
            StructList vspom = new StructList(newComp);
            count++;
            if (pHead.First == null && pHead.Last == null)
            {
                pHead.First = vspom;
                pHead.Last = vspom;
                pHead.First.Next = pHead.Last;
                pHead.Last.Next = pHead.First;
            }
            else
            {
                //pHead.Last.Next = vspom;
                pHead.Last = pHead.Last.Next = vspom;
                pHead.Last.Next = pHead.First;
            }
        }
        public ListCompany FindComp(string _nameCompany)
        {
            StructList search = pHead.First;
            while (search != null)
            {
                if (search.Name != null)
                {
                    if (search.Name.NameCompany.Equals(_nameCompany))
                    { return search.Name; }
                    else search = search.Next;
                }
            }            
            return null;
        }
        public void delAllComp()
        {
            pHead.First = null;
            pHead.Last= null;
        }
        public bool delComp(String _nameComp)
        {
            if (pHead != null)
            {
                StructList vspom = pHead.First;
                //StructList pTemp = pHead.First;
                for(int i = 0; i<count; i++)
                {
                    if (vspom != null)
                    {
                        if (vspom == pHead.First)
                        {
                            if (vspom.Name.NameCompany.Equals(_nameComp))
                            {
                                count--;
                                pHead.First = pHead.First.Next;
                                return true;
                            }
                            else { vspom = vspom.Next; }
                        }
                        else
                        {
                            if (vspom.Next.Name.NameCompany.Equals(_nameComp))
                            {
                                count--;
                                vspom.Next = vspom.Next.Next;
                                return true;
                            }
                            else { vspom = vspom.Next; }
                        }
                    }
                }
            }
            return false;
        }
        public string getQueueName()
        {
            string info = Convert.ToString(Count);
            StructList pTemp = pHead.First;
            for(int i = 0; i<count; i++)
            {
                info += "\n" + pTemp.Name.NameCompany;
                pTemp = pTemp.Next;
            }
            return info;
        }
        public string getQueueAll()
        {
            string info = "";
            StructList pTemp = pHead.First;
            for(int i = 0; i<count; i++)
            {
                info += "\n" + pTemp.Name.chekFor();
                pTemp = pTemp.Next;
            }
            return info;
        }
        public string getQueue()
        {
            string date = "-=-=-=-=-=-Employment service-=-=-=-=-=-";
            StructList pTemp = pHead.First;
            do
            {
                date += pTemp.Name.chek() + "\n";
                pTemp = pTemp.Next;
            } while (pTemp != pHead.First);
            date += "\nTotal number of vacancies: " + getSumQueue();
            return date;
        }
        public int getSumQueue()
        {
            StructList pTemp = pHead.First;
            int summa = 0;
            do
            {
                summa += pTemp.Name.SumVacantion();
                pTemp = pTemp.Next;
            } while (pTemp != pHead.First);
            return summa;
        }
    }
}

