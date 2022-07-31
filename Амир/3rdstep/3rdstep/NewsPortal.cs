using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3rdstep
{
    internal class NewsPortal
    {
        private string namePortal;//имя новостного портала
        private List pfirst, plast, ptemp;//переменные-ссылки на обьекты в структуре список(ссылка на первый, последний элементы)
        private int count;//счетчик количества элементов в списке
        public NewsPortal(string _namePortal)  //конструктор
        {
            this.namePortal = _namePortal;
            pfirst = null;
            plast = null;
            ptemp = null;
            count = 0;
        }
        public int Count
        {
            get { return count; }
        }//метод get, для получения количества элементов
        public string NamePortal 
        {
            get { return namePortal; } 
        }//метод get, для имени новостного портала
        public void addTheme(String _nameTheme)  //функция добавления раздела
        {
            ThemeSection newThemeSection = new ThemeSection(_nameTheme);
            List helper = new List(newThemeSection);
            count++;
            if (pfirst == null)
            {
                pfirst = helper;
                plast = helper;
                plast.Next = pfirst;              
            }
            else if (_nameTheme[0] < pfirst.data.NameChapter[0])
            {
                ptemp = pfirst;
                pfirst = helper;
                pfirst.Next = ptemp;               
            }
            else if (_nameTheme[0] >= plast.data.NameChapter[0])
            {
                ptemp = plast;
                plast = helper;
                ptemp.Next = plast;
                plast.Next = pfirst;
            }
            else
            {
                ptemp = pfirst;
                for (int i = 0; i < Count; i++)
                {
                    if ((_nameTheme[0] > ptemp.data.NameChapter[0]) && (_nameTheme[0] < ptemp.Next.data.NameChapter[0]))
                    {
                        helper.Next = ptemp.Next;
                        ptemp.Next = helper;
                        break;
                    }
                    else
                    {
                        ptemp = ptemp.Next;
                    }

                }
            }
        }
        public ThemeSection FindTheme(String nameTheme)  //функция поиска раздела по его названию
        {
            ptemp = pfirst;
            for (int i = 0; i < count; i++)
            {
                if (ptemp.data.NameChapter.Equals(nameTheme))
                {
                    return ptemp.data;
                }
                else ptemp = ptemp.Next;
            }
            return null;
        }
        public int FindThemeForInt(String nameTheme)  //функция получения индекса от объекта 
        {
            ptemp = pfirst;
            for (int i = 0; i < count; i++)
            {
                if (ptemp.data.NameChapter.Equals(nameTheme))
                {
                    return i;
                }
                else ptemp = ptemp.Next;
            }
            return 0;
        }
        public void delTheme(String nameTheme)  //функция удаления раздела
        {
            ptemp = pfirst;
            if (ptemp.data.NameChapter.Equals(nameTheme))
            {
                pfirst = pfirst.Next;
                plast.Next = pfirst;
                count--;
            }
            else
            {
                for (int i = 0; i < count; i++)
                {
                    if (ptemp.Next.data.NameChapter.Equals(nameTheme))
                    {
                        ptemp.Next = ptemp.Next.Next;
                        count--;
                    }
                    else ptemp = ptemp.Next;
                }
            }
        }
        public void delThemeAll()
        {
            pfirst = null;
            plast = null;
        }//удаление всего списка для функции загрузки файла в программу
        public string getQueue()  //получение информации обо всех разделах, а также информации о новостях
        {
            string info = Convert.ToString(count);
            ptemp = pfirst;
            for (int i = 0; i < count; i++)
            {
                info += "\n" + ptemp.data.NameChapter;
                ptemp = ptemp.Next;
            }
            return info;
        }
        public string getQueueFor()
        {
            string info = "";
            ptemp = pfirst;
            for(int i = 0; i < count; i++) 
            {
                info += "\n" + ptemp.data.GetData();
                ptemp = ptemp.Next;
            }
            return info;
        }//получение информации о всем новостном портале для функции сохранения
        public int getSummQueue()  //функция получения суммы всех новостей
        {
            int summ = 0;
            ptemp = pfirst;
            for (int i = 0; i < count; i++)
            {
                summ += ptemp.data.GetSumm();
                ptemp = ptemp.Next; 
            }
            return summ;
        }
    }
}
