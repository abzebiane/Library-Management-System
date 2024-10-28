using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class Form1 : Form
    {
        private Library library;

        public Form1()
        {
            InitializeComponent();
            library = Library.Instance;

            // Manually add default books
            library.AddBook(new Book("The Great Gatsby", "F. Scott Fitzgerald", "978-3-16-148410-0"));
            library.AddBook(new Book("To Kill a Mockingbird", "Harper Lee", "978-0-06-112008-4"));
            library.AddBook(new Book("1984", "George Orwell", "978-0-452-28423-4"));

            // Manually add default members
            library.AddMember(new Member("Alice Johnson"));
            library.AddMember(new Member("Bob Smith"));
            library.AddMember(new Member("Charlie Brown"));

            // Ensure that data is updated in the ListBox controls
            UpdateBookList();
            UpdateMemberList();

            // Set the SelectedIndex property to -1 for lsteBooks
            lstBooks.SelectedIndex = -1;

            // Set the SelectedIndex property to -1 for lstMembers
            lstMembers.SelectedIndex = -1;
        }


        private void btnAddBook_Click(object sender, EventArgs e)
        {
            try
            {
                string title = txtTitle.Text;
                string author = txtAuthor.Text;
                string isbn = txtISBN.Text;

                if (string.IsNullOrWhiteSpace(title) || string.IsNullOrWhiteSpace(author))
                {
                    MessageBox.Show("No New BOOK Entered.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Book book = new Book(title, author, isbn);
                library.AddBook(book);

                UpdateBookList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRemoveBook_Click(object sender, EventArgs e)
        {
            Book book = (Book)lstBooks.SelectedItem;
            if (book.Status == BookStatus.Borrowed)
                // Get selected book from list
                MessageBox.Show("Book is currently borrowed. You cannot remove it!");

            else
                // Remove book from library
                library.RemoveBook(book);

            // Update book list display
            UpdateBookList();
        }

        private void btnAddMember_Click(object sender, EventArgs e)
        {
            // Get member name from text box
            string name = txtName.Text;

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("No New NAME Entered.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Create new member and add to library
            Member member = new Member(name);
            library.AddMember(member);

            // Update member list display
            UpdateMemberList();
        }

        private void btnRemoveMember_Click(object sender, EventArgs e)
        {
            // Get selected member from list
            Member member = (Member)lstMembers.SelectedItem;

            // Remove member from library
            library.RemoveMember(member);

            // Update member list display
            UpdateMemberList();
        }

        private void btnBorrowBook_Click(object sender, EventArgs e)
        {
            // Get selected book and member from lists
            Book book = (Book)lstBooks.SelectedItem;
            Member member = (Member)lstMembers.SelectedItem;

            // Check if book and member are not null
            if (book != null && member != null)
            {
                //MessageBox.Show($"Selected Book: {book.Title}, Selected Member: {member.Name}");

                LibraryFacade facade = new LibraryFacade(library);
                facade.BorrowBook(member.Name, book.Title);

                // Update book list display
                UpdateBookList();
                UpdateMemberList();
            }
            else
            {
                MessageBox.Show("Selected book or member is null.");
            }
        }

        private void btnReturnBook_Click(object sender, EventArgs e)
        {
            // Get selected book and member from lists
            Book book = (Book)lstBooks.SelectedItem;
            Member member = (Member)lstMembers.SelectedItem;

            // Check if book and member are not null
            if (book != null && member != null)
            {
                // Member returns book
                member.ReturnBook(book);

                // Update book list display
                UpdateBookList();
                UpdateMemberList();
            }
        }

        private void UpdateBookList()
        {
            lstBooks.DataSource = null;
            lstBooks.DataSource = library.Books;
            lstBooks.DisplayMember = "DisplayText"; // DisplayText property should be added to the Book class
        }

        private void UpdateMemberList()
        {
            lstMembers.DataSource = null;
            lstMembers.DataSource = library.Members;
            lstMembers.DisplayMember = "Name"; // Assuming Member class has a Name property
        }

        private void lstBooks_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Check if an item is selected
            if (lstBooks.SelectedItem != null)
            {
                Book selectedBook = (Book)lstBooks.SelectedItem;
                txtTitle.Text = selectedBook.Title;
                txtAuthor.Text = selectedBook.Author;
                txtISBN.Text = selectedBook.ISBN;
            }
            else
            {
                txtTitle.Text = string.Empty;
                txtAuthor.Text = string.Empty;
                txtISBN.Text = string.Empty;
            }
        }

        private void btnSummary_Click(object sender, EventArgs e)
        {
            StringBuilder summary = new StringBuilder();

            foreach (Member member in library.Members)
            {
                summary.AppendLine($"{member.Name}:");

                if (member.BorrowedBooks.Any())
                {
                    foreach (Book book in member.BorrowedBooks)
                    {
                        summary.AppendLine($"\t{book.Title}");
                    }
                }
                else
                {
                    summary.AppendLine("\tN/A");
                }
            }

            MessageBox.Show(summary.ToString(), "Member Borrowing Summary");
        }
    }
}
