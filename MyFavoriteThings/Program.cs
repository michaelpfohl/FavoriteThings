using System;
using System.Collections.Generic;
using MyFavoriteThings.Things.Bands;
using MyFavoriteThings.Things.Books;

namespace MyFavoriteThings
{
    class Program
    {
        static void Main(string[] args)
        {
            var desaparecidos = new Desaparecidos();
            var sinaiVessel = new SinaiVessel();
            var youngJesus = new YoungJesus();
            var bands = new List<BandBase> { desaparecidos, sinaiVessel, youngJesus };
            foreach (var band in bands)
            {
                band.Play();
            }

            var atomicHabits = new AtomicHabits();
            var dune = new Dune();
            var homeland = new Homeland();
            var books = new List<BookBase> { atomicHabits, dune, homeland };
            foreach (var book in books)
            {
                book.ListInfo();
            }
        }
    }
}
