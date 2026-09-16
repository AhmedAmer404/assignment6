using System;
using System.Reflection;

namespace assignment6
{

    #region Question 9
    public struct DeliveryAddress
    {
        public string City;
        public string Street;

        public int BuildingNumber;

       public DeliveryAddress(string city, string street, int buildingNumber)
        {
            City = city;
            Street = street;
            BuildingNumber = buildingNumber;
        }

        public String GetFullAddress()
        {
            return $"{Street} {BuildingNumber}, {City}";
        }

    }
    #endregion
    #region Question 10
    public struct Shipment
    {
        private string trackingCode;
        private string description;

        private double weight;

        private decimal deliveryFee;

        public DeliveryAddress Destination
        {
            get;
            set;
        }

        public string TrackingCode
        {
            get
            {
                return trackingCode;
            }
            private set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    trackingCode = value;
                }

            }
        }
        public string Description
        {
            get
            {
                return description;

            }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    description = value;
                }

            }

        }
        public double Weight
        {
            get
            {
                return weight;
            }
            set
            {
                if (value > 0)
                {
                    weight = value;
                }
            }
        }
        public decimal DeliveryFee
        {
            get
            {
                return deliveryFee;
            }
            private set
            {
                if (value > 0)
                {
                    deliveryFee = value;
                }
            }
        }
        public double EstimatedCost
        {
            get
            {
                return 5 * Weight + (double)DeliveryFee;
            }
        }
        public Shipment(string trackingCode)
        {
            this.trackingCode = "Unknown";
            this.description = "Unknown";
            this.weight = 1;
            this.deliveryFee = 50;
            Destination = new DeliveryAddress();
        }
        public Shipment(string trackingCode, string description, double weight, decimal deliveryFee, DeliveryAddress destination)
        {
            this.trackingCode = "Unknown";
            this.description = "Unknown";
            this.weight = 1;
            this.deliveryFee = 50;
            Destination = destination;

            TrackingCode = trackingCode;
            Description = description;
            Weight = weight;
            DeliveryFee = deliveryFee;
            Destination = destination;
        }
        public void UpdateDeliveryFee(decimal newFee)
        {
            if (newFee > 0)
            {
                DeliveryFee = newFee;
            }
        }
        public void PrintShipment()
        {
            
            Console.WriteLine($"Tracking Code : {TrackingCode}");
            Console.WriteLine($"Description   : {Description}");
            Console.WriteLine($"Weight        : {Weight}");
            Console.WriteLine($"Delivery Fee  : {DeliveryFee}");
            Console.WriteLine($"Destination   : {Destination.GetFullAddress()}");
            Console.WriteLine($"Estimated Cost: {EstimatedCost}");
            
        }
    }
    #endregion
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

            #region Question 5
            Console.WriteLine((int)Genre.Fiction);
            Console.WriteLine((int)Genre.NonFiction);
            Console.WriteLine((int)Genre.Science);
            #endregion

            #region Question 6
            int genreNumber = 1;
            Genre genre = (Genre)genreNumber;
            Console.WriteLine(genre);
            #endregion

            #region Question 7
            string genreText = "Science";
            Genre genre1 = Enum.Parse<Genre>(genreText);
            Console.WriteLine(genre1);
            #endregion

            #region Question 8
            string genreText2 = "Mystery";
            if (Enum.TryParse<Genre>(genreText2, out Genre genre2))
            {
                Console.WriteLine(genre2);
            }
            else
            {
                Console.WriteLine("Unknown genre");
            }
            #endregion

            #region Question 9

            DeliveryAddress address1 = new DeliveryAddress("Egypt", "AboElaraby", 49);

            DeliveryAddress address2 = address1;

            address2.City = "USA";
            address2.BuildingNumber = 78;

            Console.WriteLine(address1.GetFullAddress());
            Console.WriteLine(address2.GetFullAddress());

            #endregion





        }
    }
}
