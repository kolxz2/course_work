using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AviaCompany
{
    internal class Polet
    {
        private DateTime date;
        private int cost;
        public Polet(DateTime _date, int _cost)
        {
            this.date = _date;
            this.cost = _cost;
        }
        public DateTime Date
        { get { return date; } set { this.date = value; } }
        public int Cost
        { get { return cost; } set { this.cost = value; } }
    }
}
