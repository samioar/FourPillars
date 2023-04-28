using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariParkApp
{
    public class Hunter : Person, IShootable 
    {
        public IShootable Shooter { get; set; }
        public Hunter(){} //default constructor
        public Hunter(string fName, string lName, IShootable cam) : base(fName, lName) 
        { Shooter = cam; }
        
        public string Shoot()
        {
            return $"{FullName} {Shooter.Shoot()}";
        }
        
    }
}











//public override string ToString()
//{
//    return $"{base.ToString()} Camera : {Shooter.Shoot()}";
//}