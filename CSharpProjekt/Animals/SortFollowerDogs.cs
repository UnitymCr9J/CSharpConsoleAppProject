using CSharpProjekt.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpProjekt.Animals
{
    public class SortFollowerDogs : IFollowerDog
    {
        internal void FollowerDogsListSort(string answer)
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


            switch (answer)
            {
                case "1":
                    Console.WriteLine("         Breed                       Species                        Fullname");
                    Console.WriteLine("    ----------------------------------------------------------------------------------------------");
                    SortingFollowerDogsBySpecies(FollowerDogs);
                    break;

                case "2":
                    Console.WriteLine("         Breed                       Species                        Fullname");
                    Console.WriteLine("    ----------------------------------------------------------------------------------------------");
                    SortingFollowerDogsBySpeciesReverse(FollowerDogs);
                    break;

                case "3":
                    Console.WriteLine("         Breed                       Species                        Fullname");
                    Console.WriteLine("    ----------------------------------------------------------------------------------------------");
                    SortingFollowerDogsByName(FollowerDogs);
                    break;

                case "4":
                    Console.WriteLine("         Breed                       Species                        Fullname");
                    Console.WriteLine("    ----------------------------------------------------------------------------------------------");
                    SortingFollowerDogsByNameReverse(FollowerDogs);
                    break;

                case "5":
                    Console.WriteLine("         Breed                       Species                        Fullname");
                    Console.WriteLine("    ----------------------------------------------------------------------------------------------");
                    SortingFollowerDogsBySpeciesName(FollowerDogs);
                    break;

                case "6":
                    Console.WriteLine("         Breed                       Species                        Fullname");
                    Console.WriteLine("    ----------------------------------------------------------------------------------------------");
                    SortingFollowerDogsByReverseSpeciesName(FollowerDogs);
                    break;

                case "7":
                    Console.WriteLine("         Breed                       Species                        Fullname");
                    Console.WriteLine("    ----------------------------------------------------------------------------------------------");
                    SortingFollowerDogsBySpeciesReverseName(FollowerDogs);
                    break;

                case "8":
                    Console.WriteLine("         Breed                       Species                        Fullname");
                    Console.WriteLine("    ----------------------------------------------------------------------------------------------");
                    SortingFollowerDogsBySpeciesNameReverse(FollowerDogs);
                    break;

                default:
                    Console.WriteLine("Next time please input one of displayed numbers!");
                    break;

            }
        }

        public void SortingFollowerDogsBySpecies(List<DisplayDogs> FollowerDogs)
        {

            var followerdogslist = FollowerDogs.OrderBy(followersort => followersort.Species).ToList();

            foreach (var follower in FollowerDogs)
            {
                if (follower.DogId >= 1 && follower.DogId < 10)
                {
                    switch (follower.Species)
                    {
                        case "Bulldog":
                            Console.WriteLine(String.Format("      {0}                  {1}                         {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Chow Chow":
                            Console.WriteLine(String.Format("      {0}                  {1}                       {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Fox terrier":
                            Console.WriteLine(String.Format("      {0}                  {1}                     {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Hound":
                            Console.WriteLine(String.Format("      {0}                  {1}                           {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Griffon":
                            Console.WriteLine(String.Format("      {0}                  {1}                         {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Loser dog":
                            Console.WriteLine(String.Format("      {0}                  {1}                       {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Mops":
                            Console.WriteLine(String.Format("      {0}                  {1}                         {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Pinch":
                            Console.WriteLine(String.Format("      {0}                  {1}                         {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Pudl":
                            Console.WriteLine(String.Format("      {0}                  {1}                         {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Spaniel":
                            Console.WriteLine(String.Format("      {0}                  {1}                         {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Char Pei":
                            Console.WriteLine(String.Format("      {0}                  {1}                         {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Maltese":
                            Console.WriteLine(String.Format("      {0}                  {1}                         {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Shiba Inu":
                            Console.WriteLine(String.Format("      {0}                  {1}                         {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Spitz":
                            Console.WriteLine(String.Format("      {0}                  {1}                         {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        default:
                            Console.WriteLine(String.Format("      {0}                  {1}                         {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                    }
                }
                else
                {
                    switch (follower.Species)
                    {
                        case "Bulldog":
                            Console.WriteLine(String.Format("      {0}                  {1}                         {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Chow Chow":
                            Console.WriteLine(String.Format("      {0}                  {1}                         {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Fox terrier":
                            Console.WriteLine(String.Format("      {0}                  {1}                         {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Hound":
                            Console.WriteLine(String.Format("      {0}                  {1}                         {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Griffon":
                            Console.WriteLine(String.Format("      {0}                  {1}                         {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Loser dog":
                            Console.WriteLine(String.Format("      {0}                  {1}                       {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Mops":
                            Console.WriteLine(String.Format("      {0}                  {1}                            {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Pinch":
                            Console.WriteLine(String.Format("      {0}                  {1}                           {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Pudl":
                            Console.WriteLine(String.Format("      {0}                  {1}                            {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Spaniel":
                            Console.WriteLine(String.Format("      {0}                  {1}                         {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Char Pei":
                            Console.WriteLine(String.Format("      {0}                  {1}                        {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Maltese":
                            Console.WriteLine(String.Format("      {0}                  {1}                         {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Shiba Inu":
                            Console.WriteLine(String.Format("      {0}                  {1}                       {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Spitz":
                            Console.WriteLine(String.Format("      {0}                  {1}                           {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        default:
                            Console.WriteLine(String.Format("      {0}                  {1}                        {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                    }
                }
                Console.WriteLine();
            }
        }

        public void SortingFollowerDogsBySpeciesReverse(List<DisplayDogs> FollowerDogs)
        {

            var followerdogslist = FollowerDogs.OrderByDescending(followersort => followersort.Species).ToList();

            foreach (var follower in FollowerDogs)
            {
                if (follower.DogId >= 1 && follower.DogId < 10)
                {
                    switch (follower.Species)
                    {
                        case "Bulldog":
                            Console.WriteLine(String.Format("      {0}                  {1}                         {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Chow Chow":
                            Console.WriteLine(String.Format("      {0}                  {1}                       {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Fox terrier":
                            Console.WriteLine(String.Format("      {0}                  {1}                     {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Hound":
                            Console.WriteLine(String.Format("      {0}                  {1}                           {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Griffon":
                            Console.WriteLine(String.Format("      {0}                  {1}                         {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Loser dog":
                            Console.WriteLine(String.Format("      {0}                  {1}                       {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Mops":
                            Console.WriteLine(String.Format("      {0}                  {1}                         {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Pinch":
                            Console.WriteLine(String.Format("      {0}                  {1}                         {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Pudl":
                            Console.WriteLine(String.Format("      {0}                  {1}                         {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Spaniel":
                            Console.WriteLine(String.Format("      {0}                  {1}                         {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Char Pei":
                            Console.WriteLine(String.Format("      {0}                  {1}                         {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Maltese":
                            Console.WriteLine(String.Format("      {0}                  {1}                         {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Shiba Inu":
                            Console.WriteLine(String.Format("      {0}                  {1}                         {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Spitz":
                            Console.WriteLine(String.Format("      {0}                  {1}                         {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        default:
                            Console.WriteLine(String.Format("      {0}                  {1}                         {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                    }
                }
                else
                {
                    switch (follower.Species)
                    {
                        case "Bulldog":
                            Console.WriteLine(String.Format("      {0}                  {1}                         {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Chow Chow":
                            Console.WriteLine(String.Format("      {0}                  {1}                         {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Fox terrier":
                            Console.WriteLine(String.Format("      {0}                  {1}                         {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Hound":
                            Console.WriteLine(String.Format("      {0}                  {1}                         {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Griffon":
                            Console.WriteLine(String.Format("      {0}                  {1}                         {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Loser dog":
                            Console.WriteLine(String.Format("      {0}                  {1}                       {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Mops":
                            Console.WriteLine(String.Format("      {0}                  {1}                            {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Pinch":
                            Console.WriteLine(String.Format("      {0}                  {1}                           {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Pudl":
                            Console.WriteLine(String.Format("      {0}                  {1}                            {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Spaniel":
                            Console.WriteLine(String.Format("      {0}                  {1}                         {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Char Pei":
                            Console.WriteLine(String.Format("      {0}                  {1}                        {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Maltese":
                            Console.WriteLine(String.Format("      {0}                  {1}                         {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Shiba Inu":
                            Console.WriteLine(String.Format("      {0}                  {1}                       {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Spitz":
                            Console.WriteLine(String.Format("      {0}                  {1}                           {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        default:
                            Console.WriteLine(String.Format("      {0}                  {1}                        {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                    }
                }
                Console.WriteLine();
            }
        }

        public void SortingFollowerDogsByName(List<DisplayDogs> FollowerDogs)
        {

            var followerdogslist = FollowerDogs.OrderBy(followersort => followersort.FullName).ToList();

            foreach (var follower in FollowerDogs)
            {
                if (follower.DogId >= 1 && follower.DogId < 10)
                {
                    switch (follower.Species)
                    {
                        case "Bulldog":
                            Console.WriteLine(String.Format("      {0}                  {1}                         {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Chow Chow":
                            Console.WriteLine(String.Format("      {0}                  {1}                       {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Fox terrier":
                            Console.WriteLine(String.Format("      {0}                  {1}                     {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Hound":
                            Console.WriteLine(String.Format("      {0}                  {1}                           {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Griffon":
                            Console.WriteLine(String.Format("      {0}                  {1}                         {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Loser dog":
                            Console.WriteLine(String.Format("      {0}                  {1}                       {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Mops":
                            Console.WriteLine(String.Format("      {0}                  {1}                         {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Pinch":
                            Console.WriteLine(String.Format("      {0}                  {1}                         {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Pudl":
                            Console.WriteLine(String.Format("      {0}                  {1}                         {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Spaniel":
                            Console.WriteLine(String.Format("      {0}                  {1}                         {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Char Pei":
                            Console.WriteLine(String.Format("      {0}                  {1}                         {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Maltese":
                            Console.WriteLine(String.Format("      {0}                  {1}                         {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Shiba Inu":
                            Console.WriteLine(String.Format("      {0}                  {1}                         {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Spitz":
                            Console.WriteLine(String.Format("      {0}                  {1}                         {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        default:
                            Console.WriteLine(String.Format("      {0}                  {1}                         {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                    }
                }
                else
                {
                    switch (follower.Species)
                    {
                        case "Bulldog":
                            Console.WriteLine(String.Format("      {0}                  {1}                         {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Chow Chow":
                            Console.WriteLine(String.Format("      {0}                  {1}                         {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Fox terrier":
                            Console.WriteLine(String.Format("      {0}                  {1}                         {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Hound":
                            Console.WriteLine(String.Format("      {0}                  {1}                         {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Griffon":
                            Console.WriteLine(String.Format("      {0}                  {1}                         {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Loser dog":
                            Console.WriteLine(String.Format("      {0}                  {1}                       {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Mops":
                            Console.WriteLine(String.Format("      {0}                  {1}                            {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Pinch":
                            Console.WriteLine(String.Format("      {0}                  {1}                           {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Pudl":
                            Console.WriteLine(String.Format("      {0}                  {1}                            {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Spaniel":
                            Console.WriteLine(String.Format("      {0}                  {1}                         {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Char Pei":
                            Console.WriteLine(String.Format("      {0}                  {1}                        {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Maltese":
                            Console.WriteLine(String.Format("      {0}                  {1}                         {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Shiba Inu":
                            Console.WriteLine(String.Format("      {0}                  {1}                       {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Spitz":
                            Console.WriteLine(String.Format("      {0}                  {1}                           {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        default:
                            Console.WriteLine(String.Format("      {0}                  {1}                        {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                    }
                }
                Console.WriteLine();
            }
        }

        public void SortingFollowerDogsByNameReverse(List<DisplayDogs> FollowerDogs)
        {

            var followerdogslist = FollowerDogs.OrderByDescending(followersort => followersort.FullName).ToList();

            foreach (var follower in FollowerDogs)
            {
                if (follower.DogId >= 1 && follower.DogId < 10)
                {
                    switch (follower.Species)
                    {
                        case "Bulldog":
                            Console.WriteLine(String.Format("      {0}                  {1}                         {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Chow Chow":
                            Console.WriteLine(String.Format("      {0}                  {1}                       {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Fox terrier":
                            Console.WriteLine(String.Format("      {0}                  {1}                     {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Hound":
                            Console.WriteLine(String.Format("      {0}                  {1}                           {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Griffon":
                            Console.WriteLine(String.Format("      {0}                  {1}                         {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Loser dog":
                            Console.WriteLine(String.Format("      {0}                  {1}                       {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Mops":
                            Console.WriteLine(String.Format("      {0}                  {1}                         {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Pinch":
                            Console.WriteLine(String.Format("      {0}                  {1}                         {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Pudl":
                            Console.WriteLine(String.Format("      {0}                  {1}                         {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Spaniel":
                            Console.WriteLine(String.Format("      {0}                  {1}                         {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Char Pei":
                            Console.WriteLine(String.Format("      {0}                  {1}                         {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Maltese":
                            Console.WriteLine(String.Format("      {0}                  {1}                         {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Shiba Inu":
                            Console.WriteLine(String.Format("      {0}                  {1}                         {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Spitz":
                            Console.WriteLine(String.Format("      {0}                  {1}                         {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        default:
                            Console.WriteLine(String.Format("      {0}                  {1}                         {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                    }
                }
                else
                {
                    switch (follower.Species)
                    {
                        case "Bulldog":
                            Console.WriteLine(String.Format("      {0}                  {1}                         {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Chow Chow":
                            Console.WriteLine(String.Format("      {0}                  {1}                         {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Fox terrier":
                            Console.WriteLine(String.Format("      {0}                  {1}                         {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Hound":
                            Console.WriteLine(String.Format("      {0}                  {1}                         {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Griffon":
                            Console.WriteLine(String.Format("      {0}                  {1}                         {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Loser dog":
                            Console.WriteLine(String.Format("      {0}                  {1}                       {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Mops":
                            Console.WriteLine(String.Format("      {0}                  {1}                            {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Pinch":
                            Console.WriteLine(String.Format("      {0}                  {1}                           {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Pudl":
                            Console.WriteLine(String.Format("      {0}                  {1}                            {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Spaniel":
                            Console.WriteLine(String.Format("      {0}                  {1}                         {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Char Pei":
                            Console.WriteLine(String.Format("      {0}                  {1}                        {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Maltese":
                            Console.WriteLine(String.Format("      {0}                  {1}                         {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Shiba Inu":
                            Console.WriteLine(String.Format("      {0}                  {1}                       {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Spitz":
                            Console.WriteLine(String.Format("      {0}                  {1}                           {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        default:
                            Console.WriteLine(String.Format("      {0}                  {1}                        {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                    }
                }
                Console.WriteLine();
            }
        }

        public void SortingFollowerDogsBySpeciesName(List<DisplayDogs> FollowerDogs)
        {

            var followerdogslist = FollowerDogs.OrderBy(followersort => followersort.Species).OrderBy(followersort => followersort.FullName).ToList();

            foreach (var follower in FollowerDogs)
            {
                if (follower.DogId >= 1 && follower.DogId < 10)
                {
                    switch (follower.Species)
                    {
                        case "Bulldog":
                            Console.WriteLine(String.Format("      {0}                  {1}                         {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Chow Chow":
                            Console.WriteLine(String.Format("      {0}                  {1}                       {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Fox terrier":
                            Console.WriteLine(String.Format("      {0}                  {1}                     {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Hound":
                            Console.WriteLine(String.Format("      {0}                  {1}                           {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Griffon":
                            Console.WriteLine(String.Format("      {0}                  {1}                         {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Loser dog":
                            Console.WriteLine(String.Format("      {0}                  {1}                       {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Mops":
                            Console.WriteLine(String.Format("      {0}                  {1}                         {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Pinch":
                            Console.WriteLine(String.Format("      {0}                  {1}                         {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Pudl":
                            Console.WriteLine(String.Format("      {0}                  {1}                         {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Spaniel":
                            Console.WriteLine(String.Format("      {0}                  {1}                         {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Char Pei":
                            Console.WriteLine(String.Format("      {0}                  {1}                         {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Maltese":
                            Console.WriteLine(String.Format("      {0}                  {1}                         {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Shiba Inu":
                            Console.WriteLine(String.Format("      {0}                  {1}                         {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Spitz":
                            Console.WriteLine(String.Format("      {0}                  {1}                         {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        default:
                            Console.WriteLine(String.Format("      {0}                  {1}                         {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                    }
                }
                else
                {
                    switch (follower.Species)
                    {
                        case "Bulldog":
                            Console.WriteLine(String.Format("      {0}                  {1}                         {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Chow Chow":
                            Console.WriteLine(String.Format("      {0}                  {1}                         {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Fox terrier":
                            Console.WriteLine(String.Format("      {0}                  {1}                         {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Hound":
                            Console.WriteLine(String.Format("      {0}                  {1}                         {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Griffon":
                            Console.WriteLine(String.Format("      {0}                  {1}                         {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Loser dog":
                            Console.WriteLine(String.Format("      {0}                  {1}                       {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Mops":
                            Console.WriteLine(String.Format("      {0}                  {1}                            {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Pinch":
                            Console.WriteLine(String.Format("      {0}                  {1}                           {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Pudl":
                            Console.WriteLine(String.Format("      {0}                  {1}                            {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Spaniel":
                            Console.WriteLine(String.Format("      {0}                  {1}                         {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Char Pei":
                            Console.WriteLine(String.Format("      {0}                  {1}                        {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Maltese":
                            Console.WriteLine(String.Format("      {0}                  {1}                         {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Shiba Inu":
                            Console.WriteLine(String.Format("      {0}                  {1}                       {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Spitz":
                            Console.WriteLine(String.Format("      {0}                  {1}                           {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        default:
                            Console.WriteLine(String.Format("      {0}                  {1}                        {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                    }
                }
                Console.WriteLine();
            }
        }

        public void SortingFollowerDogsByReverseSpeciesName(List<DisplayDogs> FollowerDogs)
        {

            var followerdogslist = FollowerDogs.OrderByDescending(followersort => followersort.Species).OrderByDescending(followersort => followersort.FullName).ToList();

            foreach (var follower in FollowerDogs)
            {
                if (follower.DogId >= 1 && follower.DogId < 10)
                {
                    switch (follower.Species)
                    {
                        case "Bulldog":
                            Console.WriteLine(String.Format("      {0}                  {1}                         {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Chow Chow":
                            Console.WriteLine(String.Format("      {0}                  {1}                       {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Fox terrier":
                            Console.WriteLine(String.Format("      {0}                  {1}                     {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Hound":
                            Console.WriteLine(String.Format("      {0}                  {1}                           {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Griffon":
                            Console.WriteLine(String.Format("      {0}                  {1}                         {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Loser dog":
                            Console.WriteLine(String.Format("      {0}                  {1}                       {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Mops":
                            Console.WriteLine(String.Format("      {0}                  {1}                         {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Pinch":
                            Console.WriteLine(String.Format("      {0}                  {1}                         {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Pudl":
                            Console.WriteLine(String.Format("      {0}                  {1}                         {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Spaniel":
                            Console.WriteLine(String.Format("      {0}                  {1}                         {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Char Pei":
                            Console.WriteLine(String.Format("      {0}                  {1}                         {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Maltese":
                            Console.WriteLine(String.Format("      {0}                  {1}                         {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Shiba Inu":
                            Console.WriteLine(String.Format("      {0}                  {1}                         {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Spitz":
                            Console.WriteLine(String.Format("      {0}                  {1}                         {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        default:
                            Console.WriteLine(String.Format("      {0}                  {1}                         {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                    }
                }
                else
                {
                    switch (follower.Species)
                    {
                        case "Bulldog":
                            Console.WriteLine(String.Format("      {0}                  {1}                         {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Chow Chow":
                            Console.WriteLine(String.Format("      {0}                  {1}                         {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Fox terrier":
                            Console.WriteLine(String.Format("      {0}                  {1}                         {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Hound":
                            Console.WriteLine(String.Format("      {0}                  {1}                         {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Griffon":
                            Console.WriteLine(String.Format("      {0}                  {1}                         {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Loser dog":
                            Console.WriteLine(String.Format("      {0}                  {1}                       {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Mops":
                            Console.WriteLine(String.Format("      {0}                  {1}                            {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Pinch":
                            Console.WriteLine(String.Format("      {0}                  {1}                           {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Pudl":
                            Console.WriteLine(String.Format("      {0}                  {1}                            {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Spaniel":
                            Console.WriteLine(String.Format("      {0}                  {1}                         {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Char Pei":
                            Console.WriteLine(String.Format("      {0}                  {1}                        {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Maltese":
                            Console.WriteLine(String.Format("      {0}                  {1}                         {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Shiba Inu":
                            Console.WriteLine(String.Format("      {0}                  {1}                       {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Spitz":
                            Console.WriteLine(String.Format("      {0}                  {1}                           {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        default:
                            Console.WriteLine(String.Format("      {0}                  {1}                        {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                    }
                }
                Console.WriteLine();
            }
        }

        public void SortingFollowerDogsBySpeciesReverseName(List<DisplayDogs> FollowerDogs)
        {

            var followerdogslist = FollowerDogs.OrderByDescending(followersort => followersort.Species).OrderBy(followersort => followersort.FullName).ToList();

            foreach (var follower in FollowerDogs)
            {
                if (follower.DogId >= 1 && follower.DogId < 10)
                {
                    switch (follower.Species)
                    {
                        case "Bulldog":
                            Console.WriteLine(String.Format("      {0}                  {1}                         {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Chow Chow":
                            Console.WriteLine(String.Format("      {0}                  {1}                       {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Fox terrier":
                            Console.WriteLine(String.Format("      {0}                  {1}                     {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Hound":
                            Console.WriteLine(String.Format("      {0}                  {1}                           {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Griffon":
                            Console.WriteLine(String.Format("      {0}                  {1}                         {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Loser dog":
                            Console.WriteLine(String.Format("      {0}                  {1}                       {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Mops":
                            Console.WriteLine(String.Format("      {0}                  {1}                         {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Pinch":
                            Console.WriteLine(String.Format("      {0}                  {1}                         {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Pudl":
                            Console.WriteLine(String.Format("      {0}                  {1}                         {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Spaniel":
                            Console.WriteLine(String.Format("      {0}                  {1}                         {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Char Pei":
                            Console.WriteLine(String.Format("      {0}                  {1}                         {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Maltese":
                            Console.WriteLine(String.Format("      {0}                  {1}                         {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Shiba Inu":
                            Console.WriteLine(String.Format("      {0}                  {1}                         {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Spitz":
                            Console.WriteLine(String.Format("      {0}                  {1}                         {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        default:
                            Console.WriteLine(String.Format("      {0}                  {1}                         {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                    }
                }
                else
                {
                    switch (follower.Species)
                    {
                        case "Bulldog":
                            Console.WriteLine(String.Format("      {0}                  {1}                         {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Chow Chow":
                            Console.WriteLine(String.Format("      {0}                  {1}                         {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Fox terrier":
                            Console.WriteLine(String.Format("      {0}                  {1}                         {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Hound":
                            Console.WriteLine(String.Format("      {0}                  {1}                         {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Griffon":
                            Console.WriteLine(String.Format("      {0}                  {1}                         {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Loser dog":
                            Console.WriteLine(String.Format("      {0}                  {1}                       {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Mops":
                            Console.WriteLine(String.Format("      {0}                  {1}                            {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Pinch":
                            Console.WriteLine(String.Format("      {0}                  {1}                           {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Pudl":
                            Console.WriteLine(String.Format("      {0}                  {1}                            {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Spaniel":
                            Console.WriteLine(String.Format("      {0}                  {1}                         {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Char Pei":
                            Console.WriteLine(String.Format("      {0}                  {1}                        {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Maltese":
                            Console.WriteLine(String.Format("      {0}                  {1}                         {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Shiba Inu":
                            Console.WriteLine(String.Format("      {0}                  {1}                       {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Spitz":
                            Console.WriteLine(String.Format("      {0}                  {1}                           {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        default:
                            Console.WriteLine(String.Format("      {0}                  {1}                        {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                    }
                }
                Console.WriteLine();
            }
        }

        public void SortingFollowerDogsBySpeciesNameReverse(List<DisplayDogs> FollowerDogs)
        {

            var followerdogslist = FollowerDogs.OrderBy(followersort => followersort.Species).OrderByDescending(followersort => followersort.FullName).ToList();

            foreach (var follower in FollowerDogs)
            {
                if (follower.DogId >= 1 && follower.DogId < 10)
                {
                    switch (follower.Species)
                    {
                        case "Bulldog":
                            Console.WriteLine(String.Format("      {0}                  {1}                         {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Chow Chow":
                            Console.WriteLine(String.Format("      {0}                  {1}                       {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Fox terrier":
                            Console.WriteLine(String.Format("      {0}                  {1}                     {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Hound":
                            Console.WriteLine(String.Format("      {0}                  {1}                           {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Griffon":
                            Console.WriteLine(String.Format("      {0}                  {1}                         {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Loser dog":
                            Console.WriteLine(String.Format("      {0}                  {1}                       {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Mops":
                            Console.WriteLine(String.Format("      {0}                  {1}                         {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Pinch":
                            Console.WriteLine(String.Format("      {0}                  {1}                         {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Pudl":
                            Console.WriteLine(String.Format("      {0}                  {1}                         {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Spaniel":
                            Console.WriteLine(String.Format("      {0}                  {1}                         {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Char Pei":
                            Console.WriteLine(String.Format("      {0}                  {1}                         {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Maltese":
                            Console.WriteLine(String.Format("      {0}                  {1}                         {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Shiba Inu":
                            Console.WriteLine(String.Format("      {0}                  {1}                         {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Spitz":
                            Console.WriteLine(String.Format("      {0}                  {1}                         {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        default:
                            Console.WriteLine(String.Format("      {0}                  {1}                         {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                    }
                }
                else
                {
                    switch (follower.Species)
                    {
                        case "Bulldog":
                            Console.WriteLine(String.Format("      {0}                  {1}                         {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Chow Chow":
                            Console.WriteLine(String.Format("      {0}                  {1}                         {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Fox terrier":
                            Console.WriteLine(String.Format("      {0}                  {1}                         {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Hound":
                            Console.WriteLine(String.Format("      {0}                  {1}                         {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Griffon":
                            Console.WriteLine(String.Format("      {0}                  {1}                         {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Loser dog":
                            Console.WriteLine(String.Format("      {0}                  {1}                       {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Mops":
                            Console.WriteLine(String.Format("      {0}                  {1}                            {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Pinch":
                            Console.WriteLine(String.Format("      {0}                  {1}                           {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Pudl":
                            Console.WriteLine(String.Format("      {0}                  {1}                            {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Spaniel":
                            Console.WriteLine(String.Format("      {0}                  {1}                         {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Char Pei":
                            Console.WriteLine(String.Format("      {0}                  {1}                        {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Maltese":
                            Console.WriteLine(String.Format("      {0}                  {1}                         {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Shiba Inu":
                            Console.WriteLine(String.Format("      {0}                  {1}                       {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        case "Spitz":
                            Console.WriteLine(String.Format("      {0}                  {1}                           {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                        default:
                            Console.WriteLine(String.Format("      {0}                  {1}                        {2}", follower.Breed, follower.Species, follower.FullName));
                            break;

                    }
                }
                Console.WriteLine();
            }
        }
    }
}
