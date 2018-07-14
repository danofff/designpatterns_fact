using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_factory
{
    class RockDrummer : Drummer
    {
        public void Play()
        {
            Console.WriteLine("Rock drummer play");
        }
    }
}
