using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBJECT_CLASS
{
    class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            a.id = 110;
            a.name = "abc";
            Console.WriteLine(a.id);
            Console.WriteLine(a.name);

        }
    }
    class A
    {
        public int id;
        public string name;
    }

}
