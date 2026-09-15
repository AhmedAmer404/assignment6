using System;
using System.Reflection;

namespace assignment6
{
    enum Genre
    {
        Fiction,
        NonFiction,
        Science
        
    }
    class Book
    {
        private string password = "secret";
        internal int copiesInStock = 5;

        public string Title;

        public Genre Genre;



    }

    class program
    {
        static void Main(string[] args)
        {
            Book book = new Book();
            #region Question 1
            Console.WriteLine("Book object created.");
            // Error private access modifiers can be accessed only within the class
            #endregion

            #region Question 2
            Console.WriteLine(book.copiesInStock);
            // This will print 5 internal member and can be accessed within the same Project
            #endregion

            #region Question 3
            book .Title = "C# Programming";
            Console.WriteLine(book.Title);
            // This will print "C# Programming" public member can be accessed from anywhere
            #endregion

            #region Question 4
            book.Genre = Genre.Science;
            Console.WriteLine(book.Genre);
            #endregion



        }
    }
}
