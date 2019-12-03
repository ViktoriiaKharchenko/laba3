using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Windows.Forms;

namespace laba3
{
    class DOM:ISearcher
    {
        XmlDocument doc = new XmlDocument();
        public DOM(string path)
        {
            doc.Load(path);

        }
        public List<Book> Algorithm(Book book)
        {
            List<Book> result = new List<Book>();
            XmlNode node = doc.DocumentElement;
            foreach (XmlNode no in node.ChildNodes)
            {
                //MessageBox.Show(Convert.ToString(node.ChildNodes.Count));
                foreach (XmlNode n in no.ChildNodes)
                {
                    bool g = false;
                    foreach (XmlNode nod in n.ChildNodes)
                    {
                        string genre = "";
                        string title = "";
                        string author = "";
                        string bookshop = "";
                        string year = "";
                        string language = "";
                        string description = "";
                        foreach (XmlAttribute attribute in nod.Attributes)
                        {
                           // MessageBox.Show(no.Attributes.GetNamedItem("Name").Value);
                            if (no.Name.Equals("bookshop") && (book.BookShop == null
                                || no.Attributes.GetNamedItem("Name").Value == book.BookShop)) { bookshop = no.Attributes.GetNamedItem("Name").Value; }
                            if (nod.Name.Equals("book") && attribute.Name.Equals("Name") && (book.Title == null
                                || attribute.Value == book.Title)) title = attribute.Value;
                            if (attribute.Name.Equals("Author") && (book.Author == null
                                || attribute.Value == book.Author)) author = attribute.Value;
                            if (n.Name.Equals("category") && (book.Genre == null
                                 || n.Attributes.GetNamedItem("Category").Value == book.Genre)) { g = true; }
                            if (attribute.Name.Equals("Genre") && (g == true)) genre = attribute.Value;
                            if (attribute.Name.Equals("Year") && (book.Year == null
                                || book.Year == attribute.Value.Substring(0, 2))) year = attribute.Value;
                            if (attribute.Name.Equals("Language") && (book.Language == null
                                || attribute.Value == book.Language)) language = attribute.Value;
                            if (attribute.Name.Equals("Description")) description = attribute.Value;
                        }
                        //////change


                        if (bookshop != "" && author != "" && title != "" && genre != "" && year != "" && language != "")
                        {
                            Book mybook = new Book();
                            mybook.BookShop = bookshop;
                            mybook.Title = title;
                            mybook.Author = author;
                            mybook.Genre = genre;
                            mybook.Year = year;
                            mybook.Language = language;
                            mybook.Description = description;
                            result.Add(mybook);
                        }
                    }
                }
            }
            return result;


        }

      /*  public List<Book> Algorithm (Book book, string path)
        {
            List<List<Book>> info = new List<List<Book>>();
            try
            {
                if(book.BookShop != null) { info.Add(SearchByParam("bookshop", "Name", book.BookShop, doc, 0)); }
                if (book.Title != null) { info.Add(SearchByParam("book", "Name", book.Title, doc, 1)); }
                if (book.Author != null) { info.Add(SearchByParam("book", "Author", book.Author, doc, 1)); }
                if (book.Genre!= null) { info.Add(SearchByParam("book", "Genre", book.Genre, doc, 1)); }
                if (book.Year != null) { info.Add(SearchByParam("book", "Year", book.Year, doc, 1)); }
                if (book.Language != null) { info.Add(SearchByParam("book", "Language", book.Language, doc, 1)); }
                if (book.Description != null) { info.Add(SearchByParam("book", "Description", book.Description, doc, 1)); }
            }
            catch { }
            return Cross(info);
        }
        public static List<Book> Cross(List<List<Book>> list)
        {
            List<Book> result = new List<Book>();
            try
            {
                if(list != null)
                {
                    bool IsIn = true;
                    Book[] bk = list[0].ToArray();
                    if(bk != null)
                    {
                        foreach (Book el in bk)
                        {
                            foreach (List<Book> e in list)
                            {
                                if (e.Count() <= 0) return new List<Book>();
                                foreach (Book b in e)
                                {
                                     IsIn = false;
                                    if (el.Comparing(b))
                                    {
                                        IsIn = true;
                                        break;
                                    }
                                }
                                if (!IsIn) break;
                            }
                            if (IsIn) result.Add(el);
                        }
                    }
                }
            }
            catch { }
            return result;
        }

        public static List<Book> SearchByParam (string nodename, string val,string param,XmlDocument doc,int n)
        {
            List<Book> bookList = new List<Book>();

            if(param != string.Empty && param != null)
            {
                switch (n)
                {
                    case 0:
                        {
                            XmlNodeList elem = doc.SelectNodes("//" + nodename + "[@" + val + "=\"" + param + "\"]");
                            try
                            {
                                foreach(XmlNode e in elem)
                                {
                                    XmlNodeList list1 = e.ChildNodes;
                                    foreach(XmlNode el in list1)
                                    {
                                        bookList.Add(Info(el));
                                    }
                                }
                            }
                            catch { }
                            return bookList;
                        }
                    case 1:
                        {
                            XmlNodeList elem = doc.SelectNodes("//" + nodename + "[@" + val + "=\"" + param + "\"]");
                            try
                            {
                                
                                    ;
                                    foreach (XmlNode el in elem)
                                    {
                                        bookList.Add(Info(el));
                                    }
                                
                            }
                            catch { }
                            return bookList;
                        }
                    default: break;

                }
            }
            return bookList;
        }

        public static Book Info(XmlNode node)
        {
            Book book = new Book();
            book.BookShop = node.ParentNode.Attributes.GetNamedItem("Name").Value;
            book.Title = node.Attributes.GetNamedItem("Name").Value;
            book.Author = node.Attributes.GetNamedItem("Author").Value;
            book.Genre = node.Attributes.GetNamedItem("Genre").Value;
            book.Year = node.Attributes.GetNamedItem("Year").Value;
            book.Language = node.Attributes.GetNamedItem("Language").Value;
            book.Description = node.Attributes.GetNamedItem("Description").Value;
            return book;
        }*/
    }
}
