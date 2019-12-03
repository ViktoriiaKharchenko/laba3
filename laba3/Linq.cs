using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Windows.Forms;

namespace laba3
{
    class Linq : ISearcher
    {
        List<Book> info = new List<Book>();
        XDocument doc = new XDocument();
        public Linq(string path)
        {
            doc = XDocument.Load(path);
        }
        public List<Book> Algorithm (Book book)
        {
            List<XElement> match = (from val in doc.Descendants("book")
                                    where
                                   ((book.BookShop == null || book.BookShop == val.Parent.Parent.Attribute("Name").Value) &&
                                   (book.Genre == null || book.Genre == val.Parent.Attribute("Category").Value) &&
                                   (book.Title == null || book.Title == val.Attribute("Name").Value) &&
                                   (book.Author == null || book.Author == val.Attribute("Author").Value) &&
                                   (book.Year == null || book.Year == val.Attribute("Year").Value.Substring(0,2)) &&
                                   (book.Language == null || book.Language == val.Attribute("Language").Value))
                                    select val).ToList();
            foreach (XElement element in match)
            {
                Book book1 = new Book();
                book1.BookShop = element.Parent.Parent.Attribute("Name").Value;
                book1.Title = element.Attribute("Name").Value;
                book1.Author = element.Attribute("Author").Value;
                book1.Genre = element.Attribute("Genre").Value;
                book1.Year = element.Attribute("Year").Value;
                book1.Language = element.Attribute("Language").Value;
                book1.Description = element.Attribute("Description").Value;
                info.Add(book1);
            }
            return info;
        }

    }
}
