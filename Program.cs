using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryManagementSystem;

static class Program
{
    [STAThread]
    static void Main()
    {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        Application.Run(new Form1());
    }
}

// LibraryManagementSystem namespace
namespace LibraryManagementSystem
{
    // Enum representing the status of a book
    public enum BookStatus
    {
        Available,  // Book is available for borrowing
        Borrowed    // Book is currently borrowed by a member
    }

    // Abstract class representing common properties of library items
    public abstract class LibraryItem
    {
        public string Title { get; set; }   // Title of the library item
        public string Author { get; set; }  // Author of the library item
    }

    // Concrete class representing a book, inheriting from LibraryItem
    public class Book : LibraryItem
    {
        public string ISBN { get; set; }           // ISBN (International Standard Book Number) of the book
        public BookStatus Status { get; set; }     // Status of the book (Available or Borrowed)
        public Member Borrower { get; set; }       // Member who borrowed the book

        // Constructors
        public Book(string title, string author, string isbn)
        {
            Title = title;
            Author = author;
            ISBN = isbn;
            Status = BookStatus.Available;
            Borrower = null;
        }

        public Book(string title, string author) : this(title, author, "Unknown") { }

        // Overriding method to customize the string representation of the book
        public override string ToString()
        {
            return $"{Title} by {Author} /  {ISBN}, {Status}";
        }
    }

    // Builder class for creating Book objects
    public class BookBuilder
    {
        private Book _book;

        public BookBuilder()
        {
            _book = new Book(null, null);
        }

        public BookBuilder WithTitle(string title)
        {
            _book.Title = title;
            return this;
        }

        public BookBuilder WithAuthor(string author)
        {
            _book.Author = author;
            return this;
        }

        public BookBuilder WithISBN(string isbn)
        {
            _book.ISBN = isbn;
            return this;
        }

        public Book Build()
        {
            return _book;
        }
    }

    // Interface defining the contract for library members
    public interface IMember
    {
        string Name { get; set; }            // Name of the member
        List<Book> BorrowedBooks { get; set; }  // List of books borrowed by the member

        void BorrowBook(Book book);          // Method to borrow a book
        void ReturnBook(Book book);          // Method to return a borrowed book
    }

    // Concrete class representing a library member, implementing IMember interface
    public class Member : IMember
    {
        public string Name { get; set; }              // Name of the member
        public List<Book> BorrowedBooks { get; set; }  // List of books borrowed by the member

        // Constructor
        public Member(string name)
        {
            Name = name;
            BorrowedBooks = new List<Book>();
        }

        // Override ToString to customize the display of the member
        public override string ToString() => Name;

        // Methods
        public void BorrowBook(Book book)
        {
            // Check if the book is available
            if (book.Status == BookStatus.Available)
            {
                MessageBox.Show($"Borrowing book: {book.Title}, Status: {book.Status}");
                book.Status = BookStatus.Borrowed;
                book.Borrower = this;
                BorrowedBooks.Add(book);
                MessageBox.Show($"Book borrowed successfully. New status: {book.Status}");
            }
            else
            {
                MessageBox.Show($"{book.Title} is not available for borrowing. Come back later!");
            }
        }

        public void ReturnBook(Book book)
        {
            // Check if the member borrowed the book and it's marked as borrowed
            if (book.Status == BookStatus.Borrowed && book.Borrower == this)
            {
                book.Status = BookStatus.Available;
                book.Borrower = null;
                BorrowedBooks.Remove(book);
            }
        }
    }

    // Library class with Singleton pattern
    public class Library
    {
        private static Library _instance;   // Singleton instance of the Library class

        // Singleton property to access the instance
        public static Library Instance => _instance ?? (_instance = new Library());

        public List<Book> Books { get; set; }      // List of books in the library
        public List<IMember> Members { get; set; }  // List of library members

        // Private constructor to enforce Singleton pattern
        private Library()
        {
            Books = new List<Book>();
            Members = new List<IMember>();
        }

        // Methods for adding/removing books and members
        public void AddBook(Book book) => Books.Add(book);

        public void AddBook(string title, string author, string isbn)
        {
            var book = new BookBuilder()
                .WithTitle(title)
                .WithAuthor(author)
                .WithISBN(isbn)
                .Build();

            Books.Add(book);
        }

        public void RemoveBook(Book book)
        {
            // Remove the book only if it's not currently borrowed
            if (book.Status != BookStatus.Borrowed)
                Books.Remove(book);
        }

        public void AddMember(IMember member) => Members.Add(member);

        public void RemoveMember(IMember member) => Members.Remove(member);
    }

    // Concrete class representing a library facade
    public class LibraryFacade
    {
        private Library library;

        public LibraryFacade(Library library)
        {
            this.library = library;
        }

        public void BorrowBook(string memberName, string bookTitle)
        {
            Member member = (Member)library.Members.Find(m => m.Name == memberName);
            Book book = library.Books.Find(b => b.Title == bookTitle);

            if (member != null && book != null)
            {
                member.BorrowBook(book);
            }
        }
    }
}
