using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SafariParkApp
{
    public class Person : IEquatable<Person?>, IComparable<Person>
    {
        public int CompareTo(Person? other)
        {
            if (other == null) return 1;
            if (LastName != other.LastName)
            {
                return LastName.CompareTo(other.LastName);
            }
            else if (FirstName != other.FirstName)
            {
                return FirstName.CompareTo(other.FirstName);
            } 
                else { return Age.CompareTo(other.Age); } 
        }
        private string FirstName { get; init; } = "Jonathan";
        private string LastName { get; init; } = "Doe";
        private int _age;
        public int distance;


        public override string ToString()
        {
            return $" Name: {FullName} Age : {Age}";
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as Person);
        }

        public bool Equals(Person? other)
        {
            return other is not null &&
                   FirstName == other.FirstName &&
                   LastName == other.LastName &&
                   _age == other._age &&
                   distance == other.distance &&
                   Age == other.Age &&
                   FullName == other.FullName;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(FirstName, LastName, _age, distance, Age, FullName);
        }

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

       

        //public bool Equals(Person? other)
        //{
        //    throw new NotImplementedException();
        //}

        public static bool operator == (Person left, Person right)
        {
            return EqualityComparer<Person>.Default.Equals(left, right);
        }

        public static bool operator !=(Person left, Person right)
        {
            return !(left == right);
        }


    }
}