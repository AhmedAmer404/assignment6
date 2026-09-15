using System;
using System.Reflection;

namespace assignment6
{
    class Book
    {
        private string password = "secret";
        internal int copiesInStock = 5;

    
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

        }
    }
}
