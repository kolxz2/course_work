using System;
using System.Collections.Generic;
using System.Text;

namespace Third
{
    class Film
    {
        private Stack firstSeans;//первый сеанс
        private string nameFilm;//название фильма
        private int durationFilm;//длина фильма
        private Stack SP;
        private int count;

        public Film(string _nameFilm, int _durationFilm)
        {
            this.nameFilm = _nameFilm;
            this.durationFilm = _durationFilm;
            SP = null;
        }
        public int Count { get { return count; } }
        public string Name { get { return nameFilm; } set { this.nameFilm = value; } }
        public int Durat { get { return durationFilm; } set { this.durationFilm = value; } }
        public Stack getSPEl { get{ return SP; } }
        public void addSeans(string _date, int _time)
        {
            Seans newSea = new Seans(_date,_time);
            Stack pTemp = new Stack(newSea,SP);
            if (SP == null) { firstSeans = pTemp;}
            SP = pTemp;
            count++;
        }
        public string getNameFilm() { return nameFilm; }
        public bool delSeans()
        {
            if (SP != null)
            {
                SP = SP.getPred();
                count--;
                return true;
            }
            else return false;
        }
        public int getSumStack()
        {
            return durationFilm*count;
        }
        public String getInfoStack()
        {
            String info = Convert.ToString(Count);
            Stack pTemp = SP;
            while (pTemp != null)
            {
                info += "\n" + pTemp._aDate.getDate();
                info += "\n" + pTemp._aDate.getTime();
                pTemp = pTemp.getPred();
            }
            return info;
        }
        public Seans FindSeans(string _nameSeans)
        {
            Stack vspom = SP;
            while(vspom != null)
            {
                if(vspom._aDate.getDate().Equals(_nameSeans))
                {
                    return vspom._aDate;
                }
                else { vspom = vspom.getPred(); }
            }
            return null;
        }
    }
}
