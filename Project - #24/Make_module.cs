using System; 
using System.Collections.Generic; 
using System.Linq; 
using System.Text; 
using System.Threading.Tasks;

namespace ParentChild
{
    class parent
    {
        public int x, y;
        public parent()
        {             
            x = 10;             
            y = 20;
        }
    }
    class Child : parent {
        public int z;         
        public Child()
        {             
            y = 30;             
            z = 50;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            parent p = new parent();
            Child c = new Child();
            Console.WriteLine("Parent x, y: {0} {1}", p.x, p.y);
            Console.WriteLine("Child x, y, z: {0} {1} {2}", c.x, c.y, c.z);
            Console.ReadLine();
        }
    }
}