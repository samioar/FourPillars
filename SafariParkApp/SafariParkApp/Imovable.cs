using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariParkApp
{
    public interface Imovable 
    {
        string Move();
        string Move(int times);
    }

    public interface IShootable
    {
        string Shoot();
      
    }
}
