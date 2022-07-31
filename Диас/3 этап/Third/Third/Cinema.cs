using System;
using System.Collections.Generic;
using System.Text;

namespace Third
{
    class Cinema
    {

        private Film[] Queue;//реализация очереди на основе массива
        private static int size = 10;
        private int countFilm = 0;
        private int first;//ссылка на первый элемент в очереди
        private int last;//ссылка на последний элемент в очереди
        public Cinema()
        {
            first = 0;
            last = 0;
            Queue = new Film[size];
        }
        public string addFilm(string _nameFilm, int _durationFilm)
        {
            if (size >= countFilm)
            {
                if (last > size && first > 0) {last = 0;}
                Film newFilm = new Film(_nameFilm, _durationFilm);
                Queue[last] = newFilm;
                last++;
                countFilm++;
                return _nameFilm;
            }
            return "";
        }
        public bool delFilm()
        {
            if ( countFilm != 0)
            {
                if (first > size) { first = 0;}
                Queue[first] = null;
                countFilm--;
                first++;
                return true;
            }
            return false;
        }
        public int COUNT { get { return countFilm; } }
        public string getinfo()
        {
            string inform = "";
            for(int i = 0; i < countFilm; i++)
            {
                inform += "\n" + Queue[i].getInfoStack();
            }
            return inform;
        }
        public string getinfoName()
        {
            string inform = Convert.ToString(COUNT);
            for (int i = 0; i < countFilm; i++)
            {
                inform += "\n" + Queue[i].Name;
                inform += "\n" + Queue[i].Durat;
            }
            return inform;
        }
        public Film getFirst() { return Queue[first]; }
        public Film FindFilm(string _nameFilm)
        {
            Film pTemp;
            for(int i = 0; i<= countFilm; i++)
            {
                pTemp = Queue[i];
                if (pTemp != null && pTemp.getNameFilm().Equals(_nameFilm))
                {
                    return pTemp;
                }
                
            }
            return null;
        }
        public bool getSeansToEdit(string _date, int _time, String _nameFilm)
        {
            int i = 0;
            Film pTemp = Queue[i];
            for (int j = 0; j < size; j++)
            {
                if (pTemp != null && pTemp.getNameFilm().Equals(_nameFilm))
                {
                    pTemp.addSeans(_date, _time);
                    return true;
                }
                else
                {
                    i++;
                    pTemp = Queue[i];
                }
               
            }
            return false;
        }
    }
}
