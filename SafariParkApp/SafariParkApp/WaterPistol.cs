using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SafariParkApp
{
    public class WaterPistol : Weapon , IShootable //inherits weapon class
    {
        public override string Shoot() { return $"{base.Shoot()} Spprrrrt!! "; }

        public  WaterPistol(string brand) : base(brand) {}

    }
}
//type of weapon