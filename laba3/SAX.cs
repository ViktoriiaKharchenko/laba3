using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;

namespace laba3
{
    class SAX : ISearcher
    {
        List<Book> info = new List<Book>();
        XmlReader reader ; 
        public SAX(string path)
        {
            reader = XmlReader.Create(path);
        }
        public List<Book> Algorithm (Book book)
        {
            info.Clear();
            List<Book> result = new List<Book>();
            Book bk = null;
            string bookshop = null;
            string genre = null;
            while (reader.Read())
            {
                if (reader.Name == "bookshop")
                {
                    while (reader.MoveToNextAttribute())
                    {
                        if (reader.Name == "Name")
                        {
                            bookshop = reader.Value; 
                        }
                    }
                }
                if (reader.Name == "category")
                {
                    while (reader.MoveToNextAttribute())
                    {
                        if (reader.Name == "Category")
                        {
                            genre = reader.Value;
                        }
                    }
                }
                if (reader.Name == "book")
                {
                    bk = new Book();
                    bk.BookShop = bookshop;
                    bk.Category = genre;
                   
                    if (reader.HasAttributes)
                    {
                        while (reader.MoveToNextAttribute())
                        {
                            if(reader.Name == "Name")  bk.Title = reader.Value;
                            if (reader.Name == "Author") bk.Author = reader.Value;
                            if (reader.Name == "Genre") bk.Genre = reader.Value;
                            if (reader.Name == "Year") bk.Year = reader.Value;
                            if (reader.Name == "Language") bk.Language = reader.Value;
                            if (reader.Name == "Description") bk.Description = reader.Value;
                        }
                    }
                    result.Add(bk);
                }
            }
            info = Filter(result, book);
            return info;
        }
        public List<Book> Filter (List<Book> allBooks, Book book)
        {
            List<Book> result = new List<Book>();
            if(allBooks != null)
            {
                foreach(Book bk in allBooks)
                {
                    try
                    {
                        if((bk.BookShop==book.BookShop || book.BookShop ==null)&&
                           (bk.Title == book.Title||book.Title==null)&&
                           (bk.Author == book.Author || book.Author == null)&&
                           (bk.Category==book.Genre||book.Genre == null)&&
                           (book.Year == bk.Year.Substring(0,2)|| book.Year == null)&&
                           (bk.Language == book.Language || book.Language == null))
                        {
                            result.Add(bk);
                        }
                    }
                    catch { }
                }
                
            }
            return result;
        }
    }
}
