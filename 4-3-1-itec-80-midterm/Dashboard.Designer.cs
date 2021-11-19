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
            this.components = new System.ComponentModel.Container();
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
            this.updateBook = new System.Windows.Forms.Button();
            this.archiveBook = new System.Windows.Forms.Button();
            this.addBook = new System.Windows.Forms.Button();
            this.filter = new System.Windows.Forms.Button();
            this.keyword = new System.Windows.Forms.TextBox();
            this.books = new System.Windows.Forms.DataGridView();
            this.selection = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.isbn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.available = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.circulation = new System.Windows.Forms.TabPage();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.menu.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.inventory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.books)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
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
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.inventory);
            this.tabControl.Controls.Add(this.circulation);
            this.tabControl.Location = new System.Drawing.Point(12, 27);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(776, 411);
            this.tabControl.TabIndex = 1;
            // 
            // inventory
            // 
            this.inventory.Controls.Add(this.updateBook);
            this.inventory.Controls.Add(this.archiveBook);
            this.inventory.Controls.Add(this.addBook);
            this.inventory.Controls.Add(this.filter);
            this.inventory.Controls.Add(this.keyword);
            this.inventory.Controls.Add(this.books);
            this.inventory.Location = new System.Drawing.Point(4, 24);
            this.inventory.Name = "inventory";
            this.inventory.Padding = new System.Windows.Forms.Padding(3);
            this.inventory.Size = new System.Drawing.Size(768, 383);
            this.inventory.TabIndex = 0;
            this.inventory.Text = "Inventory";
            this.inventory.UseVisualStyleBackColor = true;
            // 
            // updateBook
            // 
            this.updateBook.Location = new System.Drawing.Point(123, 337);
            this.updateBook.Name = "updateBook";
            this.updateBook.Size = new System.Drawing.Size(111, 40);
            this.updateBook.TabIndex = 5;
            this.updateBook.Text = "Update";
            this.updateBook.UseVisualStyleBackColor = true;
            this.updateBook.Click += new System.EventHandler(this.UpdateBook);
            // 
            // archiveBook
            // 
            this.archiveBook.Location = new System.Drawing.Point(6, 337);
            this.archiveBook.Name = "archiveBook";
            this.archiveBook.Size = new System.Drawing.Size(111, 40);
            this.archiveBook.TabIndex = 4;
            this.archiveBook.Text = "Archive";
            this.archiveBook.UseVisualStyleBackColor = true;
            this.archiveBook.Click += new System.EventHandler(this.ArchiveBook);
            // 
            // addBook
            // 
            this.addBook.Location = new System.Drawing.Point(240, 337);
            this.addBook.Name = "addBook";
            this.addBook.Size = new System.Drawing.Size(522, 40);
            this.addBook.TabIndex = 3;
            this.addBook.Text = "Add";
            this.addBook.UseVisualStyleBackColor = true;
            this.addBook.Click += new System.EventHandler(this.AddBook);
            // 
            // filter
            // 
            this.filter.Location = new System.Drawing.Point(687, 6);
            this.filter.Name = "filter";
            this.filter.Size = new System.Drawing.Size(75, 23);
            this.filter.TabIndex = 2;
            this.filter.Text = "Filter";
            this.filter.UseVisualStyleBackColor = true;
            this.filter.Click += new System.EventHandler(this.Filter);
            // 
            // keyword
            // 
            this.keyword.Location = new System.Drawing.Point(6, 6);
            this.keyword.Name = "keyword";
            this.keyword.PlaceholderText = "Keyword(s)";
            this.keyword.Size = new System.Drawing.Size(675, 23);
            this.keyword.TabIndex = 1;
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
            this.selection,
            this.isbn,
            this.title,
            this.author,
            this.available});
            this.books.Location = new System.Drawing.Point(6, 35);
            this.books.Name = "books";
            this.books.RowHeadersVisible = false;
            this.books.RowTemplate.Height = 25;
            this.books.Size = new System.Drawing.Size(756, 296);
            this.books.TabIndex = 0;
            // 
            // selection
            // 
            this.selection.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.selection.FalseValue = "0";
            this.selection.HeaderText = "Selection";
            this.selection.IndeterminateValue = "2";
            this.selection.Name = "selection";
            this.selection.TrueValue = "1";
            this.selection.Width = 61;
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
            // circulation
            // 
            this.circulation.Location = new System.Drawing.Point(4, 24);
            this.circulation.Name = "circulation";
            this.circulation.Padding = new System.Windows.Forms.Padding(3);
            this.circulation.Size = new System.Drawing.Size(768, 383);
            this.circulation.TabIndex = 1;
            this.circulation.Text = "Circulation";
            this.circulation.UseVisualStyleBackColor = true;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(_4_3_1_itec_80_midterm.User);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simple Library Management System";
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.inventory.ResumeLayout(false);
            this.inventory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.books)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
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
        private TabPage circulation;
        private DataGridView books;
        private BindingSource userBindingSource;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
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
        private DataGridViewCheckBoxColumn selection;
        private DataGridViewTextBoxColumn isbn;
        private DataGridViewTextBoxColumn title;
        private DataGridViewTextBoxColumn author;
        private DataGridViewCheckBoxColumn available;
    }
}