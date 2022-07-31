using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Urist3этап
{
    internal class Firm
    {
        private string nameFirm;//название фирмы
        private Urist[] ochered;//массив обьектов класса юрист
        private int size, first, last, count, sum;//необходимые переменные для
        //подсчета суммы, размера массива и координации в очереди
        public Firm(string _nameFirm, int _size)//констуктор
        {
            this.nameFirm = _nameFirm;
            this.size = _size;this.last = 0;
            this.first = 0; this.count = 0; 
            ochered = new Urist[size];
        }
        public int Count { get { return count; } }
        public void AddUrist(string _surnameUrist)//метод добавления
        {
            if(count <= size)
            { 
                Urist dobav = new Urist(_surnameUrist);
                ochered[last] = dobav;
                last++; count++;
            }
        }
        public void DellUrist()//метод удаления
        {
            if (count > 0)
            {
                ochered[first] = null;
                count--;
                for (int i = (first + 1); i < last; i++)
                {
                    ochered[i - 1] = ochered[i];
                }
                last--;
                ochered[last] = null;
            }
        }
        public Urist SearchUrist(string _surnameUrist)//поиск для дальнейшего добавления и удаления клиентов
        {
            for (int i = 0; i < count; i++)
            {
                if (ochered[i] != null && ochered[i].SurnameUrist.Equals(_surnameUrist))
                {
                    return ochered[i];
                }
            }
            return null;
        }
        public int GetSumm()//сумма полученных денег
        {
            sum = 0;
            for (int i = 0; i < count; i++)
            {
                sum += ochered[i].Sum();
            }
            return sum;
        }
        public string GetInfoOChe()//вся информация о фирме
        {
            string alldata ="";
            for(int i=0; i < count; i++)
            {
                alldata +="\n"+ ochered[i].GetInfo();
            }
            alldata += GetSumm(); 
            return alldata;
        }
        public string GetInfoForSave()//вся информация о фирме
        {
            string alldata = Convert.ToString(count);
            for (int i = 0; i < count; i++)
            {
                alldata += $"\n{ochered[i].SurnameUrist}";
            }
            alldata += "\n";
            for(int i = 0; i < count; i++)
            {
                alldata += $"\n{ochered[i].getInfoFor()}";
            }
            return alldata;
        }
    }
}
