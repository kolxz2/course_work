using System;
using System.Collections.Generic;
using System.Text;

namespace _3ЭтапКлиника
{
    class Clinic
    {
        private string nameComp;//название клиники
        private int size;//длина массива
        private Patient[] stack;//массив типа Patient
        private int SP, summ, visits;//вспомогательная переменная для добавления/удаления

        public Clinic(string _nameComp, int _size)//конструктор класса
        {
            this.nameComp = _nameComp;
            this.size = _size;
            stack = new Patient[size];
            SP = 0;
        }
        public string Getname()
        {
            return nameComp;
        }
        public int GetSp()
        {
            return SP;
        }
        public void addPatient(string _name) //добавление пациента
        {
            Patient newPatient = new Patient(_name);
            if(SP <= size)
            {
                stack[SP] = newPatient;
                SP++;
            }
        }
        public Patient search(string _name)//поиск пациента
        {
            for (int i = 0; i < SP; i++)
            {
                if (stack[i].getName().Equals(_name))
                {
                    return stack[i];
                }
            }
            return null;
        }
        public void delPatient() //удаление пациента
        {
            if(SP > 0)
            {
                stack[SP-1] = null;
                SP--;
            }
        }
        public string summPatient() //количество пациентов
        { 
            return "Summ patient - " + SP; ;
        }
        public int sumCost() //сумма потраченных денег на услуги
        {
            summ = 0;
            for (int i = 0; i < SP; i++)
            {
                summ += stack[i].summa();
            }
            return summ; 
        }
        public string info() //получение информации о всех клиентах
        {
            string resultAll = "name company - " + nameComp + "\n";
            for (int i = 0; i< SP; i++)
            {
                resultAll += "\n" + stack[i].print();
            }
            resultAll += "\n\n\nAmount of funds spent all clients - " + sumCost();
            resultAll += "\n" + summPatient();
            return resultAll;
        }
        public string infoLoad()
        {
            string resultAllLoad = "";
            for (int i = 0; i < GetSp(); i++)
            {
                resultAllLoad += "\n" + stack[i].setName;
                if (i > GetSp())
                {
                    break;
                }
            }
            resultAllLoad += "\n";
                for (int i = 0; i < SP; i++)
                {
                    resultAllLoad += "\n" + stack[i].printLoad();
                }
            return resultAllLoad;
        }
    }
}
