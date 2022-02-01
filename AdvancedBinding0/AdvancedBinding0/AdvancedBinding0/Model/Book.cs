using System;
using System.Collections.Generic;
using System.Text;

namespace AdvancedBinding0.Model
{
    public class Book
    {
        public string Name { get; set; }
        public string Author { get; set; }

    }

    public class BookStore
    {
        public string StoreName { get; set; }
        public List<Book> Books { get; set; }
        public BookStore()
        {
            StoreName="Jesse's Books";
            var booksInStock = new List<Book>
        {
           new Book
           {
                Name="The Sound And The Fury",
                Author="Faulkner",
           },
            new Book
            {
                Name = "The Time Of Our Singing",
                Author = "Powers",
            },


            new Book
            {
                Name= "In Search of Lost Time",
                Author="Proust",

            }

        };

            Books=booksInStock;
        }
    }
}
