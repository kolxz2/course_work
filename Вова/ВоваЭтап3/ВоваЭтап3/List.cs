// List
using System;
using System.Collections.Generic;
using System.Text;

namespace Этап3
{
    class List // адресный список
    {
        public Employee info;
        private List next;
        private List pred;
        public List(Employee newEmployee)
        {
            info = newEmployee;
            next = null;
            pred = null;
        }
        public List Next
        {
            get { return next; }
            set { this.next = value; }
        }
        public List Pred
        {
            get { return pred; }
            set { this.pred = value; }
        }
    }
}
