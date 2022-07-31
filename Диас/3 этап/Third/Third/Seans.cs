using System;
using System.Collections.Generic;
using System.Text;

namespace Third
{
    class Seans
    {
        private string date;//дата показа фильма
        private int time;//время показа фильма
        public Seans(string _date, int _time)
        {
            this.date = _date;
            this.time = _time;
        }
        public string getDate()
        {
            return date;
        }
        public void setDate(string _date)
        {
            this.date = _date;
        }
        public int getTime()
        {
            return time;
        }
        public void setTime(int _time)
        {
            this.time = _time;
        }
    }
}
