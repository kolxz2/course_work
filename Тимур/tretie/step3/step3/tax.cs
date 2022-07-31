using System;
using System.Collections.Generic;
using System.Text;

namespace step3
{
    class tax
    {
        private string typeTax; //тип налога
        private int amount; //сумма налога
        public tax(string atypeTax, int aMount)//конструктор
        {
            this.typeTax = atypeTax;
            this.amount = aMount;
        } 
        public string getTypeTax(){ return typeTax; } //получить тип налога
        public void setTypeTax(string _type){ this.typeTax = _type; } //поменять тип налога
        public int getAmount() { return amount; } //получить сумму налога
        public void setAmount(int _amount) { this.amount = _amount; } //поменять сумму налога
    }
}
