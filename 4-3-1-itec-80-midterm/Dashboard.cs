namespace _4_3_1_itec_80_midterm
{
    public partial class Dashboard : Form
    {
        public virtual DataGridView[] tables => new DataGridView[] {
            books
        };
        public virtual DataGridView activeTable => tables[tabControl.SelectedIndex];
        public virtual IEnumerable<DataGridViewRow> selectedRows
        {
            get
            {
                var rows = new List<DataGridViewRow>();
                if (activeTable != null)
                {
                    foreach (DataGridViewRow row in activeTable.Rows)
                    {
                        if (row.Cells[0].Value == "1") rows.Add(row);
                    }
                }
                return rows;
            }
        }

        public Dashboard()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void SignOut(object sender, EventArgs e)
        {
            Session.user = null;
            Hide();
            ResetText();
            Session.signIn.Reset();
            Session.signIn.Show();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            Refresh();
        }

        public virtual void RefreshBooks()
        {
            books.Rows.Clear();
            foreach (var book in Database.books)
            {
                int index = books.Rows.Add(
                    false,
                    book.isbn,
                    book.title,
                    string.Join("; ", book.authors),
                    true
                );
            }
        }

        public virtual void Refresh()
        {
            RefreshBooks();
        }

        private void Refresh(object sender, EventArgs e)
        {
            Refresh();
        }

        private void SelectAll(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in activeTable.Rows)
                {
                    row.Cells[0].Value = "1";
                }
            }
            catch { }
        }

        private void InvertSelection(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in activeTable.Rows)
                {
                    string value = row.Cells[0].Value == "0" ? "1" : "0";
                    row.Cells[0].Value = value;
                }
            }
            catch { }
        }

        private void ClearSelection(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in activeTable.Rows)
                {
                    row.Cells[0].Value = "0";
                }
            }
            catch { }
        }

        private void AddBook(object sender, EventArgs e)
        {
            Session.addBook.Reset();
            Session.addBook.ShowDialog();
        }

        private void Filter(object sender, EventArgs e) => Filter();

        protected virtual void Filter()
        {
            string[] keywords = keyword.Text != null ? keyword.Text.Trim().ToLower().Split(' ') : new string[] { };
            if (keywords.Length == 0 || keywords.All((k) => k.Length == 0))
            {
                Refresh();
                return;
            }

            foreach (DataGridViewRow row in activeTable.Rows)
            {
                var cells = new List<DataGridViewCell>();
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Visible) cells.Add(cell);
                }
                row.Visible = false;

                foreach (var cell in cells)
                {
                    cell.Selected = false;

                    if (cell.Value != null)
                    {
                        var cellKeywords = cell.Value.ToString().Trim().ToLower().Split(' ');
                        if (cellKeywords.Length == 0) continue;
                        foreach (string keyword in keywords)
                        {
                            if (cellKeywords.Contains(keyword))
                            {
                                cell.Selected = true;
                                row.Visible = true;
                                break;
                            }
                        }
                    }
                }
            }
        }

        private void ArchiveBook(object sender, EventArgs e)
        {
            var books = selectedRows.Select((r) =>
                Database.books.Find((b) => b.isbn == r.Cells[1].Value.ToString()))
                .Where((b) => b != null);
            if (books.Count() == 0) return;
            int count = books.Count();
            foreach (var book in books)
            {
                Database.books.Remove(book);
                Database.archivedBooks.Add(book);
            }

            MessageBox.Show(
                $"Successfully archived {count} book(s)!", "Prompt",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            RefreshBooks();
        }

        private void UpdateBook(object sender, EventArgs e)
        {
            var books = selectedRows.Select((r) =>
                Database.books.Find((b) => b.isbn == r.Cells[1].Value.ToString()))
                .Where((b) => b != null);
            if (books.Count() == 0) return;
            foreach (var book in books)
            {
                Session.updateBook.ShowDialog(book.isbn);
            }
        }
    }
}