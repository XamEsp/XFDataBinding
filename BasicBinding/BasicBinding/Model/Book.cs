using System;
using System.Collections.Generic;

namespace BasicBinding.Model
{
    public class Book
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public DateTime PublicationDate { get; set; }
        
    }

    public class BookStore
    {
        public string StoreName { get; set; }
        public List<Book> Books { get; set;}
        public void Setup()
        {
            StoreName="Jesse's Books";
            var booksInStock = new List<Book>
            {
               new Book
               {
                    Name="The Sound And The Fury",
                    Author="Faulkner",
                    PublicationDate=new DateTime(1918, 01, 01)
               },
                new Book
                {
                    Name = "The Time Of Our Singing",
                    Author = "Powers",
                    PublicationDate = new DateTime(2014,2,2)
                },

                new Book
                {
                    Name= "In Search of Lost Time",
                    Author="Proust",
                    PublicationDate = new DateTime(1920,3,3)

                }

            };

          Books = booksInStock;
        }
    }

}
