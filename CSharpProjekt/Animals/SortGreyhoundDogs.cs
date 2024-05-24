using CSharpProjekt.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpProjekt.Animals
{
    public class SortGreyhoundDogs : IGreyhound
    {
        internal void GreyhoundsListSort(string answer)
        {
            List<DisplayDogs> Greyhounds = new List<DisplayDogs>();
            Greyhounds.Add(new DisplayDogs { DogId = 1, Breed = "Greyhound", Species = "Greyhound", FullName = "Afganistanian greyhound" });
            Greyhounds.Add(new DisplayDogs { DogId = 2, Breed = "Greyhound", Species = "Greyhound", FullName = "Arabian greyhound" });
            Greyhounds.Add(new DisplayDogs { DogId = 3, Breed = "Greyhound", Species = "Greyhound", FullName = "Dirhound" });
            Greyhounds.Add(new DisplayDogs { DogId = 4, Breed = "Greyhound", Species = "Greyhound", FullName = "Pharaonic greyhound" });
            Greyhounds.Add(new DisplayDogs { DogId = 5, Breed = "Greyhound", Species = "Greyhound", FullName = "Greyhound" });
            Greyhounds.Add(new DisplayDogs { DogId = 6, Breed = "Greyhound", Species = "Greyhound", FullName = "Irish wolf greyhound" });
            Greyhounds.Add(new DisplayDogs { DogId = 7, Breed = "Greyhound", Species = "Greyhound", FullName = "Little Italian greyhound" });
            Greyhounds.Add(new DisplayDogs { DogId = 8, Breed = "Greyhound", Species = "Greyhound", FullName = "Persian greyhound" });
            Greyhounds.Add(new DisplayDogs { DogId = 9, Breed = "Greyhound", Species = "Greyhound", FullName = "Russian greyhound" });
            Greyhounds.Add(new DisplayDogs { DogId = 10, Breed = "Greyhound", Species = "Greyhound", FullName = "Spain greyhound" });
            Greyhounds.Add(new DisplayDogs { DogId = 11, Breed = "Greyhound", Species = "Greyhound", FullName = "Vipet" });

            if (answer == "1")
            {
                Console.WriteLine("        Breed                       Species                        Fullname");
                Console.WriteLine("    -----------------------------------------------------------------------------------------");
                SortingGreyhoundsByName(Greyhounds);
            }
            else if (answer == "2")
            {
                Console.WriteLine("        Breed                       Species                        Fullname");
                Console.WriteLine("    -----------------------------------------------------------------------------------------");
                SortingGreyhoundsByNameReverse(Greyhounds);
            }
            else
            {
                Console.WriteLine("Next time please input one of displayed numbers!");
            }
        }

        public void SortingGreyhoundsByName(List<DisplayDogs> Greyhounds)
        {

            var greyhoundlist = Greyhounds.OrderBy(greysort => greysort.FullName).ToList();


            foreach (var greyhound in greyhoundlist)
            {
                if (greyhound.DogId >= 1 && greyhound.DogId < 10)
                {
                    Console.WriteLine(String.Format("      {0}                    {1}                       {2}", greyhound.Breed, greyhound.Species, greyhound.FullName));
                }
                else
                {
                    Console.WriteLine(String.Format("      {0}                    {1}                       {2}", greyhound.Breed, greyhound.Species, greyhound.FullName));
                }
                Console.WriteLine();
            }
        }

        public void SortingGreyhoundsByNameReverse(List<DisplayDogs> Greyhounds)
        {

            var greyhoundlist = Greyhounds.OrderByDescending(greysort => greysort.FullName).ToList();


            foreach (var greyhound in greyhoundlist)
            {
                if (greyhound.DogId >= 1 && greyhound.DogId < 10)
                {
                    Console.WriteLine(String.Format("      {0}                    {1}                       {2}", greyhound.Breed, greyhound.Species, greyhound.FullName));
                }
                else
                {
                    Console.WriteLine(String.Format("      {0}                    {1}                       {2}", greyhound.Breed, greyhound.Species, greyhound.FullName));
                }
                Console.WriteLine();
            }
        }
    }
}
