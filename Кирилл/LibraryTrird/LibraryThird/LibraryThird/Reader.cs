using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryThird
{
    internal class Reader
    {
        private string surname;
        private int days;

        public Reader(string _surname, int _days)
        {
            this.surname = _surname;
            this.days = _days;
        }

        public string Surname//
        {
            get { return surname; }
            set { surname = value; }
        }
        public int Days//
        {
            get { return days; }
            set { days = value; }
        }
    }
}
