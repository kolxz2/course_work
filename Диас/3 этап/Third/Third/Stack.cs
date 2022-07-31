using System;
using System.Collections.Generic;
using System.Text;

namespace Third
{
    class Stack
    {
        public Seans _aDate;
        private Stack pred;
        public Stack(Seans _date, Stack _SP)
        {
            _aDate = _date;
            pred = _SP;
        }
        public Stack getPred()
        {
            return pred;
        }
    }
}
