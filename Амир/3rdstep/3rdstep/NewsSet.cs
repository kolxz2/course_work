using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3rdstep
{
    internal class NewsSet
    {
        private string date; //дата публикации
        private string title; //заголовок новости
        public NewsSet(string ntitle, string ndate)  //конструктор
        {
            date = ndate; 
            title = ntitle;  
        }
        public string Date
        {
            get => date; set => date = value;
        }//get- и set- для строки "дата публикации"
        public string Title
        {
            get => title; set => title = value;
        }//get- и set- для строки "заголовок новости"
    }
}
