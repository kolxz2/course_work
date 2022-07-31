// Clinic
using System;
using System.Collections.Generic;
using System.Text;

namespace Tretie
{
    class Clinic
    {
        private string nameComp;//название клиники
        private int size;//длина массива
        private Patient[] pati;//массив типа Patient
        private int first, count;//первый элемент в очереди
        private int last, summa;//последний элемент в очереди
        public Clinic(string _nameComp, int _size)
        {
            nameComp = _nameComp;
            size = _size;
            pati = new Patient[size];
            first = 0; last = 0; count = 0;
        }
        public int Count { get { return count; } }
        public void addPatient(string _name) //добавление пациента
        {
            Patient help = new Patient(_name);
            pati[last] = help;
            last++; count++;
            if (count > (0.8 * size)) { IzmArr(); }
        }
        public Patient search(string _name) //поиск пациента
        {
            for(int i = 0; i < count; i++)
            {
                if (pati[i] != null)
                {
                    if (pati[i].Name.Equals(_name))
                    {
                        return pati[i];
                    }
                }
            }
            return null;
        }
        public void delPatient() //удаление пациента
        {
            if (count > 0)
            {
                pati[first] = null;
                count--;
                for (int i = (first + 1); i < last; i++)
                {
                    pati[i - 1] = pati[i];
                }
                pati[last] = null;
                last--;
            }
            if (count < (0.3 * size)) { IzmArr(); }
        }
        public int summPatient() { return count; }//количество пациентов
        public int sumCost() //сумма потраченных денег на услуги
        {
            summa = 0;
            for (int i = 0; i< count; i++)
            {
                summa += pati[i].Summa();
            }
            return summa; 
        }
        public string InfoSave()
        {
            string infoSave = Convert.ToString(count);
            for(int i = 0; i < count; i++)
            {
                infoSave += "\n" + pati[i].Name;
            }
            infoSave += "\n";
            for(int i = 0; i < count; i++)
            {
                infoSave +="\n" + pati[i].infoForSave();
            }
            return infoSave;
        }
        public string Info() //получение информации о всех клиентах
        {
            string info = "Name company - " + nameComp;
            for (int i = 0; i < count; i++)
            {
                info += pati[i].Print();
            }
            info += "\nSumm all patients: " + sumCost();
            info += "\nCount client: " + summPatient();
            return info;
        }
        private void IzmArr() //увеличить или уменьшить размер массива
        {
            if (count > 0.8 * size) 
            {
                Patient[] vspom = new Patient[size * 2];
                for(int i = 0; i< count; i++)
                {
                    vspom[i] = pati[i];
                }
                size *= 2;
                pati = new Patient[size];
                for (int i = 0; i < count; i++)
                {
                    pati[i] = vspom[i];
                }
            }
            else
            {
                Patient[] vspom = new Patient[size / 2];
                for (int i = 0; i < count; i++)
                {
                    vspom[i] = pati[i];
                }
                size /= 2;
                pati = new Patient[size];
                for (int i = 0; i < size; i++)
                {
                    pati[i] = vspom[i];
                }
            }
        } 
    }
}
