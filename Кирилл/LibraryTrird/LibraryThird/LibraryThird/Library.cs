using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryThird
{
    internal class Library
    {
        private string nameLib;
        private int SP;
        private Book[] books;
        private float fullness;
        private int sizeArr,count;
        public Library(string _nameLib, int _sizeArr)
        {
            this.nameLib = _nameLib;
            this.sizeArr = _sizeArr;
            books = new Book[sizeArr];
            fullness = 0;
            SP = 0;count = 0;
        }
        public Book[] Books { get { return books; } }
        public int Count { get { return count; } }
        public bool addBook(string _title, string _author)
        {
            Book newBook = new Book(_title, _author);
            if (SP != 0)
            {
                if (fullness >= (0.8 * sizeArr)) { increaseArr(); }
                fullness = SP / sizeArr;
            }
            books[SP] = newBook;
            SP++;
            count++;
            return books[SP - 1] == newBook;
        }
        public Book searchBook(string _title)
        {
            for (int i = 0; i < sizeArr; i++)
            {
                if (books[i].Title.Equals(_title))
                {
                    return books[i];
                }
            }
            return null;
        }
        public bool delBook()
        {
            if (books[0] != null)
            {
                books[SP] = null;
                SP--;
                count--;
                if (fullness <= (0.2 * sizeArr)) { increaseArr(); }
                return true;
            }
            return false;
        }
        public string getInfoLib()
        {
            string info = nameLib;

            for (int i = 0; i < SP; i++)
            {
                Book pTemp = books[i];
                if (pTemp != null)
                {
                    info +="\n" + pTemp.getInfo();
                }
            }
            return info;
        }
        public string getName()
        {
            string info = Convert.ToString(Count);
            
            for(int i = 0;i< SP;i++)
            {
                info += "\n" + books[i].Title;
                info += "\n" + books[i].Author;
            }
            return info;
        }

        public String getForInfo()
        {
            StringBuilder info = new StringBuilder();            
            for(int i = 0; i< SP; i++)
            {
                info.Append("\n").Append(books[i].getInfoList());
            }
            return info.ToString();
        }
        

        public bool increaseArr()
        {
            if (fullness >= (0.8 * sizeArr))
            {
                Book[] pTemp = new Book[sizeArr * 2];
                for (int i = 0; i < SP; i++)
                {
                    pTemp[i] = books[i];
                }
                sizeArr *= 2;
                books = new Book[sizeArr];
                for (int i = 0; i < sizeArr; i++)
                {
                    books[i] = pTemp[i];
                }
            }
            else if (fullness <= (0.2 * sizeArr))
            {
                Book[] pTemp = new Book[sizeArr / 2];
                for (int i = 0; i < SP; i++)
                {
                    pTemp[i] = books[i];
                }
                sizeArr /= 2;
                books = new Book[sizeArr];
                for (int i = 0; i < sizeArr; i++)
                {
                    books[i] = pTemp[i];
                }
            }

            return false;
        }
    }
}