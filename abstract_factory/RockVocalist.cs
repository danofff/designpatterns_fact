using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_factory
{
    class RockVocalist:Vocalist
    {
        void Vocalist.Sing()
        {
            Console.WriteLine("Rock Singing");
        }

    }
}
