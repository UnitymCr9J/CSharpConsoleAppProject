using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpProjekt.Animals
{
    public static class Animal
    {
        public static void GreyhoundList()
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

            Console.WriteLine("     ID             Breed                       Species                        Fullname");
            Console.WriteLine("    ----------------------------------------------------------------------------------------------------------");

            GreyhoundListOutput(Greyhounds);

        }

        public static void GreyhoundListOutput(List<DisplayDogs> Greyhounds)
        {

            var greyhoundlist = from greyhound in Greyhounds
                                select new { Dogid = greyhound.DogId, Dogbreed = greyhound.Breed, Dogspecies = greyhound.Species, DogFullname = greyhound.FullName };

            foreach (var greyhound in greyhoundlist)
            {
                if (greyhound.Dogid >= 1 && greyhound.Dogid < 10)
                {
                    Console.WriteLine(String.Format("      {0}           {1}                    {2}                       {3}", greyhound.Dogid, greyhound.Dogbreed, greyhound.Dogspecies, greyhound.DogFullname));
                }
                else
                {
                    Console.WriteLine(String.Format("      {0}          {1}                    {2}                       {3}", greyhound.Dogid, greyhound.Dogbreed, greyhound.Dogspecies, greyhound.DogFullname));
                }
                Console.WriteLine();
            }
        }

        public static void DwarfDogsList()
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

            Console.WriteLine("     ID             Breed                       Species                        Fullname");
            Console.WriteLine("    ----------------------------------------------------------------------------------------------------------");

            DwarfDogsListOutput(DwarfDogs);

        }

        public static void DwarfDogsListOutput(List<DisplayDogs> DwarfDogs)
        {

            foreach (var dwarf in DwarfDogs)
            {
                if (dwarf.DogId >= 1 && dwarf.DogId < 10)
                {
                    if (dwarf.Species == "Chihuahua")
                    {
                        Console.WriteLine(String.Format("      {0}           {1}                    {2}                       {3}", dwarf.DogId, dwarf.Breed, dwarf.Species, dwarf.FullName));
                    }
                    else if (dwarf.Species == "Fox terrier")
                    {
                        Console.WriteLine(String.Format("      {0}           {1}                    {2}                     {3}", dwarf.DogId, dwarf.Breed, dwarf.Species, dwarf.FullName));
                    }
                    else if (dwarf.Species == "Naked dog")
                    {
                        Console.WriteLine(String.Format("      {0}           {1}                    {2}                       {3}", dwarf.DogId, dwarf.Breed, dwarf.Species, dwarf.FullName));
                    }
                    else if (dwarf.Species == "Griffon")
                    {
                        Console.WriteLine(String.Format("      {0}           {1}                    {2}                         {3}", dwarf.DogId, dwarf.Breed, dwarf.Species, dwarf.FullName));
                    }
                    else if (dwarf.Species == "Lasa apso")
                    {
                        Console.WriteLine(String.Format("      {0}           {1}                    {2}                       {3}", dwarf.DogId, dwarf.Breed, dwarf.Species, dwarf.FullName));
                    }
                    else if (dwarf.Species == "Maltese")
                    {
                        Console.WriteLine(String.Format("      {0}           {1}                    {2}                         {3}", dwarf.DogId, dwarf.Breed, dwarf.Species, dwarf.FullName));
                    }
                    else if (dwarf.Species == "Pinch")
                    {
                        Console.WriteLine(String.Format("      {0}           {1}                    {2}                           {3}", dwarf.DogId, dwarf.Breed, dwarf.Species, dwarf.FullName));
                    }
                    else if (dwarf.Species == "Spaniel")
                    {
                        Console.WriteLine(String.Format("      {0}           {1}                    {2}                         {3}", dwarf.DogId, dwarf.Breed, dwarf.Species, dwarf.FullName));
                    }
                    else if (dwarf.Species == "Spitz")
                    {
                        Console.WriteLine(String.Format("      {0}          {1}                    {2}                         {3}", dwarf.DogId, dwarf.Breed, dwarf.Species, dwarf.FullName));
                    }
                    else
                    {
                        Console.WriteLine(String.Format("      {0}          {1}                    {2}                        {3}", dwarf.DogId, dwarf.Breed, dwarf.Species, dwarf.FullName));
                    }
                }
                else
                {
                    if (dwarf.Species == "Chihuahua")
                    {
                        Console.WriteLine(String.Format("      {0}           {1}                    {2}                       {3}", dwarf.DogId, dwarf.Breed, dwarf.Species, dwarf.FullName));
                    }
                    else if (dwarf.Species == "Fox terrier")
                    {
                        Console.WriteLine(String.Format("      {0}           {1}                    {2}                     {3}", dwarf.DogId, dwarf.Breed, dwarf.Species, dwarf.FullName));
                    }
                    else if (dwarf.Species == "Naked dog")
                    {
                        Console.WriteLine(String.Format("      {0}           {1}                    {2}                       {3}", dwarf.DogId, dwarf.Breed, dwarf.Species, dwarf.FullName));
                    }
                    else if (dwarf.Species == "Griffon")
                    {
                        Console.WriteLine(String.Format("      {0}           {1}                    {2}                         {3}", dwarf.DogId, dwarf.Breed, dwarf.Species, dwarf.FullName));
                    }
                    else if (dwarf.Species == "Lasa apso")
                    {
                        Console.WriteLine(String.Format("      {0}           {1}                    {2}                       {3}", dwarf.DogId, dwarf.Breed, dwarf.Species, dwarf.FullName));
                    }
                    else if (dwarf.Species == "Maltese")
                    {
                        Console.WriteLine(String.Format("      {0}           {1}                    {2}                         {3}", dwarf.DogId, dwarf.Breed, dwarf.Species, dwarf.FullName));
                    }
                    else if (dwarf.Species == "Pinch")
                    {
                        Console.WriteLine(String.Format("      {0}           {1}                    {2}                           {3}", dwarf.DogId, dwarf.Breed, dwarf.Species, dwarf.FullName));
                    }
                    else if (dwarf.Species == "Spaniel")
                    {
                        Console.WriteLine(String.Format("      {0}          {1}                    {2}                         {3}", dwarf.DogId, dwarf.Breed, dwarf.Species, dwarf.FullName));
                    }
                    else if (dwarf.Species == "Spitz")
                    {
                        Console.WriteLine(String.Format("      {0}          {1}                    {2}                           {3}", dwarf.DogId, dwarf.Breed, dwarf.Species, dwarf.FullName));
                    }
                    else
                    {
                        Console.WriteLine(String.Format("      {0}          {1}                    {2}                         {3}", dwarf.DogId, dwarf.Breed, dwarf.Species, dwarf.FullName));
                    }
                }
                Console.WriteLine();
            }
        }

        public static void FollowerDogsList()
        {
            List<DisplayDogs> FollowerDogs = new List<DisplayDogs>()
            {
                new DisplayDogs
                {
                    DogId = 1,
                    Breed = "Follower dog",
                    Species = "Bulldog",
                    FullName = "African naked dog"
                },
                new DisplayDogs
                {
                    DogId = 2,
                    Breed = "Follower dog",
                    Species = "Bulldog",
                    FullName = "English buldog"
                },
                new DisplayDogs
                {
                    DogId = 3,
                    Breed = "Follower dog",
                    Species = "Bulldog",
                    FullName = "French bulldog"
                },
                new DisplayDogs
                {
                    DogId = 4,
                    Breed = "Follower dog",
                    Species = "Chow Chow",
                    FullName = "Chow Chow"
                },
                new DisplayDogs
                {
                    DogId = 5,
                    Breed = "Follower dog",
                    Species = "Fox terrier",
                    FullName = "Chromeforlander"
                },
                new DisplayDogs
                {
                    DogId = 6,
                    Breed = "Follower dog",
                    Species = "Hound",
                    FullName = "Dalmatian"
                },
                new DisplayDogs
                {
                    DogId = 7,
                    Breed = "Follower dog",
                    Species = "Griffon",
                    FullName = "Belgian dwarf griffon"
                },
                new DisplayDogs
                {
                    DogId = 8,
                    Breed = "Follower dog",
                    Species = "Griffon",
                    FullName = "Brabant dwarf griffon"
                },
                new DisplayDogs
                {
                    DogId = 9,
                    Breed = "Follower dog",
                    Species = "Loser dog",
                    FullName = "Dwarf loser"
                },
                new DisplayDogs
                {
                    DogId = 10,
                    Breed = "Follower dog",
                    Species = "Mops",
                    FullName = "Mops"
                },
                new DisplayDogs
                {
                    DogId = 11,
                    Breed = "Follower dog",
                    Species = "Pinch",
                    FullName = "Harlequin pinch"
                },
                new DisplayDogs
                {
                    DogId = 12,
                    Breed = "Follower dog",
                    Species = "Pinch",
                    FullName = "German pinch"
                },
                new DisplayDogs
                {
                    DogId = 13,
                    Breed = "Follower dog",
                    Species = "Pudl",
                    FullName = "Pudl"
                },
                new DisplayDogs
                {
                    DogId = 14,
                    Breed = "Follower dog",
                    Species = "Spaniel",
                    FullName = "King Charles cavalier spaniel"
                },
                new DisplayDogs
                {
                    DogId = 15,
                    Breed = "Follower dog",
                    Species = "Spaniel",
                    FullName = "Tibetan spaniel"
                },
                new DisplayDogs
                {
                    DogId = 16,
                    Breed = "Follower dog",
                    Species = "Char Pei",
                    FullName = "Char Pei"
                },
                new DisplayDogs
                {
                    DogId = 17,
                    Breed = "Follower dog",
                    Species = "Maltese",
                    FullName = "Silky havanese dog"
                },
                new DisplayDogs
                {
                    DogId = 18,
                    Breed = "Follower dog",
                    Species = "Shiba Inu",
                    FullName = "Shiba Inu"
                },
                new DisplayDogs
                {
                    DogId = 19,
                    Breed = "Follower dog",
                    Species = "Spitz",
                    FullName = "Belgian spitz"
                },
                new DisplayDogs
                {
                    DogId = 20,
                    Breed = "Follower dog",
                    Species = "Spitz",
                    FullName = "Japanese spitz"
                },
                new DisplayDogs
                {
                    DogId = 21,
                    Breed = "Follower dog",
                    Species = "Spitz",
                    FullName = "Little spitz"
                },
                new DisplayDogs
                {
                    DogId = 22,
                    Breed = "Follower dog",
                    Species = "Spitz",
                    FullName = "Italian spitz"
                },
                new DisplayDogs
                {
                    DogId = 23,
                    Breed = "Follower dog",
                    Species = "Spitz",
                    FullName = "German big spitz"
                },
                new DisplayDogs
                {
                    DogId = 24,
                    Breed = "Follower dog",
                    Species = "Telomian",
                    FullName = "Telomian"
                }
            };

            Console.WriteLine("     ID             Breed                       Species                        Fullname");
            Console.WriteLine("    ----------------------------------------------------------------------------------------------------------");

            FollowerDogsListOutput(FollowerDogs);

        }

        public static void FollowerDogsListOutput(List<DisplayDogs> FollowerDogs)
        {

            foreach (var follower in FollowerDogs)
            {
                if (follower.DogId >= 1 && follower.DogId < 10)
                {
                    switch (follower.Species)
                    {
                        case "Bulldog":
                            Console.WriteLine(String.Format("      {0}          {1}                  {2}                         {3}", follower.DogId, follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Chow Chow":
                            Console.WriteLine(String.Format("      {0}          {1}                  {2}                       {3}", follower.DogId, follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Fox terrier":
                            Console.WriteLine(String.Format("      {0}          {1}                  {2}                     {3}", follower.DogId, follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Hound":
                            Console.WriteLine(String.Format("      {0}          {1}                  {2}                           {3}", follower.DogId, follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Griffon":
                            Console.WriteLine(String.Format("      {0}          {1}                  {2}                         {3}", follower.DogId, follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Loser dog":
                            Console.WriteLine(String.Format("      {0}          {1}                  {2}                       {3}", follower.DogId, follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Mops":
                            Console.WriteLine(String.Format("      {0}          {1}                  {2}                         {3}", follower.DogId, follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Pinch":
                            Console.WriteLine(String.Format("      {0}          {1}                  {2}                         {3}", follower.DogId, follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Pudl":
                            Console.WriteLine(String.Format("      {0}          {1}                  {2}                         {3}", follower.DogId, follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Spaniel":
                            Console.WriteLine(String.Format("      {0}          {1}                  {2}                         {3}", follower.DogId, follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Char Pei":
                            Console.WriteLine(String.Format("      {0}             {1}                  {2}                         {3}", follower.DogId, follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Maltese":
                            Console.WriteLine(String.Format("      {0}             {1}                  {2}                         {3}", follower.DogId, follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Shiba Inu":
                            Console.WriteLine(String.Format("      {0}             {1}                  {2}                         {3}", follower.DogId, follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Spitz":
                            Console.WriteLine(String.Format("      {0}             {1}                  {2}                         {3}", follower.DogId, follower.Breed, follower.Species, follower.FullName));
                            break;

                        default:
                            Console.WriteLine(String.Format("      {0}             {1}                  {2}                         {3}", follower.DogId, follower.Breed, follower.Species, follower.FullName));
                            break;

                    }
                }
                else
                {
                    switch (follower.Species)
                    {
                        case "Bulldog":
                            Console.WriteLine(String.Format("      {0}         {1}                  {2}                         {3}", follower.DogId, follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Chow Chow":
                            Console.WriteLine(String.Format("      {0}         {1}                  {2}                         {3}", follower.DogId, follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Fox terrier":
                            Console.WriteLine(String.Format("      {0}         {1}                  {2}                         {3}", follower.DogId, follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Hound":
                            Console.WriteLine(String.Format("      {0}         {1}                  {2}                         {3}", follower.DogId, follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Griffon":
                            Console.WriteLine(String.Format("      {0}         {1}                  {2}                         {3}", follower.DogId, follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Loser dog":
                            Console.WriteLine(String.Format("      {0}         {1}                  {2}                    {3}", follower.DogId, follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Mops":
                            Console.WriteLine(String.Format("      {0}         {1}                  {2}                            {3}", follower.DogId, follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Pinch":
                            Console.WriteLine(String.Format("      {0}         {1}                  {2}                           {3}", follower.DogId, follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Pudl":
                            Console.WriteLine(String.Format("      {0}         {1}                  {2}                            {3}", follower.DogId, follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Spaniel":
                            Console.WriteLine(String.Format("      {0}         {1}                  {2}                         {3}", follower.DogId, follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Char Pei":
                            Console.WriteLine(String.Format("      {0}         {1}                  {2}                        {3}", follower.DogId, follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Maltese":
                            Console.WriteLine(String.Format("      {0}         {1}                  {2}                         {3}", follower.DogId, follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Shiba Inu":
                            Console.WriteLine(String.Format("      {0}         {1}                  {2}                       {3}", follower.DogId, follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Spitz":
                            Console.WriteLine(String.Format("      {0}         {1}                  {2}                           {3}", follower.DogId, follower.Breed, follower.Species, follower.FullName));
                            break;

                        default:
                            Console.WriteLine(String.Format("      {0}         {1}                  {2}                        {3}", follower.DogId, follower.Breed, follower.Species, follower.FullName));
                            break;

                    }
                }
                Console.WriteLine();
            }
        }

        public static void HuntingDogsList()
        {
            List<DisplayDogs> HuntingDogs = new List<DisplayDogs>()
            {
                new DisplayDogs
                {
                    DogId = 1,
                    Breed = "Hunting dog",
                    Species = "Basset",
                    FullName = "Artois norman basset"
                },
                new DisplayDogs
                {
                    DogId = 2,
                    Breed = "Hunting dog",
                    Species = "Basset",
                    FullName = "English basset"
                },
                new DisplayDogs
                {
                    DogId = 3,
                    Breed = "Hunting dog",
                    Species = "Basset",
                    FullName = "Blue gascon basset"
                },
                new DisplayDogs
                {
                    DogId = 4,
                    Breed = "Hunting dog",
                    Species = "Basset",
                    FullName = "Ginger breton sharp-haired basset"
                },
                new DisplayDogs
                {
                    DogId = 5,
                    Breed = "Hunting dog",
                    Species = "Basset",
                    FullName = "Vendean sharp-haired basset"
                },
                new DisplayDogs
                {
                    DogId = 6,
                    Breed = "Hunting dog",
                    Species = "Basenji",
                    FullName = "Basenji"
                },
                new DisplayDogs
                {
                    DogId = 7,
                    Breed = "Hunting dog",
                    Species = "Doga",
                    FullName = "Brazilian doga"
                },
                new DisplayDogs
                {
                    DogId = 8,
                    Breed = "Hunting dog",
                    Species = "Hound",
                    FullName = "Bernese hound"
                },
                new DisplayDogs
                {
                    DogId = 9,
                    Breed = "Hunting dog",
                    Species = "Hound",
                    FullName = "White colored raccoon hound"
                },
                new DisplayDogs
                {
                    DogId = 10,
                    Breed = "Hunting dog",
                    Species = "Hound",
                    FullName = "Bosnian sharp-haired hound"
                },
                new DisplayDogs
                {
                    DogId = 11,
                    Breed = "Hunting dog",
                    Species = "Hound",
                    FullName = "Austrian hound"
                },
                new DisplayDogs
                {
                    DogId = 12,
                    Breed = "Hunting dog",
                    Species = "Hound",
                    FullName = "Arijenese hound"
                },
                new DisplayDogs
                {
                    DogId = 13,
                    Breed = "Hunting dog",
                    Species = "Hound",
                    FullName = "Balkan hound"
                },
                new DisplayDogs
                {
                    DogId = 14,
                    Breed = "Hunting dog",
                    Species = "Hound",
                    FullName = "Bavarian bloodline"
                },
                new DisplayDogs
                {
                    DogId = 15,
                    Breed = "Hunting dog",
                    Species = "Hound",
                    FullName = "Mountain spanish hound"
                },
                new DisplayDogs
                {
                    DogId = 16,
                    Breed = "Hunting dog",
                    Species = "Hound",
                    FullName = "Red raccoon hound"
                },
                new DisplayDogs
                {
                    DogId = 17,
                    Breed = "Hunting dog",
                    Species = "Hound",
                    FullName = "Red colored raccoon hound"
                },
                new DisplayDogs
                {
                    DogId = 18,
                    Breed = "Hunting dog",
                    Species = "Hound",
                    FullName = "Dunker hound"
                },
                new DisplayDogs
                {
                    DogId = 19,
                    Breed = "Hunting dog",
                    Species = "Hound",
                    FullName = "Finnish hound"
                },
                new DisplayDogs
                {
                    DogId = 20,
                    Breed = "Hunting dog",
                    Species = "Hound",
                    FullName = "Finnish birds hound"
                },
                new DisplayDogs
                {
                    DogId = 21,
                    Breed = "Hunting dog",
                    Species = "Hound",
                    FullName = "French hound"
                },
                new DisplayDogs
                {
                    DogId = 22,
                    Breed = "Hunting dog",
                    Species = "Hound",
                    FullName = "Little blue gascon hound"
                },
                new DisplayDogs
                {
                    DogId = 23,
                    Breed = "Hunting dog",
                    Species = "Hound",
                    FullName = "Tennessee hound"
                },
                new DisplayDogs
                {
                    DogId = 24,
                    Breed = "Hunting dog",
                    Species = "Hound",
                    FullName = "Raccoon hound"
                },
                new DisplayDogs
                {
                    DogId = 25,
                    Breed = "Hunting dog",
                    Species = "Hound",
                    FullName = "Otter hound"
                },
                new DisplayDogs
                {
                    DogId = 26,
                    Breed = "Hunting dog",
                    Species = "Hound",
                    FullName = "Greek hound"
                },
                new DisplayDogs
                {
                    DogId = 27,
                    Breed = "Hunting dog",
                    Species = "Hound",
                    FullName = "Halden hound"
                },
                new DisplayDogs
                {
                    DogId = 28,
                    Breed = "Hunting dog",
                    Species = "Hound",
                    FullName = "Hamilton hound"
                },
                new DisplayDogs
                {
                    DogId = 29,
                    Breed = "Hunting dog",
                    Species = "Hound",
                    FullName = "Hannover bloodline"
                },
                new DisplayDogs
                {
                    DogId = 30,
                    Breed = "Hunting dog",
                    Species = "Hound",
                    FullName = "Higen hound"
                },
                new DisplayDogs
                {
                    DogId = 31,
                    Breed = "Hunting dog",
                    Species = "Hound",
                    FullName = "Ibizan humpbacked hound"
                },
                new DisplayDogs
                {
                    DogId = 32,
                    Breed = "Hunting dog",
                    Species = "Hound",
                    FullName = "Istrian shorthair hound"
                },
                new DisplayDogs
                {
                    DogId = 33,
                    Breed = "Hunting dog",
                    Species = "Hound",
                    FullName = "Istrian sharp-haired hound"
                },
                new DisplayDogs
                {
                    DogId = 34,
                    Breed = "Hunting dog",
                    Species = "Hound",
                    FullName = "Jamtlandic salmon hound"
                },
                new DisplayDogs
                {
                    DogId = 35,
                    Breed = "Hunting dog",
                    Species = "Hound",
                    FullName = "Jurrasic hound"
                },
                new DisplayDogs
                {
                    DogId = 36,
                    Breed = "Hunting dog",
                    Species = "Hound",
                    FullName = "Karelian bear hound"
                },
                new DisplayDogs
                {
                    DogId = 37,
                    Breed = "Hunting dog",
                    Species = "Hound",
                    FullName = "Levesk hound"
                },
                new DisplayDogs
                {
                    DogId = 38,
                    Breed = "Hunting dog",
                    Species = "Hound",
                    FullName = "Lucern hound"
                },
                new DisplayDogs
                {
                    DogId = 39,
                    Breed = "Hunting dog",
                    Species = "Hound",
                    FullName = "Hungarian hound"
                },
                new DisplayDogs
                {
                    DogId = 40,
                    Breed = "Hunting dog",
                    Species = "Hound",
                    FullName = "Little british-french hound"
                },
                new DisplayDogs
                {
                    DogId = 41,
                    Breed = "Hunting dog",
                    Species = "Hound",
                    FullName = "Little gascon hound"
                },
                new DisplayDogs
                {
                    DogId = 42,
                    Breed = "Hunting dog",
                    Species = "Hound",
                    FullName = "Nivern sharp-haired hound"
                },
                new DisplayDogs
                {
                    DogId = 43,
                    Breed = "Hunting dog",
                    Species = "Hound",
                    FullName = "Little portuguese humpbacked hound"
                },
                new DisplayDogs
                {
                    DogId = 44,
                    Breed = "Hunting dog",
                    Species = "Hound",
                    FullName = "Norwegian salmon hound"
                },
                new DisplayDogs
                {
                    DogId = 45,
                    Breed = "Hunting dog",
                    Species = "Hound",
                    FullName = "Norwegian duck hound"
                },
                new DisplayDogs
                {
                    DogId = 46,
                    Breed = "Hunting dog",
                    Species = "Hound",
                    FullName = "German hound"
                },
                new DisplayDogs
                {
                    DogId = 47,
                    Breed = "Hunting dog",
                    Species = "Hound",
                    FullName = "Saint Hubert dog"
                },
                new DisplayDogs
                {
                    DogId = 48,
                    Breed = "Hunting dog",
                    Species = "Hound",
                    FullName = "Mountain hound"
                },
                new DisplayDogs
                {
                    DogId = 49,
                    Breed = "Hunting dog",
                    Species = "Hound",
                    FullName = "Plot hound"
                },
                new DisplayDogs
                {
                    DogId = 50,
                    Breed = "Hunting dog",
                    Species = "Hound",
                    FullName = "Blue raccoon hound"
                },
                new DisplayDogs
                {
                    DogId = 51,
                    Breed = "Hunting dog",
                    Species = "Hound",
                    FullName = "Poateven hound"
                },
                new DisplayDogs
                {
                    DogId = 52,
                    Breed = "Hunting dog",
                    Species = "Hound",
                    FullName = "Field hound"
                },
                new DisplayDogs
                {
                    DogId = 53,
                    Breed = "Hunting dog",
                    Species = "Hound",
                    FullName = "Posavina hound"
                },
                new DisplayDogs
                {
                    DogId = 54,
                    Breed = "Hunting dog",
                    Species = "Hound",
                    FullName = "Rhodesian hound"
                },
                new DisplayDogs
                {
                    DogId = 55,
                    Breed = "Hunting dog",
                    Species = "Hound",
                    FullName = "Porcelain hound"
                },
                new DisplayDogs
                {
                    DogId = 56,
                    Breed = "Hunting dog",
                    Species = "Hound",
                    FullName = "Skandinavian grey hound"
                },
                new DisplayDogs
                {
                    DogId = 57,
                    Breed = "Hunting dog",
                    Species = "Hound",
                    FullName = "Smaland hound"
                },
                new DisplayDogs
                {
                    DogId = 58,
                    Breed = "Hunting dog",
                    Species = "Hound",
                    FullName = "Sicilian humpbacked hound"
                },
                new DisplayDogs
                {
                    DogId = 59,
                    Breed = "Hunting dog",
                    Species = "Hound",
                    FullName = "Middle artois hound"
                },
                new DisplayDogs
                {
                    DogId = 60,
                    Breed = "Hunting dog",
                    Species = "Hound",
                    FullName = "Slovak hound"
                },
                new DisplayDogs
                {
                    DogId = 61,
                    Breed = "Hunting dog",
                    Species = "Hound",
                    FullName = "Middle sharp-haired vendean hound"
                },
                new DisplayDogs
                {
                    DogId = 62,
                    Breed = "Hunting dog",
                    Species = "Hound",
                    FullName = "Middle portuguese humpbacked hound"
                },
                new DisplayDogs
                {
                    DogId = 63,
                    Breed = "Hunting dog",
                    Species = "Hound",
                    FullName = "Swedish short-legged hound"
                },
                new DisplayDogs
                {
                    DogId = 64,
                    Breed = "Hunting dog",
                    Species = "Hound",
                    FullName = "Schiller hound"
                },
                new DisplayDogs
                {
                    DogId = 65,
                    Breed = "Hunting dog",
                    Species = "Hound",
                    FullName = "Middle british-french hound"
                },
                new DisplayDogs
                {
                    DogId = 66,
                    Breed = "Hunting dog",
                    Species = "Hound",
                    FullName = "Swiss hound"
                },
                new DisplayDogs
                {
                    DogId = 67,
                    Breed = "Hunting dog",
                    Species = "Hound",
                    FullName = "Swiss short-legged hound"
                },
                new DisplayDogs
                {
                    DogId = 68,
                    Breed = "Hunting dog",
                    Species = "Hound",
                    FullName = "Styrian high mountain sharp-haired hound"
                },
                new DisplayDogs
                {
                    DogId = 69,
                    Breed = "Hunting dog",
                    Species = "Hound",
                    FullName = "Italian hound"
                },
                new DisplayDogs
                {
                    DogId = 70,
                    Breed = "Hunting dog",
                    Species = "Hound",
                    FullName = "Tyrolean hound"
                },
                new DisplayDogs
                {
                    DogId = 71,
                    Breed = "Hunting dog",
                    Species = "Hound",
                    FullName = "Trigov dog"
                },
                new DisplayDogs
                {
                    DogId = 72,
                    Breed = "Hunting dog",
                    Species = "Hound",
                    FullName = "Big portuguese humpbacked hound"
                },
                new DisplayDogs
                {
                    DogId = 73,
                    Breed = "Hunting dog",
                    Species = "Hound",
                    FullName = "Big british-french hound"
                },
                new DisplayDogs
                {
                    DogId = 74,
                    Breed = "Hunting dog",
                    Species = "Hound",
                    FullName = "Big gascon sentojoanski hound"
                },
                new DisplayDogs
                {
                    DogId = 75,
                    Breed = "Hunting dog",
                    Species = "Hound",
                    FullName = "Big blue gascon hound"
                },
                new DisplayDogs
                {
                    DogId = 76,
                    Breed = "Hunting dog",
                    Species = "Hound",
                    FullName = "Big vendean sharp-haired hound"
                },
                new DisplayDogs
                {
                    DogId = 77,
                    Breed = "Hunting dog",
                    Species = "Hound",
                    FullName = "Yellow sharp-haired breton hound"
                },
                new DisplayDogs
                {
                    DogId = 78,
                    Breed = "Hunting dog",
                    Species = "Epaniel",
                    FullName = "Breton epaniel"
                },
                new DisplayDogs
                {
                    DogId = 79,
                    Breed = "Hunting dog",
                    Species = "Epaniel",
                    FullName = "French epaniel"
                },
                new DisplayDogs
                {
                    DogId = 80,
                    Breed = "Hunting dog",
                    Species = "Epaniel",
                    FullName = "Picardy epaniel"
                },
                new DisplayDogs
                {
                    DogId = 81,
                    Breed = "Hunting dog",
                    Species = "Epaniel",
                    FullName = "Pon overseas epaniel"
                },
                new DisplayDogs
                {
                    DogId = 82,
                    Breed = "Hunting dog",
                    Species = "Dachshund",
                    FullName = "Marriage dachshund"
                },
                new DisplayDogs
                {
                    DogId = 83,
                    Breed = "Hunting dog",
                    Species = "Dachshund",
                    FullName = "Longhaired dachshund"
                },
                new DisplayDogs
                {
                    DogId = 84,
                    Breed = "Hunting dog",
                    Species = "Dachshund",
                    FullName = "Shorthaired dachshund"
                },
                new DisplayDogs
                {
                    DogId = 85,
                    Breed = "Hunting dog",
                    Species = "Dachshund",
                    FullName = "Westphalian marriage dachshund"
                },
                new DisplayDogs
                {
                    DogId = 86,
                    Breed = "Hunting dog",
                    Species = "Foxhound",
                    FullName = "American foxhound"
                },
                new DisplayDogs
                {
                    DogId = 87,
                    Breed = "Hunting dog",
                    Species = "Foxhound",
                    FullName = "English foxhound"
                },
                new DisplayDogs
                {
                    DogId = 88,
                    Breed = "Hunting dog",
                    Species = "Pointer",
                    FullName = "Frisian pointer"
                },
                new DisplayDogs
                {
                    DogId = 89,
                    Breed = "Hunting dog",
                    Species = "Pointer",
                    FullName = "Dutch pointer"
                },
                new DisplayDogs
                {
                    DogId = 90,
                    Breed = "Hunting dog",
                    Species = "Pointer",
                    FullName = "German pointer",
                },
                new DisplayDogs
                {
                    DogId = 91,
                    Breed = "Hunting dog",
                    Species = "Bird watcher",
                    FullName = "Arijenese bird watcher"
                },
                new DisplayDogs
                {
                    DogId = 92,
                    Breed = "Hunting dog",
                    Species = "Bird watcher",
                    FullName = "French bearded bird watcher"
                },
                new DisplayDogs
                {
                    DogId = 93,
                    Breed = "Hunting dog",
                    Species = "Bird watcher",
                    FullName = "Bule's woolly hair bird watcher"
                },
                new DisplayDogs
                {
                    DogId = 94,
                    Breed = "Hunting dog",
                    Species = "Bird watcher",
                    FullName = "Bourbon bird watcher"
                },
                new DisplayDogs
                {
                    DogId = 95,
                    Breed = "Hunting dog",
                    Species = "Bird watcher",
                    FullName = "Dipui's bird watcher"
                },
                new DisplayDogs
                {
                    DogId = 96,
                    Breed = "Hunting dog",
                    Species = "Bird watcher",
                    FullName = "Burgos bird watcher"
                },
                new DisplayDogs
                {
                    DogId = 97,
                    Breed = "Hunting dog",
                    Species = "Bird watcher",
                    FullName = "Czech sharp-haired bird watcher"
                },
                new DisplayDogs
                {
                    DogId = 98,
                    Breed = "Hunting dog",
                    Species = "Bird watcher",
                    FullName = "Denmark shorthair bird watcher"
                },
                new DisplayDogs
                {
                    DogId = 99,
                    Breed = "Hunting dog",
                    Species = "Bird watcher",
                    FullName = "French shorthair bird watcher"
                },
                new DisplayDogs
                {
                    DogId = 100,
                    Breed = "Hunting dog",
                    Species = "Bird watcher",
                    FullName = "English shorthair bird watcher"
                },
                new DisplayDogs
                {
                    DogId = 101,
                    Breed = "Hunting dog",
                    Species = "Bird watcher",
                    FullName = "Korthalsov sharp-haired bird watcher"
                },
                new DisplayDogs
                {
                    DogId = 102,
                    Breed = "Hunting dog",
                    Species = "Bird watcher",
                    FullName = "Hungarian shorthair bird watcher"
                },
                new DisplayDogs
                {
                    DogId = 103,
                    Breed = "Hunting dog",
                    Species = "Bird watcher",
                    FullName = "Little minstrelsy bird watcher"
                },
                new DisplayDogs
                {
                    DogId = 104,
                    Breed = "Hunting dog",
                    Species = "Bird watcher",
                    FullName = "Dutch bird watcher"
                },
                new DisplayDogs
                {
                    DogId = 105,
                    Breed = "Hunting dog",
                    Species = "Bird watcher",
                    FullName = "German longhair bird watcher"
                },
                new DisplayDogs
                {
                    DogId = 106,
                    Breed = "Hunting dog",
                    Species = "Bird watcher",
                    FullName = "German shorthair bird watcher"
                },
                new DisplayDogs
                {
                    DogId = 107,
                    Breed = "Hunting dog",
                    Species = "Bird watcher",
                    FullName = "Auvergne bird watcher"
                },
                new DisplayDogs
                {
                    DogId = 108,
                    Breed = "Hunting dog",
                    Species = "Bird watcher",
                    FullName = "Portuguese shorthair bird watcher"
                },
                new DisplayDogs
                {
                    DogId = 109,
                    Breed = "Hunting dog",
                    Species = "Bird watcher",
                    FullName = "Saint-Germain bird watcher"
                },
                new DisplayDogs
                {
                    DogId = 110,
                    Breed = "Hunting dog",
                    Species = "Bird watcher",
                    FullName = "Pudlpointer"
                },
                new DisplayDogs
                {
                    DogId = 111,
                    Breed = "Hunting dog",
                    Species = "Bird watcher",
                    FullName = "Italian shorthair bird watcher"
                },
                new DisplayDogs
                {
                    DogId = 112,
                    Breed = "Hunting dog",
                    Species = "Bird watcher",
                    FullName = "Italian sharp-haired bird watcher"
                },
                new DisplayDogs
                {
                    DogId = 113,
                    Breed = "Hunting dog",
                    Species = "Bird watcher",
                    FullName = "Weimar bird watcher"
                },
                new DisplayDogs
                {
                    DogId = 114,
                    Breed = "Hunting dog",
                    Species = "Bird watcher",
                    FullName = "Big minstrelsy bird watcher"
                },
                new DisplayDogs
                {
                    DogId = 115,
                    Breed = "Hunting dog",
                    Species = "Setter",
                    FullName = "English setter"
                },
                new DisplayDogs
                {
                    DogId = 116,
                    Breed = "Hunting dog",
                    Species = "Setter",
                    FullName = "Gordon setter"
                },
                new DisplayDogs
                {
                    DogId = 117,
                    Breed = "Hunting dog",
                    Species = "Setter",
                    FullName = "Irish setter"
                },
                new DisplayDogs
                {
                    DogId = 118,
                    Breed = "Hunting dog",
                    Species = "Retriever",
                    FullName = "Longhair retriever"
                },
                new DisplayDogs
                {
                    DogId = 119,
                    Breed = "Hunting dog",
                    Species = "Retriever",
                    FullName = "Curly retriever"
                },
                new DisplayDogs
                {
                    DogId = 120,
                    Breed = "Hunting dog",
                    Species = "Retriever",
                    FullName = "Labrador retriever"
                },
                new DisplayDogs
                {
                    DogId = 121,
                    Breed = "Hunting dog",
                    Species = "Retriever",
                    FullName = "Chesapeake Bay retriever"
                },
                new DisplayDogs
                {
                    DogId = 122,
                    Breed = "Hunting dog",
                    Species = "Retriever",
                    FullName = "Golden retriever"
                },
                new DisplayDogs
                {
                    DogId = 123,
                    Breed = "Hunting dog",
                    Species = "Spaniel",
                    FullName = "American cocker spaniel"
                },
                new DisplayDogs
                {
                    DogId = 124,
                    Breed = "Hunting dog",
                    Species = "Spaniel",
                    FullName = "American water spaniel"
                },
                new DisplayDogs
                {
                    DogId = 125,
                    Breed = "Hunting dog",
                    Species = "Spaniel",
                    FullName = "Boykin spaniel"
                },
                new DisplayDogs
                {
                    DogId = 126,
                    Breed = "Hunting dog",
                    Species = "Spaniel",
                    FullName = "English cocker spaniel"
                },
                new DisplayDogs
                {
                    DogId = 127,
                    Breed = "Hunting dog",
                    Species = "Spaniel",
                    FullName = "English springer spaniel"
                },
                new DisplayDogs
                {
                    DogId = 128,
                    Breed = "Hunting dog",
                    Species = "Spaniel",
                    FullName = "Irish water spaniel"
                },
                new DisplayDogs
                {
                    DogId = 129,
                    Breed = "Hunting dog",
                    Species = "Spaniel",
                    FullName = "Clamp spaniel"
                },
                new DisplayDogs
                {
                    DogId = 130,
                    Breed = "Hunting dog",
                    Species = "Spaniel",
                    FullName = "Field spaniel"
                },
                new DisplayDogs
                {
                    DogId = 131,
                    Breed = "Hunting dog",
                    Species = "Spaniel",
                    FullName = "Sasik spaniel"
                },
                new DisplayDogs
                {
                    DogId = 132,
                    Breed = "Hunting dog",
                    Species = "Spaniel",
                    FullName = "Welsh springer spaniel"
                },
                new DisplayDogs
                {
                    DogId = 133,
                    Breed = "Hunting dog",
                    Species = "Beagle",
                    FullName = "Beagle"
                },
                new DisplayDogs
                {
                    DogId = 134,
                    Breed = "Hunting dog",
                    Species = "Beagle",
                    FullName = "English beagle"
                },
                new DisplayDogs
                {
                    DogId = 135,
                    Breed = "Hunting dog",
                    Species = "Beagle",
                    FullName = "Somersetian beagle"
                }
            };

            Console.WriteLine("     ID             Breed                       Species                        Fullname");
            Console.WriteLine("    --------------------------------------------------------------------------------------------------------------------");

            HuntingDogsListOutput(HuntingDogs);

        }

        public static void HuntingDogsListOutput(List<DisplayDogs> HuntingDogs)
        {

            var hunters = HuntingDogs.Select(z => z);

            foreach (var hunt in hunters)
            {
                if (hunt.DogId >= 1 && hunt.DogId < 10)
                {
                    switch (hunt.Species)
                    {
                        case "Basset":
                            Console.WriteLine(String.Format("      {0}          {1}                   {2}                          {3}", hunt.DogId, hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Basenji":
                            Console.WriteLine(String.Format("      {0}          {1}                   {2}                         {3}", hunt.DogId, hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Doga":
                            Console.WriteLine(String.Format("      {0}          {1}                   {2}                            {3}", hunt.DogId, hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Hound":
                            Console.WriteLine(String.Format("      {0}          {1}                   {2}                           {3}", hunt.DogId, hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Epaniel":
                            Console.WriteLine(String.Format("      {0}            {1}                   {2}                      {3}", hunt.DogId, hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Dachshund":
                            Console.WriteLine(String.Format("      {0}            {1}                   {2}                      {3}", hunt.DogId, hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Foxhound":
                            Console.WriteLine(String.Format("      {0}            {1}                   {2}                      {3}", hunt.DogId, hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Pointer":
                            Console.WriteLine(String.Format("      {0}            {1}                   {2}                      {3}", hunt.DogId, hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Bird watcher":
                            Console.WriteLine(String.Format("      {0}            {1}                    {2}                      {3}", hunt.DogId, hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Setter":
                            Console.WriteLine(String.Format("      {0}            {1}                    {2}                      {3}", hunt.DogId, hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Retriever":
                            Console.WriteLine(String.Format("      {0}            {1}                    {2}                      {3}", hunt.DogId, hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Spaniel":
                            Console.WriteLine(String.Format("      {0}            {1}                    {2}                      {3}", hunt.DogId, hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Beagle":
                            Console.WriteLine(String.Format("      {0}            {1}                    {2}                      {3}", hunt.DogId, hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                    }
                }
                else if (hunt.DogId >= 10 && hunt.DogId < 100)
                {
                    switch (hunt.Species)
                    {
                        case "Basset":
                            Console.WriteLine(String.Format("      {0}         {1}                   {2}                      {3}", hunt.DogId, hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Basenji":
                            Console.WriteLine(String.Format("      {0}         {1}                   {2}                      {3}", hunt.DogId, hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Doga":
                            Console.WriteLine(String.Format("      {0}         {1}                   {2}                      {3}", hunt.DogId, hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Hound":
                            Console.WriteLine(String.Format("      {0}         {1}                   {2}                           {3}", hunt.DogId, hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Epaniel":
                            Console.WriteLine(String.Format("      {0}         {1}                   {2}                         {3}", hunt.DogId, hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Dachshund":
                            Console.WriteLine(String.Format("      {0}         {1}                   {2}                       {3}", hunt.DogId, hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Foxhound":
                            Console.WriteLine(String.Format("      {0}         {1}                   {2}                        {3}", hunt.DogId, hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Pointer":
                            Console.WriteLine(String.Format("      {0}         {1}                   {2}                         {3}", hunt.DogId, hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Bird watcher":
                            Console.WriteLine(String.Format("      {0}         {1}                   {2}                    {3}", hunt.DogId, hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Setter":
                            Console.WriteLine(String.Format("      {0}           {1}                   {2}                      {3}", hunt.DogId, hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Retriever":
                            Console.WriteLine(String.Format("      {0}           {1}                   {2}                      {3}", hunt.DogId, hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Spaniel":
                            Console.WriteLine(String.Format("      {0}           {1}                   {2}                      {3}", hunt.DogId, hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Beagle":
                            Console.WriteLine(String.Format("      {0}           {1}                   {2}                      {3}", hunt.DogId, hunt.Breed, hunt.Species, hunt.FullName));
                            break;
                    }
                }
                else
                {
                    switch (hunt.Species)
                    {
                        case "Basset":
                            Console.WriteLine(String.Format("      {0}        {1}                   {2}                      {3}", hunt.DogId, hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Basenji":
                            Console.WriteLine(String.Format("      {0}        {1}                   {2}                      {3}", hunt.DogId, hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Doga":
                            Console.WriteLine(String.Format("      {0}        {1}                   {2}                      {3}", hunt.DogId, hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Hound":
                            Console.WriteLine(String.Format("      {0}        {1}                   {2}                      {3}", hunt.DogId, hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Epaniel":
                            Console.WriteLine(String.Format("      {0}        {1}                   {2}                      {3}", hunt.DogId, hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Dachshund":
                            Console.WriteLine(String.Format("      {0}        {1}                   {2}                      {3}", hunt.DogId, hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Foxhound":
                            Console.WriteLine(String.Format("      {0}        {1}                   {2}                      {3}", hunt.DogId, hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Pointer":
                            Console.WriteLine(String.Format("      {0}        {1}                   {2}                      {3}", hunt.DogId, hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Bird watcher":
                            Console.WriteLine(String.Format("      {0}        {1}                   {2}                    {3}", hunt.DogId, hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Setter":
                            Console.WriteLine(String.Format("      {0}        {1}                   {2}                          {3}", hunt.DogId, hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Retriever":
                            Console.WriteLine(String.Format("      {0}        {1}                   {2}                       {3}", hunt.DogId, hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Spaniel":
                            Console.WriteLine(String.Format("      {0}        {1}                   {2}                         {3}", hunt.DogId, hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Beagle":
                            Console.WriteLine(String.Format("      {0}        {1}                   {2}                          {3}", hunt.DogId, hunt.Breed, hunt.Species, hunt.FullName));
                            break;
                    }
                }
                Console.WriteLine();
            }
        }

        public static void TerrierList()
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

            Console.WriteLine("     ID             Breed                       Species                        Fullname");
            Console.WriteLine("    ----------------------------------------------------------------------------------------------------------");

            TerrierListOutput(Terriers);

        }

        public static void TerrierListOutput(List<DisplayDogs> Terriers)
        {

            var terriers = from terrier in Terriers
                           select new { DogID = terrier.DogId, Breed = terrier.Breed, Species = terrier.Species, FullName = terrier.FullName };

            foreach (var terrier in terriers)
            {
                if (terrier.DogID >= 1 && terrier.DogID < 10)
                {
                    if (terrier.Species == "Bull terrier")
                    {
                        Console.WriteLine(String.Format("      {0}            {1}                     {2}                    {3}", terrier.DogID, terrier.Breed, terrier.Species, terrier.FullName));
                    }
                    else if (terrier.Species == "Fox terrier")
                    {
                        Console.WriteLine(String.Format("      {0}            {1}                     {2}                     {3}", terrier.DogID, terrier.Breed, terrier.Species, terrier.FullName));
                    }
                    else
                    {
                        Console.WriteLine(String.Format("      {0}            {1}                     {2}                         {3}", terrier.DogID, terrier.Breed, terrier.Species, terrier.FullName));
                    }
                }
                else
                {
                    if (terrier.Species == "Bull terrier")
                    {
                        Console.WriteLine(String.Format("      {0}            {1}                     {2}                    {3}", terrier.DogID, terrier.Breed, terrier.Species, terrier.FullName));
                    }
                    else if (terrier.Species == "Fox terrier")
                    {
                        Console.WriteLine(String.Format("      {0}          {1}                 {2}                      {3}", terrier.DogID, terrier.Breed, terrier.Species, terrier.FullName));
                    }
                    else
                    {
                        Console.WriteLine(String.Format("      {0}           {1}                     {2}                         {3}", terrier.DogID, terrier.Breed, terrier.Species, terrier.FullName));
                    }
                }
                Console.WriteLine();
            }
        }

        public static void ServiceDogsList()
        {
            List<DisplayDogs> ServiceDogs = new List<DisplayDogs>()
            {
                new DisplayDogs
                {
                    DogId = 1,
                    Breed = "Service dog",
                    Species = "Australian herd guard",
                    FullName = "Australian herd guard"
                },
                new DisplayDogs
                {
                    DogId = 2,
                    Breed = "Service dog",
                    Species = "Bernardine",
                    FullName = "Longhair bernardine"
                },
                new DisplayDogs
                {
                    DogId = 3,
                    Breed = "Service dog",
                    Species = "Bernardine",
                    FullName = "Shorthair bernardine"
                },
                new DisplayDogs
                {
                    DogId = 4,
                    Breed = "Service dog",
                    Species = "Boxer",
                    FullName = "German boxer"
                },
                new DisplayDogs
                {
                    DogId = 5,
                    Breed = "Service dog",
                    Species = "Boxer",
                    FullName = "German yellow boxer"
                },
                new DisplayDogs
                {
                    DogId = 6,
                    Breed = "Service dog",
                    Species = "Boxer",
                    FullName = "Brindle german boxer"
                },
                new DisplayDogs
                {
                    DogId = 7,
                    Breed = "Service dog",
                    Species = "Bearded koli",
                    FullName = "Bearded koli"
                },
                new DisplayDogs
                {
                    DogId = 8,
                    Breed = "Service dog",
                    Species = "Doga",
                    FullName = "Bordeaux doga"
                },
                new DisplayDogs
                {
                    DogId = 9,
                    Breed = "Service dog",
                    Species = "Doga",
                    FullName = "Black german doga"
                },
                new DisplayDogs
                {
                    DogId = 10,
                    Breed = "Service dog",
                    Species = "Doga",
                    FullName = "Harlequin german doga"
                },
                new DisplayDogs
                {
                    DogId = 11,
                    Breed = "Service dog",
                    Species = "Doga",
                    FullName = "Yellow german doga"
                },
                new DisplayDogs
                {
                    DogId = 12,
                    Breed = "Service dog",
                    Species = "Husky",
                    FullName = "Canadian husky"
                },
                new DisplayDogs
                {
                    DogId = 13,
                    Breed = "Service dog",
                    Species = "Hound",
                    FullName = "Brazilian hound"
                },
                new DisplayDogs
                {
                    DogId = 14,
                    Breed = "Service dog",
                    Species = "Cattle dog",
                    FullName = "Ardenian cattle dog"
                },
                new DisplayDogs
                {
                    DogId = 15,
                    Breed = "Service dog",
                    Species = "Cattle dog",
                    FullName = "Australian cattle dog"
                },
                new DisplayDogs
                {
                    DogId = 16,
                    Breed = "Service dog",
                    Species = "Cattle dog",
                    FullName = "Flemish cattle dog"
                },
                new DisplayDogs
                {
                    DogId = 17,
                    Breed = "Service dog",
                    Species = "Loser dog",
                    FullName = "Middle loser"
                },
                new DisplayDogs
                {
                    DogId = 18,
                    Breed = "Service dog",
                    Species = "Loser dog",
                    FullName = "Big loser"
                },
                new DisplayDogs
                {
                    DogId = 19,
                    Breed = "Service dog",
                    Species = "Japanese dog",
                    FullName = "Japanese dog Ainu"
                },
                new DisplayDogs
                {
                    DogId = 20,
                    Breed = "Service dog",
                    Species = "Japanese dog",
                    FullName = "Japanese fighting dog Tosa"
                },
                new DisplayDogs
                {
                    DogId = 21,
                    Breed = "Service dog",
                    Species = "Japanese dog",
                    FullName = "Japanese dog from Hokaido"
                },
                new DisplayDogs
                {
                    DogId = 22,
                    Breed = "Service dog",
                    Species = "Lendsir",
                    FullName = "Lendsir"
                },
                new DisplayDogs
                {
                    DogId = 23,
                    Breed = "Service dog",
                    Species = "Leonberg dog",
                    FullName = "Leonberg dog"
                },
                new DisplayDogs
                {
                    DogId = 24,
                    Breed = "Service dog",
                    Species = "Mastiff",
                    FullName = "Bullmastiff"
                },
                new DisplayDogs
                {
                    DogId = 25,
                    Breed = "Service dog",
                    Species = "Mastiff",
                    FullName = "English mastiff"
                },
                new DisplayDogs
                {
                    DogId = 26,
                    Breed = "Service dog",
                    Species = "Mastiff",
                    FullName = "English mastiff"
                },
                new DisplayDogs
                {
                    DogId = 27,
                    Breed = "Service dog",
                    Species = "Mastiff",
                    FullName = "Pyrenean mastiff"
                },
                new DisplayDogs
                {
                    DogId = 28,
                    Breed = "Service dog",
                    Species = "Mastiff",
                    FullName = "Spanish mastiff"
                },
                new DisplayDogs
                {
                    DogId = 29,
                    Breed = "Service dog",
                    Species = "Mastiff",
                    FullName = "Italian mastiff"
                },
                new DisplayDogs
                {
                    DogId = 30,
                    Breed = "Service dog",
                    Species = "Mastiff",
                    FullName = "Tibetian mastiff"
                },
                new DisplayDogs
                {
                    DogId = 31,
                    Breed = "Service dog",
                    Species = "Newfoundlander",
                    FullName = "Newfoundlander"
                },
                new DisplayDogs
                {
                    DogId = 32,
                    Breed = "Service dog",
                    Species = "Sheep dog",
                    FullName = "Belgian longhair sheep dog"
                },
                new DisplayDogs
                {
                    DogId = 33,
                    Breed = "Service dog",
                    Species = "Sheep dog",
                    FullName = "Belgian shorthair sheep dog"
                },
                new DisplayDogs
                {
                    DogId = 34,
                    Breed = "Service dog",
                    Species = "Sheep dog",
                    FullName = "Belgian sheep dog"
                },
                new DisplayDogs
                {
                    DogId = 35,
                    Breed = "Service dog",
                    Species = "Sheep dog",
                    FullName = "Aturian longhair sheep dog"
                },
                new DisplayDogs
                {
                    DogId = 36,
                    Breed = "Service dog",
                    Species = "Sheep dog",
                    FullName = "Australian sheep dog"
                },
                new DisplayDogs
                {
                    DogId = 37,
                    Breed = "Service dog",
                    Species = "Sheep dog",
                    FullName = "Bergam sheep dog"
                },
                new DisplayDogs
                {
                    DogId = 38,
                    Breed = "Service dog",
                    Species = "Sheep dog",
                    FullName = "Briar sheep dog"
                },
                new DisplayDogs
                {
                    DogId = 39,
                    Breed = "Service dog",
                    Species = "Sheep dog",
                    FullName = "Hungarian sheep dog"
                },
                new DisplayDogs
                {
                    DogId = 40,
                    Breed = "Service dog",
                    Species = "Sheep dog",
                    FullName = "Hungarian sheep dog Puli"
                },
                new DisplayDogs
                {
                    DogId = 41,
                    Breed = "Service dog",
                    Species = "Sheep dog",
                    FullName = "Hungarian sheep dog Pumi"
                },
                new DisplayDogs
                {
                    DogId = 42,
                    Breed = "Service dog",
                    Species = "Sheep dog",
                    FullName = "Scotish longhair sheep dog"
                },
                new DisplayDogs
                {
                    DogId = 43,
                    Breed = "Service dog",
                    Species = "Sheep dog",
                    FullName = "Scotish border sheep dog"
                },
                new DisplayDogs
                {
                    DogId = 44,
                    Breed = "Service dog",
                    Species = "Sheep dog",
                    FullName = "Scotish shorthair sheep dog"
                },
                new DisplayDogs
                {
                    DogId = 45,
                    Breed = "Service dog",
                    Species = "Sheep dog",
                    FullName = "Karst sheep dog"
                },
                new DisplayDogs
                {
                    DogId = 46,
                    Breed = "Service dog",
                    Species = "Sheep dog",
                    FullName = "Dutch sheep dog"
                },
                new DisplayDogs
                {
                    DogId = 47,
                    Breed = "Service dog",
                    Species = "Sheep dog",
                    FullName = "German yard guard"
                },
                new DisplayDogs
                {
                    DogId = 48,
                    Breed = "Service dog",
                    Species = "Sheep dog",
                    FullName = "German sheep dog"
                },
                new DisplayDogs
                {
                    DogId = 49,
                    Breed = "Service dog",
                    Species = "Sheep dog",
                    FullName = "Croatian sheep dog"
                },
                new DisplayDogs
                {
                    DogId = 50,
                    Breed = "Service dog",
                    Species = "Sheep dog",
                    FullName = "Old english sheep dog"
                },
                new DisplayDogs
                {
                    DogId = 51,
                    Breed = "Service dog",
                    Species = "Sheep dog",
                    FullName = "Palestinian sheep dog"
                },
                new DisplayDogs
                {
                    DogId = 52,
                    Breed = "Service dog",
                    Species = "Sheep dog",
                    FullName = "Sheep dog from Beauce"
                },
                new DisplayDogs
                {
                    DogId = 53,
                    Breed = "Service dog",
                    Species = "Sheep dog",
                    FullName = "Picardy sheep dog"
                },
                new DisplayDogs
                {
                    DogId = 54,
                    Breed = "Service dog",
                    Species = "Sheep dog",
                    FullName = "Pyreneian sheep dog"
                },
                new DisplayDogs
                {
                    DogId = 55,
                    Breed = "Service dog",
                    Species = "Sheep dog",
                    FullName = "Pyreneian shorthair sheep dog"
                },
                new DisplayDogs
                {
                    DogId = 56,
                    Breed = "Service dog",
                    Species = "Sheep dog",
                    FullName = "Field lowland sheep dog"
                },
                new DisplayDogs
                {
                    DogId = 57,
                    Breed = "Service dog",
                    Species = "Sheep dog",
                    FullName = "Portuguese sheep dog"
                },
                new DisplayDogs
                {
                    DogId = 58,
                    Breed = "Service dog",
                    Species = "Sheep dog",
                    FullName = "Sharplaninac"
                },
                new DisplayDogs
                {
                    DogId = 59,
                    Breed = "Service dog",
                    Species = "Sheep dog",
                    FullName = "Shetland sheep dog"
                },
                new DisplayDogs
                {
                    DogId = 60,
                    Breed = "Service dog",
                    Species = "Sheep dog",
                    FullName = "Swedish short-legged sheep dog"
                },
                new DisplayDogs
                {
                    DogId = 61,
                    Breed = "Service dog",
                    Species = "Sheep dog",
                    FullName = "Welsh short-legged sheep dog"
                },
                new DisplayDogs
                {
                    DogId = 62,
                    Breed = "Service dog",
                    Species = "Shepherd dog",
                    FullName = "American shepherd dog"
                },
                new DisplayDogs
                {
                    DogId = 63,
                    Breed = "Service dog",
                    Species = "Shepherd dog",
                    FullName = "Anatolian shepherd dog"
                },
                new DisplayDogs
                {
                    DogId = 64,
                    Breed = "Service dog",
                    Species = "Shepherd dog",
                    FullName = "Lappish shepherd dog"
                },
                new DisplayDogs
                {
                    DogId = 65,
                    Breed = "Service dog",
                    Species = "Shepherd dog",
                    FullName = "Hungarian shepherd dog"
                },
                new DisplayDogs
                {
                    DogId = 66,
                    Breed = "Service dog",
                    Species = "Shepherd dog",
                    FullName = "Hungarian shepherd dog Kuvas"
                },
                new DisplayDogs
                {
                    DogId = 67,
                    Breed = "Service dog",
                    Species = "Shepherd dog",
                    FullName = "Mareman abruzzi shepherd dog"
                },
                new DisplayDogs
                {
                    DogId = 68,
                    Breed = "Service dog",
                    Species = "Shepherd dog",
                    FullName = "Moroccan shepherd dog"
                },
                new DisplayDogs
                {
                    DogId = 69,
                    Breed = "Service dog",
                    Species = "Shepherd dog",
                    FullName = "Podhalan shepherd dog"
                },
                new DisplayDogs
                {
                    DogId = 70,
                    Breed = "Service dog",
                    Species = "Shepherd dog",
                    FullName = "Portuguese estrelian shepherd dog"
                },
                new DisplayDogs
                {
                    DogId = 71,
                    Breed = "Service dog",
                    Species = "Shepherd dog",
                    FullName = "Portuguese shepherd dog"
                },
                new DisplayDogs
                {
                    DogId = 72,
                    Breed = "Service dog",
                    Species = "Shepherd dog",
                    FullName = "Slovakian shepherd dog"
                },
                new DisplayDogs
                {
                    DogId = 73,
                    Breed = "Service dog",
                    Species = "Pinch",
                    FullName = "Austrian shorthair pinch"
                },
                new DisplayDogs
                {
                    DogId = 74,
                    Breed = "Service dog",
                    Species = "Pinch",
                    FullName = "Doberman pinch"
                },
                new DisplayDogs
                {
                    DogId = 75,
                    Breed = "Service dog",
                    Species = "Mountain dog",
                    FullName = "Appenzell mountain dog"
                },
                new DisplayDogs
                {
                    DogId = 76,
                    Breed = "Service dog",
                    Species = "Mountain dog",
                    FullName = "Bernese mountain dog"
                },
                new DisplayDogs
                {
                    DogId = 77,
                    Breed = "Service dog",
                    Species = "Mountain dog",
                    FullName = "Entlebush mountain dog"
                },
                new DisplayDogs
                {
                    DogId = 78,
                    Breed = "Service dog",
                    Species = "Mountain dog",
                    FullName = "Pyreneian mountain dog"
                },
                new DisplayDogs
                {
                    DogId = 79,
                    Breed = "Service dog",
                    Species = "Mountain dog",
                    FullName = "Mountain dog from village Laboreiro"
                },
                new DisplayDogs
                {
                    DogId = 80,
                    Breed = "Service dog",
                    Species = "Mountain dog",
                    FullName = "Big swiss mountain dog"
                },
                new DisplayDogs
                {
                    DogId = 81,
                    Breed = "Service dog",
                    Species = "Polar dog",
                    FullName = "Alaskan polar dog"
                },
                new DisplayDogs
                {
                    DogId = 82,
                    Breed = "Service dog",
                    Species = "Polar dog",
                    FullName = "Greenland polar dog"
                },
                new DisplayDogs
                {
                    DogId = 83,
                    Breed = "Service dog",
                    Species = "Polar dog",
                    FullName = "Nenets polar dog"
                },
                new DisplayDogs
                {
                    DogId = 84,
                    Breed = "Service dog",
                    Species = "Siberian husky",
                    FullName = "Siberian husky"
                },
                new DisplayDogs
                {
                    DogId = 85,
                    Breed = "Service dog",
                    Species = "Rottweiler",
                    FullName = "Rottweiler"
                },
                new DisplayDogs
                {
                    DogId = 86,
                    Breed = "Service dog",
                    Species = "Spitz",
                    FullName = "Laponian swedish spitz"
                },
                new DisplayDogs
                {
                    DogId = 87,
                    Breed = "Service dog",
                    Species = "Spitz",
                    FullName = "Iceland spitz"
                },
                new DisplayDogs
                {
                    DogId = 88,
                    Breed = "Service dog",
                    Species = "Spitz",
                    FullName = "Dutch spitz"
                },
                new DisplayDogs
                {
                    DogId = 89,
                    Breed = "Service dog",
                    Species = "Spitz",
                    FullName = "Norwegian sheep dog spitz"
                },
                new DisplayDogs
                {
                    DogId = 90,
                    Breed = "Service dog",
                    Species = "Spitz",
                    FullName = "North swedish spitz"
                },
                new DisplayDogs
                {
                    DogId = 91,
                    Breed = "Service dog",
                    Species = "Spitz",
                    FullName = "Middle japanese spitz Sashu"
                },
                new DisplayDogs
                {
                    DogId = 92,
                    Breed = "Service dog",
                    Species = "Spitz",
                    FullName = "Big japanese spitz"
                },
                new DisplayDogs
                {
                    DogId = 93,
                    Breed = "Service dog",
                    Species = "Water dog",
                    FullName = "Portuguese water dog"
                }
            };

            Console.WriteLine("     ID             Breed                       Species                        Fullname");
            Console.WriteLine("    ----------------------------------------------------------------------------------------------------------");

            ServiceDogsListOutput(ServiceDogs);

        }

        public static void ServiceDogsListOutput(List<DisplayDogs> ServiceDogs)
        {

            foreach (var service in ServiceDogs)
            {
                if (service.DogId >= 1 && service.DogId < 10)
                {
                    switch (service.Species)
                    {
                        case "Australian herd guard":
                            Console.WriteLine(String.Format("      {0}          {1}                   {2}           {3}", service.DogId, service.Breed, service.Species, service.FullName));
                            break;

                        case "Bernardine":
                            Console.WriteLine(String.Format("      {0}          {1}                   {2}                      {3}", service.DogId, service.Breed, service.Species, service.FullName));
                            break;

                        case "Boxer":
                            Console.WriteLine(String.Format("      {0}          {1}                   {2}                           {3}", service.DogId, service.Breed, service.Species, service.FullName));
                            break;

                        case "Bearded koli":
                            Console.WriteLine(String.Format("      {0}          {1}                   {2}                    {3}", service.DogId, service.Breed, service.Species, service.FullName));
                            break;

                        case "Doga":
                            Console.WriteLine(String.Format("      {0}          {1}                   {2}                            {3}", service.DogId, service.Breed, service.Species, service.FullName));
                            break;

                        case "Husky":
                            Console.WriteLine(String.Format("      {0}            {1}                   {2}                           {3}", service.DogId, service.Breed, service.Species, service.FullName));
                            break;

                        case "Hound":
                            Console.WriteLine(String.Format("      {0}            {1}                   {2}                {3}", service.DogId, service.Breed, service.Species, service.FullName));
                            break;

                        case "Cattle dog":
                            Console.WriteLine(String.Format("      {0}            {1}                   {2}                {3}", service.DogId, service.Breed, service.Species, service.FullName));
                            break;

                        case "Loser dog":
                            Console.WriteLine(String.Format("      {0}            {1}                    {2}            {3}", service.DogId, service.Breed, service.Species, service.FullName));
                            break;

                        case "Japanese dog":
                            Console.WriteLine(String.Format("      {0}            {1}                    {2}                {3}", service.DogId, service.Breed, service.Species, service.FullName));
                            break;

                        case "Lendsir":
                            Console.WriteLine(String.Format("      {0}            {1}                    {2}                {3}", service.DogId, service.Breed, service.Species, service.FullName));
                            break;

                        case "Leonberg dog":
                            Console.WriteLine(String.Format("      {0}            {1}                    {2}                {3}", service.DogId, service.Breed, service.Species, service.FullName));
                            break;

                        case "Mastiff":
                            Console.WriteLine(String.Format("      {0}            {1}                    {2}                {3}", service.DogId, service.Breed, service.Species, service.FullName));
                            break;

                        case "Newfoundlander":
                            Console.WriteLine(String.Format("      {0}            {1}                    {2}                {3}", service.DogId, service.Breed, service.Species, service.FullName));
                            break;

                        case "Sheep dog":
                            Console.WriteLine(String.Format("      {0}            {1}                    {2}                {3}", service.DogId, service.Breed, service.Species, service.FullName));
                            break;

                        case "Shepherd dog":
                            Console.WriteLine(String.Format("      {0}            {1}                    {2}                {3}", service.DogId, service.Breed, service.Species, service.FullName));
                            break;

                        case "Pinch":
                            Console.WriteLine(String.Format("      {0}            {1}                    {2}                {3}", service.DogId, service.Breed, service.Species, service.FullName));
                            break;

                        case "Mountain dog":
                            Console.WriteLine(String.Format("      {0}            {1}                    {2}                {3}", service.DogId, service.Breed, service.Species, service.FullName));
                            break;

                        case "Polar dog":
                            Console.WriteLine(String.Format("      {0}            {1}                    {2}                {3}", service.DogId, service.Breed, service.Species, service.FullName));
                            break;

                        case "Siberian husky":
                            Console.WriteLine(String.Format("      {0}            {1}                    {2}                {3}", service.DogId, service.Breed, service.Species, service.FullName));
                            break;

                        case "Spitz":
                            Console.WriteLine(String.Format("      {0}            {1}                    {2}                {3}", service.DogId, service.Breed, service.Species, service.FullName));
                            break;

                        case "Rottweiler":
                            Console.WriteLine(String.Format("      {0}            {1}                    {2}                {3}", service.DogId, service.Breed, service.Species, service.FullName));
                            break;

                        case "Water dog":
                            Console.WriteLine(String.Format("      {0}            {1}                    {2}                {3}", service.DogId, service.Breed, service.Species, service.FullName));
                            break;
                    }
                }
                else
                {
                    switch (service.Species)
                    {
                        case "Australian herd guard":
                            Console.WriteLine(String.Format("      {0}          {1}                   {2}                    {3}", service.DogId, service.Breed, service.Species, service.FullName));
                            break;

                        case "Bernardine":
                            Console.WriteLine(String.Format("      {0}          {1}                   {2}                   {3}", service.DogId, service.Breed, service.Species, service.FullName));
                            break;

                        case "Boxer":
                            Console.WriteLine(String.Format("      {0}          {1}                   {2}                      {3}", service.DogId, service.Breed, service.Species, service.FullName));
                            break;

                        case "Bearded koli":
                            Console.WriteLine(String.Format("      {0}          {1}                   {2}                     {3}", service.DogId, service.Breed, service.Species, service.FullName));
                            break;

                        case "Doga":
                            Console.WriteLine(String.Format("      {0}         {1}                   {2}                            {3}", service.DogId, service.Breed, service.Species, service.FullName));
                            break;

                        case "Husky":
                            Console.WriteLine(String.Format("      {0}         {1}                   {2}                           {3}", service.DogId, service.Breed, service.Species, service.FullName));
                            break;

                        case "Hound":
                            Console.WriteLine(String.Format("      {0}         {1}                   {2}                           {3}", service.DogId, service.Breed, service.Species, service.FullName));
                            break;

                        case "Cattle dog":
                            Console.WriteLine(String.Format("      {0}         {1}                   {2}                      {3}", service.DogId, service.Breed, service.Species, service.FullName));
                            break;

                        case "Loser dog":
                            Console.WriteLine(String.Format("      {0}         {1}                   {2}                       {3}", service.DogId, service.Breed, service.Species, service.FullName));
                            break;

                        case "Japanese dog":
                            Console.WriteLine(String.Format("      {0}         {1}                   {2}                    {3}", service.DogId, service.Breed, service.Species, service.FullName));
                            break;

                        case "Lendsir":
                            Console.WriteLine(String.Format("      {0}         {1}                   {2}                         {3}", service.DogId, service.Breed, service.Species, service.FullName));
                            break;

                        case "Leonberg dog":
                            Console.WriteLine(String.Format("      {0}         {1}                   {2}                    {3}", service.DogId, service.Breed, service.Species, service.FullName));
                            break;

                        case "Mastiff":
                            Console.WriteLine(String.Format("      {0}         {1}                   {2}                         {3}", service.DogId, service.Breed, service.Species, service.FullName));
                            break;

                        case "Newfoundlander":
                            Console.WriteLine(String.Format("      {0}         {1}                   {2}                  {3}", service.DogId, service.Breed, service.Species, service.FullName));
                            break;

                        case "Sheep dog":
                            Console.WriteLine(String.Format("      {0}         {1}                   {2}                       {3}", service.DogId, service.Breed, service.Species, service.FullName));
                            break;

                        case "Shepherd dog":
                            Console.WriteLine(String.Format("      {0}         {1}                   {2}                    {3}", service.DogId, service.Breed, service.Species, service.FullName));
                            break;

                        case "Pinch":
                            Console.WriteLine(String.Format("      {0}         {1}                   {2}                           {3}", service.DogId, service.Breed, service.Species, service.FullName));
                            break;

                        case "Mountain dog":
                            Console.WriteLine(String.Format("      {0}         {1}                   {2}                    {3}", service.DogId, service.Breed, service.Species, service.FullName));
                            break;

                        case "Polar dog":
                            Console.WriteLine(String.Format("      {0}         {1}                   {2}                       {3}", service.DogId, service.Breed, service.Species, service.FullName));
                            break;

                        case "Siberian husky":
                            Console.WriteLine(String.Format("      {0}         {1}                   {2}                  {3}", service.DogId, service.Breed, service.Species, service.FullName));
                            break;

                        case "Spitz":
                            Console.WriteLine(String.Format("      {0}         {1}                   {2}                           {3}", service.DogId, service.Breed, service.Species, service.FullName));
                            break;

                        case "Rottweiler":
                            Console.WriteLine(String.Format("      {0}         {1}                   {2}                      {3}", service.DogId, service.Breed, service.Species, service.FullName));
                            break;

                        case "Water dog":
                            Console.WriteLine(String.Format("      {0}         {1}                   {2}                       {3}", service.DogId, service.Breed, service.Species, service.FullName));
                            break;
                    }
                }
                Console.WriteLine();
            }
        }
    }




    public static class AnimalSplit
    {
        public static void GreyhoundList(string display)
        {
            int answer = Convert.ToInt32(display);

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

            if (answer == 0 || answer > 11)
            {
                GreyhoundListOutput(Greyhounds, answer);
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("     ID             Breed                       Species                        Fullname");
                Console.WriteLine("    ----------------------------------------------------------------------------------------------------------");

                GreyhoundListOutput(Greyhounds, answer);
            }
        }

        public static void GreyhoundListOutput(List<DisplayDogs> Greyhounds, int answer)
        {

            int NumberOfItems = Greyhounds.Count();
            if (answer > NumberOfItems)
            {
                Console.WriteLine("Next time please input any number between 1 and including 11, number that you've inputted is too high!\n\n");
            }
            else if (answer == 0)
            {
                Console.WriteLine("Next time please enter valid number.\n\n");
            }
            else
            {
                for (var counter = 0; counter < answer; counter++)
                {
                    if (Greyhounds[counter].DogId >= 1 && Greyhounds[counter].DogId < 10)
                    {
                        Console.WriteLine(String.Format("      {0}           {1}                    {2}                       {3}", Greyhounds[counter].DogId, Greyhounds[counter].Breed, Greyhounds[counter].Species, Greyhounds[counter].FullName));
                    }
                    else
                    {
                        Console.WriteLine(String.Format("      {0}          {1}                    {2}                       {3}", Greyhounds[counter].DogId, Greyhounds[counter].Breed, Greyhounds[counter].Species, Greyhounds[counter].FullName));
                    }
                    Console.WriteLine();
                }
            }
        }

        public static void DwarfDogsList(string display)
        {
            int answer = Convert.ToInt32(display);

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

            if (answer == 0 || answer > 20)
            {
                DwarfDogsListOutput(DwarfDogs, answer);
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("     ID             Breed                       Species                        Fullname");
                Console.WriteLine("    ----------------------------------------------------------------------------------------------------------");

                DwarfDogsListOutput(DwarfDogs, answer);
            }
        }

        public static void DwarfDogsListOutput(List<DisplayDogs> DwarfDogs, int answer)
        {

            int NumberOfItems = DwarfDogs.Count();
            if (answer > NumberOfItems)
            {
                Console.WriteLine("Next time please input any number between 1 and including 20, number that you've inputted is too high!\n\n");
            }
            else if (answer == 0)
            {
                Console.WriteLine("Next time please enter valid number.\n\n");
            }
            else
            {
                for (var counter = 0; counter < answer; counter++)
                {
                    if (DwarfDogs[counter].DogId >= 1 && DwarfDogs[counter].DogId < 10)
                    {
                        if (DwarfDogs[counter].Species == "Chihuahua")
                        {
                            Console.WriteLine(String.Format("      {0}           {1}                    {2}                       {3}", DwarfDogs[counter].DogId, DwarfDogs[counter].Breed, DwarfDogs[counter].Species, DwarfDogs[counter].FullName));
                        }
                        else if (DwarfDogs[counter].Species == "Fox terrier")
                        {
                            Console.WriteLine(String.Format("      {0}           {1}                    {2}                     {3}", DwarfDogs[counter].DogId, DwarfDogs[counter].Breed, DwarfDogs[counter].Species, DwarfDogs[counter].FullName));
                        }
                        else if (DwarfDogs[counter].Species == "Naked dog")
                        {
                            Console.WriteLine(String.Format("      {0}           {1}                    {2}                       {3}", DwarfDogs[counter].DogId, DwarfDogs[counter].Breed, DwarfDogs[counter].Species, DwarfDogs[counter].FullName));
                        }
                        else if (DwarfDogs[counter].Species == "Griffon")
                        {
                            Console.WriteLine(String.Format("      {0}           {1}                    {2}                         {3}", DwarfDogs[counter].DogId, DwarfDogs[counter].Breed, DwarfDogs[counter].Species, DwarfDogs[counter].FullName));
                        }
                        else if (DwarfDogs[counter].Species == "Lasa apso")
                        {
                            Console.WriteLine(String.Format("      {0}           {1}                    {2}                       {3}", DwarfDogs[counter].DogId, DwarfDogs[counter].Breed, DwarfDogs[counter].Species, DwarfDogs[counter].FullName));
                        }
                        else if (DwarfDogs[counter].Species == "Maltese")
                        {
                            Console.WriteLine(String.Format("      {0}           {1}                    {2}                         {3}", DwarfDogs[counter].DogId, DwarfDogs[counter].Breed, DwarfDogs[counter].Species, DwarfDogs[counter].FullName));
                        }
                        else if (DwarfDogs[counter].Species == "Pinch")
                        {
                            Console.WriteLine(String.Format("      {0}           {1}                    {2}                           {3}", DwarfDogs[counter].DogId, DwarfDogs[counter].Breed, DwarfDogs[counter].Species, DwarfDogs[counter].FullName));
                        }
                        else if (DwarfDogs[counter].Species == "Spaniel")
                        {
                            Console.WriteLine(String.Format("      {0}           {1}                    {2}                         {3}", DwarfDogs[counter].DogId, DwarfDogs[counter].Breed, DwarfDogs[counter].Species, DwarfDogs[counter].FullName));
                        }
                        else if (DwarfDogs[counter].Species == "Spitz")
                        {
                            Console.WriteLine(String.Format("      {0}          {1}                    {2}                         {3}", DwarfDogs[counter].DogId, DwarfDogs[counter].Breed, DwarfDogs[counter].Species, DwarfDogs[counter].FullName));
                        }
                        else
                        {
                            Console.WriteLine(String.Format("      {0}          {1}                    {2}                        {3}", DwarfDogs[counter].DogId, DwarfDogs[counter].Breed, DwarfDogs[counter].Species, DwarfDogs[counter].FullName));
                        }
                    }
                    else
                    {
                        if (DwarfDogs[counter].Species == "Chihuahua")
                        {
                            Console.WriteLine(String.Format("      {0}           {1}                    {2}                       {3}", DwarfDogs[counter].DogId, DwarfDogs[counter].Breed, DwarfDogs[counter].Species, DwarfDogs[counter].FullName));
                        }
                        else if (DwarfDogs[counter].Species == "Fox terrier")
                        {
                            Console.WriteLine(String.Format("      {0}           {1}                    {2}                     {3}", DwarfDogs[counter].DogId, DwarfDogs[counter].Breed, DwarfDogs[counter].Species, DwarfDogs[counter].FullName));
                        }
                        else if (DwarfDogs[counter].Species == "Naked dog")
                        {
                            Console.WriteLine(String.Format("      {0}           {1}                    {2}                       {3}", DwarfDogs[counter].DogId, DwarfDogs[counter].Breed, DwarfDogs[counter].Species, DwarfDogs[counter].FullName));
                        }
                        else if (DwarfDogs[counter].Species == "Griffon")
                        {
                            Console.WriteLine(String.Format("      {0}           {1}                    {2}                         {3}", DwarfDogs[counter].DogId, DwarfDogs[counter].Breed, DwarfDogs[counter].Species, DwarfDogs[counter].FullName));
                        }
                        else if (DwarfDogs[counter].Species == "Lasa apso")
                        {
                            Console.WriteLine(String.Format("      {0}           {1}                    {2}                       {3}", DwarfDogs[counter].DogId, DwarfDogs[counter].Breed, DwarfDogs[counter].Species, DwarfDogs[counter].FullName));
                        }
                        else if (DwarfDogs[counter].Species == "Maltese")
                        {
                            Console.WriteLine(String.Format("      {0}           {1}                    {2}                         {3}", DwarfDogs[counter].DogId, DwarfDogs[counter].Breed, DwarfDogs[counter].Species, DwarfDogs[counter].FullName));
                        }
                        else if (DwarfDogs[counter].Species == "Pinch")
                        {
                            Console.WriteLine(String.Format("      {0}           {1}                    {2}                           {3}", DwarfDogs[counter].DogId, DwarfDogs[counter].Breed, DwarfDogs[counter].Species, DwarfDogs[counter].FullName));
                        }
                        else if (DwarfDogs[counter].Species == "Spaniel")
                        {
                            Console.WriteLine(String.Format("      {0}          {1}                    {2}                         {3}", DwarfDogs[counter].DogId, DwarfDogs[counter].Breed, DwarfDogs[counter].Species, DwarfDogs[counter].FullName));
                        }
                        else if (DwarfDogs[counter].Species == "Spitz")
                        {
                            Console.WriteLine(String.Format("      {0}          {1}                    {2}                           {3}", DwarfDogs[counter].DogId, DwarfDogs[counter].Breed, DwarfDogs[counter].Species, DwarfDogs[counter].FullName));
                        }
                        else
                        {
                            Console.WriteLine(String.Format("      {0}          {1}                    {2}                         {3}", DwarfDogs[counter].DogId, DwarfDogs[counter].Breed, DwarfDogs[counter].Species, DwarfDogs[counter].FullName));
                        }
                    }
                    Console.WriteLine();
                }
            }
        }

        public static void FollowerDogsList(string display)
        {
            int answer = Convert.ToInt32(display);

            List<DisplayDogs> FollowerDogs = new List<DisplayDogs>()
            {
                new DisplayDogs
                {
                    DogId = 1,
                    Breed = "Follower dog",
                    Species = "Bulldog",
                    FullName = "African naked dog"
                },
                new DisplayDogs
                {
                    DogId = 2,
                    Breed = "Follower dog",
                    Species = "Bulldog",
                    FullName = "English buldog"
                },
                new DisplayDogs
                {
                    DogId = 3,
                    Breed = "Follower dog",
                    Species = "Bulldog",
                    FullName = "French bulldog"
                },
                new DisplayDogs
                {
                    DogId = 4,
                    Breed = "Follower dog",
                    Species = "Chow Chow",
                    FullName = "Chow Chow"
                },
                new DisplayDogs
                {
                    DogId = 5,
                    Breed = "Follower dog",
                    Species = "Fox terrier",
                    FullName = "Chromeforlander"
                },
                new DisplayDogs
                {
                    DogId = 6,
                    Breed = "Follower dog",
                    Species = "Hound",
                    FullName = "Dalmatian"
                },
                new DisplayDogs
                {
                    DogId = 7,
                    Breed = "Follower dog",
                    Species = "Griffon",
                    FullName = "Belgian dwarf griffon"
                },
                new DisplayDogs
                {
                    DogId = 8,
                    Breed = "Follower dog",
                    Species = "Griffon",
                    FullName = "Brabant dwarf griffon"
                },
                new DisplayDogs
                {
                    DogId = 9,
                    Breed = "Follower dog",
                    Species = "Loser dog",
                    FullName = "Dwarf loser"
                },
                new DisplayDogs
                {
                    DogId = 10,
                    Breed = "Follower dog",
                    Species = "Mops",
                    FullName = "Mops"
                },
                new DisplayDogs
                {
                    DogId = 11,
                    Breed = "Follower dog",
                    Species = "Pinch",
                    FullName = "Harlequin pinch"
                },
                new DisplayDogs
                {
                    DogId = 12,
                    Breed = "Follower dog",
                    Species = "Pinch",
                    FullName = "German pinch"
                },
                new DisplayDogs
                {
                    DogId = 13,
                    Breed = "Follower dog",
                    Species = "Pudl",
                    FullName = "Pudl"
                },
                new DisplayDogs
                {
                    DogId = 14,
                    Breed = "Follower dog",
                    Species = "Spaniel",
                    FullName = "King Charles cavalier spaniel"
                },
                new DisplayDogs
                {
                    DogId = 15,
                    Breed = "Follower dog",
                    Species = "Spaniel",
                    FullName = "Tibetan spaniel"
                },
                new DisplayDogs
                {
                    DogId = 16,
                    Breed = "Follower dog",
                    Species = "Char Pei",
                    FullName = "Char Pei"
                },
                new DisplayDogs
                {
                    DogId = 17,
                    Breed = "Follower dog",
                    Species = "Maltese",
                    FullName = "Silky havanese dog"
                },
                new DisplayDogs
                {
                    DogId = 18,
                    Breed = "Follower dog",
                    Species = "Shiba Inu",
                    FullName = "Shiba Inu"
                },
                new DisplayDogs
                {
                    DogId = 19,
                    Breed = "Follower dog",
                    Species = "Spitz",
                    FullName = "Belgian spitz"
                },
                new DisplayDogs
                {
                    DogId = 20,
                    Breed = "Follower dog",
                    Species = "Spitz",
                    FullName = "Japanese spitz"
                },
                new DisplayDogs
                {
                    DogId = 21,
                    Breed = "Follower dog",
                    Species = "Spitz",
                    FullName = "Little spitz"
                },
                new DisplayDogs
                {
                    DogId = 22,
                    Breed = "Follower dog",
                    Species = "Spitz",
                    FullName = "Italian spitz"
                },
                new DisplayDogs
                {
                    DogId = 23,
                    Breed = "Follower dog",
                    Species = "Spitz",
                    FullName = "German big spitz"
                },
                new DisplayDogs
                {
                    DogId = 24,
                    Breed = "Follower dog",
                    Species = "Telomian",
                    FullName = "Telomian"
                }
            };

            if (answer == 0 || answer > 24)
            {
                FollowerDogsListOutput(FollowerDogs, answer);
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("     ID             Breed                       Species                        Fullname");
                Console.WriteLine("    ----------------------------------------------------------------------------------------------------------");

                FollowerDogsListOutput(FollowerDogs, answer);
            }
        }

        public static void FollowerDogsListOutput(List<DisplayDogs> FollowerDogs, int answer)
        {

            int NumberOfItems = FollowerDogs.Count();
            if (answer > NumberOfItems)
            {
                Console.WriteLine("Next time please input any number between 1 and including 24, number that you've inputted is too high!\n\n");
            }
            else if (answer == 0)
            {
                Console.WriteLine("Next time please enter valid number.\n\n");
            }
            else
            {
                for (var counter = 0; counter < answer; counter++)
                {
                    if (FollowerDogs[counter].DogId >= 1 && FollowerDogs[counter].DogId < 10)
                    {
                        switch (FollowerDogs[counter].Species)
                        {
                            case "Bulldog":
                                Console.WriteLine(String.Format("      {0}          {1}                  {2}                         {3}", FollowerDogs[counter].DogId, FollowerDogs[counter].Breed, FollowerDogs[counter].Species, FollowerDogs[counter].FullName));
                                break;

                            case "Chow Chow":
                                Console.WriteLine(String.Format("      {0}          {1}                  {2}                       {3}", FollowerDogs[counter].DogId, FollowerDogs[counter].Breed, FollowerDogs[counter].Species, FollowerDogs[counter].FullName));
                                break;

                            case "Fox terrier":
                                Console.WriteLine(String.Format("      {0}          {1}                  {2}                     {3}", FollowerDogs[counter].DogId, FollowerDogs[counter].Breed, FollowerDogs[counter].Species, FollowerDogs[counter].FullName));
                                break;

                            case "Hound":
                                Console.WriteLine(String.Format("      {0}          {1}                  {2}                           {3}", FollowerDogs[counter].DogId, FollowerDogs[counter].Breed, FollowerDogs[counter].Species, FollowerDogs[counter].FullName));
                                break;

                            case "Griffon":
                                Console.WriteLine(String.Format("      {0}          {1}                  {2}                         {3}", FollowerDogs[counter].DogId, FollowerDogs[counter].Breed, FollowerDogs[counter].Species, FollowerDogs[counter].FullName));
                                break;

                            case "Loser dog":
                                Console.WriteLine(String.Format("      {0}          {1}                  {2}                       {3}", FollowerDogs[counter].DogId, FollowerDogs[counter].Breed, FollowerDogs[counter].Species, FollowerDogs[counter].FullName));
                                break;

                            case "Mops":
                                Console.WriteLine(String.Format("      {0}          {1}                  {2}                         {3}", FollowerDogs[counter].DogId, FollowerDogs[counter].Breed, FollowerDogs[counter].Species, FollowerDogs[counter].FullName));
                                break;

                            case "Pinch":
                                Console.WriteLine(String.Format("      {0}          {1}                  {2}                         {3}", FollowerDogs[counter].DogId, FollowerDogs[counter].Breed, FollowerDogs[counter].Species, FollowerDogs[counter].FullName));
                                break;

                            case "Pudl":
                                Console.WriteLine(String.Format("      {0}          {1}                  {2}                         {3}", FollowerDogs[counter].DogId, FollowerDogs[counter].Breed, FollowerDogs[counter].Species, FollowerDogs[counter].FullName));
                                break;

                            case "Spaniel":
                                Console.WriteLine(String.Format("      {0}          {1}                  {2}                         {3}", FollowerDogs[counter].DogId, FollowerDogs[counter].Breed, FollowerDogs[counter].Species, FollowerDogs[counter].FullName));
                                break;

                            case "Char Pei":
                                Console.WriteLine(String.Format("      {0}             {1}                  {2}                         {3}", FollowerDogs[counter].DogId, FollowerDogs[counter].Breed, FollowerDogs[counter].Species, FollowerDogs[counter].FullName));
                                break;

                            case "Maltese":
                                Console.WriteLine(String.Format("      {0}             {1}                  {2}                         {3}", FollowerDogs[counter].DogId, FollowerDogs[counter].Breed, FollowerDogs[counter].Species, FollowerDogs[counter].FullName));
                                break;

                            case "Shiba Inu":
                                Console.WriteLine(String.Format("      {0}             {1}                  {2}                         {3}", FollowerDogs[counter].DogId, FollowerDogs[counter].Breed, FollowerDogs[counter].Species, FollowerDogs[counter].FullName));
                                break;

                            case "Spitz":
                                Console.WriteLine(String.Format("      {0}             {1}                  {2}                         {3}", FollowerDogs[counter].DogId, FollowerDogs[counter].Breed, FollowerDogs[counter].Species, FollowerDogs[counter].FullName));
                                break;

                            default:
                                Console.WriteLine(String.Format("      {0}             {1}                  {2}                         {3}", FollowerDogs[counter].DogId, FollowerDogs[counter].Breed, FollowerDogs[counter].Species, FollowerDogs[counter].FullName));
                                break;

                        }
                    }
                    else
                    {
                        switch (FollowerDogs[counter].Species)
                        {
                            case "Bulldog":
                                Console.WriteLine(String.Format("      {0}         {1}                  {2}                         {3}", FollowerDogs[counter].DogId, FollowerDogs[counter].Breed, FollowerDogs[counter].Species, FollowerDogs[counter].FullName));
                                break;

                            case "Chow Chow":
                                Console.WriteLine(String.Format("      {0}         {1}                  {2}                         {3}", FollowerDogs[counter].DogId, FollowerDogs[counter].Breed, FollowerDogs[counter].Species, FollowerDogs[counter].FullName));
                                break;

                            case "Fox terrier":
                                Console.WriteLine(String.Format("      {0}         {1}                  {2}                         {3}", FollowerDogs[counter].DogId, FollowerDogs[counter].Breed, FollowerDogs[counter].Species, FollowerDogs[counter].FullName));
                                break;

                            case "Hound":
                                Console.WriteLine(String.Format("      {0}         {1}                  {2}                         {3}", FollowerDogs[counter].DogId, FollowerDogs[counter].Breed, FollowerDogs[counter].Species, FollowerDogs[counter].FullName));
                                break;

                            case "Griffon":
                                Console.WriteLine(String.Format("      {0}         {1}                  {2}                         {3}", FollowerDogs[counter].DogId, FollowerDogs[counter].Breed, FollowerDogs[counter].Species, FollowerDogs[counter].FullName));
                                break;

                            case "Loser dog":
                                Console.WriteLine(String.Format("      {0}         {1}                  {2}                    {3}", FollowerDogs[counter].DogId, FollowerDogs[counter].Breed, FollowerDogs[counter].Species, FollowerDogs[counter].FullName));
                                break;

                            case "Mops":
                                Console.WriteLine(String.Format("      {0}         {1}                  {2}                            {3}", FollowerDogs[counter].DogId, FollowerDogs[counter].Breed, FollowerDogs[counter].Species, FollowerDogs[counter].FullName));
                                break;

                            case "Pinch":
                                Console.WriteLine(String.Format("      {0}         {1}                  {2}                           {3}", FollowerDogs[counter].DogId, FollowerDogs[counter].Breed, FollowerDogs[counter].Species, FollowerDogs[counter].FullName));
                                break;

                            case "Pudl":
                                Console.WriteLine(String.Format("      {0}         {1}                  {2}                            {3}", FollowerDogs[counter].DogId, FollowerDogs[counter].Breed, FollowerDogs[counter].Species, FollowerDogs[counter].FullName));
                                break;

                            case "Spaniel":
                                Console.WriteLine(String.Format("      {0}         {1}                  {2}                         {3}", FollowerDogs[counter].DogId, FollowerDogs[counter].Breed, FollowerDogs[counter].Species, FollowerDogs[counter].FullName));
                                break;

                            case "Char Pei":
                                Console.WriteLine(String.Format("      {0}         {1}                  {2}                        {3}", FollowerDogs[counter].DogId, FollowerDogs[counter].Breed, FollowerDogs[counter].Species, FollowerDogs[counter].FullName));
                                break;

                            case "Maltese":
                                Console.WriteLine(String.Format("      {0}         {1}                  {2}                         {3}", FollowerDogs[counter].DogId, FollowerDogs[counter].Breed, FollowerDogs[counter].Species, FollowerDogs[counter].FullName));
                                break;

                            case "Shiba Inu":
                                Console.WriteLine(String.Format("      {0}         {1}                  {2}                       {3}", FollowerDogs[counter].DogId, FollowerDogs[counter].Breed, FollowerDogs[counter].Species, FollowerDogs[counter].FullName));
                                break;

                            case "Spitz":
                                Console.WriteLine(String.Format("      {0}         {1}                  {2}                           {3}", FollowerDogs[counter].DogId, FollowerDogs[counter].Breed, FollowerDogs[counter].Species, FollowerDogs[counter].FullName));
                                break;

                            default:
                                Console.WriteLine(String.Format("      {0}         {1}                  {2}                        {3}", FollowerDogs[counter].DogId, FollowerDogs[counter].Breed, FollowerDogs[counter].Species, FollowerDogs[counter].FullName));
                                break;

                        }
                    }
                    Console.WriteLine();
                }
            }
        }

        public static void HuntingDogsList(string display)
        {
            int answer = Convert.ToInt32(display);

            List<DisplayDogs> HuntingDogs = new List<DisplayDogs>()
            {
                new DisplayDogs
                {
                    DogId = 1,
                    Breed = "Hunting dog",
                    Species = "Basset",
                    FullName = "Artois norman basset"
                },
                new DisplayDogs
                {
                    DogId = 2,
                    Breed = "Hunting dog",
                    Species = "Basset",
                    FullName = "English basset"
                },
                new DisplayDogs
                {
                    DogId = 3,
                    Breed = "Hunting dog",
                    Species = "Basset",
                    FullName = "Blue gascon basset"
                },
                new DisplayDogs
                {
                    DogId = 4,
                    Breed = "Hunting dog",
                    Species = "Basset",
                    FullName = "Ginger breton sharp-haired basset"
                },
                new DisplayDogs
                {
                    DogId = 5,
                    Breed = "Hunting dog",
                    Species = "Basset",
                    FullName = "Vendean sharp-haired basset"
                },
                new DisplayDogs
                {
                    DogId = 6,
                    Breed = "Hunting dog",
                    Species = "Basenji",
                    FullName = "Basenji"
                },
                new DisplayDogs
                {
                    DogId = 7,
                    Breed = "Hunting dog",
                    Species = "Doga",
                    FullName = "Brazilian doga"
                },
                new DisplayDogs
                {
                    DogId = 8,
                    Breed = "Hunting dog",
                    Species = "Hound",
                    FullName = "Bernese hound"
                },
                new DisplayDogs
                {
                    DogId = 9,
                    Breed = "Hunting dog",
                    Species = "Hound",
                    FullName = "White colored raccoon hound"
                },
                new DisplayDogs
                {
                    DogId = 10,
                    Breed = "Hunting dog",
                    Species = "Hound",
                    FullName = "Bosnian sharp-haired hound"
                },
                new DisplayDogs
                {
                    DogId = 11,
                    Breed = "Hunting dog",
                    Species = "Hound",
                    FullName = "Austrian hound"
                },
                new DisplayDogs
                {
                    DogId = 12,
                    Breed = "Hunting dog",
                    Species = "Hound",
                    FullName = "Arijenese hound"
                },
                new DisplayDogs
                {
                    DogId = 13,
                    Breed = "Hunting dog",
                    Species = "Hound",
                    FullName = "Balkan hound"
                },
                new DisplayDogs
                {
                    DogId = 14,
                    Breed = "Hunting dog",
                    Species = "Hound",
                    FullName = "Bavarian bloodline"
                },
                new DisplayDogs
                {
                    DogId = 15,
                    Breed = "Hunting dog",
                    Species = "Hound",
                    FullName = "Mountain spanish hound"
                },
                new DisplayDogs
                {
                    DogId = 16,
                    Breed = "Hunting dog",
                    Species = "Hound",
                    FullName = "Red raccoon hound"
                },
                new DisplayDogs
                {
                    DogId = 17,
                    Breed = "Hunting dog",
                    Species = "Hound",
                    FullName = "Red colored raccoon hound"
                },
                new DisplayDogs
                {
                    DogId = 18,
                    Breed = "Hunting dog",
                    Species = "Hound",
                    FullName = "Dunker hound"
                },
                new DisplayDogs
                {
                    DogId = 19,
                    Breed = "Hunting dog",
                    Species = "Hound",
                    FullName = "Finnish hound"
                },
                new DisplayDogs
                {
                    DogId = 20,
                    Breed = "Hunting dog",
                    Species = "Hound",
                    FullName = "Finnish birds hound"
                },
                new DisplayDogs
                {
                    DogId = 21,
                    Breed = "Hunting dog",
                    Species = "Hound",
                    FullName = "French hound"
                },
                new DisplayDogs
                {
                    DogId = 22,
                    Breed = "Hunting dog",
                    Species = "Hound",
                    FullName = "Little blue gascon hound"
                },
                new DisplayDogs
                {
                    DogId = 23,
                    Breed = "Hunting dog",
                    Species = "Hound",
                    FullName = "Tennessee hound"
                },
                new DisplayDogs
                {
                    DogId = 24,
                    Breed = "Hunting dog",
                    Species = "Hound",
                    FullName = "Raccoon hound"
                },
                new DisplayDogs
                {
                    DogId = 25,
                    Breed = "Hunting dog",
                    Species = "Hound",
                    FullName = "Otter hound"
                },
                new DisplayDogs
                {
                    DogId = 26,
                    Breed = "Hunting dog",
                    Species = "Hound",
                    FullName = "Greek hound"
                },
                new DisplayDogs
                {
                    DogId = 27,
                    Breed = "Hunting dog",
                    Species = "Hound",
                    FullName = "Halden hound"
                },
                new DisplayDogs
                {
                    DogId = 28,
                    Breed = "Hunting dog",
                    Species = "Hound",
                    FullName = "Hamilton hound"
                },
                new DisplayDogs
                {
                    DogId = 29,
                    Breed = "Hunting dog",
                    Species = "Hound",
                    FullName = "Hannover bloodline"
                },
                new DisplayDogs
                {
                    DogId = 30,
                    Breed = "Hunting dog",
                    Species = "Hound",
                    FullName = "Higen hound"
                },
                new DisplayDogs
                {
                    DogId = 31,
                    Breed = "Hunting dog",
                    Species = "Hound",
                    FullName = "Ibizan humpbacked hound"
                },
                new DisplayDogs
                {
                    DogId = 32,
                    Breed = "Hunting dog",
                    Species = "Hound",
                    FullName = "Istrian shorthair hound"
                },
                new DisplayDogs
                {
                    DogId = 33,
                    Breed = "Hunting dog",
                    Species = "Hound",
                    FullName = "Istrian sharp-haired hound"
                },
                new DisplayDogs
                {
                    DogId = 34,
                    Breed = "Hunting dog",
                    Species = "Hound",
                    FullName = "Jamtlandic salmon hound"
                },
                new DisplayDogs
                {
                    DogId = 35,
                    Breed = "Hunting dog",
                    Species = "Hound",
                    FullName = "Jurrasic hound"
                },
                new DisplayDogs
                {
                    DogId = 36,
                    Breed = "Hunting dog",
                    Species = "Hound",
                    FullName = "Karelian bear hound"
                },
                new DisplayDogs
                {
                    DogId = 37,
                    Breed = "Hunting dog",
                    Species = "Hound",
                    FullName = "Levesk hound"
                },
                new DisplayDogs
                {
                    DogId = 38,
                    Breed = "Hunting dog",
                    Species = "Hound",
                    FullName = "Lucern hound"
                },
                new DisplayDogs
                {
                    DogId = 39,
                    Breed = "Hunting dog",
                    Species = "Hound",
                    FullName = "Hungarian hound"
                },
                new DisplayDogs
                {
                    DogId = 40,
                    Breed = "Hunting dog",
                    Species = "Hound",
                    FullName = "Little british-french hound"
                },
                new DisplayDogs
                {
                    DogId = 41,
                    Breed = "Hunting dog",
                    Species = "Hound",
                    FullName = "Little gascon hound"
                },
                new DisplayDogs
                {
                    DogId = 42,
                    Breed = "Hunting dog",
                    Species = "Hound",
                    FullName = "Nivern sharp-haired hound"
                },
                new DisplayDogs
                {
                    DogId = 43,
                    Breed = "Hunting dog",
                    Species = "Hound",
                    FullName = "Little portuguese humpbacked hound"
                },
                new DisplayDogs
                {
                    DogId = 44,
                    Breed = "Hunting dog",
                    Species = "Hound",
                    FullName = "Norwegian salmon hound"
                },
                new DisplayDogs
                {
                    DogId = 45,
                    Breed = "Hunting dog",
                    Species = "Hound",
                    FullName = "Norwegian duck hound"
                },
                new DisplayDogs
                {
                    DogId = 46,
                    Breed = "Hunting dog",
                    Species = "Hound",
                    FullName = "German hound"
                },
                new DisplayDogs
                {
                    DogId = 47,
                    Breed = "Hunting dog",
                    Species = "Hound",
                    FullName = "Saint Hubert dog"
                },
                new DisplayDogs
                {
                    DogId = 48,
                    Breed = "Hunting dog",
                    Species = "Hound",
                    FullName = "Mountain hound"
                },
                new DisplayDogs
                {
                    DogId = 49,
                    Breed = "Hunting dog",
                    Species = "Hound",
                    FullName = "Plot hound"
                },
                new DisplayDogs
                {
                    DogId = 50,
                    Breed = "Hunting dog",
                    Species = "Hound",
                    FullName = "Blue raccoon hound"
                },
                new DisplayDogs
                {
                    DogId = 51,
                    Breed = "Hunting dog",
                    Species = "Hound",
                    FullName = "Poateven hound"
                },
                new DisplayDogs
                {
                    DogId = 52,
                    Breed = "Hunting dog",
                    Species = "Hound",
                    FullName = "Field hound"
                },
                new DisplayDogs
                {
                    DogId = 53,
                    Breed = "Hunting dog",
                    Species = "Hound",
                    FullName = "Posavina hound"
                },
                new DisplayDogs
                {
                    DogId = 54,
                    Breed = "Hunting dog",
                    Species = "Hound",
                    FullName = "Rhodesian hound"
                },
                new DisplayDogs
                {
                    DogId = 55,
                    Breed = "Hunting dog",
                    Species = "Hound",
                    FullName = "Porcelain hound"
                },
                new DisplayDogs
                {
                    DogId = 56,
                    Breed = "Hunting dog",
                    Species = "Hound",
                    FullName = "Skandinavian grey hound"
                },
                new DisplayDogs
                {
                    DogId = 57,
                    Breed = "Hunting dog",
                    Species = "Hound",
                    FullName = "Smaland hound"
                },
                new DisplayDogs
                {
                    DogId = 58,
                    Breed = "Hunting dog",
                    Species = "Hound",
                    FullName = "Sicilian humpbacked hound"
                },
                new DisplayDogs
                {
                    DogId = 59,
                    Breed = "Hunting dog",
                    Species = "Hound",
                    FullName = "Middle artois hound"
                },
                new DisplayDogs
                {
                    DogId = 60,
                    Breed = "Hunting dog",
                    Species = "Hound",
                    FullName = "Slovak hound"
                },
                new DisplayDogs
                {
                    DogId = 61,
                    Breed = "Hunting dog",
                    Species = "Hound",
                    FullName = "Middle sharp-haired vendean hound"
                },
                new DisplayDogs
                {
                    DogId = 62,
                    Breed = "Hunting dog",
                    Species = "Hound",
                    FullName = "Middle portuguese humpbacked hound"
                },
                new DisplayDogs
                {
                    DogId = 63,
                    Breed = "Hunting dog",
                    Species = "Hound",
                    FullName = "Swedish short-legged hound"
                },
                new DisplayDogs
                {
                    DogId = 64,
                    Breed = "Hunting dog",
                    Species = "Hound",
                    FullName = "Schiller hound"
                },
                new DisplayDogs
                {
                    DogId = 65,
                    Breed = "Hunting dog",
                    Species = "Hound",
                    FullName = "Middle british-french hound"
                },
                new DisplayDogs
                {
                    DogId = 66,
                    Breed = "Hunting dog",
                    Species = "Hound",
                    FullName = "Swiss hound"
                },
                new DisplayDogs
                {
                    DogId = 67,
                    Breed = "Hunting dog",
                    Species = "Hound",
                    FullName = "Swiss short-legged hound"
                },
                new DisplayDogs
                {
                    DogId = 68,
                    Breed = "Hunting dog",
                    Species = "Hound",
                    FullName = "Styrian high mountain sharp-haired hound"
                },
                new DisplayDogs
                {
                    DogId = 69,
                    Breed = "Hunting dog",
                    Species = "Hound",
                    FullName = "Italian hound"
                },
                new DisplayDogs
                {
                    DogId = 70,
                    Breed = "Hunting dog",
                    Species = "Hound",
                    FullName = "Tyrolean hound"
                },
                new DisplayDogs
                {
                    DogId = 71,
                    Breed = "Hunting dog",
                    Species = "Hound",
                    FullName = "Trigov dog"
                },
                new DisplayDogs
                {
                    DogId = 72,
                    Breed = "Hunting dog",
                    Species = "Hound",
                    FullName = "Big portuguese humpbacked hound"
                },
                new DisplayDogs
                {
                    DogId = 73,
                    Breed = "Hunting dog",
                    Species = "Hound",
                    FullName = "Big british-french hound"
                },
                new DisplayDogs
                {
                    DogId = 74,
                    Breed = "Hunting dog",
                    Species = "Hound",
                    FullName = "Big gascon sentojoanski hound"
                },
                new DisplayDogs
                {
                    DogId = 75,
                    Breed = "Hunting dog",
                    Species = "Hound",
                    FullName = "Big blue gascon hound"
                },
                new DisplayDogs
                {
                    DogId = 76,
                    Breed = "Hunting dog",
                    Species = "Hound",
                    FullName = "Big vendean sharp-haired hound"
                },
                new DisplayDogs
                {
                    DogId = 77,
                    Breed = "Hunting dog",
                    Species = "Hound",
                    FullName = "Yellow sharp-haired breton hound"
                },
                new DisplayDogs
                {
                    DogId = 78,
                    Breed = "Hunting dog",
                    Species = "Epaniel",
                    FullName = "Breton epaniel"
                },
                new DisplayDogs
                {
                    DogId = 79,
                    Breed = "Hunting dog",
                    Species = "Epaniel",
                    FullName = "French epaniel"
                },
                new DisplayDogs
                {
                    DogId = 80,
                    Breed = "Hunting dog",
                    Species = "Epaniel",
                    FullName = "Picardy epaniel"
                },
                new DisplayDogs
                {
                    DogId = 81,
                    Breed = "Hunting dog",
                    Species = "Epaniel",
                    FullName = "Pon overseas epaniel"
                },
                new DisplayDogs
                {
                    DogId = 82,
                    Breed = "Hunting dog",
                    Species = "Dachshund",
                    FullName = "Marriage dachshund"
                },
                new DisplayDogs
                {
                    DogId = 83,
                    Breed = "Hunting dog",
                    Species = "Dachshund",
                    FullName = "Longhaired dachshund"
                },
                new DisplayDogs
                {
                    DogId = 84,
                    Breed = "Hunting dog",
                    Species = "Dachshund",
                    FullName = "Shorthaired dachshund"
                },
                new DisplayDogs
                {
                    DogId = 85,
                    Breed = "Hunting dog",
                    Species = "Dachshund",
                    FullName = "Westphalian marriage dachshund"
                },
                new DisplayDogs
                {
                    DogId = 86,
                    Breed = "Hunting dog",
                    Species = "Foxhound",
                    FullName = "American foxhound"
                },
                new DisplayDogs
                {
                    DogId = 87,
                    Breed = "Hunting dog",
                    Species = "Foxhound",
                    FullName = "English foxhound"
                },
                new DisplayDogs
                {
                    DogId = 88,
                    Breed = "Hunting dog",
                    Species = "Pointer",
                    FullName = "Frisian pointer"
                },
                new DisplayDogs
                {
                    DogId = 89,
                    Breed = "Hunting dog",
                    Species = "Pointer",
                    FullName = "Dutch pointer"
                },
                new DisplayDogs
                {
                    DogId = 90,
                    Breed = "Hunting dog",
                    Species = "Pointer",
                    FullName = "German pointer",
                },
                new DisplayDogs
                {
                    DogId = 91,
                    Breed = "Hunting dog",
                    Species = "Bird watcher",
                    FullName = "Arijenese bird watcher"
                },
                new DisplayDogs
                {
                    DogId = 92,
                    Breed = "Hunting dog",
                    Species = "Bird watcher",
                    FullName = "French bearded bird watcher"
                },
                new DisplayDogs
                {
                    DogId = 93,
                    Breed = "Hunting dog",
                    Species = "Bird watcher",
                    FullName = "Bule's woolly hair bird watcher"
                },
                new DisplayDogs
                {
                    DogId = 94,
                    Breed = "Hunting dog",
                    Species = "Bird watcher",
                    FullName = "Bourbon bird watcher"
                },
                new DisplayDogs
                {
                    DogId = 95,
                    Breed = "Hunting dog",
                    Species = "Bird watcher",
                    FullName = "Dipui's bird watcher"
                },
                new DisplayDogs
                {
                    DogId = 96,
                    Breed = "Hunting dog",
                    Species = "Bird watcher",
                    FullName = "Burgos bird watcher"
                },
                new DisplayDogs
                {
                    DogId = 97,
                    Breed = "Hunting dog",
                    Species = "Bird watcher",
                    FullName = "Czech sharp-haired bird watcher"
                },
                new DisplayDogs
                {
                    DogId = 98,
                    Breed = "Hunting dog",
                    Species = "Bird watcher",
                    FullName = "Denmark shorthair bird watcher"
                },
                new DisplayDogs
                {
                    DogId = 99,
                    Breed = "Hunting dog",
                    Species = "Bird watcher",
                    FullName = "French shorthair bird watcher"
                },
                new DisplayDogs
                {
                    DogId = 100,
                    Breed = "Hunting dog",
                    Species = "Bird watcher",
                    FullName = "English shorthair bird watcher"
                },
                new DisplayDogs
                {
                    DogId = 101,
                    Breed = "Hunting dog",
                    Species = "Bird watcher",
                    FullName = "Korthalsov sharp-haired bird watcher"
                },
                new DisplayDogs
                {
                    DogId = 102,
                    Breed = "Hunting dog",
                    Species = "Bird watcher",
                    FullName = "Hungarian shorthair bird watcher"
                },
                new DisplayDogs
                {
                    DogId = 103,
                    Breed = "Hunting dog",
                    Species = "Bird watcher",
                    FullName = "Little minstrelsy bird watcher"
                },
                new DisplayDogs
                {
                    DogId = 104,
                    Breed = "Hunting dog",
                    Species = "Bird watcher",
                    FullName = "Dutch bird watcher"
                },
                new DisplayDogs
                {
                    DogId = 105,
                    Breed = "Hunting dog",
                    Species = "Bird watcher",
                    FullName = "German longhair bird watcher"
                },
                new DisplayDogs
                {
                    DogId = 106,
                    Breed = "Hunting dog",
                    Species = "Bird watcher",
                    FullName = "German shorthair bird watcher"
                },
                new DisplayDogs
                {
                    DogId = 107,
                    Breed = "Hunting dog",
                    Species = "Bird watcher",
                    FullName = "Auvergne bird watcher"
                },
                new DisplayDogs
                {
                    DogId = 108,
                    Breed = "Hunting dog",
                    Species = "Bird watcher",
                    FullName = "Portuguese shorthair bird watcher"
                },
                new DisplayDogs
                {
                    DogId = 109,
                    Breed = "Hunting dog",
                    Species = "Bird watcher",
                    FullName = "Saint-Germain bird watcher"
                },
                new DisplayDogs
                {
                    DogId = 110,
                    Breed = "Hunting dog",
                    Species = "Bird watcher",
                    FullName = "Pudlpointer"
                },
                new DisplayDogs
                {
                    DogId = 111,
                    Breed = "Hunting dog",
                    Species = "Bird watcher",
                    FullName = "Italian shorthair bird watcher"
                },
                new DisplayDogs
                {
                    DogId = 112,
                    Breed = "Hunting dog",
                    Species = "Bird watcher",
                    FullName = "Italian sharp-haired bird watcher"
                },
                new DisplayDogs
                {
                    DogId = 113,
                    Breed = "Hunting dog",
                    Species = "Bird watcher",
                    FullName = "Weimar bird watcher"
                },
                new DisplayDogs
                {
                    DogId = 114,
                    Breed = "Hunting dog",
                    Species = "Bird watcher",
                    FullName = "Big minstrelsy bird watcher"
                },
                new DisplayDogs
                {
                    DogId = 115,
                    Breed = "Hunting dog",
                    Species = "Setter",
                    FullName = "English setter"
                },
                new DisplayDogs
                {
                    DogId = 116,
                    Breed = "Hunting dog",
                    Species = "Setter",
                    FullName = "Gordon setter"
                },
                new DisplayDogs
                {
                    DogId = 117,
                    Breed = "Hunting dog",
                    Species = "Setter",
                    FullName = "Irish setter"
                },
                new DisplayDogs
                {
                    DogId = 118,
                    Breed = "Hunting dog",
                    Species = "Retriever",
                    FullName = "Longhair retriever"
                },
                new DisplayDogs
                {
                    DogId = 119,
                    Breed = "Hunting dog",
                    Species = "Retriever",
                    FullName = "Curly retriever"
                },
                new DisplayDogs
                {
                    DogId = 120,
                    Breed = "Hunting dog",
                    Species = "Retriever",
                    FullName = "Labrador retriever"
                },
                new DisplayDogs
                {
                    DogId = 121,
                    Breed = "Hunting dog",
                    Species = "Retriever",
                    FullName = "Chesapeake Bay retriever"
                },
                new DisplayDogs
                {
                    DogId = 122,
                    Breed = "Hunting dog",
                    Species = "Retriever",
                    FullName = "Golden retriever"
                },
                new DisplayDogs
                {
                    DogId = 123,
                    Breed = "Hunting dog",
                    Species = "Spaniel",
                    FullName = "American cocker spaniel"
                },
                new DisplayDogs
                {
                    DogId = 124,
                    Breed = "Hunting dog",
                    Species = "Spaniel",
                    FullName = "American water spaniel"
                },
                new DisplayDogs
                {
                    DogId = 125,
                    Breed = "Hunting dog",
                    Species = "Spaniel",
                    FullName = "Boykin spaniel"
                },
                new DisplayDogs
                {
                    DogId = 126,
                    Breed = "Hunting dog",
                    Species = "Spaniel",
                    FullName = "English cocker spaniel"
                },
                new DisplayDogs
                {
                    DogId = 127,
                    Breed = "Hunting dog",
                    Species = "Spaniel",
                    FullName = "English springer spaniel"
                },
                new DisplayDogs
                {
                    DogId = 128,
                    Breed = "Hunting dog",
                    Species = "Spaniel",
                    FullName = "Irish water spaniel"
                },
                new DisplayDogs
                {
                    DogId = 129,
                    Breed = "Hunting dog",
                    Species = "Spaniel",
                    FullName = "Clamp spaniel"
                },
                new DisplayDogs
                {
                    DogId = 130,
                    Breed = "Hunting dog",
                    Species = "Spaniel",
                    FullName = "Field spaniel"
                },
                new DisplayDogs
                {
                    DogId = 131,
                    Breed = "Hunting dog",
                    Species = "Spaniel",
                    FullName = "Sasik spaniel"
                },
                new DisplayDogs
                {
                    DogId = 132,
                    Breed = "Hunting dog",
                    Species = "Spaniel",
                    FullName = "Welsh springer spaniel"
                },
                new DisplayDogs
                {
                    DogId = 133,
                    Breed = "Hunting dog",
                    Species = "Beagle",
                    FullName = "Beagle"
                },
                new DisplayDogs
                {
                    DogId = 134,
                    Breed = "Hunting dog",
                    Species = "Beagle",
                    FullName = "English beagle"
                },
                new DisplayDogs
                {
                    DogId = 135,
                    Breed = "Hunting dog",
                    Species = "Beagle",
                    FullName = "Somersetian beagle"
                }
            };

            if (answer == 0 || answer > 135)
            {
                HuntingDogsListOutput(HuntingDogs, answer);
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("     ID             Breed                       Species                        Fullname");
                Console.WriteLine("    --------------------------------------------------------------------------------------------------------------------");

                HuntingDogsListOutput(HuntingDogs, answer);
            }
        }

        public static void HuntingDogsListOutput(List<DisplayDogs> HuntingDogs, int answer)
        {

            int NumberOfItems = HuntingDogs.Count();
            if (answer > NumberOfItems)
            {
                Console.WriteLine("Next time please input any number between 1 and including 135, number that you've inputted is too high!");
            }
            else if (answer == 0)
            {
                Console.WriteLine("Next time please input valid number!");
            }
            else
            {
                for (var counter = 0; counter < answer; counter++)
                {
                    if (HuntingDogs[counter].DogId >= 1 && HuntingDogs[counter].DogId < 10)
                    {
                        switch (HuntingDogs[counter].Species)
                        {
                            case "Basset":
                                Console.WriteLine(String.Format("      {0}          {1}                   {2}                          {3}", HuntingDogs[counter].DogId, HuntingDogs[counter].Breed, HuntingDogs[counter].Species, HuntingDogs[counter].FullName));
                                break;

                            case "Basenji":
                                Console.WriteLine(String.Format("      {0}          {1}                   {2}                         {3}", HuntingDogs[counter].DogId, HuntingDogs[counter].Breed, HuntingDogs[counter].Species, HuntingDogs[counter].FullName));
                                break;

                            case "Doga":
                                Console.WriteLine(String.Format("      {0}          {1}                   {2}                            {3}", HuntingDogs[counter].DogId, HuntingDogs[counter].Breed, HuntingDogs[counter].Species, HuntingDogs[counter].FullName));
                                break;

                            case "Hound":
                                Console.WriteLine(String.Format("      {0}          {1}                   {2}                           {3}", HuntingDogs[counter].DogId, HuntingDogs[counter].Breed, HuntingDogs[counter].Species, HuntingDogs[counter].FullName));
                                break;

                            case "Epaniel":
                                Console.WriteLine(String.Format("      {0}            {1}                   {2}                      {3}", HuntingDogs[counter].DogId, HuntingDogs[counter].Breed, HuntingDogs[counter].Species, HuntingDogs[counter].FullName));
                                break;

                            case "Dachshund":
                                Console.WriteLine(String.Format("      {0}            {1}                   {2}                      {3}", HuntingDogs[counter].DogId, HuntingDogs[counter].Breed, HuntingDogs[counter].Species, HuntingDogs[counter].FullName));
                                break;

                            case "Foxhound":
                                Console.WriteLine(String.Format("      {0}            {1}                   {2}                      {3}", HuntingDogs[counter].DogId, HuntingDogs[counter].Breed, HuntingDogs[counter].Species, HuntingDogs[counter].FullName));
                                break;

                            case "Pointer":
                                Console.WriteLine(String.Format("      {0}            {1}                   {2}                      {3}", HuntingDogs[counter].DogId, HuntingDogs[counter].Breed, HuntingDogs[counter].Species, HuntingDogs[counter].FullName));
                                break;

                            case "Bird watcher":
                                Console.WriteLine(String.Format("      {0}            {1}                    {2}                      {3}", HuntingDogs[counter].DogId, HuntingDogs[counter].Breed, HuntingDogs[counter].Species, HuntingDogs[counter].FullName));
                                break;

                            case "Setter":
                                Console.WriteLine(String.Format("      {0}            {1}                    {2}                      {3}", HuntingDogs[counter].DogId, HuntingDogs[counter].Breed, HuntingDogs[counter].Species, HuntingDogs[counter].FullName));
                                break;

                            case "Retriever":
                                Console.WriteLine(String.Format("      {0}            {1}                    {2}                      {3}", HuntingDogs[counter].DogId, HuntingDogs[counter].Breed, HuntingDogs[counter].Species, HuntingDogs[counter].FullName));
                                break;

                            case "Spaniel":
                                Console.WriteLine(String.Format("      {0}            {1}                    {2}                      {3}", HuntingDogs[counter].DogId, HuntingDogs[counter].Breed, HuntingDogs[counter].Species, HuntingDogs[counter].FullName));
                                break;

                            case "Beagle":
                                Console.WriteLine(String.Format("      {0}            {1}                    {2}                      {3}", HuntingDogs[counter].DogId, HuntingDogs[counter].Breed, HuntingDogs[counter].Species, HuntingDogs[counter].FullName));
                                break;

                        }
                    }
                    else if (HuntingDogs[counter].DogId >= 10 && HuntingDogs[counter].DogId < 100)
                    {
                        switch (HuntingDogs[counter].Species)
                        {
                            case "Basset":
                                Console.WriteLine(String.Format("      {0}         {1}                   {2}                      {3}", HuntingDogs[counter].DogId, HuntingDogs[counter].Breed, HuntingDogs[counter].Species, HuntingDogs[counter].FullName));
                                break;

                            case "Basenji":
                                Console.WriteLine(String.Format("      {0}         {1}                   {2}                      {3}", HuntingDogs[counter].DogId, HuntingDogs[counter].Breed, HuntingDogs[counter].Species, HuntingDogs[counter].FullName));
                                break;

                            case "Doga":
                                Console.WriteLine(String.Format("      {0}         {1}                   {2}                      {3}", HuntingDogs[counter].DogId, HuntingDogs[counter].Breed, HuntingDogs[counter].Species, HuntingDogs[counter].FullName));
                                break;

                            case "Hound":
                                Console.WriteLine(String.Format("      {0}         {1}                   {2}                           {3}", HuntingDogs[counter].DogId, HuntingDogs[counter].Breed, HuntingDogs[counter].Species, HuntingDogs[counter].FullName));
                                break;

                            case "Epaniel":
                                Console.WriteLine(String.Format("      {0}         {1}                   {2}                         {3}", HuntingDogs[counter].DogId, HuntingDogs[counter].Breed, HuntingDogs[counter].Species, HuntingDogs[counter].FullName));
                                break;

                            case "Dachshund":
                                Console.WriteLine(String.Format("      {0}         {1}                   {2}                       {3}", HuntingDogs[counter].DogId, HuntingDogs[counter].Breed, HuntingDogs[counter].Species, HuntingDogs[counter].FullName));
                                break;

                            case "Foxhound":
                                Console.WriteLine(String.Format("      {0}         {1}                   {2}                        {3}", HuntingDogs[counter].DogId, HuntingDogs[counter].Breed, HuntingDogs[counter].Species, HuntingDogs[counter].FullName));
                                break;

                            case "Pointer":
                                Console.WriteLine(String.Format("      {0}         {1}                   {2}                         {3}", HuntingDogs[counter].DogId, HuntingDogs[counter].Breed, HuntingDogs[counter].Species, HuntingDogs[counter].FullName));
                                break;

                            case "Bird watcher":
                                Console.WriteLine(String.Format("      {0}         {1}                   {2}                    {3}", HuntingDogs[counter].DogId, HuntingDogs[counter].Breed, HuntingDogs[counter].Species, HuntingDogs[counter].FullName));
                                break;

                            case "Setter":
                                Console.WriteLine(String.Format("      {0}           {1}                   {2}                      {3}", HuntingDogs[counter].DogId, HuntingDogs[counter].Breed, HuntingDogs[counter].Species, HuntingDogs[counter].FullName));
                                break;

                            case "Retriever":
                                Console.WriteLine(String.Format("      {0}           {1}                   {2}                      {3}", HuntingDogs[counter].DogId, HuntingDogs[counter].Breed, HuntingDogs[counter].Species, HuntingDogs[counter].FullName));
                                break;

                            case "Spaniel":
                                Console.WriteLine(String.Format("      {0}           {1}                   {2}                      {3}", HuntingDogs[counter].DogId, HuntingDogs[counter].Breed, HuntingDogs[counter].Species, HuntingDogs[counter].FullName));
                                break;

                            case "Beagle":
                                Console.WriteLine(String.Format("      {0}           {1}                   {2}                      {3}", HuntingDogs[counter].DogId, HuntingDogs[counter].Breed, HuntingDogs[counter].Species, HuntingDogs[counter].FullName));
                                break;
                        }
                    }
                    else
                    {
                        switch (HuntingDogs[counter].Species)
                        {
                            case "Basset":
                                Console.WriteLine(String.Format("      {0}        {1}                   {2}                      {3}", HuntingDogs[counter].DogId, HuntingDogs[counter].Breed, HuntingDogs[counter].Species, HuntingDogs[counter].FullName));
                                break;

                            case "Basenji":
                                Console.WriteLine(String.Format("      {0}        {1}                   {2}                      {3}", HuntingDogs[counter].DogId, HuntingDogs[counter].Breed, HuntingDogs[counter].Species, HuntingDogs[counter].FullName));
                                break;

                            case "Doga":
                                Console.WriteLine(String.Format("      {0}        {1}                   {2}                      {3}", HuntingDogs[counter].DogId, HuntingDogs[counter].Breed, HuntingDogs[counter].Species, HuntingDogs[counter].FullName));
                                break;

                            case "Hound":
                                Console.WriteLine(String.Format("      {0}        {1}                   {2}                      {3}", HuntingDogs[counter].DogId, HuntingDogs[counter].Breed, HuntingDogs[counter].Species, HuntingDogs[counter].FullName));
                                break;

                            case "Epaniel":
                                Console.WriteLine(String.Format("      {0}        {1}                   {2}                      {3}", HuntingDogs[counter].DogId, HuntingDogs[counter].Breed, HuntingDogs[counter].Species, HuntingDogs[counter].FullName));
                                break;

                            case "Dachshund":
                                Console.WriteLine(String.Format("      {0}        {1}                   {2}                      {3}", HuntingDogs[counter].DogId, HuntingDogs[counter].Breed, HuntingDogs[counter].Species, HuntingDogs[counter].FullName));
                                break;

                            case "Foxhound":
                                Console.WriteLine(String.Format("      {0}        {1}                   {2}                      {3}", HuntingDogs[counter].DogId, HuntingDogs[counter].Breed, HuntingDogs[counter].Species, HuntingDogs[counter].FullName));
                                break;

                            case "Pointer":
                                Console.WriteLine(String.Format("      {0}        {1}                   {2}                      {3}", HuntingDogs[counter].DogId, HuntingDogs[counter].Breed, HuntingDogs[counter].Species, HuntingDogs[counter].FullName));
                                break;

                            case "Bird watcher":
                                Console.WriteLine(String.Format("      {0}        {1}                   {2}                    {3}", HuntingDogs[counter].DogId, HuntingDogs[counter].Breed, HuntingDogs[counter].Species, HuntingDogs[counter].FullName));
                                break;

                            case "Setter":
                                Console.WriteLine(String.Format("      {0}        {1}                   {2}                          {3}", HuntingDogs[counter].DogId, HuntingDogs[counter].Breed, HuntingDogs[counter].Species, HuntingDogs[counter].FullName));
                                break;

                            case "Retriever":
                                Console.WriteLine(String.Format("      {0}        {1}                   {2}                       {3}", HuntingDogs[counter].DogId, HuntingDogs[counter].Breed, HuntingDogs[counter].Species, HuntingDogs[counter].FullName));
                                break;

                            case "Spaniel":
                                Console.WriteLine(String.Format("      {0}        {1}                   {2}                         {3}", HuntingDogs[counter].DogId, HuntingDogs[counter].Breed, HuntingDogs[counter].Species, HuntingDogs[counter].FullName));
                                break;

                            case "Beagle":
                                Console.WriteLine(String.Format("      {0}        {1}                   {2}                          {3}", HuntingDogs[counter].DogId, HuntingDogs[counter].Breed, HuntingDogs[counter].Species, HuntingDogs[counter].FullName));
                                break;
                        }
                    }
                    Console.WriteLine();
                }
            }
        }

        public static void TerrierList(string display)
        {
            int answer = Convert.ToInt32(display);

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

            if (answer == 0 || answer > 28)
            {
                TerrierListOutput(Terriers, answer);
                Console.WriteLine();
            }
            else
            {

                Console.WriteLine("     ID             Breed                       Species                        Fullname");
                Console.WriteLine("    ----------------------------------------------------------------------------------------------------------");

                TerrierListOutput(Terriers, answer);
            }
        }

        public static void TerrierListOutput(List<DisplayDogs> Terriers, int answer)
        {

            int NumberOfItems = Terriers.Count();
            if (answer > NumberOfItems)
            {
                Console.WriteLine("Next time please input any number between 1 and including 28, number that you've inputted is too high!\n\n");
            }
            else if (answer == 0)
            {
                Console.WriteLine("Next time please input valid number.\n\n");
            }
            else
            {
                for (var counter = 0; counter < answer; counter++)
                {
                    if (Terriers[counter].DogId >= 1 && Terriers[counter].DogId < 10)
                    {
                        if (Terriers[counter].Species == "Bull terrier")
                        {
                            Console.WriteLine(String.Format("      {0}            {1}                     {2}                    {3}", Terriers[counter].DogId, Terriers[counter].Breed, Terriers[counter].Species, Terriers[counter].FullName));
                        }
                        else if (Terriers[counter].Species == "Fox terrier")
                        {
                            Console.WriteLine(String.Format("      {0}            {1}                     {2}                     {3}", Terriers[counter].DogId, Terriers[counter].Breed, Terriers[counter].Species, Terriers[counter].FullName));
                        }
                        else
                        {
                            Console.WriteLine(String.Format("      {0}            {1}                     {2}                         {3}", Terriers[counter].DogId, Terriers[counter].Breed, Terriers[counter].Species, Terriers[counter].FullName));
                        }
                    }
                    else
                    {
                        if (Terriers[counter].Species == "Bull terrier")
                        {
                            Console.WriteLine(String.Format("      {0}            {1}                     {2}                    {3}", Terriers[counter].DogId, Terriers[counter].Breed, Terriers[counter].Species, Terriers[counter].FullName));
                        }
                        else if (Terriers[counter].Species == "Fox terrier")
                        {
                            Console.WriteLine(String.Format("      {0}          {1}                 {2}                      {3}", Terriers[counter].DogId, Terriers[counter].Breed, Terriers[counter].Species, Terriers[counter].FullName));
                        }
                        else
                        {
                            Console.WriteLine(String.Format("      {0}           {1}                     {2}                         {3}", Terriers[counter].DogId, Terriers[counter].Breed, Terriers[counter].Species, Terriers[counter].FullName));
                        }
                    }
                    Console.WriteLine();
                }
            }
        }

        public static void ServiceDogsList(string display)
        {
            int answer = Convert.ToInt32(display);

            List<DisplayDogs> ServiceDogs = new List<DisplayDogs>()
            {
                new DisplayDogs
                {
                    DogId = 1,
                    Breed = "Service dog",
                    Species = "Australian herd guard",
                    FullName = "Australian herd guard"
                },
                new DisplayDogs
                {
                    DogId = 2,
                    Breed = "Service dog",
                    Species = "Bernardine",
                    FullName = "Longhair bernardine"
                },
                new DisplayDogs
                {
                    DogId = 3,
                    Breed = "Service dog",
                    Species = "Bernardine",
                    FullName = "Shorthair bernardine"
                },
                new DisplayDogs
                {
                    DogId = 4,
                    Breed = "Service dog",
                    Species = "Boxer",
                    FullName = "German boxer"
                },
                new DisplayDogs
                {
                    DogId = 5,
                    Breed = "Service dog",
                    Species = "Boxer",
                    FullName = "German yellow boxer"
                },
                new DisplayDogs
                {
                    DogId = 6,
                    Breed = "Service dog",
                    Species = "Boxer",
                    FullName = "Brindle german boxer"
                },
                new DisplayDogs
                {
                    DogId = 7,
                    Breed = "Service dog",
                    Species = "Bearded koli",
                    FullName = "Bearded koli"
                },
                new DisplayDogs
                {
                    DogId = 8,
                    Breed = "Service dog",
                    Species = "Doga",
                    FullName = "Bordeaux doga"
                },
                new DisplayDogs
                {
                    DogId = 9,
                    Breed = "Service dog",
                    Species = "Doga",
                    FullName = "Black german doga"
                },
                new DisplayDogs
                {
                    DogId = 10,
                    Breed = "Service dog",
                    Species = "Doga",
                    FullName = "Harlequin german doga"
                },
                new DisplayDogs
                {
                    DogId = 11,
                    Breed = "Service dog",
                    Species = "Doga",
                    FullName = "Yellow german doga"
                },
                new DisplayDogs
                {
                    DogId = 12,
                    Breed = "Service dog",
                    Species = "Husky",
                    FullName = "Canadian husky"
                },
                new DisplayDogs
                {
                    DogId = 13,
                    Breed = "Service dog",
                    Species = "Hound",
                    FullName = "Brazilian hound"
                },
                new DisplayDogs
                {
                    DogId = 14,
                    Breed = "Service dog",
                    Species = "Cattle dog",
                    FullName = "Ardenian cattle dog"
                },
                new DisplayDogs
                {
                    DogId = 15,
                    Breed = "Service dog",
                    Species = "Cattle dog",
                    FullName = "Australian cattle dog"
                },
                new DisplayDogs
                {
                    DogId = 16,
                    Breed = "Service dog",
                    Species = "Cattle dog",
                    FullName = "Flemish cattle dog"
                },
                new DisplayDogs
                {
                    DogId = 17,
                    Breed = "Service dog",
                    Species = "Loser dog",
                    FullName = "Middle loser"
                },
                new DisplayDogs
                {
                    DogId = 18,
                    Breed = "Service dog",
                    Species = "Loser dog",
                    FullName = "Big loser"
                },
                new DisplayDogs
                {
                    DogId = 19,
                    Breed = "Service dog",
                    Species = "Japanese dog",
                    FullName = "Japanese dog Ainu"
                },
                new DisplayDogs
                {
                    DogId = 20,
                    Breed = "Service dog",
                    Species = "Japanese dog",
                    FullName = "Japanese fighting dog Tosa"
                },
                new DisplayDogs
                {
                    DogId = 21,
                    Breed = "Service dog",
                    Species = "Japanese dog",
                    FullName = "Japanese dog from Hokaido"
                },
                new DisplayDogs
                {
                    DogId = 22,
                    Breed = "Service dog",
                    Species = "Lendsir",
                    FullName = "Lendsir"
                },
                new DisplayDogs
                {
                    DogId = 23,
                    Breed = "Service dog",
                    Species = "Leonberg dog",
                    FullName = "Leonberg dog"
                },
                new DisplayDogs
                {
                    DogId = 24,
                    Breed = "Service dog",
                    Species = "Mastiff",
                    FullName = "Bullmastiff"
                },
                new DisplayDogs
                {
                    DogId = 25,
                    Breed = "Service dog",
                    Species = "Mastiff",
                    FullName = "English mastiff"
                },
                new DisplayDogs
                {
                    DogId = 26,
                    Breed = "Service dog",
                    Species = "Mastiff",
                    FullName = "English mastiff"
                },
                new DisplayDogs
                {
                    DogId = 27,
                    Breed = "Service dog",
                    Species = "Mastiff",
                    FullName = "Pyrenean mastiff"
                },
                new DisplayDogs
                {
                    DogId = 28,
                    Breed = "Service dog",
                    Species = "Mastiff",
                    FullName = "Spanish mastiff"
                },
                new DisplayDogs
                {
                    DogId = 29,
                    Breed = "Service dog",
                    Species = "Mastiff",
                    FullName = "Italian mastiff"
                },
                new DisplayDogs
                {
                    DogId = 30,
                    Breed = "Service dog",
                    Species = "Mastiff",
                    FullName = "Tibetian mastiff"
                },
                new DisplayDogs
                {
                    DogId = 31,
                    Breed = "Service dog",
                    Species = "Newfoundlander",
                    FullName = "Newfoundlander"
                },
                new DisplayDogs
                {
                    DogId = 32,
                    Breed = "Service dog",
                    Species = "Sheep dog",
                    FullName = "Belgian longhair sheep dog"
                },
                new DisplayDogs
                {
                    DogId = 33,
                    Breed = "Service dog",
                    Species = "Sheep dog",
                    FullName = "Belgian shorthair sheep dog"
                },
                new DisplayDogs
                {
                    DogId = 34,
                    Breed = "Service dog",
                    Species = "Sheep dog",
                    FullName = "Belgian sheep dog"
                },
                new DisplayDogs
                {
                    DogId = 35,
                    Breed = "Service dog",
                    Species = "Sheep dog",
                    FullName = "Aturian longhair sheep dog"
                },
                new DisplayDogs
                {
                    DogId = 36,
                    Breed = "Service dog",
                    Species = "Sheep dog",
                    FullName = "Australian sheep dog"
                },
                new DisplayDogs
                {
                    DogId = 37,
                    Breed = "Service dog",
                    Species = "Sheep dog",
                    FullName = "Bergam sheep dog"
                },
                new DisplayDogs
                {
                    DogId = 38,
                    Breed = "Service dog",
                    Species = "Sheep dog",
                    FullName = "Briar sheep dog"
                },
                new DisplayDogs
                {
                    DogId = 39,
                    Breed = "Service dog",
                    Species = "Sheep dog",
                    FullName = "Hungarian sheep dog"
                },
                new DisplayDogs
                {
                    DogId = 40,
                    Breed = "Service dog",
                    Species = "Sheep dog",
                    FullName = "Hungarian sheep dog Puli"
                },
                new DisplayDogs
                {
                    DogId = 41,
                    Breed = "Service dog",
                    Species = "Sheep dog",
                    FullName = "Hungarian sheep dog Pumi"
                },
                new DisplayDogs
                {
                    DogId = 42,
                    Breed = "Service dog",
                    Species = "Sheep dog",
                    FullName = "Scotish longhair sheep dog"
                },
                new DisplayDogs
                {
                    DogId = 43,
                    Breed = "Service dog",
                    Species = "Sheep dog",
                    FullName = "Scotish border sheep dog"
                },
                new DisplayDogs
                {
                    DogId = 44,
                    Breed = "Service dog",
                    Species = "Sheep dog",
                    FullName = "Scotish shorthair sheep dog"
                },
                new DisplayDogs
                {
                    DogId = 45,
                    Breed = "Service dog",
                    Species = "Sheep dog",
                    FullName = "Karst sheep dog"
                },
                new DisplayDogs
                {
                    DogId = 46,
                    Breed = "Service dog",
                    Species = "Sheep dog",
                    FullName = "Dutch sheep dog"
                },
                new DisplayDogs
                {
                    DogId = 47,
                    Breed = "Service dog",
                    Species = "Sheep dog",
                    FullName = "German yard guard"
                },
                new DisplayDogs
                {
                    DogId = 48,
                    Breed = "Service dog",
                    Species = "Sheep dog",
                    FullName = "German sheep dog"
                },
                new DisplayDogs
                {
                    DogId = 49,
                    Breed = "Service dog",
                    Species = "Sheep dog",
                    FullName = "Croatian sheep dog"
                },
                new DisplayDogs
                {
                    DogId = 50,
                    Breed = "Service dog",
                    Species = "Sheep dog",
                    FullName = "Old english sheep dog"
                },
                new DisplayDogs
                {
                    DogId = 51,
                    Breed = "Service dog",
                    Species = "Sheep dog",
                    FullName = "Palestinian sheep dog"
                },
                new DisplayDogs
                {
                    DogId = 52,
                    Breed = "Service dog",
                    Species = "Sheep dog",
                    FullName = "Sheep dog from Beauce"
                },
                new DisplayDogs
                {
                    DogId = 53,
                    Breed = "Service dog",
                    Species = "Sheep dog",
                    FullName = "Picardy sheep dog"
                },
                new DisplayDogs
                {
                    DogId = 54,
                    Breed = "Service dog",
                    Species = "Sheep dog",
                    FullName = "Pyreneian sheep dog"
                },
                new DisplayDogs
                {
                    DogId = 55,
                    Breed = "Service dog",
                    Species = "Sheep dog",
                    FullName = "Pyreneian shorthair sheep dog"
                },
                new DisplayDogs
                {
                    DogId = 56,
                    Breed = "Service dog",
                    Species = "Sheep dog",
                    FullName = "Field lowland sheep dog"
                },
                new DisplayDogs
                {
                    DogId = 57,
                    Breed = "Service dog",
                    Species = "Sheep dog",
                    FullName = "Portuguese sheep dog"
                },
                new DisplayDogs
                {
                    DogId = 58,
                    Breed = "Service dog",
                    Species = "Sheep dog",
                    FullName = "Sharplaninac"
                },
                new DisplayDogs
                {
                    DogId = 59,
                    Breed = "Service dog",
                    Species = "Sheep dog",
                    FullName = "Shetland sheep dog"
                },
                new DisplayDogs
                {
                    DogId = 60,
                    Breed = "Service dog",
                    Species = "Sheep dog",
                    FullName = "Swedish short-legged sheep dog"
                },
                new DisplayDogs
                {
                    DogId = 61,
                    Breed = "Service dog",
                    Species = "Sheep dog",
                    FullName = "Welsh short-legged sheep dog"
                },
                new DisplayDogs
                {
                    DogId = 62,
                    Breed = "Service dog",
                    Species = "Shepherd dog",
                    FullName = "American shepherd dog"
                },
                new DisplayDogs
                {
                    DogId = 63,
                    Breed = "Service dog",
                    Species = "Shepherd dog",
                    FullName = "Anatolian shepherd dog"
                },
                new DisplayDogs
                {
                    DogId = 64,
                    Breed = "Service dog",
                    Species = "Shepherd dog",
                    FullName = "Lappish shepherd dog"
                },
                new DisplayDogs
                {
                    DogId = 65,
                    Breed = "Service dog",
                    Species = "Shepherd dog",
                    FullName = "Hungarian shepherd dog"
                },
                new DisplayDogs
                {
                    DogId = 66,
                    Breed = "Service dog",
                    Species = "Shepherd dog",
                    FullName = "Hungarian shepherd dog Kuvas"
                },
                new DisplayDogs
                {
                    DogId = 67,
                    Breed = "Service dog",
                    Species = "Shepherd dog",
                    FullName = "Mareman abruzzi shepherd dog"
                },
                new DisplayDogs
                {
                    DogId = 68,
                    Breed = "Service dog",
                    Species = "Shepherd dog",
                    FullName = "Moroccan shepherd dog"
                },
                new DisplayDogs
                {
                    DogId = 69,
                    Breed = "Service dog",
                    Species = "Shepherd dog",
                    FullName = "Podhalan shepherd dog"
                },
                new DisplayDogs
                {
                    DogId = 70,
                    Breed = "Service dog",
                    Species = "Shepherd dog",
                    FullName = "Portuguese estrelian shepherd dog"
                },
                new DisplayDogs
                {
                    DogId = 71,
                    Breed = "Service dog",
                    Species = "Shepherd dog",
                    FullName = "Portuguese shepherd dog"
                },
                new DisplayDogs
                {
                    DogId = 72,
                    Breed = "Service dog",
                    Species = "Shepherd dog",
                    FullName = "Slovakian shepherd dog"
                },
                new DisplayDogs
                {
                    DogId = 73,
                    Breed = "Service dog",
                    Species = "Pinch",
                    FullName = "Austrian shorthair pinch"
                },
                new DisplayDogs
                {
                    DogId = 74,
                    Breed = "Service dog",
                    Species = "Pinch",
                    FullName = "Doberman pinch"
                },
                new DisplayDogs
                {
                    DogId = 75,
                    Breed = "Service dog",
                    Species = "Mountain dog",
                    FullName = "Appenzell mountain dog"
                },
                new DisplayDogs
                {
                    DogId = 76,
                    Breed = "Service dog",
                    Species = "Mountain dog",
                    FullName = "Bernese mountain dog"
                },
                new DisplayDogs
                {
                    DogId = 77,
                    Breed = "Service dog",
                    Species = "Mountain dog",
                    FullName = "Entlebush mountain dog"
                },
                new DisplayDogs
                {
                    DogId = 78,
                    Breed = "Service dog",
                    Species = "Mountain dog",
                    FullName = "Pyreneian mountain dog"
                },
                new DisplayDogs
                {
                    DogId = 79,
                    Breed = "Service dog",
                    Species = "Mountain dog",
                    FullName = "Mountain dog from village Laboreiro"
                },
                new DisplayDogs
                {
                    DogId = 80,
                    Breed = "Service dog",
                    Species = "Mountain dog",
                    FullName = "Big swiss mountain dog"
                },
                new DisplayDogs
                {
                    DogId = 81,
                    Breed = "Service dog",
                    Species = "Polar dog",
                    FullName = "Alaskan polar dog"
                },
                new DisplayDogs
                {
                    DogId = 82,
                    Breed = "Service dog",
                    Species = "Polar dog",
                    FullName = "Greenland polar dog"
                },
                new DisplayDogs
                {
                    DogId = 83,
                    Breed = "Service dog",
                    Species = "Polar dog",
                    FullName = "Nenets polar dog"
                },
                new DisplayDogs
                {
                    DogId = 84,
                    Breed = "Service dog",
                    Species = "Siberian husky",
                    FullName = "Siberian husky"
                },
                new DisplayDogs
                {
                    DogId = 85,
                    Breed = "Service dog",
                    Species = "Rottweiler",
                    FullName = "Rottweiler"
                },
                new DisplayDogs
                {
                    DogId = 86,
                    Breed = "Service dog",
                    Species = "Spitz",
                    FullName = "Laponian swedish spitz"
                },
                new DisplayDogs
                {
                    DogId = 87,
                    Breed = "Service dog",
                    Species = "Spitz",
                    FullName = "Iceland spitz"
                },
                new DisplayDogs
                {
                    DogId = 88,
                    Breed = "Service dog",
                    Species = "Spitz",
                    FullName = "Dutch spitz"
                },
                new DisplayDogs
                {
                    DogId = 89,
                    Breed = "Service dog",
                    Species = "Spitz",
                    FullName = "Norwegian sheep dog spitz"
                },
                new DisplayDogs
                {
                    DogId = 90,
                    Breed = "Service dog",
                    Species = "Spitz",
                    FullName = "North swedish spitz"
                },
                new DisplayDogs
                {
                    DogId = 91,
                    Breed = "Service dog",
                    Species = "Spitz",
                    FullName = "Middle japanese spitz Sashu"
                },
                new DisplayDogs
                {
                    DogId = 92,
                    Breed = "Service dog",
                    Species = "Spitz",
                    FullName = "Big japanese spitz"
                },
                new DisplayDogs
                {
                    DogId = 93,
                    Breed = "Service dog",
                    Species = "Water dog",
                    FullName = "Portuguese water dog"
                }
            };

            if (answer == 0 || answer > 93)
            {
                ServiceDogsListOutput(ServiceDogs, answer);
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("     ID             Breed                       Species                        Fullname");
                Console.WriteLine("    ----------------------------------------------------------------------------------------------------------");

                ServiceDogsListOutput(ServiceDogs, answer);
            }
        }

        public static void ServiceDogsListOutput(List<DisplayDogs> ServiceDogs, int answer)
        {

            int NumberOfItems = ServiceDogs.Count();
            if (answer > NumberOfItems)
            {
                Console.WriteLine("Next time please input any number between 1 and including 93, number that you've inputted is too high!");
            }
            else if (answer == 0)
            {
                Console.WriteLine("Next time please input valid number!");
            }
            else
            {
                for (var counter = 0; counter < answer; counter++)
                {
                    if (ServiceDogs[counter].DogId >= 1 && ServiceDogs[counter].DogId < 10)
                    {
                        switch (ServiceDogs[counter].Species)
                        {
                            case "Australian herd guard":
                                Console.WriteLine(String.Format("      {0}          {1}                   {2}           {3}", ServiceDogs[counter].DogId, ServiceDogs[counter].Breed, ServiceDogs[counter].Species, ServiceDogs[counter].FullName));
                                break;

                            case "Bernardine":
                                Console.WriteLine(String.Format("      {0}          {1}                   {2}                      {3}", ServiceDogs[counter].DogId, ServiceDogs[counter].Breed, ServiceDogs[counter].Species, ServiceDogs[counter].FullName));
                                break;

                            case "Boxer":
                                Console.WriteLine(String.Format("      {0}          {1}                   {2}                           {3}", ServiceDogs[counter].DogId, ServiceDogs[counter].Breed, ServiceDogs[counter].Species, ServiceDogs[counter].FullName));
                                break;

                            case "Bearded koli":
                                Console.WriteLine(String.Format("      {0}          {1}                   {2}                    {3}", ServiceDogs[counter].DogId, ServiceDogs[counter].Breed, ServiceDogs[counter].Species, ServiceDogs[counter].FullName));
                                break;

                            case "Doga":
                                Console.WriteLine(String.Format("      {0}          {1}                   {2}                            {3}", ServiceDogs[counter].DogId, ServiceDogs[counter].Breed, ServiceDogs[counter].Species, ServiceDogs[counter].FullName));
                                break;

                            case "Husky":
                                Console.WriteLine(String.Format("      {0}            {1}                   {2}                           {3}", ServiceDogs[counter].DogId, ServiceDogs[counter].Breed, ServiceDogs[counter].Species, ServiceDogs[counter].FullName));
                                break;

                            case "Hound":
                                Console.WriteLine(String.Format("      {0}            {1}                   {2}                {3}", ServiceDogs[counter].DogId, ServiceDogs[counter].Breed, ServiceDogs[counter].Species, ServiceDogs[counter].FullName));
                                break;

                            case "Cattle dog":
                                Console.WriteLine(String.Format("      {0}            {1}                   {2}                {3}", ServiceDogs[counter].DogId, ServiceDogs[counter].Breed, ServiceDogs[counter].Species, ServiceDogs[counter].FullName));
                                break;

                            case "Loser dog":
                                Console.WriteLine(String.Format("      {0}            {1}                    {2}            {3}", ServiceDogs[counter].DogId, ServiceDogs[counter].Breed, ServiceDogs[counter].Species, ServiceDogs[counter].FullName));
                                break;

                            case "Japanese dog":
                                Console.WriteLine(String.Format("      {0}            {1}                    {2}                {3}", ServiceDogs[counter].DogId, ServiceDogs[counter].Breed, ServiceDogs[counter].Species, ServiceDogs[counter].FullName));
                                break;

                            case "Lendsir":
                                Console.WriteLine(String.Format("      {0}            {1}                    {2}                {3}", ServiceDogs[counter].DogId, ServiceDogs[counter].Breed, ServiceDogs[counter].Species, ServiceDogs[counter].FullName));
                                break;

                            case "Leonberg dog":
                                Console.WriteLine(String.Format("      {0}            {1}                    {2}                {3}", ServiceDogs[counter].DogId, ServiceDogs[counter].Breed, ServiceDogs[counter].Species, ServiceDogs[counter].FullName));
                                break;

                            case "Mastiff":
                                Console.WriteLine(String.Format("      {0}            {1}                    {2}                {3}", ServiceDogs[counter].DogId, ServiceDogs[counter].Breed, ServiceDogs[counter].Species, ServiceDogs[counter].FullName));
                                break;

                            case "Newfoundlander":
                                Console.WriteLine(String.Format("      {0}            {1}                    {2}                {3}", ServiceDogs[counter].DogId, ServiceDogs[counter].Breed, ServiceDogs[counter].Species, ServiceDogs[counter].FullName));
                                break;

                            case "Sheep dog":
                                Console.WriteLine(String.Format("      {0}            {1}                    {2}                {3}", ServiceDogs[counter].DogId, ServiceDogs[counter].Breed, ServiceDogs[counter].Species, ServiceDogs[counter].FullName));
                                break;

                            case "Shepherd dog":
                                Console.WriteLine(String.Format("      {0}            {1}                    {2}                {3}", ServiceDogs[counter].DogId, ServiceDogs[counter].Breed, ServiceDogs[counter].Species, ServiceDogs[counter].FullName));
                                break;

                            case "Pinch":
                                Console.WriteLine(String.Format("      {0}            {1}                    {2}                {3}", ServiceDogs[counter].DogId, ServiceDogs[counter].Breed, ServiceDogs[counter].Species, ServiceDogs[counter].FullName));
                                break;

                            case "Mountain dog":
                                Console.WriteLine(String.Format("      {0}            {1}                    {2}                {3}", ServiceDogs[counter].DogId, ServiceDogs[counter].Breed, ServiceDogs[counter].Species, ServiceDogs[counter].FullName));
                                break;

                            case "Polar dog":
                                Console.WriteLine(String.Format("      {0}            {1}                    {2}                {3}", ServiceDogs[counter].DogId, ServiceDogs[counter].Breed, ServiceDogs[counter].Species, ServiceDogs[counter].FullName));
                                break;

                            case "Siberian husky":
                                Console.WriteLine(String.Format("      {0}            {1}                    {2}                {3}", ServiceDogs[counter].DogId, ServiceDogs[counter].Breed, ServiceDogs[counter].Species, ServiceDogs[counter].FullName));
                                break;

                            case "Spitz":
                                Console.WriteLine(String.Format("      {0}            {1}                    {2}                {3}", ServiceDogs[counter].DogId, ServiceDogs[counter].Breed, ServiceDogs[counter].Species, ServiceDogs[counter].FullName));
                                break;

                            case "Rottweiler":
                                Console.WriteLine(String.Format("      {0}            {1}                    {2}                {3}", ServiceDogs[counter].DogId, ServiceDogs[counter].Breed, ServiceDogs[counter].Species, ServiceDogs[counter].FullName));
                                break;

                            case "Water dog":
                                Console.WriteLine(String.Format("      {0}            {1}                    {2}                {3}", ServiceDogs[counter].DogId, ServiceDogs[counter].Breed, ServiceDogs[counter].Species, ServiceDogs[counter].FullName));
                                break;
                        }
                    }
                    else
                    {
                        switch (ServiceDogs[counter].Species)
                        {
                            case "Australian herd guard":
                                Console.WriteLine(String.Format("      {0}          {1}                   {2}                    {3}", ServiceDogs[counter].DogId, ServiceDogs[counter].Breed, ServiceDogs[counter].Species, ServiceDogs[counter].FullName));
                                break;

                            case "Bernardine":
                                Console.WriteLine(String.Format("      {0}          {1}                   {2}                   {3}", ServiceDogs[counter].DogId, ServiceDogs[counter].Breed, ServiceDogs[counter].Species, ServiceDogs[counter].FullName));
                                break;

                            case "Boxer":
                                Console.WriteLine(String.Format("      {0}          {1}                   {2}                      {3}", ServiceDogs[counter].DogId, ServiceDogs[counter].Breed, ServiceDogs[counter].Species, ServiceDogs[counter].FullName));
                                break;

                            case "Bearded koli":
                                Console.WriteLine(String.Format("      {0}          {1}                   {2}                     {3}", ServiceDogs[counter].DogId, ServiceDogs[counter].Breed, ServiceDogs[counter].Species, ServiceDogs[counter].FullName));
                                break;

                            case "Doga":
                                Console.WriteLine(String.Format("      {0}         {1}                   {2}                            {3}", ServiceDogs[counter].DogId, ServiceDogs[counter].Breed, ServiceDogs[counter].Species, ServiceDogs[counter].FullName));
                                break;

                            case "Husky":
                                Console.WriteLine(String.Format("      {0}         {1}                   {2}                           {3}", ServiceDogs[counter].DogId, ServiceDogs[counter].Breed, ServiceDogs[counter].Species, ServiceDogs[counter].FullName));
                                break;

                            case "Hound":
                                Console.WriteLine(String.Format("      {0}         {1}                   {2}                           {3}", ServiceDogs[counter].DogId, ServiceDogs[counter].Breed, ServiceDogs[counter].Species, ServiceDogs[counter].FullName));
                                break;

                            case "Cattle dog":
                                Console.WriteLine(String.Format("      {0}         {1}                   {2}                      {3}", ServiceDogs[counter].DogId, ServiceDogs[counter].Breed, ServiceDogs[counter].Species, ServiceDogs[counter].FullName));
                                break;

                            case "Loser dog":
                                Console.WriteLine(String.Format("      {0}         {1}                   {2}                       {3}", ServiceDogs[counter].DogId, ServiceDogs[counter].Breed, ServiceDogs[counter].Species, ServiceDogs[counter].FullName));
                                break;

                            case "Japanese dog":
                                Console.WriteLine(String.Format("      {0}         {1}                   {2}                    {3}", ServiceDogs[counter].DogId, ServiceDogs[counter].Breed, ServiceDogs[counter].Species, ServiceDogs[counter].FullName));
                                break;

                            case "Lendsir":
                                Console.WriteLine(String.Format("      {0}         {1}                   {2}                         {3}", ServiceDogs[counter].DogId, ServiceDogs[counter].Breed, ServiceDogs[counter].Species, ServiceDogs[counter].FullName));
                                break;

                            case "Leonberg dog":
                                Console.WriteLine(String.Format("      {0}         {1}                   {2}                    {3}", ServiceDogs[counter].DogId, ServiceDogs[counter].Breed, ServiceDogs[counter].Species, ServiceDogs[counter].FullName));
                                break;

                            case "Mastiff":
                                Console.WriteLine(String.Format("      {0}         {1}                   {2}                         {3}", ServiceDogs[counter].DogId, ServiceDogs[counter].Breed, ServiceDogs[counter].Species, ServiceDogs[counter].FullName));
                                break;

                            case "Newfoundlander":
                                Console.WriteLine(String.Format("      {0}         {1}                   {2}                  {3}", ServiceDogs[counter].DogId, ServiceDogs[counter].Breed, ServiceDogs[counter].Species, ServiceDogs[counter].FullName));
                                break;

                            case "Sheep dog":
                                Console.WriteLine(String.Format("      {0}         {1}                   {2}                       {3}", ServiceDogs[counter].DogId, ServiceDogs[counter].Breed, ServiceDogs[counter].Species, ServiceDogs[counter].FullName));
                                break;

                            case "Shepherd dog":
                                Console.WriteLine(String.Format("      {0}         {1}                   {2}                    {3}", ServiceDogs[counter].DogId, ServiceDogs[counter].Breed, ServiceDogs[counter].Species, ServiceDogs[counter].FullName));
                                break;

                            case "Pinch":
                                Console.WriteLine(String.Format("      {0}         {1}                   {2}                           {3}", ServiceDogs[counter].DogId, ServiceDogs[counter].Breed, ServiceDogs[counter].Species, ServiceDogs[counter].FullName));
                                break;

                            case "Mountain dog":
                                Console.WriteLine(String.Format("      {0}         {1}                   {2}                    {3}", ServiceDogs[counter].DogId, ServiceDogs[counter].Breed, ServiceDogs[counter].Species, ServiceDogs[counter].FullName));
                                break;

                            case "Polar dog":
                                Console.WriteLine(String.Format("      {0}         {1}                   {2}                       {3}", ServiceDogs[counter].DogId, ServiceDogs[counter].Breed, ServiceDogs[counter].Species, ServiceDogs[counter].FullName));
                                break;

                            case "Siberian husky":
                                Console.WriteLine(String.Format("      {0}         {1}                   {2}                  {3}", ServiceDogs[counter].DogId, ServiceDogs[counter].Breed, ServiceDogs[counter].Species, ServiceDogs[counter].FullName));
                                break;

                            case "Spitz":
                                Console.WriteLine(String.Format("      {0}         {1}                   {2}                           {3}", ServiceDogs[counter].DogId, ServiceDogs[counter].Breed, ServiceDogs[counter].Species, ServiceDogs[counter].FullName));
                                break;

                            case "Rottweiler":
                                Console.WriteLine(String.Format("      {0}         {1}                   {2}                      {3}", ServiceDogs[counter].DogId, ServiceDogs[counter].Breed, ServiceDogs[counter].Species, ServiceDogs[counter].FullName));
                                break;

                            case "Water dog":
                                Console.WriteLine(String.Format("      {0}         {1}                   {2}                       {3}", ServiceDogs[counter].DogId, ServiceDogs[counter].Breed, ServiceDogs[counter].Species, ServiceDogs[counter].FullName));
                                break;
                        }
                    }
                    Console.WriteLine();
                }
            }
        }
    }

    public class DisplayDogs
    {
        public int DogId { get; set; }
        public string Breed { get; set; }
        public string Species { get; set; }
        public string FullName { get; set; }
    }
}
