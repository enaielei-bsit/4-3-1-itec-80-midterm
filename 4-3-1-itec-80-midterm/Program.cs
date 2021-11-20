namespace _4_3_1_itec_80_midterm
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Database.users.Add(new User("admin", "admin"));

            Database.books.Add(new Book("1234567890", "Book 1"));
            Database.books.Add(new Book("1334567890", "Book 2", "Mike", "Sarah"));
            Database.books.Add(new Book("5334567890", "Book 3"));
            Database.books.Add(new Book("1339567890", "Book 4"));
            Database.books.Add(new Book("1339567990", "Book 5", "Jessica", "Nicole"));

            Database.borrowers.Add(new Borrower("john@email.com", "John", "Manaloto"));
            Database.borrowers.Add(new Borrower("elena@email.com", "Elena", "Strikes"));

            ApplicationConfiguration.Initialize();
            Session.signIn = new SignIn();
            Session.dashboard = new Dashboard();
            Session.addBook = new AddBook();
            Session.updateBook = new UpdateBook();
            Session.addBorrower = new AddBorrower();
            Session.updateBorrower = new UpdateBorrower();
            Session.borrow = new Borrow();
            Session.lending = new Lending();

            Session.dashboard.Hide();
            Session.addBook.Hide();
            Session.updateBook.Hide();
            Session.addBorrower.Hide();
            Session.updateBorrower.Hide();
            Session.borrow.Hide();
            Session.lending.Hide();

            Application.Run(Session.signIn);
        }
    }
}