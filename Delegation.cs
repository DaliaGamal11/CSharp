using static ConsoleApp_day9_.Program;

namespace ConsoleApp_day9_
{
    // Write Down the Body of all Listed Methods and Properties ,  
    public class Book
    {
        public string ISBN { get; set; }
        public string Title { get; set; }
        public string[] Authors { get; set; }
        public DateTime PublicationDate { get; set; }
        public decimal Price { get; set; }

        public Book(string _ISBN, string _Title, string[] _Authors, DateTime _PublicationDate, decimal _Price)
        {
            ISBN = _ISBN;
            Title = _Title;
            Authors = _Authors;
            PublicationDate = _PublicationDate;
            Price = _Price;
        }

        public override string ToString()
        {
            return $"ISBN: {ISBN}, Title: {Title}, Authors: {string.Join(", ", Authors)}, Published: {PublicationDate.ToShortDateString()}, Price: {Price:C}";
        }
    }

    public class BookFunctions
    {
        public static string GetTitle(Book B)
        {
            return B.Title;
        }

        public static string GetAuthors(Book B)
        {
            return string.Join(", ", B.Authors);
        }

        public static string GetPrice(Book B)
        {
            return B.Price.ToString("C");
        }
    }

    public class LibraryEngine
    {
        public static void ProcessBooks(List<Book> bList, Delegatte fPtr)
        {
            foreach (Book B in bList)
            {
                Console.WriteLine(fPtr(B));
            }
        }
        public static void ProcessBooks(List<Book> bList, Func<Book, string> fPtr)
        {
            foreach (Book B in bList)
            {
                Console.WriteLine(fPtr(B));
            }
        }
    }

    public delegate string Delegatte(Book b);// define delegate 

    class Program
    {
        static void Main()
        {
            List<Book> books = new List<Book>
        {
            new Book("123", "C# Basics", new[] { "Alice", "Bob" }, new DateTime(2020, 1, 1), 29.99m),
            new Book("456", "Advanced C#", new[] { "Charlie" }, new DateTime(2021, 5, 15), 49.99m),
        };

            //a. Using user-defined delegate
            Delegatte del1 = BookFunctions.GetTitle;
            LibraryEngine.ProcessBooks(books, del1);

            Console.WriteLine("\n---");

            // b. Using BCL delegate (Func<T, TResult>)
            Func<Book, string> del2 = BookFunctions.GetAuthors;
            LibraryEngine.ProcessBooks(books, del2);

            Console.WriteLine("\n---");

            // c. Anonymous method (for ISBN)
            Func<Book, string> del3 = delegate (Book b)
            {
                return b.ISBN;
            };
            LibraryEngine.ProcessBooks(books, del3);

            Console.WriteLine("\n---");

            // d. Lambda expression (for publication date)
            Func<Book, string> del4 = b => b.PublicationDate.ToShortDateString();
            LibraryEngine.ProcessBooks(books, del4);
        }
    }
}
