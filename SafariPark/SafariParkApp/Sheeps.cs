﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariParkApp
{
    public abstract class Shapes
    { 
        public abstract int CalculateArea();
        
    }

        public sealed class Rectangle : Shapes
    {
        private int _width;
        private int _height;

        public override int CalculateArea()
        {
            return _width * _height;
        }

        public Rectangle(int height, int width)
        {
 
            _width = width;
            _height = height;

        }
        public override string ToString()
        {
            return $"{base.ToString()} Area: {CalculateArea()}";
            //return $"{this.GetType} Area: {CalculateArea()}";
        }
    }

    
}
