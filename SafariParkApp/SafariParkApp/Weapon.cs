using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace SafariParkApp
{
    public abstract class Weapon :IShootable
    {
        private string _brand;

        public Weapon(string brand)
        {
            _brand = brand;
        }

        public virtual string Shoot()
        {
            return $"has exercised their 2nd ammendment right and fired his {_brand}";
        }

        //public override string ToString()
        //{
        //    return base.ToString();
        //}
        

    }
}