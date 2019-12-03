using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Xsl;
using System.Xml;

namespace laba3
{
    public partial class BookDatabase : Form
    {
        string path = "C:/Users/Boss/source/repos/laba3/laba3/bin/Debug/XMLFile1.xml";
        List<Book> final = new List<Book>();
        public BookDatabase()
        {
            InitializeComponent();
            CreateComboboxes();

        }

        public void CreateComboboxes()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(path);
            XmlElement node = doc.DocumentElement;

            foreach (XmlNode no in node.ChildNodes)
            {
                //MessageBox.Show(Convert.ToString(node.ChildNodes.Count));
                foreach (XmlNode n in no.ChildNodes)
                {
                   
                    foreach (XmlNode nod in n.ChildNodes)
                    {
                        if (!BookShop.Items.Contains(no.SelectSingleNode("@Name").Value)) { BookShop.Items.Add(no.SelectSingleNode("@Name").Value); }
                        if (!Genre.Items.Contains(n.SelectSingleNode("@Category").Value)) { Genre.Items.Add(n.SelectSingleNode("@Category").Value); }
                        if (!Title.Items.Contains(nod.SelectSingleNode("@Name").Value)) Title.Items.Add(nod.SelectSingleNode("@Name").Value);
                        if (!Author.Items.Contains(nod.SelectSingleNode("@Author").Value)) Author.Items.Add(nod.SelectSingleNode("@Author").Value);
                        if (!Language.Items.Contains(nod.SelectSingleNode("@Language").Value)) Language.Items.Add(nod.SelectSingleNode("@Language").Value);
                    }
                }
            }
        }
        private void Name_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox_Name_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void SAX_button_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void DOM_button_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void BookDatabase_Load(object sender, EventArgs e)
        {

        }

        private void Search_Click(object sender, EventArgs e)
        {
            Text1.Clear();
            Book book = OurBook();
            if(!LINQ_button.Checked && !DOM_button.Checked && !SAX_button.Checked)
            {
                MessageBox.Show("Ви повинні обрати спосіб пошуку (LINQ, DOM або SAX)");
            }
           // MessageBox.Show(book.BookShop);
            if (LINQ_button.Checked)
            {
                ISearcher currentSearcher = new Linq(path);
                book.Algo = currentSearcher;
                final = book.Algorithm(book);
                OutPut(final);
            }
            if (DOM_button.Checked) 
            {
                ISearcher currentSearcher = new DOM(path);
                book.Algo = currentSearcher;
                final = book.Algorithm(book);
                OutPut(final);
            }
            if (SAX_button.Checked)
            {
                ISearcher currentSearcher = new SAX(path);
                book.Algo = currentSearcher;
                final =book.Algorithm(book);
                OutPut(final);
            }
        }
        private Book OurBook()
        {
            string[] info = new string[6];
            if (checkBox_BookShop.Checked) info[0] = Convert.ToString(BookShop.Text);
           // MessageBox.Show(info[0]);
            if (checkBox_Author.Checked) info[2] = Convert.ToString(Author.Text);
            if (checkBox_Name.Checked) info[1] = Convert.ToString(Title.Text);
            if (checkBox_genre.Checked) info[3] = Convert.ToString(Genre.Text);
            if (checkBox_Year.Checked) 
            {
                if (Year.Text == "Література XVIII ст.") info[4] = "17";
                if (Year.Text == "Література XIX ст.") info[4] = "18";
                if (Year.Text == "Література XX ст.") info[4] = "19";
                if (Year.Text == "Сучасна література") info[4] = "20";
            }
            if (checkBox_Language.Checked) info[5] = Convert.ToString(Language.Text);
            Book IdealBook = new Book(info);
            return IdealBook;

        }
        private void OutPut(List<Book> final)
        {
            if (final.Count == 0) { Text1.AppendText("Нажаль, такої книги немає в наявності"); }
            int i = 1;
            foreach (Book book in final)
            {
                Text1.AppendText(i + "." + "\n");
                Text1.AppendText("Магазин " + book.BookShop + "\n");
                Text1.AppendText("Назва " + book.Title + "\n");
                Text1.AppendText("Автор " + book.Author + "\n");
                Text1.AppendText("Жанр " + book.Genre + "\n");
                Text1.AppendText("Рік публікації " + book.Year + "\n");
                Text1.AppendText("Мова " + book.Language + "\n");
                Text1.AppendText("Опис " + book.Description + "\n");
                Text1.AppendText("____________________________________\n");
                i++;
            }
        }
        private void Text1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox_BookShop_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox_genre_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Clear_Click(object sender, EventArgs e)
        {
            Text1.Clear();
            checkBox_BookShop.Checked = false;
            checkBox_Name.Checked = false;
            checkBox_Author.Checked = false;
            checkBox_genre.Checked = false;
            checkBox_Year.Checked = false;
            checkBox_Language.Checked = false;
            BookShop.Text = null;
            Title.Text = null;
            Author.Text = null;
            Genre.Text = null;
            Year.Text = null;
            Language.Text = null;
            LINQ_button.Checked = false;
            DOM_button.Checked = false;
            SAX_button.Checked = false;

        }

        private void Transform_Click(object sender, EventArgs e)
        {
            XslCompiledTransform xslt = new XslCompiledTransform();
            xslt.Load("XSL.xsl");
            string input = @"XMLFile1.xml";
            string output = @"result.html";
            xslt.Transform(input, output);
            MessageBox.Show("Операція успішна");
        }
    }
}
