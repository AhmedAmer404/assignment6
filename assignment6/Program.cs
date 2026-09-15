using System;

namespace assignment6
{
    class Book
    {
        private string password = "secret";
    
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

        }
    }
}
