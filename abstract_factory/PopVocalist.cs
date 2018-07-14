using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_factory
{
    class PopVocalist:Vocalist
    {
        void Vocalist.Sing()
        {
            Console.WriteLine("Sing Pop");
        }
    }
}
