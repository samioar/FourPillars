using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SafariParkApp
{
    public class Person : Vehicle
    {
        private string FirstName { get; init; } = "";
        private string LastName { get; init; } = "";
        private int _age;
        public int distance;
       
        
            
        public int Age 
        {
            get { return _age; }
            set
            {
                if (value < 0 || value > 99) throw new ArgumentException();
                _age = value;
            }
        }
        public Person()
        {

        }
        public Person(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }
        public Person(string firstName)
        {
            FirstName = firstName;
        }

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            
        }

        public string FullName => $"{FirstName} {LastName}";
    }
}