using System;
using System.Collections.Generic;
using System.Text;

namespace MyFavoriteThings.Things.Bands
{
    class BandBase
    {
        public string Name { get; set; }
        public string Album { get; set; }
        public string Song { get; set; }

        //Methods
        public void State()
        {
            Console.WriteLine($"{Name} is one of your favorite bands.");
        }
        public void Play()
        {
            Console.WriteLine($"{Name} plays {Song} from {Album}.");
        }
    }
}
