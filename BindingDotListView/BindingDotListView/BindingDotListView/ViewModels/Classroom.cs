using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace BindingDotListView.ViewModels
{
    internal class Classroom
    {
        public string Name { get; set; }
        public ObservableCollection<Student> Students { get; set; }

        public Classroom()
        {
            CreateStudents();
        }

        public void CreateStudents()
        {
                ObservableCollection<Student> Kids = new ObservableCollection<Student>
                {
                    new Student
                    {
                        Name =  "John"
                    },
                    new Student
                    {
                        Name = "Paul"
                    },
                    new Student
                    {
                        Name = "George"
                    },
                    new Student
                    {
                        Name = "Ringo"
                    }
                };
            Students=Kids;
        }
    }
}
