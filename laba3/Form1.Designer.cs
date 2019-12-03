namespace laba3
{
    partial class BookDatabase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Title = new System.Windows.Forms.ComboBox();
            this.checkBox_Author = new System.Windows.Forms.CheckBox();
            this.Author = new System.Windows.Forms.ComboBox();
            this.checkBox_genre = new System.Windows.Forms.CheckBox();
            this.Genre = new System.Windows.Forms.ComboBox();
            this.checkBox_Year = new System.Windows.Forms.CheckBox();
            this.Year = new System.Windows.Forms.ComboBox();
            this.checkBox_Language = new System.Windows.Forms.CheckBox();
            this.Language = new System.Windows.Forms.ComboBox();
            this.DOM_button = new System.Windows.Forms.RadioButton();
            this.SAX_button = new System.Windows.Forms.RadioButton();
            this.LINQ_button = new System.Windows.Forms.RadioButton();
            this.Search = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.Transform = new System.Windows.Forms.Button();
            this.Text1 = new System.Windows.Forms.RichTextBox();
            this.checkBox_Name = new System.Windows.Forms.CheckBox();
            this.checkBox_BookShop = new System.Windows.Forms.CheckBox();
            this.BookShop = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.FormattingEnabled = true;
            this.Title.Location = new System.Drawing.Point(188, 31);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(195, 24);
            this.Title.TabIndex = 0;
            this.Title.SelectedIndexChanged += new System.EventHandler(this.Name_SelectedIndexChanged);
            // 
            // checkBox_Author
            // 
            this.checkBox_Author.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_Author.Location = new System.Drawing.Point(23, 86);
            this.checkBox_Author.Name = "checkBox_Author";
            this.checkBox_Author.Size = new System.Drawing.Size(121, 32);
            this.checkBox_Author.TabIndex = 2;
            this.checkBox_Author.Text = "Автор";
            this.checkBox_Author.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.checkBox_Author.UseVisualStyleBackColor = true;
            // 
            // Author
            // 
            this.Author.FormattingEnabled = true;
            this.Author.Location = new System.Drawing.Point(188, 86);
            this.Author.Name = "Author";
            this.Author.Size = new System.Drawing.Size(195, 24);
            this.Author.TabIndex = 3;
            // 
            // checkBox_genre
            // 
            this.checkBox_genre.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_genre.Location = new System.Drawing.Point(23, 202);
            this.checkBox_genre.Name = "checkBox_genre";
            this.checkBox_genre.Size = new System.Drawing.Size(137, 29);
            this.checkBox_genre.TabIndex = 4;
            this.checkBox_genre.Text = "Категорія";
            this.checkBox_genre.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.checkBox_genre.UseVisualStyleBackColor = true;
            this.checkBox_genre.CheckedChanged += new System.EventHandler(this.checkBox_genre_CheckedChanged);
            // 
            // Genre
            // 
            this.Genre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Genre.FormattingEnabled = true;
            this.Genre.Location = new System.Drawing.Point(188, 202);
            this.Genre.Name = "Genre";
            this.Genre.Size = new System.Drawing.Size(195, 24);
            this.Genre.TabIndex = 5;
            // 
            // checkBox_Year
            // 
            this.checkBox_Year.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_Year.Location = new System.Drawing.Point(23, 259);
            this.checkBox_Year.Name = "checkBox_Year";
            this.checkBox_Year.Size = new System.Drawing.Size(159, 29);
            this.checkBox_Year.TabIndex = 6;
            this.checkBox_Year.Text = "Рік публікації";
            this.checkBox_Year.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.checkBox_Year.UseVisualStyleBackColor = true;
            // 
            // Year
            // 
            this.Year.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Year.FormattingEnabled = true;
            this.Year.Items.AddRange(new object[] {
            "Література XVIII ст.",
            "Література XIX ст.",
            "Література XX ст.",
            "Сучасна література"});
            this.Year.Location = new System.Drawing.Point(188, 259);
            this.Year.Name = "Year";
            this.Year.Size = new System.Drawing.Size(195, 24);
            this.Year.TabIndex = 7;
            // 
            // checkBox_Language
            // 
            this.checkBox_Language.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_Language.Location = new System.Drawing.Point(23, 313);
            this.checkBox_Language.Name = "checkBox_Language";
            this.checkBox_Language.Size = new System.Drawing.Size(159, 24);
            this.checkBox_Language.TabIndex = 8;
            this.checkBox_Language.Text = "Мова";
            this.checkBox_Language.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.checkBox_Language.UseVisualStyleBackColor = true;
            // 
            // Language
            // 
            this.Language.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Language.FormattingEnabled = true;
            this.Language.Location = new System.Drawing.Point(188, 313);
            this.Language.Name = "Language";
            this.Language.Size = new System.Drawing.Size(195, 24);
            this.Language.TabIndex = 9;
            // 
            // DOM_button
            // 
            this.DOM_button.AutoSize = true;
            this.DOM_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DOM_button.Location = new System.Drawing.Point(38, 381);
            this.DOM_button.Name = "DOM_button";
            this.DOM_button.Size = new System.Drawing.Size(73, 24);
            this.DOM_button.TabIndex = 10;
            this.DOM_button.TabStop = true;
            this.DOM_button.Text = "DOM";
            this.DOM_button.UseVisualStyleBackColor = true;
            this.DOM_button.CheckedChanged += new System.EventHandler(this.DOM_button_CheckedChanged);
            // 
            // SAX_button
            // 
            this.SAX_button.AutoSize = true;
            this.SAX_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SAX_button.Location = new System.Drawing.Point(145, 381);
            this.SAX_button.Name = "SAX_button";
            this.SAX_button.Size = new System.Drawing.Size(66, 24);
            this.SAX_button.TabIndex = 11;
            this.SAX_button.TabStop = true;
            this.SAX_button.Text = "SAX";
            this.SAX_button.UseVisualStyleBackColor = true;
            this.SAX_button.CheckedChanged += new System.EventHandler(this.SAX_button_CheckedChanged);
            // 
            // LINQ_button
            // 
            this.LINQ_button.AutoSize = true;
            this.LINQ_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LINQ_button.Location = new System.Drawing.Point(244, 381);
            this.LINQ_button.Name = "LINQ_button";
            this.LINQ_button.Size = new System.Drawing.Size(139, 24);
            this.LINQ_button.TabIndex = 12;
            this.LINQ_button.TabStop = true;
            this.LINQ_button.Text = "LINQ to XML";
            this.LINQ_button.UseVisualStyleBackColor = true;
            // 
            // Search
            // 
            this.Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.Location = new System.Drawing.Point(23, 451);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(105, 49);
            this.Search.TabIndex = 13;
            this.Search.Text = "Пошук";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // Clear
            // 
            this.Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear.Location = new System.Drawing.Point(145, 451);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(109, 49);
            this.Clear.TabIndex = 14;
            this.Clear.Text = "Відмінити вибір";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Transform
            // 
            this.Transform.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Transform.Location = new System.Drawing.Point(272, 451);
            this.Transform.Name = "Transform";
            this.Transform.Size = new System.Drawing.Size(111, 49);
            this.Transform.TabIndex = 15;
            this.Transform.Text = "Створити HTML";
            this.Transform.UseVisualStyleBackColor = true;
            this.Transform.Click += new System.EventHandler(this.Transform_Click);
            // 
            // Text1
            // 
            this.Text1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text1.Location = new System.Drawing.Point(435, 28);
            this.Text1.Name = "Text1";
            this.Text1.ReadOnly = true;
            this.Text1.Size = new System.Drawing.Size(655, 497);
            this.Text1.TabIndex = 16;
            this.Text1.Text = "";
            this.Text1.TextChanged += new System.EventHandler(this.Text1_TextChanged);
            // 
            // checkBox_Name
            // 
            this.checkBox_Name.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_Name.Location = new System.Drawing.Point(23, 31);
            this.checkBox_Name.Name = "checkBox_Name";
            this.checkBox_Name.Size = new System.Drawing.Size(121, 24);
            this.checkBox_Name.TabIndex = 1;
            this.checkBox_Name.Text = "Назва";
            this.checkBox_Name.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.checkBox_Name.UseVisualStyleBackColor = true;
            this.checkBox_Name.CheckedChanged += new System.EventHandler(this.checkBox_Name_CheckedChanged);
            // 
            // checkBox_BookShop
            // 
            this.checkBox_BookShop.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_BookShop.Location = new System.Drawing.Point(23, 147);
            this.checkBox_BookShop.Name = "checkBox_BookShop";
            this.checkBox_BookShop.Size = new System.Drawing.Size(121, 24);
            this.checkBox_BookShop.TabIndex = 17;
            this.checkBox_BookShop.Text = "Магазин";
            this.checkBox_BookShop.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.checkBox_BookShop.UseVisualStyleBackColor = true;
            this.checkBox_BookShop.CheckedChanged += new System.EventHandler(this.checkBox_BookShop_CheckedChanged);
            // 
            // BookShop
            // 
            this.BookShop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BookShop.FormattingEnabled = true;
            this.BookShop.Location = new System.Drawing.Point(188, 147);
            this.BookShop.Name = "BookShop";
            this.BookShop.Size = new System.Drawing.Size(195, 24);
            this.BookShop.TabIndex = 18;
            // 
            // BookDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 578);
            this.Controls.Add(this.BookShop);
            this.Controls.Add(this.checkBox_BookShop);
            this.Controls.Add(this.Text1);
            this.Controls.Add(this.Transform);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.LINQ_button);
            this.Controls.Add(this.SAX_button);
            this.Controls.Add(this.DOM_button);
            this.Controls.Add(this.Language);
            this.Controls.Add(this.checkBox_Language);
            this.Controls.Add(this.Year);
            this.Controls.Add(this.checkBox_Year);
            this.Controls.Add(this.Genre);
            this.Controls.Add(this.checkBox_genre);
            this.Controls.Add(this.Author);
            this.Controls.Add(this.checkBox_Author);
            this.Controls.Add(this.checkBox_Name);
            this.Controls.Add(this.Title);
            this.Name = "BookDatabase";
            this.Load += new System.EventHandler(this.BookDatabase_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Title;
        private System.Windows.Forms.CheckBox checkBox_Author;
        private System.Windows.Forms.ComboBox Author;
        private System.Windows.Forms.CheckBox checkBox_genre;
        private System.Windows.Forms.ComboBox Genre;
        private System.Windows.Forms.CheckBox checkBox_Year;
        private System.Windows.Forms.ComboBox Year;
        private System.Windows.Forms.CheckBox checkBox_Language;
        private System.Windows.Forms.ComboBox Language;
        private System.Windows.Forms.RadioButton DOM_button;
        private System.Windows.Forms.RadioButton SAX_button;
        private System.Windows.Forms.RadioButton LINQ_button;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Transform;
        private System.Windows.Forms.RichTextBox Text1;
        private System.Windows.Forms.CheckBox checkBox_Name;
        private System.Windows.Forms.CheckBox checkBox_BookShop;
        private System.Windows.Forms.ComboBox BookShop;
    }
}

