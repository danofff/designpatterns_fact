using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_factory
{
    class RockBandFactory : BandFactory
    {
        public Drummer getDrummer()
        {
            return new RockDrummer();
        }

        public Guitarist getGuitarist()
        {
            return null;
        }

        public Vocalist getVocalist()
        {
            return new RockVocalist();
        }
    }
}
