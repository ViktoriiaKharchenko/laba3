using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace laba3
{
    class Book
    {
        public string BookShop { get; set; }
        public string Category { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public string Year { get; set; }
        public string Language { get; set; }
        public string Description { get; set; }

        public Book(string[] data)
        {
            BookShop = data[0];
            Title = data[1];
            Author = data[2];
            Genre = data[3];
            Year = data[4];
            Language = data[5];
            //Description = data[6];
        }
        public Book() { }
       /* public Book(ISearcher algo)
        {
            BookShop = String.Empty;
            Category = String.Empty;
            Title = String.Empty; 
            Author = String.Empty;
            Genre = String.Empty;
            Year = String.Empty;
            Language = String.Empty;
            Description = String.Empty;
        }*/
        public bool Comparing (Book book)
        {
            if (this.Title == book.Title && this.Author == book.Author
                && this.Genre == book.Genre && this.Year == book.Year
                && this.Language == book.Language) return true;
            else return false;
        }
        public ISearcher Algo { get; set; }
        public List<Book> Algorithm (Book book)
        {
            return Algo.Algorithm(book);
        }
    }
}
