namespace _4_3_1_itec_80_midterm
{
    partial class Dashboard
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menu = new System.Windows.Forms.MenuStrip();
            this.account = new System.Windows.Forms.ToolStripMenuItem();
            this.signOut = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.selectionAll = new System.Windows.Forms.ToolStripMenuItem();
            this.selectionClear = new System.Windows.Forms.ToolStripMenuItem();
            this.selectionInvert = new System.Windows.Forms.ToolStripMenuItem();
            this.view = new System.Windows.Forms.ToolStripMenuItem();
            this.refresh = new System.Windows.Forms.ToolStripMenuItem();
            this.help = new System.Windows.Forms.ToolStripMenuItem();
            this.about = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.inventory = new System.Windows.Forms.TabPage();
            this.books = new System.Windows.Forms.DataGridView();
            this.selectionBook = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.isbn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.available = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.borrowBook = new System.Windows.Forms.Button();
            this.updateBook = new System.Windows.Forms.Button();
            this.archiveBook = new System.Windows.Forms.Button();
            this.addBook = new System.Windows.Forms.Button();
            this.borrowersTab = new System.Windows.Forms.TabPage();
            this.borrowers = new System.Windows.Forms.DataGridView();
            this.selectionBorrower = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borrowedBook = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updateBorrower = new System.Windows.Forms.Button();
            this.archiveBorrower = new System.Windows.Forms.Button();
            this.addBorrower = new System.Windows.Forms.Button();
            this.circulation = new System.Windows.Forms.TabPage();
            this.viewCirculation = new System.Windows.Forms.Button();
            this.returnCirculation = new System.Windows.Forms.Button();
            this.circulations = new System.Windows.Forms.DataGridView();
            this.selectionCirculation = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.book = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borrower = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateBorrowed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateReturned = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filter = new System.Windows.Forms.Button();
            this.keyword = new System.Windows.Forms.TextBox();
            this.menu.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.inventory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.books)).BeginInit();
            this.borrowersTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.borrowers)).BeginInit();
            this.circulation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.circulations)).BeginInit();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.account,
            this.toolStripMenuItem1,
            this.view,
            this.help});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(800, 24);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            // 
            // account
            // 
            this.account.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.signOut});
            this.account.Name = "account";
            this.account.Size = new System.Drawing.Size(64, 20);
            this.account.Text = "Account";
            // 
            // signOut
            // 
            this.signOut.Name = "signOut";
            this.signOut.Size = new System.Drawing.Size(118, 22);
            this.signOut.Text = "Sign out";
            this.signOut.Click += new System.EventHandler(this.SignOut);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(39, 20);
            this.toolStripMenuItem1.Text = "Edit";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectionAll,
            this.selectionClear,
            this.selectionInvert});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(122, 22);
            this.toolStripMenuItem2.Text = "Selection";
            // 
            // selectionAll
            // 
            this.selectionAll.Name = "selectionAll";
            this.selectionAll.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.selectionAll.Size = new System.Drawing.Size(141, 22);
            this.selectionAll.Text = "All";
            this.selectionAll.Click += new System.EventHandler(this.SelectAll);
            // 
            // selectionClear
            // 
            this.selectionClear.Name = "selectionClear";
            this.selectionClear.Size = new System.Drawing.Size(141, 22);
            this.selectionClear.Text = "Clear";
            this.selectionClear.Click += new System.EventHandler(this.ClearSelection);
            // 
            // selectionInvert
            // 
            this.selectionInvert.Name = "selectionInvert";
            this.selectionInvert.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.selectionInvert.Size = new System.Drawing.Size(141, 22);
            this.selectionInvert.Text = "Invert";
            this.selectionInvert.Click += new System.EventHandler(this.InvertSelection);
            // 
            // view
            // 
            this.view.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refresh});
            this.view.Name = "view";
            this.view.Size = new System.Drawing.Size(44, 20);
            this.view.Text = "View";
            // 
            // refresh
            // 
            this.refresh.Name = "refresh";
            this.refresh.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.refresh.Size = new System.Drawing.Size(132, 22);
            this.refresh.Text = "Refresh";
            this.refresh.Click += new System.EventHandler(this.Refresh);
            // 
            // help
            // 
            this.help.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.about});
            this.help.Name = "help";
            this.help.Size = new System.Drawing.Size(44, 20);
            this.help.Text = "Help";
            // 
            // about
            // 
            this.about.Name = "about";
            this.about.Size = new System.Drawing.Size(107, 22);
            this.about.Text = "About";
            this.about.Click += new System.EventHandler(this.About);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.inventory);
            this.tabControl.Controls.Add(this.borrowersTab);
            this.tabControl.Controls.Add(this.circulation);
            this.tabControl.Location = new System.Drawing.Point(12, 57);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(776, 381);
            this.tabControl.TabIndex = 1;
            // 
            // inventory
            // 
            this.inventory.Controls.Add(this.books);
            this.inventory.Controls.Add(this.borrowBook);
            this.inventory.Controls.Add(this.updateBook);
            this.inventory.Controls.Add(this.archiveBook);
            this.inventory.Controls.Add(this.addBook);
            this.inventory.Location = new System.Drawing.Point(4, 24);
            this.inventory.Name = "inventory";
            this.inventory.Padding = new System.Windows.Forms.Padding(3);
            this.inventory.Size = new System.Drawing.Size(768, 353);
            this.inventory.TabIndex = 0;
            this.inventory.Text = "Inventory";
            this.inventory.UseVisualStyleBackColor = true;
            // 
            // books
            // 
            this.books.AllowUserToAddRows = false;
            this.books.AllowUserToDeleteRows = false;
            this.books.AllowUserToOrderColumns = true;
            this.books.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.books.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.books.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.books.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.selectionBook,
            this.isbn,
            this.title,
            this.author,
            this.available});
            this.books.Location = new System.Drawing.Point(6, 6);
            this.books.Name = "books";
            this.books.RowHeadersVisible = false;
            this.books.RowTemplate.Height = 25;
            this.books.Size = new System.Drawing.Size(756, 296);
            this.books.TabIndex = 7;
            // 
            // selectionBook
            // 
            this.selectionBook.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.selectionBook.FalseValue = "0";
            this.selectionBook.HeaderText = "Selection";
            this.selectionBook.IndeterminateValue = "2";
            this.selectionBook.Name = "selectionBook";
            this.selectionBook.TrueValue = "1";
            this.selectionBook.Width = 61;
            // 
            // isbn
            // 
            this.isbn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.isbn.HeaderText = "ISBN";
            this.isbn.Name = "isbn";
            this.isbn.ReadOnly = true;
            this.isbn.Width = 231;
            // 
            // title
            // 
            this.title.HeaderText = "Title";
            this.title.Name = "title";
            this.title.ReadOnly = true;
            // 
            // author
            // 
            this.author.HeaderText = "Author(s)";
            this.author.Name = "author";
            this.author.ReadOnly = true;
            // 
            // available
            // 
            this.available.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.available.FalseValue = "0";
            this.available.HeaderText = "Available";
            this.available.IndeterminateValue = "2";
            this.available.Name = "available";
            this.available.ReadOnly = true;
            this.available.TrueValue = "1";
            this.available.Width = 61;
            // 
            // borrowBook
            // 
            this.borrowBook.Location = new System.Drawing.Point(238, 307);
            this.borrowBook.Name = "borrowBook";
            this.borrowBook.Size = new System.Drawing.Size(110, 40);
            this.borrowBook.TabIndex = 6;
            this.borrowBook.Text = "Borrow";
            this.borrowBook.UseVisualStyleBackColor = true;
            this.borrowBook.Click += new System.EventHandler(this.Borrow);
            // 
            // updateBook
            // 
            this.updateBook.Location = new System.Drawing.Point(122, 307);
            this.updateBook.Name = "updateBook";
            this.updateBook.Size = new System.Drawing.Size(110, 40);
            this.updateBook.TabIndex = 5;
            this.updateBook.Text = "Update";
            this.updateBook.UseVisualStyleBackColor = true;
            this.updateBook.Click += new System.EventHandler(this.UpdateBook);
            // 
            // archiveBook
            // 
            this.archiveBook.Location = new System.Drawing.Point(6, 307);
            this.archiveBook.Name = "archiveBook";
            this.archiveBook.Size = new System.Drawing.Size(110, 40);
            this.archiveBook.TabIndex = 4;
            this.archiveBook.Text = "Archive";
            this.archiveBook.UseVisualStyleBackColor = true;
            this.archiveBook.Click += new System.EventHandler(this.ArchiveBook);
            // 
            // addBook
            // 
            this.addBook.Location = new System.Drawing.Point(354, 307);
            this.addBook.Name = "addBook";
            this.addBook.Size = new System.Drawing.Size(408, 40);
            this.addBook.TabIndex = 3;
            this.addBook.Text = "Add";
            this.addBook.UseVisualStyleBackColor = true;
            this.addBook.Click += new System.EventHandler(this.AddBook);
            // 
            // borrowersTab
            // 
            this.borrowersTab.Controls.Add(this.borrowers);
            this.borrowersTab.Controls.Add(this.updateBorrower);
            this.borrowersTab.Controls.Add(this.archiveBorrower);
            this.borrowersTab.Controls.Add(this.addBorrower);
            this.borrowersTab.Location = new System.Drawing.Point(4, 24);
            this.borrowersTab.Name = "borrowersTab";
            this.borrowersTab.Padding = new System.Windows.Forms.Padding(3);
            this.borrowersTab.Size = new System.Drawing.Size(768, 353);
            this.borrowersTab.TabIndex = 1;
            this.borrowersTab.Text = "Borrowers";
            this.borrowersTab.UseVisualStyleBackColor = true;
            // 
            // borrowers
            // 
            this.borrowers.AllowUserToAddRows = false;
            this.borrowers.AllowUserToDeleteRows = false;
            this.borrowers.AllowUserToOrderColumns = true;
            this.borrowers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.borrowers.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.borrowers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.borrowers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.selectionBorrower,
            this.email,
            this.fullName,
            this.borrowedBook});
            this.borrowers.Location = new System.Drawing.Point(6, 6);
            this.borrowers.Name = "borrowers";
            this.borrowers.RowHeadersVisible = false;
            this.borrowers.RowTemplate.Height = 25;
            this.borrowers.Size = new System.Drawing.Size(756, 296);
            this.borrowers.TabIndex = 8;
            // 
            // selectionBorrower
            // 
            this.selectionBorrower.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.selectionBorrower.FalseValue = "0";
            this.selectionBorrower.HeaderText = "Selection";
            this.selectionBorrower.IndeterminateValue = "2";
            this.selectionBorrower.Name = "selectionBorrower";
            this.selectionBorrower.TrueValue = "1";
            this.selectionBorrower.Width = 61;
            // 
            // email
            // 
            this.email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            this.email.Width = 231;
            // 
            // fullName
            // 
            this.fullName.HeaderText = "Full Name";
            this.fullName.Name = "fullName";
            this.fullName.ReadOnly = true;
            // 
            // borrowedBook
            // 
            this.borrowedBook.HeaderText = "Borrowed Book(s)";
            this.borrowedBook.Name = "borrowedBook";
            this.borrowedBook.ReadOnly = true;
            // 
            // updateBorrower
            // 
            this.updateBorrower.Location = new System.Drawing.Point(122, 307);
            this.updateBorrower.Name = "updateBorrower";
            this.updateBorrower.Size = new System.Drawing.Size(110, 40);
            this.updateBorrower.TabIndex = 7;
            this.updateBorrower.Text = "Update";
            this.updateBorrower.UseVisualStyleBackColor = true;
            this.updateBorrower.Click += new System.EventHandler(this.UpdateBorrower);
            // 
            // archiveBorrower
            // 
            this.archiveBorrower.Location = new System.Drawing.Point(6, 307);
            this.archiveBorrower.Name = "archiveBorrower";
            this.archiveBorrower.Size = new System.Drawing.Size(110, 40);
            this.archiveBorrower.TabIndex = 6;
            this.archiveBorrower.Text = "Archive";
            this.archiveBorrower.UseVisualStyleBackColor = true;
            this.archiveBorrower.Click += new System.EventHandler(this.ArchiveBorrower);
            // 
            // addBorrower
            // 
            this.addBorrower.Location = new System.Drawing.Point(238, 307);
            this.addBorrower.Name = "addBorrower";
            this.addBorrower.Size = new System.Drawing.Size(524, 40);
            this.addBorrower.TabIndex = 4;
            this.addBorrower.Text = "Add";
            this.addBorrower.UseVisualStyleBackColor = true;
            this.addBorrower.Click += new System.EventHandler(this.AddBorrower);
            // 
            // circulation
            // 
            this.circulation.Controls.Add(this.viewCirculation);
            this.circulation.Controls.Add(this.returnCirculation);
            this.circulation.Controls.Add(this.circulations);
            this.circulation.Location = new System.Drawing.Point(4, 24);
            this.circulation.Name = "circulation";
            this.circulation.Padding = new System.Windows.Forms.Padding(3);
            this.circulation.Size = new System.Drawing.Size(768, 353);
            this.circulation.TabIndex = 2;
            this.circulation.Text = "Circulation";
            this.circulation.UseVisualStyleBackColor = true;
            // 
            // viewCirculation
            // 
            this.viewCirculation.Location = new System.Drawing.Point(6, 307);
            this.viewCirculation.Name = "viewCirculation";
            this.viewCirculation.Size = new System.Drawing.Size(110, 40);
            this.viewCirculation.TabIndex = 10;
            this.viewCirculation.Text = "View";
            this.viewCirculation.UseVisualStyleBackColor = true;
            this.viewCirculation.Click += new System.EventHandler(this.ViewCirculation);
            // 
            // returnCirculation
            // 
            this.returnCirculation.Location = new System.Drawing.Point(122, 307);
            this.returnCirculation.Name = "returnCirculation";
            this.returnCirculation.Size = new System.Drawing.Size(640, 40);
            this.returnCirculation.TabIndex = 9;
            this.returnCirculation.Text = "Return";
            this.returnCirculation.UseVisualStyleBackColor = true;
            this.returnCirculation.Click += new System.EventHandler(this.ReturnCirculation);
            // 
            // circulations
            // 
            this.circulations.AllowUserToAddRows = false;
            this.circulations.AllowUserToDeleteRows = false;
            this.circulations.AllowUserToOrderColumns = true;
            this.circulations.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.circulations.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.circulations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.circulations.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.selectionCirculation,
            this.id,
            this.book,
            this.borrower,
            this.dateBorrowed,
            this.dateReturned});
            this.circulations.Location = new System.Drawing.Point(6, 6);
            this.circulations.Name = "circulations";
            this.circulations.RowHeadersVisible = false;
            this.circulations.RowTemplate.Height = 25;
            this.circulations.Size = new System.Drawing.Size(756, 296);
            this.circulations.TabIndex = 8;
            // 
            // selectionCirculation
            // 
            this.selectionCirculation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.selectionCirculation.FalseValue = "0";
            this.selectionCirculation.HeaderText = "Selection";
            this.selectionCirculation.IndeterminateValue = "2";
            this.selectionCirculation.Name = "selectionCirculation";
            this.selectionCirculation.TrueValue = "1";
            this.selectionCirculation.Width = 61;
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // book
            // 
            this.book.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.book.HeaderText = "Book";
            this.book.Name = "book";
            this.book.ReadOnly = true;
            this.book.Width = 231;
            // 
            // borrower
            // 
            this.borrower.HeaderText = "Borrower";
            this.borrower.Name = "borrower";
            this.borrower.ReadOnly = true;
            // 
            // dateBorrowed
            // 
            this.dateBorrowed.HeaderText = "Date Borrowed";
            this.dateBorrowed.Name = "dateBorrowed";
            this.dateBorrowed.ReadOnly = true;
            // 
            // dateReturned
            // 
            this.dateReturned.HeaderText = "Data Returned";
            this.dateReturned.Name = "dateReturned";
            this.dateReturned.ReadOnly = true;
            // 
            // filter
            // 
            this.filter.Location = new System.Drawing.Point(713, 28);
            this.filter.Name = "filter";
            this.filter.Size = new System.Drawing.Size(71, 23);
            this.filter.TabIndex = 2;
            this.filter.Text = "Filter";
            this.filter.UseVisualStyleBackColor = true;
            this.filter.Click += new System.EventHandler(this.Filter);
            // 
            // keyword
            // 
            this.keyword.Location = new System.Drawing.Point(12, 28);
            this.keyword.Name = "keyword";
            this.keyword.PlaceholderText = "Keyword(s)";
            this.keyword.Size = new System.Drawing.Size(695, 23);
            this.keyword.TabIndex = 1;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.keyword);
            this.Controls.Add(this.filter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simple Library Management System";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ExitApplication);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.inventory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.books)).EndInit();
            this.borrowersTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.borrowers)).EndInit();
            this.circulation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.circulations)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menu;
        private ToolStripMenuItem account;
        private ToolStripMenuItem signOut;
        private ToolStripMenuItem help;
        private ToolStripMenuItem about;
        private TabControl tabControl;
        private TabPage inventory;
        private TabPage borrowersTab;
        private ToolStripMenuItem view;
        private ToolStripMenuItem refresh;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem selectionAll;
        private ToolStripMenuItem selectionClear;
        private ToolStripMenuItem selectionInvert;
        private Button filter;
        private TextBox keyword;
        private Button addBook;
        private Button updateBook;
        private Button archiveBook;
        private Button borrowBook;
        private Button updateBorrower;
        private Button archiveBorrower;
        private Button addBorrower;
        private DataGridView books;
        private DataGridView borrowers;
        private TabPage circulation;
        private DataGridView circulations;
        private DataGridViewCheckBoxColumn selectionBook;
        private DataGridViewTextBoxColumn isbn;
        private DataGridViewTextBoxColumn title;
        private DataGridViewTextBoxColumn author;
        private DataGridViewCheckBoxColumn available;
        private DataGridViewCheckBoxColumn selectionBorrower;
        private DataGridViewTextBoxColumn email;
        private DataGridViewTextBoxColumn fullName;
        private DataGridViewTextBoxColumn borrowedBook;
        private Button viewCirculation;
        private Button returnCirculation;
        private DataGridViewCheckBoxColumn selectionCirculation;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn book;
        private DataGridViewTextBoxColumn borrower;
        private DataGridViewTextBoxColumn dateBorrowed;
        private DataGridViewTextBoxColumn dateReturned;
    }
}