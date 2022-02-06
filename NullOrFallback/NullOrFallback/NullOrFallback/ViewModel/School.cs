using System;
using System.Collections.Generic;
using System.Text;
using NullOrFallback.Model;

namespace NullOrFallback.ViewModel
{
    public class School
    {
        public List<Person> People { get; set; }

        public School()
        {
            try
            {
                var peeps = new List<Person>()
                {
                    new Person()
                    {
                        Name = "Marcel Proust",
                        Age = 55
                    },
                    new Person()
                    {
                        Name = "Maggie O'Farrell",
                        Age = null
                    },
                    new Student()
                    {
                        Name = "Richard Powers",
                        Age = 45,
                        SchoolName = "Harvard"
                    },
                    new Student()
                    {
                        Name = "James Joyce",
                        Age = 33,
                        SchoolName="Streets of Dublin"
                    },

                };
                People=peeps;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
         
        }
    }
}
