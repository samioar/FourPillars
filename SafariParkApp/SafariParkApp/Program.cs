using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace SafariParkApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            //    //Person joe = new("Joe", "McCann", 40);
            //    //Console.WriteLine(joe.FullName);

            //    //Person nish = new("Nish", "Mandal",70);
            //    //Console.WriteLine(nish.FullName);

            //    //Person martin = new("Martin");
            //    //Console.WriteLine(martin.FullName);

            //    //martin.Age = 22;
            //    //Console.WriteLine(martin.Age);
            //    //var alex = new Person("Alexander", "Blunt") { Age = 31 };
            //    //var list = new ShoppingList() { Bread = 2, Potato = 6, Milk = 2 };

            //    Point3D p = new Point3D(3, 6, 2);
            //    var p2 = new Point3D();
            //    Point3D p3;
            //    Point3D p4 = new Point3D(1, 7);

            //    Person akito = new Person("Akito", "Oyama") {Age= 20};
            //    Point3D pt3D= new Point3D(5, 8,2);
            //    DemoMethod(pt3D, akito);
            //}
            //static void DemoMethod(Point3D pt, Person p)
            //{
            //    pt.y = 1000;
            //    p.Age = 92;

            //Airplane a = new Airplane(200, 100, "JetsRUs"){ NumPassengers = 150}; 
            //a.Ascend(500); 
            //Console.WriteLine(a.Move(3));
            //Console.WriteLine(a); a.Descend(200); 
            //Console.WriteLine(a.Move()); 
            //a.Move();
            //Console.WriteLine(a);

            //    List<Object> gameObjects = new List<Object>()
            //    {
            //        new Person("Cathy","French"),
            //        new Hunter ("Stephano","Naressi", "iPhone13")
            //    };
            //    foreach (var gameObj in gameObjects)
            //    {
            //        Console.WriteLine(gameObj);
            //    }

            //    Person yolonda = new Person("Yolonda", "Young");
            //    SpartaWrite(yolonda);
            //}
            //public static void SpartaWrite(object obj)
            //{
            //    Console.WriteLine(obj.ToString());
            //    if (obj is Hunter)
            //    {
            //        var hunterObj = (Hunter)obj;
            //        Console.WriteLine(hunterObj.Shoot);
            //    }

            //List<Object> PeopleThatWalk = new List<Object>()
            //    {
            //        new Person("Cathy","French"),
            //        new Vehicle(100, 10),
            //        new Hunter("Stephano", "Naressi")
            //    };
            //foreach (var imObg in PeopleThatWalk)
            //{
            //    Console.WriteLine(imObg.Move(5));
            //}


            //List<Weapon> Weapon = new List<Weapon>()
            //{
            //    new LaserGun(),
            //    new WaterPistol()
            //};
            //foreach( var gun in Weapon)
            //{
            //    gun.Shoot();
            //}
            //List<Hunter> Hunters = new List<Hunter>()
            //{ new Hunter("Samiur", "Rahman", Shooter)

            // };

            //List<Ishootable> Guns = new List<Ishootable>() 
            //{ new LaserGun("random brand"), 
            // new WaterPistol("other random brand") };
            //foreach (var gun in Guns)
            //{
            //    Console.WriteLine(gun.Shoot());
            //}

            Console.WriteLine("Polymorphic Shootout!!!!! START!");
            Camera pentax = new Camera("Kodak");
            WaterPistol pistol = new WaterPistol("SuperSoaker");
            LaserGun laserGun = new LaserGun("Rail Gun");
            Hunter nish = new Hunter("Nish", "Mandal", pentax);
            Console.WriteLine(nish.Shoot());
            nish.Shooter = pistol;
            Console.WriteLine(nish.Shoot());
            nish.Shooter = laserGun;
            Console.WriteLine(nish.Shoot());
            nish.Shooter = pistol;
            Console.WriteLine(nish.Shoot());
        }
    }
}
    
