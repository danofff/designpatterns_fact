using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleTon
{
    class Program
    {

        public class Neo
        {
            private static Neo neo;
            private static readonly String name = "Mr Anderson";
            private static readonly int age = 37;

            private Neo() { }
            public static Neo getNeo()
            {
                if (neo == null)
                {
                    neo = new Neo();
                }
                return neo;
            }

            public override string ToString()
            {
                return "Name " + name + " age " + age + " hash " + this.GetHashCode();
            }
        }
        static void Main(string[] args)
        {
            Neo theOne = Neo.getNeo();

            Console.WriteLine(theOne);

        }
    }
}
