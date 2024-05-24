using CSharpProjekt.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpProjekt.Animals
{
    public class SortTerrierDogs : ITerrier
    {
        internal void TerriersListSort(string answer)
        {
            List<DisplayDogs> Terriers = new List<DisplayDogs>()
            {
                new DisplayDogs
                {
                    DogId = 1,
                    Breed = "Terrier",
                    Species = "Bull terrier",
                    FullName = "Bull terrier"
                },
                new DisplayDogs
                {
                    DogId = 2,
                    Breed = "Terrier",
                    Species = "Bull terrier",
                    FullName = "Staffordian terrier"
                },
                new DisplayDogs
                {
                    DogId = 3,
                    Breed = "Terrier",
                    Species = "Fox terrier",
                    FullName = "Shorthair fox terrier"
                },
                new DisplayDogs
                {
                    DogId = 4,
                    Breed = "Terrier",
                    Species = "Fox terrier",
                    FullName = "Sharp-haired fox terrier"
                },
                new DisplayDogs
                {
                    DogId = 5,
                    Breed = "Terrier",
                    Species = "Terrier",
                    FullName = "American Staffordian terrier"
                },
                new DisplayDogs
                {
                    DogId = 6,
                    Breed = "Terrier",
                    Species = "Terrier",
                    FullName = "Bedlington terrier"
                },
                new DisplayDogs
                {
                    DogId = 7,
                    Breed = "Terrier",
                    Species = "Terrier",
                    FullName = "Bostonian terrier"
                },
                new DisplayDogs
                {
                    DogId = 8,
                    Breed = "Terrier",
                    Species = "Terrier",
                    FullName = "Czech terrier"
                },
                new DisplayDogs
                {
                    DogId = 9,
                    Breed = "Terrier",
                    Species = "Terrier",
                    FullName = "Dendi Dinmont terrier"
                },
                new DisplayDogs
                {
                    DogId = 10,
                    Breed = "Terrier",
                    Species = "Terrier",
                    FullName = "Airedale terrier"
                },
                new DisplayDogs
                {
                    DogId = 11,
                    Breed = "Terrier",
                    Species = "Terrier",
                    FullName = "Border terrier"
                },
                new DisplayDogs
                {
                    DogId = 12,
                    Breed = "Terrier",
                    Species = "Terrier",
                    FullName = "Imal terrier"
                },
                new DisplayDogs
                {
                    DogId = 13,
                    Breed = "Terrier",
                    Species = "Terrier",
                    FullName = "Irish terrier"
                },
                new DisplayDogs
                {
                    DogId = 14,
                    Breed = "Terrier",
                    Species = "Terrier",
                    FullName = "Kern terrier"
                },
                new DisplayDogs
                {
                    DogId = 15,
                    Breed = "Terrier",
                    Species = "Terrier",
                    FullName = "Leiklend terrier"
                },
                new DisplayDogs
                {
                    DogId = 16,
                    Breed = "Terrier",
                    Species = "Terrier",
                    FullName = "Manchester terrier"
                },
                new DisplayDogs
                {
                    DogId = 17,
                    Breed = "Terrier",
                    Species = "Terrier",
                    FullName = "Soft-haired wheat terrier"
                },
                new DisplayDogs
                {
                    DogId = 18,
                    Breed = "Terrier",
                    Species = "Terrier",
                    FullName = "Norfolk terrier"
                },
                new DisplayDogs
                {
                    DogId = 19,
                    Breed = "Terrier",
                    Species = "Terrier",
                    FullName = "Norwich terrier"
                },
                new DisplayDogs
                {
                    DogId = 20,
                    Breed = "Terrier",
                    Species = "Terrier",
                    FullName = "German hunting terrier"
                },
                new DisplayDogs
                {
                    DogId = 21,
                    Breed = "Terrier",
                    Species = "Terrier",
                    FullName = "Blue irish terrier"
                },
                new DisplayDogs
                {
                    DogId = 22,
                    Breed = "Terrier",
                    Species = "Terrier",
                    FullName = "Russell terrier"
                },
                new DisplayDogs
                {
                    DogId = 23,
                    Breed = "Terrier",
                    Species = "Terrier",
                    FullName = "Silichem terrier"
                },
                new DisplayDogs
                {
                    DogId = 24,
                    Breed = "Terrier",
                    Species = "Terrier",
                    FullName = "Skai terrier"
                },
                new DisplayDogs
                {
                    DogId = 25,
                    Breed = "Terrier",
                    Species = "Terrier",
                    FullName = "Scotish terrier"
                },
                new DisplayDogs
                {
                    DogId = 26,
                    Breed = "Terrier",
                    Species = "Terrier",
                    FullName = "Tibetian terrier"
                },
                new DisplayDogs
                {
                    DogId = 27,
                    Breed = "Terrier",
                    Species = "Terrier",
                    FullName = "Welsh terrier"
                },
                new DisplayDogs
                {
                    DogId = 28,
                    Breed = "Terrier",
                    Species = "Terrier",
                    FullName = "Western scotish white terrier"
                }
            };


            switch (answer)
            {
                case "1":
                    Console.WriteLine("       Breed                       Species                        Fullname");
                    Console.WriteLine("    ----------------------------------------------------------------------------------------------");
                    SortingTerriersBySpecies(Terriers);
                    break;

                case "2":
                    Console.WriteLine("       Breed                       Species                        Fullname");
                    Console.WriteLine("    ----------------------------------------------------------------------------------------------");
                    SortingTerriersBySpeciesReverse(Terriers);
                    break;

                case "3":
                    Console.WriteLine("       Breed                       Species                        Fullname");
                    Console.WriteLine("    ----------------------------------------------------------------------------------------------");
                    SortingTerriersByName(Terriers);
                    break;

                case "4":
                    Console.WriteLine("       Breed                       Species                        Fullname");
                    Console.WriteLine("    ----------------------------------------------------------------------------------------------");
                    SortingTerriersByNameReverse(Terriers);
                    break;

                case "5":
                    Console.WriteLine("       Breed                       Species                        Fullname");
                    Console.WriteLine("    ----------------------------------------------------------------------------------------------");
                    SortingTerriersBySpeciesName(Terriers);
                    break;

                case "6":
                    Console.WriteLine("       Breed                       Species                        Fullname");
                    Console.WriteLine("    ----------------------------------------------------------------------------------------------");
                    SortingTerriersByReverseSpeciesName(Terriers);
                    break;

                case "7":
                    Console.WriteLine("       Breed                       Species                        Fullname");
                    Console.WriteLine("    ----------------------------------------------------------------------------------------------");
                    SortingTerriersBySpeciesReverseName(Terriers);
                    break;

                case "8":
                    Console.WriteLine("       Breed                       Species                        Fullname");
                    Console.WriteLine("    ----------------------------------------------------------------------------------------------");
                    SortingTerriersBySpeciesNameReverse(Terriers);
                    break;

                default:
                    Console.WriteLine("Next time please input one of displayed numbers!");
                    break;

            }
        }

        public void SortingTerriersBySpecies(List<DisplayDogs> Terriers)
        {

            var terrierslist = Terriers.OrderBy(terriersort => terriersort.Species).ToList();

            foreach (var terrier in terrierslist)
            {
                if (terrier.DogId >= 1 && terrier.DogId < 10)
                {
                    if (terrier.Species == "Bull terrier")
                    {
                        Console.WriteLine(String.Format("      {0}                     {1}                    {2}", terrier.Breed, terrier.Species, terrier.FullName));
                    }
                    else if (terrier.Species == "Fox terrier")
                    {
                        Console.WriteLine(String.Format("      {0}                     {1}                     {2}", terrier.Breed, terrier.Species, terrier.FullName));
                    }
                    else
                    {
                        Console.WriteLine(String.Format("      {0}                     {1}                         {2}", terrier.Breed, terrier.Species, terrier.FullName));
                    }
                }
                else
                {
                    if (terrier.Species == "Bull terrier")
                    {
                        Console.WriteLine(String.Format("      {0}                     {1}                    {2}", terrier.Breed, terrier.Species, terrier.FullName));
                    }
                    else if (terrier.Species == "Fox terrier")
                    {
                        Console.WriteLine(String.Format("      {0}                 {1}                      {2}", terrier.Breed, terrier.Species, terrier.FullName));
                    }
                    else
                    {
                        Console.WriteLine(String.Format("      {0}                     {1}                         {2}", terrier.Breed, terrier.Species, terrier.FullName));
                    }
                }
                Console.WriteLine();
            }
        }

        public void SortingTerriersBySpeciesReverse(List<DisplayDogs> Terriers)
        {

            var terrierslist = Terriers.OrderByDescending(terriersort => terriersort.Species).ToList();

            foreach (var terrier in terrierslist)
            {
                if (terrier.DogId >= 1 && terrier.DogId < 10)
                {
                    if (terrier.Species == "Bull terrier")
                    {
                        Console.WriteLine(String.Format("      {0}                     {1}                    {2}", terrier.Breed, terrier.Species, terrier.FullName));
                    }
                    else if (terrier.Species == "Fox terrier")
                    {
                        Console.WriteLine(String.Format("      {0}                     {1}                     {2}", terrier.Breed, terrier.Species, terrier.FullName));
                    }
                    else
                    {
                        Console.WriteLine(String.Format("      {0}                     {1}                         {2}", terrier.Breed, terrier.Species, terrier.FullName));
                    }
                }
                else
                {
                    if (terrier.Species == "Bull terrier")
                    {
                        Console.WriteLine(String.Format("      {0}                     {1}                    {2}", terrier.Breed, terrier.Species, terrier.FullName));
                    }
                    else if (terrier.Species == "Fox terrier")
                    {
                        Console.WriteLine(String.Format("      {0}                 {1}                      {2}", terrier.Breed, terrier.Species, terrier.FullName));
                    }
                    else
                    {
                        Console.WriteLine(String.Format("      {0}                     {1}                         {2}", terrier.Breed, terrier.Species, terrier.FullName));
                    }
                }
                Console.WriteLine();
            }
        }

        public void SortingTerriersByName(List<DisplayDogs> Terriers)
        {

            var terrierslist = Terriers.OrderBy(terriersort => terriersort.FullName).ToList();

            foreach (var terrier in terrierslist)
            {
                if (terrier.DogId >= 1 && terrier.DogId < 10)
                {
                    if (terrier.Species == "Bull terrier")
                    {
                        Console.WriteLine(String.Format("      {0}                     {1}                    {2}", terrier.Breed, terrier.Species, terrier.FullName));
                    }
                    else if (terrier.Species == "Fox terrier")
                    {
                        Console.WriteLine(String.Format("      {0}                     {1}                     {2}", terrier.Breed, terrier.Species, terrier.FullName));
                    }
                    else
                    {
                        Console.WriteLine(String.Format("      {0}                     {1}                         {2}", terrier.Breed, terrier.Species, terrier.FullName));
                    }
                }
                else
                {
                    if (terrier.Species == "Bull terrier")
                    {
                        Console.WriteLine(String.Format("      {0}                     {1}                    {2}", terrier.Breed, terrier.Species, terrier.FullName));
                    }
                    else if (terrier.Species == "Fox terrier")
                    {
                        Console.WriteLine(String.Format("      {0}                 {1}                      {2}", terrier.Breed, terrier.Species, terrier.FullName));
                    }
                    else
                    {
                        Console.WriteLine(String.Format("      {0}                     {1}                         {2}", terrier.Breed, terrier.Species, terrier.FullName));
                    }
                }
                Console.WriteLine();
            }
        }

        public void SortingTerriersByNameReverse(List<DisplayDogs> Terriers)
        {

            var terrierslist = Terriers.OrderByDescending(terriersort => terriersort.FullName).ToList();

            foreach (var terrier in terrierslist)
            {
                if (terrier.DogId >= 1 && terrier.DogId < 10)
                {
                    if (terrier.Species == "Bull terrier")
                    {
                        Console.WriteLine(String.Format("      {0}                     {1}                    {2}", terrier.Breed, terrier.Species, terrier.FullName));
                    }
                    else if (terrier.Species == "Fox terrier")
                    {
                        Console.WriteLine(String.Format("      {0}                     {1}                     {2}", terrier.Breed, terrier.Species, terrier.FullName));
                    }
                    else
                    {
                        Console.WriteLine(String.Format("      {0}                     {1}                         {2}", terrier.Breed, terrier.Species, terrier.FullName));
                    }
                }
                else
                {
                    if (terrier.Species == "Bull terrier")
                    {
                        Console.WriteLine(String.Format("      {0}                     {1}                    {2}", terrier.Breed, terrier.Species, terrier.FullName));
                    }
                    else if (terrier.Species == "Fox terrier")
                    {
                        Console.WriteLine(String.Format("      {0}                 {1}                      {2}", terrier.Breed, terrier.Species, terrier.FullName));
                    }
                    else
                    {
                        Console.WriteLine(String.Format("      {0}                     {1}                         {2}", terrier.Breed, terrier.Species, terrier.FullName));
                    }
                }
                Console.WriteLine();
            }
        }

        public void SortingTerriersBySpeciesName(List<DisplayDogs> Terriers)
        {

            var terrierslist = Terriers.OrderBy(terriersort => terriersort.Species).OrderBy(terriersort => terriersort.FullName).ToList();

            foreach (var terrier in terrierslist)
            {
                if (terrier.DogId >= 1 && terrier.DogId < 10)
                {
                    if (terrier.Species == "Bull terrier")
                    {
                        Console.WriteLine(String.Format("      {0}                     {1}                    {2}", terrier.Breed, terrier.Species, terrier.FullName));
                    }
                    else if (terrier.Species == "Fox terrier")
                    {
                        Console.WriteLine(String.Format("      {0}                     {1}                     {2}", terrier.Breed, terrier.Species, terrier.FullName));
                    }
                    else
                    {
                        Console.WriteLine(String.Format("      {0}                     {1}                         {2}", terrier.Breed, terrier.Species, terrier.FullName));
                    }
                }
                else
                {
                    if (terrier.Species == "Bull terrier")
                    {
                        Console.WriteLine(String.Format("      {0}                     {1}                    {2}", terrier.Breed, terrier.Species, terrier.FullName));
                    }
                    else if (terrier.Species == "Fox terrier")
                    {
                        Console.WriteLine(String.Format("      {0}                 {1}                      {2}", terrier.Breed, terrier.Species, terrier.FullName));
                    }
                    else
                    {
                        Console.WriteLine(String.Format("      {0}                     {1}                         {2}", terrier.Breed, terrier.Species, terrier.FullName));
                    }
                }
                Console.WriteLine();
            }
        }

        public void SortingTerriersByReverseSpeciesName(List<DisplayDogs> Terriers)
        {

            var terrierslist = Terriers.OrderByDescending(terriersort => terriersort.Species).OrderByDescending(terriersort => terriersort.FullName).ToList();

            foreach (var terrier in terrierslist)
            {
                if (terrier.DogId >= 1 && terrier.DogId < 10)
                {
                    if (terrier.Species == "Bull terrier")
                    {
                        Console.WriteLine(String.Format("      {0}                     {1}                    {2}", terrier.Breed, terrier.Species, terrier.FullName));
                    }
                    else if (terrier.Species == "Fox terrier")
                    {
                        Console.WriteLine(String.Format("      {0}                     {1}                     {2}", terrier.Breed, terrier.Species, terrier.FullName));
                    }
                    else
                    {
                        Console.WriteLine(String.Format("      {0}                     {1}                         {2}", terrier.Breed, terrier.Species, terrier.FullName));
                    }
                }
                else
                {
                    if (terrier.Species == "Bull terrier")
                    {
                        Console.WriteLine(String.Format("      {0}                     {1}                    {2}", terrier.Breed, terrier.Species, terrier.FullName));
                    }
                    else if (terrier.Species == "Fox terrier")
                    {
                        Console.WriteLine(String.Format("      {0}                 {1}                      {2}", terrier.Breed, terrier.Species, terrier.FullName));
                    }
                    else
                    {
                        Console.WriteLine(String.Format("      {0}                     {1}                         {2}", terrier.Breed, terrier.Species, terrier.FullName));
                    }
                }
                Console.WriteLine();
            }
        }

        public void SortingTerriersBySpeciesReverseName(List<DisplayDogs> Terriers)
        {

            var terrierslist = Terriers.OrderByDescending(terriersort => terriersort.Species).OrderBy(terriersort => terriersort.FullName).ToList();

            foreach (var terrier in terrierslist)
            {
                if (terrier.DogId >= 1 && terrier.DogId < 10)
                {
                    if (terrier.Species == "Bull terrier")
                    {
                        Console.WriteLine(String.Format("      {0}                     {1}                    {2}", terrier.Breed, terrier.Species, terrier.FullName));
                    }
                    else if (terrier.Species == "Fox terrier")
                    {
                        Console.WriteLine(String.Format("      {0}                     {1}                     {2}", terrier.Breed, terrier.Species, terrier.FullName));
                    }
                    else
                    {
                        Console.WriteLine(String.Format("      {0}                     {1}                         {2}", terrier.Breed, terrier.Species, terrier.FullName));
                    }
                }
                else
                {
                    if (terrier.Species == "Bull terrier")
                    {
                        Console.WriteLine(String.Format("      {0}                     {1}                    {2}", terrier.Breed, terrier.Species, terrier.FullName));
                    }
                    else if (terrier.Species == "Fox terrier")
                    {
                        Console.WriteLine(String.Format("      {0}                 {1}                      {2}", terrier.Breed, terrier.Species, terrier.FullName));
                    }
                    else
                    {
                        Console.WriteLine(String.Format("      {0}                     {1}                         {2}", terrier.Breed, terrier.Species, terrier.FullName));
                    }
                }
                Console.WriteLine();
            }
        }

        public void SortingTerriersBySpeciesNameReverse(List<DisplayDogs> Terriers)
        {

            var terrierslist = Terriers.OrderBy(terriersort => terriersort.Species).OrderByDescending(terriersort => terriersort.FullName).ToList();

            foreach (var terrier in terrierslist)
            {
                if (terrier.DogId >= 1 && terrier.DogId < 10)
                {
                    if (terrier.Species == "Bull terrier")
                    {
                        Console.WriteLine(String.Format("      {0}                     {1}                    {2}", terrier.Breed, terrier.Species, terrier.FullName));
                    }
                    else if (terrier.Species == "Fox terrier")
                    {
                        Console.WriteLine(String.Format("      {0}                     {1}                     {2}", terrier.Breed, terrier.Species, terrier.FullName));
                    }
                    else
                    {
                        Console.WriteLine(String.Format("      {0}                     {1}                         {2}", terrier.Breed, terrier.Species, terrier.FullName));
                    }
                }
                else
                {
                    if (terrier.Species == "Bull terrier")
                    {
                        Console.WriteLine(String.Format("      {0}                     {1}                    {2}", terrier.Breed, terrier.Species, terrier.FullName));
                    }
                    else if (terrier.Species == "Fox terrier")
                    {
                        Console.WriteLine(String.Format("      {0}                 {1}                      {2}", terrier.Breed, terrier.Species, terrier.FullName));
                    }
                    else
                    {
                        Console.WriteLine(String.Format("      {0}                     {1}                         {2}", terrier.Breed, terrier.Species, terrier.FullName));
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
