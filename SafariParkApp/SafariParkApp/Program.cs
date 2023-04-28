using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace SafariParkApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            //fix watch recording

            var helen = new Person("Helen", "Troy", 22);
            var will = new Hunter("William", "Shakespeare"); //fix

            Console.WriteLine("List of people");
            List<Person> thePeople = new List<Person> { helen, will };

            foreach (var person in thePeople)
            {
                Console.WriteLine(person);
            }
            Console.WriteLine();

            LinkedList<Person> thePeopleLinked = new LinkedList<Person>();
            var firstNode = thePeopleLinked.AddFirst(helen);
            thePeopleLinked.AddLast(will);
            thePeopleLinked.AddLast(new Person("Linda", "Persons")); //fix
            thePeopleLinked.AddAfter(thePeopleLinked.Find(helen), new Person("John", "Green", 3));
            List<int> numList = new List<int> { 5, 4, 3, 9, 0 };

            numList.Add(8); numList.Sort(); numList.RemoveRange(1, 2); numList.Insert(1, 1); numList.Reverse(); numList.Remove(9);
            Console.WriteLine(string.Join(", ", numList));

            var myQueue = new Queue<Person>();
            myQueue.Enqueue(helen);
            myQueue.Enqueue(will);
            myQueue.Enqueue(new Person("Cathy"));

            foreach (var q in myQueue) { Console.WriteLine(q); }
            var first = myQueue.Peek();
            var last = myQueue.Dequeue();
            var second = myQueue.Peek();
            var served = myQueue.Dequeue();

            int[] original = new int[] { 1, 2, 3, 4, 5 };
            int[] reversed = new int[original.Length];
            var stack = new Stack<int>();
            foreach(var n in original)
            { stack.Push(n); }
            Console.WriteLine("\n Stack");
            foreach (var s in stack) { Console.WriteLine(s); }

            for (int i = 0; i < original.Length; i++)
                 {
                reversed[i] = stack.Pop();
            }

            var peopleSet = new HashSet<Person>
            {
                helen,new Person ("Jasmine"), new Person("Andrei")
            };
            Console.WriteLine("HashSet");
            foreach(var entry in peopleSet) { Console.WriteLine(entry); }
            var successMartin = peopleSet.Add((new Person { FirstName = "Maritn", LastName = "Beard" }));
            var successHelen = peopleSet.Add((new Person { FirstName = "Helen", LastName = "Troy" }));

            var morePeople = new HashSet<Person> {new Person("Cathy"), new Person("Jasmine") };
            peopleSet.IntersectWith(morePeople);

            var personDict = new Dictionary<string, Person>
            {
                { "helen", helen},
                { "sherlock ", new Person("Sherlock", "Jones"){Age = 40}}

            };

            var p = personDict["sherlock"];
            personDict.Add("will", will);
            string input = "The cat in the hat comes back";
            input = input.Trim().ToLower();
            var countDict = new Dictionary<char, int>();

            foreach(var c in input)
            {
                if (countDict.ContainsKey(c))
                { 
                    countDict[c]++;
                }
                else
                {
                    countDict.Add(c, 1);
                }
                Console.WriteLine("Dictionary Problem");
                foreach(var entry in countDict)
                {
                    Console.WriteLine(entry);
                }
                Console.WriteLine("\nKeys");
                foreach(var key in countDict.Keys) { Console.WriteLine(key + ""); }
                Console.WriteLine("\nValues");
                foreach()
            }
            
         
        }
        //var robOne = new Person("R           obert", "Sponge") { Age = 20 };
        //var robTwo = robOne;
        //var areSame = robOne.Equals(robTwo); //Console.WriteLine(areSame); //true
        ////equals checks memory location or address
        //var robThree = new Person("Robert", "Sponge") { Age = 20 };
        //var areSameOneThree = robOne.Equals(robThree); //false not same memory address

        //List<Person> personList = new List<Person>
        //{
        //new Person("Bobert", "Sponge"),

        //new Person("Sandy", "Cheeks"){ Age = 25},

        //new Person("Robert", "Sponge"){ Age = 20},

        //new Person("Squilliam", "Tentacles"){ Age = 32}
        //};
        //var hasRob = personList.Contains(robOne);

        //var equals = robOne == robThree;
        //var notEquals = robOne != robThree;

        //foreach (var person in personList) { Console.WriteLine(person); }

        //personList.Sort();

        //foreach (var person in personList) { Console.WriteLine(person); }
        public static void SpartaWrite(object obj)
        {
            Console.WriteLine(obj.ToString());
            if (obj is Hunter)
            {
                var hunterObj = (Hunter)obj;
                Console.WriteLine(hunterObj.Shoot);
            }
        }
    }
}


            //Console.WriteLine("Polymorphic Shootout!!!!! START!");
            //Camera Kodak = new Camera("Kodak"); // Camera Object instantiated with brand name Kodak
            //WaterPistol pistol = new WaterPistol("SuperSoaker");//''
            //LaserGun laserGun = new LaserGun("Rail Gun");//''
            //Hunter nish = new Hunter("Nish", "Mandal", Kodak); //Hunter Nish joins the party
            //Console.WriteLine(nish.Shoot());
            //nish.Shooter = pistol; // Nish drops his camera and picks up waterpistol
            //Console.WriteLine(nish.Shoot());
            //nish.Shooter = laserGun;// ''
            //Console.WriteLine(nish.Shoot());
            //nish.Shooter = pistol;// called again 
            //Console.WriteLine(nish.Shoot());


         //-----------------------------------------------------------------------------------------\\


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

