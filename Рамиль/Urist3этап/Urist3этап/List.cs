using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Urist3этап
{
    internal class List
    {
        private Client client;//важные данные
        private List last, first, second,pred;//переменные-ссылки 
        public List (Client _client)//конструктор
        {
            this.client = _client;
            this.last = null;
            this.first = null;
            this.second = null;
        }
        public Client cClient { get { return client; }set { this.client = value; } }
        public List Second//гет и сет для следующего элемента
        {
            get { return second; }
            set { second = value; }
        }
        public List Last//гет и сет для последнего элемента
        {
            get { return last; }
            set { last = value; }
        }
        public List First//гет и сет для первого элемента
        {
            get { return first; }
            set { first = value; }
        }
        public List Pred 
        { 
            get { return pred; } 
            set { this.pred = value; } 
        }
    }
}
