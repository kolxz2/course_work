using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3rdstep
{
    internal class ThemeSection
    {
        private NewsSet[] queue; //очередь для хранения новостей
        private int count; //количество новостей
        private int first, last; //ссылки на первый и последний элементы
        private int next; // ссылка на следующий раздел        
        private string namechapter;  //переменная имя раздела

        public ThemeSection(string _name)  //конструктор
        {
            first = 0; last = 0; count = 0;
            queue = new NewsSet[10];
            namechapter = _name;
        }
        public string NameChapter
        {
            get { return namechapter; }
            set { namechapter = value; }
        }//get- и set- для строки "название раздела"
        public int Count
        {
            get { return count; }
        }//get- для счетчика количества элементов
        public NewsSet[] Queue
        {
            get
            {
                return queue;
            }
        }//get- для получения всего массива очереди для сохранения и загрузки файла
        public void AddToList(string _title, string _date)  //функция добавления
        {
            NewsSet First = new NewsSet(_title, _date);
            if (count < 10)
            {
                if (last >= 10 && first > 0) last = 0;  //закольцовывание last
                queue[last] = First;
                count++;
                last++;
            }
        }
        public void DeleteFromQueue()  //функция удаления
        {
            if (count != 0)
            {
                if (first > 10) first = 0;  //закольцовывание first
                queue[first] = null;
                count--;
                first++;
            }
        }
        public NewsSet Search(string _title)  //функция поиска в списке 
        {
            for (int i = 0; i < count; i++)
            {
                if (queue[i].Title.Equals(_title))
                {
                    return queue[i];
                }
            }
            return null;
        }
        public int GetSumm()  //функция подсчета суммы всех новостей
        {

            return count;
        }
        public string GetData()  //инфо
        {
            string info = Convert.ToString(count);
            for (int i = 0; i < count; i++)
            {
                if (queue[i] != null)
                {
                    info += "\n" + queue[i].Title;
                    info += "\n" + queue[i].Date;
                }               
            }
            return info;
        }
    }
}
