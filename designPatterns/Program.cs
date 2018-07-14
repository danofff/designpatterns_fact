using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace designPatterns
{
    class Program
    {
        public interface Band
        {
            void play();
        }

        public interface BandFactory
        {
            Band createBand();
        }

        public class RockGroup : Band
        {
            public void play()
            {
                Console.WriteLine("Play Rock");
            }
        }

        public class PopGroup : Band
        {
            public void play()
            {
                Console.WriteLine("Play Pop");
            }
        }

        public class RockBandFactory : BandFactory
        {
            public Band createBand()
            {
                return new RockGroup();
            }
        }

        public class PopBandFactory : BandFactory
        {
            public Band createBand()
            {
                return new PopGroup();
            }
        }

        static void Main(string[] args)
        {
            BandFactory factory = getBangFactory("rock");
            Band band = factory.createBand();
            band.play();
        }

        private static BandFactory getBangFactory(string genre)
        {
            switch (genre)
            {
                case "rock":
                    return new RockBandFactory();
                case "pop":
                    return new PopBandFactory();
                default:
                    return null;
            }
        }
    }
}
