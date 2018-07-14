using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prototype
{
    class Program
    {
        public class Agent:IClonable
        {
            private string Name;
            private int Age;

            public Agent (string name, int age)
            {
                Name = name;
                Age = age;
            }

            public Object clone()
            {
                Agent agentClone = new Agent(Name, Age);
                return agentClone;
            }

            public override string ToString()
            {
                return "Name "+this.Name+" Age "+this.Age;
            }
        }
        static void Main(string[] args)
        {
            Agent prototypeAgent = new Agent("Smith", 31);
            Console.WriteLine(prototypeAgent);

            Agent smith1 = (Agent)prototypeAgent.clone();

            Agent smith2 = (Agent)prototypeAgent.clone();
            
            Console.WriteLine(smith1);

            Console.WriteLine(prototypeAgent.GetHashCode());

            Console.WriteLine(smith1.GetHashCode());

            Console.WriteLine(smith2.GetHashCode());
            
        }
    }
}
