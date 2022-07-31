using System;
using System.Collections.Generic;
using System.Text;

namespace step3
{
    class registry
    {
        private string nameRegistr; //название регистра
        private taxpayer[] taxs;    //массив объектов-налогоплательщиков
        private int sizeArr,count;        //стартовый размер массива
        private int first, last,summa;
        public registry(string _nameRegistr,int _sizeArr) //конструктор
        {
            nameRegistr = _nameRegistr;
            sizeArr = _sizeArr;
            taxs = new taxpayer[sizeArr];
            first = 0; last = 0; count = 0;
        }      
        public int Count { get { return count; } }
        public void addtaxpayer(string _surname, long _INN) //добавление налогоплательщика
        {
            if (count > 0.75 * sizeArr) { growthArr(); }
            taxpayer newTaxPay = new taxpayer(_surname, _INN);
            taxs[last] = newTaxPay;
            last++; count++;
        } 
        public taxpayer searchtaxpayer(string _surname) //поиск налогоплательщика
        {
            for(int i = 0; i < count; i++)
            {
                if(taxs[i] != null && taxs[i].Surname.Equals(_surname))
                {
                    return taxs[i];
                }
            }
            return null;
        }
        public void deltaxpayer() //удаление налогоплательщика
        {
            if (count > 0)
            {
                taxs[first] = null;
                count--;
                for (int i = (first + 1); i < last; i++)
                {
                    taxs[i - 1] = taxs[i];
                }
                taxs[last-1] = null;
                last--;
                if (count < (0.25 * sizeArr)) { growthArr(); }
            }
            
        } 
        public string Info() //информация по всему регистру
        {
            string info = "\nName registry - " + nameRegistr;
            for (int i = 0; i < count; i++)
            {
                info +="\n" + taxs[i].getInfo();
            }
            info += "\nSumm all taxpayer's: " + getSum() + "\n\n";
            return info;
        }
        public string InfoForSave()
        {
            string info = Convert.ToString(Count)+ "\n";
            for (int i = 0; i < count; i++)
            {
                info +="\n" + taxs[i].Surname;
                info += "\n" + taxs[i].IINN;
            }
            for (int i = 0; i <count; i++)
            {
                info += "\n" + taxs[i].getInfoFor();
            }
            return info;
        }
        public int getSum() //сумма всех задолжностей
        {
            summa = 0;
            for(int i = 0; i < count; i++)
            {
                summa += taxs[i].sumTax();
            }
            return summa;
        }
        private void growthArr() //увеличить размер массива
        {
            if (count > 0.8 * sizeArr)
            {
                taxpayer[] vspom = new taxpayer[sizeArr * 2];
                for (int i = 0; i < count; i++)
                {
                    vspom[i] = taxs[i];
                }
                sizeArr *= 2;
                taxs = new taxpayer[sizeArr];
                for (int i = 0; i < count; i++)
                {
                    taxs[i] = vspom[i];
                }
            }
            else
            {
                taxpayer[] vspom = new taxpayer[sizeArr / 2];
                for (int i = 0; i < count; i++)
                {
                    vspom[i] = taxs[i];
                }
                sizeArr /= 2;
                taxs = new taxpayer[sizeArr];
                for (int i = 0; i < count; i++)
                {
                    taxs[i] = vspom[i];
                }
            }
        } 
    }
}
