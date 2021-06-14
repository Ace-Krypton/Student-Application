using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApplication
{
    class Student
    {
        //Properties
        public string Name { get; set; }
        public string Surname { get; set; }

        //Fields
        private static int _id = 0; //Unique ID
        public readonly int ID; //Unique ID

        //Empty constructor
        public Student()
        {
            _id++;
            ID = _id;
        }

        //Constructor with 2 parametres
        public Student(string name, string surname) : this()
        {
            Name = name;
            Surname = surname;
        }

        //ToString() method that returns Name and Surname
        public override string ToString()
        {
            return $"Name: {Name} Surname: {Surname} ID: {ID}";
        }
    }
}
