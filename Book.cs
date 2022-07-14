using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    public class Book
    {
        private string title;
        public string author;
        public int pages;
        public Book(string aTitle,string aAuthor,int aPages)
        {
            Title = aTitle;
            author = aAuthor;
            pages = aPages;
        }
        public string Title
        {
            get { return title; }
            set { 
                if(value == "G" || value == "PG" || value == "PG-13" || value == "R" )
                {
                    title = value;
                }
                else
                {
                    title = "NR";
                }
            }
        }
    }
}
