using CSharpProjekt.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpProjekt.Animals
{
    public class SortDwarfDogs : IDwarfDog
    {
        internal void DwarfDogsListSort(string answer)
        {
            List<DisplayDogs> DwarfDogs = new List<DisplayDogs>()
            {
                new DisplayDogs
                {
                    DogId = 1,
                    Breed = "Dwarf dog",
                    Species = "Chihuahua",
                    FullName = "Chihuahua"
                },
                new DisplayDogs
                {
                    DogId = 2,
                    Breed = "Dwarf dog",
                    Species = "Fox terrier",
                    FullName = "Miniature fox terrier"
                },
                new DisplayDogs
                {
                    DogId = 3,
                    Breed = "Dwarf dog",
                    Species = "Naked dog",
                    FullName = "Mexican naked dog"
                },
                new DisplayDogs
                {
                    DogId = 4,
                    Breed = "Dwarf dog",
                    Species = "Griffon",
                    FullName = "Dwarf Brussels griffon"
                },
                new DisplayDogs
                {
                    DogId = 5,
                    Breed = "Dwarf dog",
                    Species = "Lasa apso",
                    FullName = "Lasa apso"
                },
                new DisplayDogs
                {
                    DogId = 6,
                    Breed = "Dwarf dog",
                    Species = "Maltese",
                    FullName = "Mljet dog"
                },
                new DisplayDogs
                {
                    DogId = 7,
                    Breed = "Dwarf dog",
                    Species = "Pinch",
                    FullName = "Monkey pinch"
                },
                new DisplayDogs
                {
                    DogId = 8,
                    Breed = "Dwarf dog",
                    Species = "Spaniel",
                    FullName = "Japanese spaniel"
                },
                new DisplayDogs
                {
                    DogId = 9,
                    Breed = "Dwarf dog",
                    Species = "Spaniel",
                    FullName = "Falen"
                },
                new DisplayDogs
                {
                    DogId = 10,
                    Breed = "Dwarf dog",
                    Species = "Spaniel",
                    FullName = "Papion"
                },
                new DisplayDogs
                {
                    DogId = 11,
                    Breed = "Dwarf dog",
                    Species = "Spaniel",
                    FullName = "King Charles spaniel"
                },
                new DisplayDogs
                {
                    DogId = 12,
                    Breed = "Dwarf dog",
                    Species = "Spitz",
                    FullName = "Pomeranian spitz"
                },
                new DisplayDogs
                {
                    DogId = 13,
                    Breed = "Dwarf dog",
                    Species = "Spitz",
                    FullName = "Shi-tzu"
                },
                new DisplayDogs
                {
                    DogId = 14,
                    Breed = "Dwarf dog",
                    Species = "Terrier",
                    FullName = "Australian silky terrier"
                },
                new DisplayDogs
                {
                    DogId = 15,
                    Breed = "Dwarf dog",
                    Species = "Terrier",
                    FullName = "Australian terrier"
                },
                new DisplayDogs
                {
                    DogId = 16,
                    Breed = "Dwarf dog",
                    Species = "Terrier",
                    FullName = "Black yellow miniature terrier"
                },
                new DisplayDogs
                {
                    DogId = 17,
                    Breed = "Dwarf dog",
                    Species = "Terrier",
                    FullName = "Yorkshire terrier"
                },
                new DisplayDogs
                {
                    DogId = 18,
                    Breed = "Dwarf dog",
                    Species = "Terrier",
                    FullName = "Miniature terrier"
                },
                new DisplayDogs
                {
                    DogId = 19,
                    Breed = "Dwarf dog",
                    Species = "Terrier",
                    FullName = "Sidney terrier"
                },
                new DisplayDogs
                {
                    DogId = 20,
                    Breed = "Dwarf dog",
                    Species = "Terrier",
                    FullName = "Tulear curly dog"
                }
            };


            switch (answer)
            {
                case "1":
                    Console.WriteLine("        Breed                       Species                        Fullname");
                    Console.WriteLine("    ----------------------------------------------------------------------------------------------");
                    SortingDwarfDogsBySpecies(DwarfDogs);
                    break;

                case "2":
                    Console.WriteLine("        Breed                       Species                        Fullname");
                    Console.WriteLine("    ----------------------------------------------------------------------------------------------");
                    SortingDwarfDogsBySpeciesReverse(DwarfDogs);
                    break;

                case "3":
                    Console.WriteLine("        Breed                       Species                        Fullname");
                    Console.WriteLine("    ----------------------------------------------------------------------------------------------");
                    SortingDwarfDogsByName(DwarfDogs);
                    break;

                case "4":
                    Console.WriteLine("        Breed                       Species                        Fullname");
                    Console.WriteLine("    ----------------------------------------------------------------------------------------------");
                    SortingDwarfDogsByNameReverse(DwarfDogs);
                    break;

                case "5":
                    Console.WriteLine("        Breed                       Species                        Fullname");
                    Console.WriteLine("    ----------------------------------------------------------------------------------------------");
                    SortingDwarfDogsBySpeciesName(DwarfDogs);
                    break;

                case "6":
                    Console.WriteLine("        Breed                       Species                        Fullname");
                    Console.WriteLine("    ----------------------------------------------------------------------------------------------");
                    SortingDwarfDogsByReverseSpeciesName(DwarfDogs);
                    break;

                case "7":
                    Console.WriteLine("        Breed                       Species                        Fullname");
                    Console.WriteLine("    ----------------------------------------------------------------------------------------------");
                    SortingDwarfDogsBySpeciesReverseName(DwarfDogs);
                    break;

                case "8":
                    Console.WriteLine("        Breed                       Species                        Fullname");
                    Console.WriteLine("    ----------------------------------------------------------------------------------------------");
                    SortingDwarfDogsBySpeciesNameReverse(DwarfDogs);
                    break;

                default:
                    Console.WriteLine("Next time please input one of displayed numbers!");
                    break;

            }
        }

        public void SortingDwarfDogsBySpecies(List<DisplayDogs> DwarfDogs)
        {

            var dwarfdogslist = DwarfDogs.OrderBy(dwarfsort => dwarfsort.Species).ToList();

            foreach (var dwarf in dwarfdogslist)
            {
                if (dwarf.DogId >= 1 && dwarf.DogId < 10)
                {
                    if (dwarf.Species == "Chihuahua")
                    {
                        Console.WriteLine(String.Format("      {0}                    {1}                       {2}", dwarf.Breed, dwarf.Species, dwarf.FullName));
                    }
                    else if (dwarf.Species == "Fox terrier")
                    {
                        Console.WriteLine(String.Format("      {0}                    {1}                     {2}", dwarf.Breed, dwarf.Species, dwarf.FullName));
                    }
                    else if (dwarf.Species == "Naked dog")
                    {
                        Console.WriteLine(String.Format("      {0}                    {1}                       {2}", dwarf.Breed, dwarf.Species, dwarf.FullName));
                    }
                    else if (dwarf.Species == "Griffon")
                    {
                        Console.WriteLine(String.Format("      {0}                    {1}                         {2}", dwarf.Breed, dwarf.Species, dwarf.FullName));
                    }
                    else if (dwarf.Species == "Lasa apso")
                    {
                        Console.WriteLine(String.Format("      {0}                    {1}                       {2}", dwarf.Breed, dwarf.Species, dwarf.FullName));
                    }
                    else if (dwarf.Species == "Maltese")
                    {
                        Console.WriteLine(String.Format("      {0}                    {1}                         {2}", dwarf.Breed, dwarf.Species, dwarf.FullName));
                    }
                    else if (dwarf.Species == "Pinch")
                    {
                        Console.WriteLine(String.Format("      {0}                    {1}                           {2}", dwarf.Breed, dwarf.Species, dwarf.FullName));
                    }
                    else if (dwarf.Species == "Spaniel")
                    {
                        Console.WriteLine(String.Format("      {0}                    {1}                         {2}", dwarf.Breed, dwarf.Species, dwarf.FullName));
                    }
                    else if (dwarf.Species == "Spitz")
                    {
                        Console.WriteLine(String.Format("      {0}                    {1}                         {2}", dwarf.Breed, dwarf.Species, dwarf.FullName));
                    }
                    else
                    {
                        Console.WriteLine(String.Format("      {0}                    {1}                        {2}", dwarf.Breed, dwarf.Species, dwarf.FullName));
                    }
                }
                else
                {
                    if (dwarf.Species == "Chihuahua")
                    {
                        Console.WriteLine(String.Format("      {0}                    {1}                       {2}", dwarf.Breed, dwarf.Species, dwarf.FullName));
                    }
                    else if (dwarf.Species == "Fox terrier")
                    {
                        Console.WriteLine(String.Format("      {0}                    {1}                     {2}", dwarf.Breed, dwarf.Species, dwarf.FullName));
                    }
                    else if (dwarf.Species == "Naked dog")
                    {
                        Console.WriteLine(String.Format("      {0}                    {1}                       {2}", dwarf.Breed, dwarf.Species, dwarf.FullName));
                    }
                    else if (dwarf.Species == "Griffon")
                    {
                        Console.WriteLine(String.Format("      {0}                    {1}                         {2}", dwarf.Breed, dwarf.Species, dwarf.FullName));
                    }
                    else if (dwarf.Species == "Lasa apso")
                    {
                        Console.WriteLine(String.Format("      {0}                    {1}                       {2}", dwarf.Breed, dwarf.Species, dwarf.FullName));
                    }
                    else if (dwarf.Species == "Maltese")
                    {
                        Console.WriteLine(String.Format("      {0}                    {1}                         {2}", dwarf.Breed, dwarf.Species, dwarf.FullName));
                    }
                    else if (dwarf.Species == "Pinch")
                    {
                        Console.WriteLine(String.Format("      {0}                    {1}                           {2}", dwarf.Breed, dwarf.Species, dwarf.FullName));
                    }
                    else if (dwarf.Species == "Spaniel")
                    {
                        Console.WriteLine(String.Format("      {0}                    {1}                         {2}", dwarf.Breed, dwarf.Species, dwarf.FullName));
                    }
                    else if (dwarf.Species == "Spitz")
                    {
                        Console.WriteLine(String.Format("      {0}                    {1}                           {2}", dwarf.Breed, dwarf.Species, dwarf.FullName));
                    }
                    else
                    {
                        Console.WriteLine(String.Format("      {0}                    {1}                         {2}", dwarf.Breed, dwarf.Species, dwarf.FullName));
                    }
                }
                Console.WriteLine();
            }
        }

        public void SortingDwarfDogsBySpeciesReverse(List<DisplayDogs> DwarfDogs)
        {

            var dwarfdogslist = DwarfDogs.OrderByDescending(dwarfsort => dwarfsort.Species).ToList();

            foreach (var dwarf in dwarfdogslist)
            {
                if (dwarf.DogId >= 1 && dwarf.DogId < 10)
                {
                    if (dwarf.Species == "Chihuahua")
                    {
                        Console.WriteLine(String.Format("      {0}                    {1}                       {2}", dwarf.Breed, dwarf.Species, dwarf.FullName));
                    }
                    else if (dwarf.Species == "Fox terrier")
                    {
                        Console.WriteLine(String.Format("      {0}                    {1}                     {2}", dwarf.Breed, dwarf.Species, dwarf.FullName));
                    }
                    else if (dwarf.Species == "Naked dog")
                    {
                        Console.WriteLine(String.Format("      {0}                    {1}                       {2}", dwarf.Breed, dwarf.Species, dwarf.FullName));
                    }
                    else if (dwarf.Species == "Griffon")
                    {
                        Console.WriteLine(String.Format("      {0}                    {1}                         {2}", dwarf.Breed, dwarf.Species, dwarf.FullName));
                    }
                    else if (dwarf.Species == "Lasa apso")
                    {
                        Console.WriteLine(String.Format("      {0}                    {1}                       {2}", dwarf.Breed, dwarf.Species, dwarf.FullName));
                    }
                    else if (dwarf.Species == "Maltese")
                    {
                        Console.WriteLine(String.Format("      {0}                    {1}                         {2}", dwarf.Breed, dwarf.Species, dwarf.FullName));
                    }
                    else if (dwarf.Species == "Pinch")
                    {
                        Console.WriteLine(String.Format("      {0}                    {1}                           {2}", dwarf.Breed, dwarf.Species, dwarf.FullName));
                    }
                    else if (dwarf.Species == "Spaniel")
                    {
                        Console.WriteLine(String.Format("      {0}                    {1}                         {2}", dwarf.Breed, dwarf.Species, dwarf.FullName));
                    }
                    else if (dwarf.Species == "Spitz")
                    {
                        Console.WriteLine(String.Format("      {0}                    {1}                         {2}", dwarf.Breed, dwarf.Species, dwarf.FullName));
                    }
                    else
                    {
                        Console.WriteLine(String.Format("      {0}                    {1}                        {2}", dwarf.Breed, dwarf.Species, dwarf.FullName));
                    }
                }
                else
                {
                    if (dwarf.Species == "Chihuahua")
                    {
                        Console.WriteLine(String.Format("      {0}                    {1}                       {2}", dwarf.Breed, dwarf.Species, dwarf.FullName));
                    }
                    else if (dwarf.Species == "Fox terrier")
                    {
                        Console.WriteLine(String.Format("      {0}                    {1}                     {2}", dwarf.Breed, dwarf.Species, dwarf.FullName));
                    }
                    else if (dwarf.Species == "Naked dog")
                    {
                        Console.WriteLine(String.Format("      {0}                    {1}                       {2}", dwarf.Breed, dwarf.Species, dwarf.FullName));
                    }
                    else if (dwarf.Species == "Griffon")
                    {
                        Console.WriteLine(String.Format("      {0}                    {1}                         {2}", dwarf.Breed, dwarf.Species, dwarf.FullName));
                    }
                    else if (dwarf.Species == "Lasa apso")
                    {
                        Console.WriteLine(String.Format("      {0}                    {1}                       {2}", dwarf.Breed, dwarf.Species, dwarf.FullName));
                    }
                    else if (dwarf.Species == "Maltese")
                    {
                        Console.WriteLine(String.Format("      {0}                    {1}                         {2}", dwarf.Breed, dwarf.Species, dwarf.FullName));
                    }
                    else if (dwarf.Species == "Pinch")
                    {
                        Console.WriteLine(String.Format("      {0}                    {1}                           {2}", dwarf.Breed, dwarf.Species, dwarf.FullName));
                    }
                    else if (dwarf.Species == "Spaniel")
                    {
                        Console.WriteLine(String.Format("      {0}                    {1}                         {2}", dwarf.Breed, dwarf.Species, dwarf.FullName));
                    }
                    else if (dwarf.Species == "Spitz")
                    {
                        Console.WriteLine(String.Format("      {0}                    {1}                           {2}", dwarf.Breed, dwarf.Species, dwarf.FullName));
                    }
                    else
                    {
                        Console.WriteLine(String.Format("      {0}                    {1}                         {2}", dwarf.Breed, dwarf.Species, dwarf.FullName));
                    }
                }
                Console.WriteLine();
            }
        }

        public void SortingDwarfDogsByName(List<DisplayDogs> DwarfDogs)
        {

            var dwarfdogslist = DwarfDogs.OrderBy(dwarfsort => dwarfsort.FullName).ToList();

            foreach (var dwarf in dwarfdogslist)
            {
                if (dwarf.DogId >= 1 && dwarf.DogId < 10)
                {
                    if (dwarf.Species == "Chihuahua")
                    {
                        Console.WriteLine(String.Format("      {0}                    {1}                       {2}", dwarf.Breed, dwarf.Species, dwarf.FullName));
                    }
                    else if (dwarf.Species == "Fox terrier")
                    {
                        Console.WriteLine(String.Format("      {0}                    {1}                     {2}", dwarf.Breed, dwarf.Species, dwarf.FullName));
                    }
                    else if (dwarf.Species == "Naked dog")
                    {
                        Console.WriteLine(String.Format("      {0}                    {1}                       {2}", dwarf.Breed, dwarf.Species, dwarf.FullName));
                    }
                    else if (dwarf.Species == "Griffon")
                    {
                        Console.WriteLine(String.Format("      {0}                    {1}                         {2}", dwarf.Breed, dwarf.Species, dwarf.FullName));
                    }
                    else if (dwarf.Species == "Lasa apso")
                    {
                        Console.WriteLine(String.Format("      {0}                    {1}                       {2}", dwarf.Breed, dwarf.Species, dwarf.FullName));
                    }
                    else if (dwarf.Species == "Maltese")
                    {
                        Console.WriteLine(String.Format("      {0}                    {1}                         {2}", dwarf.Breed, dwarf.Species, dwarf.FullName));
                    }
                    else if (dwarf.Species == "Pinch")
                    {
                        Console.WriteLine(String.Format("      {0}                    {1}                           {2}", dwarf.Breed, dwarf.Species, dwarf.FullName));
                    }
                    else if (dwarf.Species == "Spaniel")
                    {
                        Console.WriteLine(String.Format("      {0}                    {1}                         {2}", dwarf.Breed, dwarf.Species, dwarf.FullName));
                    }
                    else if (dwarf.Species == "Spitz")
                    {
                        Console.WriteLine(String.Format("      {0}                    {1}                         {2}", dwarf.Breed, dwarf.Species, dwarf.FullName));
                    }
                    else
                    {
                        Console.WriteLine(String.Format("      {0}                    {1}                        {2}", dwarf.Breed, dwarf.Species, dwarf.FullName));
                    }
                }
                else
                {
                    if (dwarf.Species == "Chihuahua")
                    {
                        Console.WriteLine(String.Format("      {0}                    {1}                       {2}", dwarf.Breed, dwarf.Species, dwarf.FullName));
                    }
                    else if (dwarf.Species == "Fox terrier")
                    {
                        Console.WriteLine(String.Format("      {0}                    {1}                     {2}", dwarf.Breed, dwarf.Species, dwarf.FullName));
                    }
                    else if (dwarf.Species == "Naked dog")
                    {
                        Console.WriteLine(String.Format("      {0}                    {1}                       {2}", dwarf.Breed, dwarf.Species, dwarf.FullName));
                    }
                    else if (dwarf.Species == "Griffon")
                    {
                        Console.WriteLine(String.Format("      {0}                    {1}                         {2}", dwarf.Breed, dwarf.Species, dwarf.FullName));
                    }
                    else if (dwarf.Species == "Lasa apso")
                    {
                        Console.WriteLine(String.Format("      {0}                    {1}                       {2}", dwarf.Breed, dwarf.Species, dwarf.FullName));
                    }
                    else if (dwarf.Species == "Maltese")
                    {
                        Console.WriteLine(String.Format("      {0}                    {1}                         {2}", dwarf.Breed, dwarf.Species, dwarf.FullName));
                    }
                    else if (dwarf.Species == "Pinch")
                    {
                        Console.WriteLine(String.Format("      {0}                    {1}                           {2}", dwarf.Breed, dwarf.Species, dwarf.FullName));
                    }
                    else if (dwarf.Species == "Spaniel")
                    {
                        Console.WriteLine(String.Format("      {0}                    {1}                         {2}", dwarf.Breed, dwarf.Species, dwarf.FullName));
                    }
                    else if (dwarf.Species == "Spitz")
                    {
                        Console.WriteLine(String.Format("      {0}                    {1}                           {2}", dwarf.Breed, dwarf.Species, dwarf.FullName));
                    }
                    else
                    {
                        Console.WriteLine(String.Format("      {0}                    {1}                         {2}", dwarf.Breed, dwarf.Species, dwarf.FullName));
                    }
                }
                Console.WriteLine();
            }
        }

        public void SortingDwarfDogsByNameReverse(List<DisplayDogs> DwarfDogs)
        {

            var dwarfdogslist = DwarfDogs.OrderByDescending(dwarfsort => dwarfsort.FullName).ToList();

            foreach (var dwarf in dwarfdogslist)
            {
                if (dwarf.DogId >= 1 && dwarf.DogId < 10)
                {
                    if (dwarf.Species == "Chihuahua")
                    {
                        Console.WriteLine(String.Format("      {0}                    {1}                       {2}", dwarf.Breed, dwarf.Species, dwarf.FullName));
                    }
                    else if (dwarf.Species == "Fox terrier")
                    {
                        Console.WriteLine(String.Format("      {0}                    {1}                     {2}", dwarf.Breed, dwarf.Species, dwarf.FullName));
                    }
                    else if (dwarf.Species == "Naked dog")
                    {
                        Console.WriteLine(String.Format("      {0}                    {1}                       {2}", dwarf.Breed, dwarf.Species, dwarf.FullName));
                    }
                    else if (dwarf.Species == "Griffon")
                    {
                        Console.WriteLine(String.Format("      {0}                    {1}                         {2}", dwarf.Breed, dwarf.Species, dwarf.FullName));
                    }
                    else if (dwarf.Species == "Lasa apso")
                    {
                        Console.WriteLine(String.Format("      {0}                    {1}                       {2}", dwarf.Breed, dwarf.Species, dwarf.FullName));
                    }
                    else if (dwarf.Species == "Maltese")
                    {
                        Console.WriteLine(String.Format("      {0}                    {1}                         {2}", dwarf.Breed, dwarf.Species, dwarf.FullName));
                    }
                    else if (dwarf.Species == "Pinch")
                    {
                        Console.WriteLine(String.Format("      {0}                    {1}                           {2}", dwarf.Breed, dwarf.Species, dwarf.FullName));
                    }
                    else if (dwarf.Species == "Spaniel")
                    {
                        Console.WriteLine(String.Format("      {0}                    {1}                         {2}", dwarf.Breed, dwarf.Species, dwarf.FullName));
                    }
                    else if (dwarf.Species == "Spitz")
                    {
                        Console.WriteLine(String.Format("      {0}                    {1}                         {2}", dwarf.Breed, dwarf.Species, dwarf.FullName));
                    }
                    else
                    {
                        Console.WriteLine(String.Format("      {0}                    {1}                        {2}", dwarf.Breed, dwarf.Species, dwarf.FullName));
                    }
                }
                else
                {
                    if (dwarf.Species == "Chihuahua")
                    {
                        Console.WriteLine(String.Format("      {0}                    {1}                       {2}", dwarf.Breed, dwarf.Species, dwarf.FullName));
                    }
                    else if (dwarf.Species == "Fox terrier")
                    {
                        Console.WriteLine(String.Format("      {0}                    {1}                     {2}", dwarf.Breed, dwarf.Species, dwarf.FullName));
                    }
                    else if (dwarf.Species == "Naked dog")
                    {
                        Console.WriteLine(String.Format("      {0}                    {1}                       {2}", dwarf.Breed, dwarf.Species, dwarf.FullName));
                    }
                    else if (dwarf.Species == "Griffon")
                    {
                        Console.WriteLine(String.Format("      {0}                    {1}                         {2}", dwarf.Breed, dwarf.Species, dwarf.FullName));
                    }
                    else if (dwarf.Species == "Lasa apso")
                    {
                        Console.WriteLine(String.Format("      {0}                    {1}                       {2}", dwarf.Breed, dwarf.Species, dwarf.FullName));
                    }
                    else if (dwarf.Species == "Maltese")
                    {
                        Console.WriteLine(String.Format("      {0}                    {1}                         {2}", dwarf.Breed, dwarf.Species, dwarf.FullName));
                    }
                    else if (dwarf.Species == "Pinch")
                    {
                        Console.WriteLine(String.Format("      {0}                    {1}                           {2}", dwarf.Breed, dwarf.Species, dwarf.FullName));
                    }
                    else if (dwarf.Species == "Spaniel")
                    {
                        Console.WriteLine(String.Format("      {0}                    {1}                         {2}", dwarf.Breed, dwarf.Species, dwarf.FullName));
                    }
                    else if (dwarf.Species == "Spitz")
                    {
                        Console.WriteLine(String.Format("      {0}                    {1}                           {2}", dwarf.Breed, dwarf.Species, dwarf.FullName));
                    }
                    else
                    {
                        Console.WriteLine(String.Format("      {0}                    {1}                         {2}", dwarf.Breed, dwarf.Species, dwarf.FullName));
                    }
                }
                Console.WriteLine();
            }
        }

        public void SortingDwarfDogsBySpeciesName(List<DisplayDogs> DwarfDogs)
        {

            var dwarfdogslist = DwarfDogs.OrderBy(dwarfsort => dwarfsort.Species).OrderBy(dwarfsort => dwarfsort.FullName).ToList();

            foreach (var dwarf in dwarfdogslist)
            {
                if (dwarf.DogId >= 1 && dwarf.DogId < 10)
                {
                    if (dwarf.Species == "Chihuahua")
                    {
                        Console.WriteLine(String.Format("      {0}                    {1}                       {2}", dwarf.Breed, dwarf.Species, dwarf.FullName));
                    }
                    else if (dwarf.Species == "Fox terrier")
                    {
                        Console.WriteLine(String.Format("      {0}                    {1}                     {2}", dwarf.Breed, dwarf.Species, dwarf.FullName));
                    }
                    else if (dwarf.Species == "Naked dog")
                    {
                        Console.WriteLine(String.Format("      {0}                    {1}                       {2}", dwarf.Breed, dwarf.Species, dwarf.FullName));
                    }
                    else if (dwarf.Species == "Griffon")
                    {
                        Console.WriteLine(String.Format("      {0}                    {1}                         {2}", dwarf.Breed, dwarf.Species, dwarf.FullName));
                    }
                    else if (dwarf.Species == "Lasa apso")
                    {
                        Console.WriteLine(String.Format("      {0}                    {1}                       {2}", dwarf.Breed, dwarf.Species, dwarf.FullName));
                    }
                    else if (dwarf.Species == "Maltese")
                    {
                        Console.WriteLine(String.Format("      {0}                    {1}                         {2}", dwarf.Breed, dwarf.Species, dwarf.FullName));
                    }
                    else if (dwarf.Species == "Pinch")
                    {
                        Console.WriteLine(String.Format("      {0}                    {1}                           {2}", dwarf.Breed, dwarf.Species, dwarf.FullName));
                    }
                    else if (dwarf.Species == "Spaniel")
                    {
                        Console.WriteLine(String.Format("      {0}                    {1}                         {2}", dwarf.Breed, dwarf.Species, dwarf.FullName));
                    }
                    else if (dwarf.Species == "Spitz")
                    {
                        Console.WriteLine(String.Format("      {0}                    {1}                         {2}", dwarf.Breed, dwarf.Species, dwarf.FullName));
                    }
                    else
                    {
                        Console.WriteLine(String.Format("      {0}                    {1}                        {2}", dwarf.Breed, dwarf.Species, dwarf.FullName));
                    }
                }
                else
                {
                    if (dwarf.Species == "Chihuahua")
                    {
                        Console.WriteLine(String.Format("      {0}                    {1}                       {2}", dwarf.Breed, dwarf.Species, dwarf.FullName));
                    }
                    else if (dwarf.Species == "Fox terrier")
                    {
                        Console.WriteLine(String.Format("      {0}                    {1}                     {2}", dwarf.Breed, dwarf.Species, dwarf.FullName));
                    }
                    else if (dwarf.Species == "Naked dog")
                    {
                        Console.WriteLine(String.Format("      {0}                    {1}                       {2}", dwarf.Breed, dwarf.Species, dwarf.FullName));
                    }
                    else if (dwarf.Species == "Griffon")
                    {
                        Console.WriteLine(String.Format("      {0}                    {1}                         {2}", dwarf.Breed, dwarf.Species, dwarf.FullName));
                    }
                    else if (dwarf.Species == "Lasa apso")
                    {
                        Console.WriteLine(String.Format("      {0}                    {1}                       {2}", dwarf.Breed, dwarf.Species, dwarf.FullName));
                    }
                    else if (dwarf.Species == "Maltese")
                    {
                        Console.WriteLine(String.Format("      {0}                    {1}                         {2}", dwarf.Breed, dwarf.Species, dwarf.FullName));
                    }
                    else if (dwarf.Species == "Pinch")
                    {
                        Console.WriteLine(String.Format("      {0}                    {1}                           {2}", dwarf.Breed, dwarf.Species, dwarf.FullName));
                    }
                    else if (dwarf.Species == "Spaniel")
                    {
                        Console.WriteLine(String.Format("      {0}                    {1}                         {2}", dwarf.Breed, dwarf.Species, dwarf.FullName));
                    }
                    else if (dwarf.Species == "Spitz")
                    {
                        Console.WriteLine(String.Format("      {0}                    {1}                           {2}", dwarf.Breed, dwarf.Species, dwarf.FullName));
                    }
                    else
                    {
                        Console.WriteLine(String.Format("      {0}                    {1}                         {2}", dwarf.Breed, dwarf.Species, dwarf.FullName));
                    }
                }
                Console.WriteLine();
            }
        }

        public void SortingDwarfDogsByReverseSpeciesName(List<DisplayDogs> DwarfDogs)
        {

            var dwarfdogslist = DwarfDogs.OrderByDescending(dwarfsort => dwarfsort.Species).OrderByDescending(dwarfsort => dwarfsort.FullName).ToList();

            foreach (var dwarf in dwarfdogslist)
            {
                if (dwarf.DogId >= 1 && dwarf.DogId < 10)
                {
                    if (dwarf.Species == "Chihuahua")
                    {
                        Console.WriteLine(String.Format("      {0}                    {1}                       {2}", dwarf.Breed, dwarf.Species, dwarf.FullName));
                    }
                    else if (dwarf.Species == "Fox terrier")
                    {
                        Console.WriteLine(String.Format("      {0}                    {1}                     {2}", dwarf.Breed, dwarf.Species, dwarf.FullName));
                    }
                    else if (dwarf.Species == "Naked dog")
                    {
                        Console.WriteLine(String.Format("      {0}                    {1}                       {2}", dwarf.Breed, dwarf.Species, dwarf.FullName));
                    }
                    else if (dwarf.Species == "Griffon")
                    {
                        Console.WriteLine(String.Format("      {0}                    {1}                         {2}", dwarf.Breed, dwarf.Species, dwarf.FullName));
                    }
                    else if (dwarf.Species == "Lasa apso")
                    {
                        Console.WriteLine(String.Format("      {0}                    {1}                       {2}", dwarf.Breed, dwarf.Species, dwarf.FullName));
                    }
                    else if (dwarf.Species == "Maltese")
                    {
                        Console.WriteLine(String.Format("      {0}                    {1}                         {2}", dwarf.Breed, dwarf.Species, dwarf.FullName));
                    }
                    else if (dwarf.Species == "Pinch")
                    {
                        Console.WriteLine(String.Format("      {0}                    {1}                           {2}", dwarf.Breed, dwarf.Species, dwarf.FullName));
                    }
                    else if (dwarf.Species == "Spaniel")
                    {
                        Console.WriteLine(String.Format("      {0}                    {1}                         {2}", dwarf.Breed, dwarf.Species, dwarf.FullName));
                    }
                    else if (dwarf.Species == "Spitz")
                    {
                        Console.WriteLine(String.Format("      {0}                    {1}                         {2}", dwarf.Breed, dwarf.Species, dwarf.FullName));
                    }
                    else
                    {
                        Console.WriteLine(String.Format("      {0}                    {1}                        {2}", dwarf.Breed, dwarf.Species, dwarf.FullName));
                    }
                }
                else
                {
                    if (dwarf.Species == "Chihuahua")
                    {
                        Console.WriteLine(String.Format("      {0}                    {1}                       {2}", dwarf.Breed, dwarf.Species, dwarf.FullName));
                    }
                    else if (dwarf.Species == "Fox terrier")
                    {
                        Console.WriteLine(String.Format("      {0}                    {1}                     {2}", dwarf.Breed, dwarf.Species, dwarf.FullName));
                    }
                    else if (dwarf.Species == "Naked dog")
                    {
                        Console.WriteLine(String.Format("      {0}                    {1}                       {2}", dwarf.Breed, dwarf.Species, dwarf.FullName));
                    }
                    else if (dwarf.Species == "Griffon")
                    {
                        Console.WriteLine(String.Format("      {0}                    {1}                         {2}", dwarf.Breed, dwarf.Species, dwarf.FullName));
                    }
                    else if (dwarf.Species == "Lasa apso")
                    {
                        Console.WriteLine(String.Format("      {0}                    {1}                       {2}", dwarf.Breed, dwarf.Species, dwarf.FullName));
                    }
                    else if (dwarf.Species == "Maltese")
                    {
                        Console.WriteLine(String.Format("      {0}                    {1}                         {2}", dwarf.Breed, dwarf.Species, dwarf.FullName));
                    }
                    else if (dwarf.Species == "Pinch")
                    {
                        Console.WriteLine(String.Format("      {0}                    {1}                           {2}", dwarf.Breed, dwarf.Species, dwarf.FullName));
                    }
                    else if (dwarf.Species == "Spaniel")
                    {
                        Console.WriteLine(String.Format("      {0}                    {1}                         {2}", dwarf.Breed, dwarf.Species, dwarf.FullName));
                    }
                    else if (dwarf.Species == "Spitz")
                    {
                        Console.WriteLine(String.Format("      {0}                    {1}                           {2}", dwarf.Breed, dwarf.Species, dwarf.FullName));
                    }
                    else
                    {
                        Console.WriteLine(String.Format("      {0}                    {1}                         {2}", dwarf.Breed, dwarf.Species, dwarf.FullName));
                    }
                }
                Console.WriteLine();
            }
        }

        public void SortingDwarfDogsBySpeciesReverseName(List<DisplayDogs> DwarfDogs)
        {

            var dwarfdogslist = DwarfDogs.OrderByDescending(dwarfsort => dwarfsort.Species).OrderBy(dwarfsort => dwarfsort.FullName).ToList();

            foreach (var dwarf in dwarfdogslist)
            {
                if (dwarf.DogId >= 1 && dwarf.DogId < 10)
                {
                    if (dwarf.Species == "Chihuahua")
                    {
                        Console.WriteLine(String.Format("      {0}                    {1}                       {2}", dwarf.Breed, dwarf.Species, dwarf.FullName));
                    }
                    else if (dwarf.Species == "Fox terrier")
                    {
                        Console.WriteLine(String.Format("      {0}                    {1}                     {2}", dwarf.Breed, dwarf.Species, dwarf.FullName));
                    }
                    else if (dwarf.Species == "Naked dog")
                    {
                        Console.WriteLine(String.Format("      {0}                    {1}                       {2}", dwarf.Breed, dwarf.Species, dwarf.FullName));
                    }
                    else if (dwarf.Species == "Griffon")
                    {
                        Console.WriteLine(String.Format("      {0}                    {1}                         {2}", dwarf.Breed, dwarf.Species, dwarf.FullName));
                    }
                    else if (dwarf.Species == "Lasa apso")
                    {
                        Console.WriteLine(String.Format("      {0}                    {1}                       {2}", dwarf.Breed, dwarf.Species, dwarf.FullName));
                    }
                    else if (dwarf.Species == "Maltese")
                    {
                        Console.WriteLine(String.Format("      {0}                    {1}                         {2}", dwarf.Breed, dwarf.Species, dwarf.FullName));
                    }
                    else if (dwarf.Species == "Pinch")
                    {
                        Console.WriteLine(String.Format("      {0}                    {1}                           {2}", dwarf.Breed, dwarf.Species, dwarf.FullName));
                    }
                    else if (dwarf.Species == "Spaniel")
                    {
                        Console.WriteLine(String.Format("      {0}                    {1}                         {2}", dwarf.Breed, dwarf.Species, dwarf.FullName));
                    }
                    else if (dwarf.Species == "Spitz")
                    {
                        Console.WriteLine(String.Format("      {0}                    {1}                         {2}", dwarf.Breed, dwarf.Species, dwarf.FullName));
                    }
                    else
                    {
                        Console.WriteLine(String.Format("      {0}                    {1}                        {2}", dwarf.Breed, dwarf.Species, dwarf.FullName));
                    }
                }
                else
                {
                    if (dwarf.Species == "Chihuahua")
                    {
                        Console.WriteLine(String.Format("      {0}                    {1}                       {2}", dwarf.Breed, dwarf.Species, dwarf.FullName));
                    }
                    else if (dwarf.Species == "Fox terrier")
                    {
                        Console.WriteLine(String.Format("      {0}                    {1}                     {2}", dwarf.Breed, dwarf.Species, dwarf.FullName));
                    }
                    else if (dwarf.Species == "Naked dog")
                    {
                        Console.WriteLine(String.Format("      {0}                    {1}                       {2}", dwarf.Breed, dwarf.Species, dwarf.FullName));
                    }
                    else if (dwarf.Species == "Griffon")
                    {
                        Console.WriteLine(String.Format("      {0}                    {1}                         {2}", dwarf.Breed, dwarf.Species, dwarf.FullName));
                    }
                    else if (dwarf.Species == "Lasa apso")
                    {
                        Console.WriteLine(String.Format("      {0}                    {1}                       {2}", dwarf.Breed, dwarf.Species, dwarf.FullName));
                    }
                    else if (dwarf.Species == "Maltese")
                    {
                        Console.WriteLine(String.Format("      {0}                    {1}                         {2}", dwarf.Breed, dwarf.Species, dwarf.FullName));
                    }
                    else if (dwarf.Species == "Pinch")
                    {
                        Console.WriteLine(String.Format("      {0}                    {1}                           {2}", dwarf.Breed, dwarf.Species, dwarf.FullName));
                    }
                    else if (dwarf.Species == "Spaniel")
                    {
                        Console.WriteLine(String.Format("      {0}                    {1}                         {2}", dwarf.Breed, dwarf.Species, dwarf.FullName));
                    }
                    else if (dwarf.Species == "Spitz")
                    {
                        Console.WriteLine(String.Format("      {0}                    {1}                           {2}", dwarf.Breed, dwarf.Species, dwarf.FullName));
                    }
                    else
                    {
                        Console.WriteLine(String.Format("      {0}                    {1}                         {2}", dwarf.Breed, dwarf.Species, dwarf.FullName));
                    }
                }
                Console.WriteLine();
            }
        }

        public void SortingDwarfDogsBySpeciesNameReverse(List<DisplayDogs> DwarfDogs)
        {

            var dwarfdogslist = DwarfDogs.OrderBy(dwarfsort => dwarfsort.Species).OrderByDescending(dwarfsort => dwarfsort.FullName).ToList();

            foreach (var dwarf in dwarfdogslist)
            {
                if (dwarf.DogId >= 1 && dwarf.DogId < 10)
                {
                    if (dwarf.Species == "Chihuahua")
                    {
                        Console.WriteLine(String.Format("      {0}                    {1}                       {2}", dwarf.Breed, dwarf.Species, dwarf.FullName));
                    }
                    else if (dwarf.Species == "Fox terrier")
                    {
                        Console.WriteLine(String.Format("      {0}                    {1}                     {2}", dwarf.Breed, dwarf.Species, dwarf.FullName));
                    }
                    else if (dwarf.Species == "Naked dog")
                    {
                        Console.WriteLine(String.Format("      {0}                    {1}                       {2}", dwarf.Breed, dwarf.Species, dwarf.FullName));
                    }
                    else if (dwarf.Species == "Griffon")
                    {
                        Console.WriteLine(String.Format("      {0}                    {1}                         {2}", dwarf.Breed, dwarf.Species, dwarf.FullName));
                    }
                    else if (dwarf.Species == "Lasa apso")
                    {
                        Console.WriteLine(String.Format("      {0}                    {1}                       {2}", dwarf.Breed, dwarf.Species, dwarf.FullName));
                    }
                    else if (dwarf.Species == "Maltese")
                    {
                        Console.WriteLine(String.Format("      {0}                    {1}                         {2}", dwarf.Breed, dwarf.Species, dwarf.FullName));
                    }
                    else if (dwarf.Species == "Pinch")
                    {
                        Console.WriteLine(String.Format("      {0}                    {1}                           {2}", dwarf.Breed, dwarf.Species, dwarf.FullName));
                    }
                    else if (dwarf.Species == "Spaniel")
                    {
                        Console.WriteLine(String.Format("      {0}                    {1}                         {2}", dwarf.Breed, dwarf.Species, dwarf.FullName));
                    }
                    else if (dwarf.Species == "Spitz")
                    {
                        Console.WriteLine(String.Format("      {0}                    {1}                         {2}", dwarf.Breed, dwarf.Species, dwarf.FullName));
                    }
                    else
                    {
                        Console.WriteLine(String.Format("      {0}                    {1}                        {2}", dwarf.Breed, dwarf.Species, dwarf.FullName));
                    }
                }
                else
                {
                    if (dwarf.Species == "Chihuahua")
                    {
                        Console.WriteLine(String.Format("      {0}                    {1}                       {2}", dwarf.Breed, dwarf.Species, dwarf.FullName));
                    }
                    else if (dwarf.Species == "Fox terrier")
                    {
                        Console.WriteLine(String.Format("      {0}                    {1}                     {2}", dwarf.Breed, dwarf.Species, dwarf.FullName));
                    }
                    else if (dwarf.Species == "Naked dog")
                    {
                        Console.WriteLine(String.Format("      {0}                    {1}                       {2}", dwarf.Breed, dwarf.Species, dwarf.FullName));
                    }
                    else if (dwarf.Species == "Griffon")
                    {
                        Console.WriteLine(String.Format("      {0}                    {1}                         {2}", dwarf.Breed, dwarf.Species, dwarf.FullName));
                    }
                    else if (dwarf.Species == "Lasa apso")
                    {
                        Console.WriteLine(String.Format("      {0}                    {1}                       {2}", dwarf.Breed, dwarf.Species, dwarf.FullName));
                    }
                    else if (dwarf.Species == "Maltese")
                    {
                        Console.WriteLine(String.Format("      {0}                    {1}                         {2}", dwarf.Breed, dwarf.Species, dwarf.FullName));
                    }
                    else if (dwarf.Species == "Pinch")
                    {
                        Console.WriteLine(String.Format("      {0}                    {1}                           {2}", dwarf.Breed, dwarf.Species, dwarf.FullName));
                    }
                    else if (dwarf.Species == "Spaniel")
                    {
                        Console.WriteLine(String.Format("      {0}                    {1}                         {2}", dwarf.Breed, dwarf.Species, dwarf.FullName));
                    }
                    else if (dwarf.Species == "Spitz")
                    {
                        Console.WriteLine(String.Format("      {0}                    {1}                           {2}", dwarf.Breed, dwarf.Species, dwarf.FullName));
                    }
                    else
                    {
                        Console.WriteLine(String.Format("      {0}                    {1}                         {2}", dwarf.Breed, dwarf.Species, dwarf.FullName));
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
