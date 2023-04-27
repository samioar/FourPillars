using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace SafariParkApp
{
    public class Vehicle : Imovable
    {
        private int _capacity;
        private int _numPassengers;
        private int _position;

        public int Position { get; private set; }
        public int Speed { get; init; }
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
        public Vehicle(int capacity)
        {
            _capacity = capacity;
        }

        public int Capacity
        {
            get { return _capacity; }
            set { _capacity = value; }
        }
        protected int Distance
        {
            get { return _position; }
            set { _position = value; }
        }

        public virtual string Move()
        {
            Position += Speed;
            return "Moving along";
        }

        public virtual string Move(int times)
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