using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace SafariParkApp
{
    public class Vehicle
    {
        private int _capacity;
        private int _numPassengers;

        public int NumPassengers
        {
            get { return _numPassengers; }
            set
            {
                if (_numPassengers > _capacity || _numPassengers < 0)
                {
                    throw new ArgumentException("Number of passengers cannot be zero or above capacity");
                }
                else
                {
                    _numPassengers = value;
                }
            }
        }

        public int Position
        {
            get;
            private set;
        } = 0;

        public int Speed
        {
            get;
            init;
        } = 10;

        public string Move()
        {
            Position += Speed;
            return "Moving along";
        }

        public string Move(int times)
        {
            Position = Speed * times;
            return $"Moving along {times} times";
        }
        public Vehicle()
        {

        }
        public Vehicle(int capacity, int speed = 10)
        {
            _capacity = capacity;
            Speed = speed;

        }
    }
}