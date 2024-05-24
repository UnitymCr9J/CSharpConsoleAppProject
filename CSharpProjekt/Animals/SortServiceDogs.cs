using CSharpProjekt.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpProjekt.Animals
{
    public class SortServiceDogs : IServiceDog
    {
        internal void ServiceDogsListSort(string answer)
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


            switch (answer)
            {
                case "1":
                    Console.WriteLine("         Breed                       Species                        Fullname");
                    Console.WriteLine("    -----------------------------------------------------------------------------------------------------");
                    SortingServiceDogsBySpecies(ServiceDogs);
                    break;

                case "2":
                    Console.WriteLine("         Breed                       Species                        Fullname");
                    Console.WriteLine("    -----------------------------------------------------------------------------------------------------");
                    SortingServiceDogsBySpeciesReverse(ServiceDogs);
                    break;

                case "3":
                    Console.WriteLine("         Breed                       Species                        Fullname");
                    Console.WriteLine("    -----------------------------------------------------------------------------------------------------");
                    SortingServiceDogsByName(ServiceDogs);
                    break;

                case "4":
                    Console.WriteLine("         Breed                       Species                        Fullname");
                    Console.WriteLine("    -----------------------------------------------------------------------------------------------------");
                    SortingServiceDogsByNameReverse(ServiceDogs);
                    break;

                case "5":
                    Console.WriteLine("         Breed                       Species                        Fullname");
                    Console.WriteLine("    -----------------------------------------------------------------------------------------------------");
                    SortingServiceDogsBySpeciesName(ServiceDogs);
                    break;

                case "6":
                    Console.WriteLine("         Breed                       Species                        Fullname");
                    Console.WriteLine("    -----------------------------------------------------------------------------------------------------");
                    SortingServiceDogsByReverseSpeciesName(ServiceDogs);
                    break;

                case "7":
                    Console.WriteLine("         Breed                       Species                        Fullname");
                    Console.WriteLine("    -----------------------------------------------------------------------------------------------------");
                    SortingServiceDogsBySpeciesReverseName(ServiceDogs);
                    break;

                case "8":
                    Console.WriteLine("         Breed                       Species                        Fullname");
                    Console.WriteLine("    -----------------------------------------------------------------------------------------------------");
                    SortingServiceDogsBySpeciesNameReverse(ServiceDogs);
                    break;

                default:
                    Console.WriteLine("Next time please input one of displayed numbers!");
                    break;

            }
        }

        public void SortingServiceDogsBySpecies(List<DisplayDogs> ServiceDogs)
        {

            var servicedogslist = ServiceDogs.OrderBy(servicesort => servicesort.Species).ToList();

            foreach (var service in ServiceDogs)
            {
                if (service.DogId >= 1 && service.DogId < 10)
                {
                    switch (service.Species)
                    {
                        case "Australian herd guard":
                            Console.WriteLine(String.Format("      {0}                   {1}           {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Bernardine":
                            Console.WriteLine(String.Format("      {0}                   {1}                      {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Boxer":
                            Console.WriteLine(String.Format("      {0}                   {1}                           {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Bearded koli":
                            Console.WriteLine(String.Format("      {0}                   {1}                    {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Doga":
                            Console.WriteLine(String.Format("      {0}                   {1}                            {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Husky":
                            Console.WriteLine(String.Format("      {0}                   {1}                           {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Hound":
                            Console.WriteLine(String.Format("      {0}                   {1}                {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Cattle dog":
                            Console.WriteLine(String.Format("      {0}                   {1}                {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Loser dog":
                            Console.WriteLine(String.Format("      {0}                    {1}            {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Japanese dog":
                            Console.WriteLine(String.Format("      {0}                    {1}                {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Lendsir":
                            Console.WriteLine(String.Format("      {0}                    {1}                {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Leonberg dog":
                            Console.WriteLine(String.Format("      {0}                    {1}                {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Mastiff":
                            Console.WriteLine(String.Format("      {0}                    {1}                {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Newfoundlander":
                            Console.WriteLine(String.Format("      {0}                    {1}                {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Sheep dog":
                            Console.WriteLine(String.Format("      {0}                    {1}                {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Shepherd dog":
                            Console.WriteLine(String.Format("      {0}                    {1}                {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Pinch":
                            Console.WriteLine(String.Format("      {0}                    {1}                {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Mountain dog":
                            Console.WriteLine(String.Format("      {0}                    {1}                {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Polar dog":
                            Console.WriteLine(String.Format("      {0}                    {1}                {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Siberian husky":
                            Console.WriteLine(String.Format("      {0}                    {1}                {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Spitz":
                            Console.WriteLine(String.Format("      {0}                    {1}                {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Rottweiler":
                            Console.WriteLine(String.Format("      {0}                    {1}                {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Water dog":
                            Console.WriteLine(String.Format("      {0}                    {1}                {2}", service.Breed, service.Species, service.FullName));
                            break;

                    }
                }
                else
                {
                    switch (service.Species)
                    {
                        case "Australian herd guard":
                            Console.WriteLine(String.Format("      {0}                   {1}                    {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Bernardine":
                            Console.WriteLine(String.Format("      {0}                   {1}                   {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Boxer":
                            Console.WriteLine(String.Format("      {0}                   {1}                      {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Bearded koli":
                            Console.WriteLine(String.Format("      {0}                   {1}                     {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Doga":
                            Console.WriteLine(String.Format("      {0}                   {1}                            {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Husky":
                            Console.WriteLine(String.Format("      {0}                   {1}                           {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Hound":
                            Console.WriteLine(String.Format("      {0}                   {1}                           {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Cattle dog":
                            Console.WriteLine(String.Format("      {0}                   {1}                      {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Loser dog":
                            Console.WriteLine(String.Format("      {0}                   {1}                       {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Japanese dog":
                            Console.WriteLine(String.Format("      {0}                   {1}                    {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Lendsir":
                            Console.WriteLine(String.Format("      {0}                   {1}                         {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Leonberg dog":
                            Console.WriteLine(String.Format("      {0}                   {1}                    {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Mastiff":
                            Console.WriteLine(String.Format("      {0}                   {1}                         {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Newfoundlander":
                            Console.WriteLine(String.Format("      {0}                   {1}                  {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Sheep dog":
                            Console.WriteLine(String.Format("      {0}                   {1}                       {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Shepherd dog":
                            Console.WriteLine(String.Format("      {0}                   {1}                    {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Pinch":
                            Console.WriteLine(String.Format("      {0}                   {1}                           {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Mountain dog":
                            Console.WriteLine(String.Format("      {0}                   {1}                    {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Polar dog":
                            Console.WriteLine(String.Format("      {0}                   {1}                       {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Siberian husky":
                            Console.WriteLine(String.Format("      {0}                   {1}                  {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Spitz":
                            Console.WriteLine(String.Format("      {0}                   {1}                           {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Rottweiler":
                            Console.WriteLine(String.Format("      {0}                   {1}                      {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Water dog":
                            Console.WriteLine(String.Format("      {0}                   {1}                       {2}", service.Breed, service.Species, service.FullName));
                            break;

                    }
                }
                Console.WriteLine();
            }
        }

        public void SortingServiceDogsBySpeciesReverse(List<DisplayDogs> ServiceDogs)
        {

            var servicedogslist = ServiceDogs.OrderByDescending(servicesort => servicesort.Species).ToList();

            foreach (var service in ServiceDogs)
            {
                if (service.DogId >= 1 && service.DogId < 10)
                {
                    switch (service.Species)
                    {
                        case "Australian herd guard":
                            Console.WriteLine(String.Format("      {0}                   {1}           {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Bernardine":
                            Console.WriteLine(String.Format("      {0}                   {1}                      {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Boxer":
                            Console.WriteLine(String.Format("      {0}                   {1}                           {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Bearded koli":
                            Console.WriteLine(String.Format("      {0}                   {1}                    {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Doga":
                            Console.WriteLine(String.Format("      {0}                   {1}                            {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Husky":
                            Console.WriteLine(String.Format("      {0}                   {1}                           {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Hound":
                            Console.WriteLine(String.Format("      {0}                   {1}                {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Cattle dog":
                            Console.WriteLine(String.Format("      {0}                   {1}                {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Loser dog":
                            Console.WriteLine(String.Format("      {0}                    {1}            {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Japanese dog":
                            Console.WriteLine(String.Format("      {0}                    {1}                {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Lendsir":
                            Console.WriteLine(String.Format("      {0}                    {1}                {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Leonberg dog":
                            Console.WriteLine(String.Format("      {0}                    {1}                {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Mastiff":
                            Console.WriteLine(String.Format("      {0}                    {1}                {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Newfoundlander":
                            Console.WriteLine(String.Format("      {0}                    {1}                {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Sheep dog":
                            Console.WriteLine(String.Format("      {0}                    {1}                {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Shepherd dog":
                            Console.WriteLine(String.Format("      {0}                    {1}                {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Pinch":
                            Console.WriteLine(String.Format("      {0}                    {1}                {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Mountain dog":
                            Console.WriteLine(String.Format("      {0}                    {1}                {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Polar dog":
                            Console.WriteLine(String.Format("      {0}                    {1}                {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Siberian husky":
                            Console.WriteLine(String.Format("      {0}                    {1}                {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Spitz":
                            Console.WriteLine(String.Format("      {0}                    {1}                {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Rottweiler":
                            Console.WriteLine(String.Format("      {0}                    {1}                {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Water dog":
                            Console.WriteLine(String.Format("      {0}                    {1}                {2}", service.Breed, service.Species, service.FullName));
                            break;

                    }
                }
                else
                {
                    switch (service.Species)
                    {
                        case "Australian herd guard":
                            Console.WriteLine(String.Format("      {0}                   {1}                    {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Bernardine":
                            Console.WriteLine(String.Format("      {0}                   {1}                   {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Boxer":
                            Console.WriteLine(String.Format("      {0}                   {1}                      {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Bearded koli":
                            Console.WriteLine(String.Format("      {0}                   {1}                     {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Doga":
                            Console.WriteLine(String.Format("      {0}                   {1}                            {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Husky":
                            Console.WriteLine(String.Format("      {0}                   {1}                           {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Hound":
                            Console.WriteLine(String.Format("      {0}                   {1}                           {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Cattle dog":
                            Console.WriteLine(String.Format("      {0}                   {1}                      {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Loser dog":
                            Console.WriteLine(String.Format("      {0}                   {1}                       {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Japanese dog":
                            Console.WriteLine(String.Format("      {0}                   {1}                    {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Lendsir":
                            Console.WriteLine(String.Format("      {0}                   {1}                         {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Leonberg dog":
                            Console.WriteLine(String.Format("      {0}                   {1}                    {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Mastiff":
                            Console.WriteLine(String.Format("      {0}                   {1}                         {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Newfoundlander":
                            Console.WriteLine(String.Format("      {0}                   {1}                  {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Sheep dog":
                            Console.WriteLine(String.Format("      {0}                   {1}                       {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Shepherd dog":
                            Console.WriteLine(String.Format("      {0}                   {1}                    {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Pinch":
                            Console.WriteLine(String.Format("      {0}                   {1}                           {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Mountain dog":
                            Console.WriteLine(String.Format("      {0}                   {1}                    {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Polar dog":
                            Console.WriteLine(String.Format("      {0}                   {1}                       {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Siberian husky":
                            Console.WriteLine(String.Format("      {0}                   {1}                  {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Spitz":
                            Console.WriteLine(String.Format("      {0}                   {1}                           {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Rottweiler":
                            Console.WriteLine(String.Format("      {0}                   {1}                      {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Water dog":
                            Console.WriteLine(String.Format("      {0}                   {1}                       {2}", service.Breed, service.Species, service.FullName));
                            break;

                    }
                }
                Console.WriteLine();
            }
        }

        public void SortingServiceDogsByName(List<DisplayDogs> ServiceDogs)
        {

            var servicedogslist = ServiceDogs.OrderBy(servicesort => servicesort.FullName).ToList();

            foreach (var service in ServiceDogs)
            {
                if (service.DogId >= 1 && service.DogId < 10)
                {
                    switch (service.Species)
                    {
                        case "Australian herd guard":
                            Console.WriteLine(String.Format("      {0}                   {1}           {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Bernardine":
                            Console.WriteLine(String.Format("      {0}                   {1}                      {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Boxer":
                            Console.WriteLine(String.Format("      {0}                   {1}                           {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Bearded koli":
                            Console.WriteLine(String.Format("      {0}                   {1}                    {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Doga":
                            Console.WriteLine(String.Format("      {0}                   {1}                            {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Husky":
                            Console.WriteLine(String.Format("      {0}                   {1}                           {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Hound":
                            Console.WriteLine(String.Format("      {0}                   {1}                {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Cattle dog":
                            Console.WriteLine(String.Format("      {0}                   {1}                {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Loser dog":
                            Console.WriteLine(String.Format("      {0}                    {1}            {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Japanese dog":
                            Console.WriteLine(String.Format("      {0}                    {1}                {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Lendsir":
                            Console.WriteLine(String.Format("      {0}                    {1}                {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Leonberg dog":
                            Console.WriteLine(String.Format("      {0}                    {1}                {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Mastiff":
                            Console.WriteLine(String.Format("      {0}                    {1}                {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Newfoundlander":
                            Console.WriteLine(String.Format("      {0}                    {1}                {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Sheep dog":
                            Console.WriteLine(String.Format("      {0}                    {1}                {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Shepherd dog":
                            Console.WriteLine(String.Format("      {0}                    {1}                {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Pinch":
                            Console.WriteLine(String.Format("      {0}                    {1}                {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Mountain dog":
                            Console.WriteLine(String.Format("      {0}                    {1}                {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Polar dog":
                            Console.WriteLine(String.Format("      {0}                    {1}                {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Siberian husky":
                            Console.WriteLine(String.Format("      {0}                    {1}                {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Spitz":
                            Console.WriteLine(String.Format("      {0}                    {1}                {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Rottweiler":
                            Console.WriteLine(String.Format("      {0}                    {1}                {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Water dog":
                            Console.WriteLine(String.Format("      {0}                    {1}                {2}", service.Breed, service.Species, service.FullName));
                            break;

                    }
                }
                else
                {
                    switch (service.Species)
                    {
                        case "Australian herd guard":
                            Console.WriteLine(String.Format("      {0}                   {1}                    {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Bernardine":
                            Console.WriteLine(String.Format("      {0}                   {1}                   {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Boxer":
                            Console.WriteLine(String.Format("      {0}                   {1}                      {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Bearded koli":
                            Console.WriteLine(String.Format("      {0}                   {1}                     {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Doga":
                            Console.WriteLine(String.Format("      {0}                   {1}                            {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Husky":
                            Console.WriteLine(String.Format("      {0}                   {1}                           {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Hound":
                            Console.WriteLine(String.Format("      {0}                   {1}                           {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Cattle dog":
                            Console.WriteLine(String.Format("      {0}                   {1}                      {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Loser dog":
                            Console.WriteLine(String.Format("      {0}                   {1}                       {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Japanese dog":
                            Console.WriteLine(String.Format("      {0}                   {1}                    {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Lendsir":
                            Console.WriteLine(String.Format("      {0}                   {1}                         {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Leonberg dog":
                            Console.WriteLine(String.Format("      {0}                   {1}                    {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Mastiff":
                            Console.WriteLine(String.Format("      {0}                   {1}                         {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Newfoundlander":
                            Console.WriteLine(String.Format("      {0}                   {1}                  {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Sheep dog":
                            Console.WriteLine(String.Format("      {0}                   {1}                       {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Shepherd dog":
                            Console.WriteLine(String.Format("      {0}                   {1}                    {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Pinch":
                            Console.WriteLine(String.Format("      {0}                   {1}                           {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Mountain dog":
                            Console.WriteLine(String.Format("      {0}                   {1}                    {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Polar dog":
                            Console.WriteLine(String.Format("      {0}                   {1}                       {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Siberian husky":
                            Console.WriteLine(String.Format("      {0}                   {1}                  {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Spitz":
                            Console.WriteLine(String.Format("      {0}                   {1}                           {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Rottweiler":
                            Console.WriteLine(String.Format("      {0}                   {1}                      {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Water dog":
                            Console.WriteLine(String.Format("      {0}                   {1}                       {2}", service.Breed, service.Species, service.FullName));
                            break;

                    }
                }
                Console.WriteLine();
            }
        }

        public void SortingServiceDogsByNameReverse(List<DisplayDogs> ServiceDogs)
        {

            var servicedogslist = ServiceDogs.OrderByDescending(servicesort => servicesort.FullName).ToList();

            foreach (var service in ServiceDogs)
            {
                if (service.DogId >= 1 && service.DogId < 10)
                {
                    switch (service.Species)
                    {
                        case "Australian herd guard":
                            Console.WriteLine(String.Format("      {0}                   {1}           {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Bernardine":
                            Console.WriteLine(String.Format("      {0}                   {1}                      {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Boxer":
                            Console.WriteLine(String.Format("      {0}                   {1}                           {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Bearded koli":
                            Console.WriteLine(String.Format("      {0}                   {1}                    {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Doga":
                            Console.WriteLine(String.Format("      {0}                   {1}                            {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Husky":
                            Console.WriteLine(String.Format("      {0}                   {1}                           {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Hound":
                            Console.WriteLine(String.Format("      {0}                   {1}                {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Cattle dog":
                            Console.WriteLine(String.Format("      {0}                   {1}                {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Loser dog":
                            Console.WriteLine(String.Format("      {0}                    {1}            {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Japanese dog":
                            Console.WriteLine(String.Format("      {0}                    {1}                {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Lendsir":
                            Console.WriteLine(String.Format("      {0}                    {1}                {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Leonberg dog":
                            Console.WriteLine(String.Format("      {0}                    {1}                {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Mastiff":
                            Console.WriteLine(String.Format("      {0}                    {1}                {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Newfoundlander":
                            Console.WriteLine(String.Format("      {0}                    {1}                {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Sheep dog":
                            Console.WriteLine(String.Format("      {0}                    {1}                {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Shepherd dog":
                            Console.WriteLine(String.Format("      {0}                    {1}                {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Pinch":
                            Console.WriteLine(String.Format("      {0}                    {1}                {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Mountain dog":
                            Console.WriteLine(String.Format("      {0}                    {1}                {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Polar dog":
                            Console.WriteLine(String.Format("      {0}                    {1}                {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Siberian husky":
                            Console.WriteLine(String.Format("      {0}                    {1}                {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Spitz":
                            Console.WriteLine(String.Format("      {0}                    {1}                {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Rottweiler":
                            Console.WriteLine(String.Format("      {0}                    {1}                {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Water dog":
                            Console.WriteLine(String.Format("      {0}                    {1}                {2}", service.Breed, service.Species, service.FullName));
                            break;

                    }
                }
                else
                {
                    switch (service.Species)
                    {
                        case "Australian herd guard":
                            Console.WriteLine(String.Format("      {0}                   {1}                    {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Bernardine":
                            Console.WriteLine(String.Format("      {0}                   {1}                   {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Boxer":
                            Console.WriteLine(String.Format("      {0}                   {1}                      {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Bearded koli":
                            Console.WriteLine(String.Format("      {0}                   {1}                     {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Doga":
                            Console.WriteLine(String.Format("      {0}                   {1}                            {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Husky":
                            Console.WriteLine(String.Format("      {0}                   {1}                           {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Hound":
                            Console.WriteLine(String.Format("      {0}                   {1}                           {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Cattle dog":
                            Console.WriteLine(String.Format("      {0}                   {1}                      {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Loser dog":
                            Console.WriteLine(String.Format("      {0}                   {1}                       {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Japanese dog":
                            Console.WriteLine(String.Format("      {0}                   {1}                    {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Lendsir":
                            Console.WriteLine(String.Format("      {0}                   {1}                         {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Leonberg dog":
                            Console.WriteLine(String.Format("      {0}                   {1}                    {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Mastiff":
                            Console.WriteLine(String.Format("      {0}                   {1}                         {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Newfoundlander":
                            Console.WriteLine(String.Format("      {0}                   {1}                  {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Sheep dog":
                            Console.WriteLine(String.Format("      {0}                   {1}                       {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Shepherd dog":
                            Console.WriteLine(String.Format("      {0}                   {1}                    {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Pinch":
                            Console.WriteLine(String.Format("      {0}                   {1}                           {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Mountain dog":
                            Console.WriteLine(String.Format("      {0}                   {1}                    {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Polar dog":
                            Console.WriteLine(String.Format("      {0}                   {1}                       {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Siberian husky":
                            Console.WriteLine(String.Format("      {0}                   {1}                  {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Spitz":
                            Console.WriteLine(String.Format("      {0}                   {1}                           {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Rottweiler":
                            Console.WriteLine(String.Format("      {0}                   {1}                      {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Water dog":
                            Console.WriteLine(String.Format("      {0}                   {1}                       {2}", service.Breed, service.Species, service.FullName));
                            break;

                    }
                }
                Console.WriteLine();
            }
        }

        public void SortingServiceDogsBySpeciesName(List<DisplayDogs> ServiceDogs)
        {

            var servicedogslist = ServiceDogs.OrderBy(servicesort => servicesort.Species).OrderBy(servicesort => servicesort.FullName).ToList();

            foreach (var service in ServiceDogs)
            {
                if (service.DogId >= 1 && service.DogId < 10)
                {
                    switch (service.Species)
                    {
                        case "Australian herd guard":
                            Console.WriteLine(String.Format("      {0}                   {1}           {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Bernardine":
                            Console.WriteLine(String.Format("      {0}                   {1}                      {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Boxer":
                            Console.WriteLine(String.Format("      {0}                   {1}                           {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Bearded koli":
                            Console.WriteLine(String.Format("      {0}                   {1}                    {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Doga":
                            Console.WriteLine(String.Format("      {0}                   {1}                            {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Husky":
                            Console.WriteLine(String.Format("      {0}                   {1}                           {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Hound":
                            Console.WriteLine(String.Format("      {0}                   {1}                {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Cattle dog":
                            Console.WriteLine(String.Format("      {0}                   {1}                {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Loser dog":
                            Console.WriteLine(String.Format("      {0}                    {1}            {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Japanese dog":
                            Console.WriteLine(String.Format("      {0}                    {1}                {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Lendsir":
                            Console.WriteLine(String.Format("      {0}                    {1}                {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Leonberg dog":
                            Console.WriteLine(String.Format("      {0}                    {1}                {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Mastiff":
                            Console.WriteLine(String.Format("      {0}                    {1}                {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Newfoundlander":
                            Console.WriteLine(String.Format("      {0}                    {1}                {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Sheep dog":
                            Console.WriteLine(String.Format("      {0}                    {1}                {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Shepherd dog":
                            Console.WriteLine(String.Format("      {0}                    {1}                {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Pinch":
                            Console.WriteLine(String.Format("      {0}                    {1}                {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Mountain dog":
                            Console.WriteLine(String.Format("      {0}                    {1}                {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Polar dog":
                            Console.WriteLine(String.Format("      {0}                    {1}                {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Siberian husky":
                            Console.WriteLine(String.Format("      {0}                    {1}                {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Spitz":
                            Console.WriteLine(String.Format("      {0}                    {1}                {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Rottweiler":
                            Console.WriteLine(String.Format("      {0}                    {1}                {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Water dog":
                            Console.WriteLine(String.Format("      {0}                    {1}                {2}", service.Breed, service.Species, service.FullName));
                            break;

                    }
                }
                else
                {
                    switch (service.Species)
                    {
                        case "Australian herd guard":
                            Console.WriteLine(String.Format("      {0}                   {1}                    {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Bernardine":
                            Console.WriteLine(String.Format("      {0}                   {1}                   {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Boxer":
                            Console.WriteLine(String.Format("      {0}                   {1}                      {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Bearded koli":
                            Console.WriteLine(String.Format("      {0}                   {1}                     {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Doga":
                            Console.WriteLine(String.Format("      {0}                   {1}                            {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Husky":
                            Console.WriteLine(String.Format("      {0}                   {1}                           {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Hound":
                            Console.WriteLine(String.Format("      {0}                   {1}                           {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Cattle dog":
                            Console.WriteLine(String.Format("      {0}                   {1}                      {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Loser dog":
                            Console.WriteLine(String.Format("      {0}                   {1}                       {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Japanese dog":
                            Console.WriteLine(String.Format("      {0}                   {1}                    {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Lendsir":
                            Console.WriteLine(String.Format("      {0}                   {1}                         {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Leonberg dog":
                            Console.WriteLine(String.Format("      {0}                   {1}                    {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Mastiff":
                            Console.WriteLine(String.Format("      {0}                   {1}                         {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Newfoundlander":
                            Console.WriteLine(String.Format("      {0}                   {1}                  {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Sheep dog":
                            Console.WriteLine(String.Format("      {0}                   {1}                       {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Shepherd dog":
                            Console.WriteLine(String.Format("      {0}                   {1}                    {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Pinch":
                            Console.WriteLine(String.Format("      {0}                   {1}                           {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Mountain dog":
                            Console.WriteLine(String.Format("      {0}                   {1}                    {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Polar dog":
                            Console.WriteLine(String.Format("      {0}                   {1}                       {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Siberian husky":
                            Console.WriteLine(String.Format("      {0}                   {1}                  {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Spitz":
                            Console.WriteLine(String.Format("      {0}                   {1}                           {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Rottweiler":
                            Console.WriteLine(String.Format("      {0}                   {1}                      {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Water dog":
                            Console.WriteLine(String.Format("      {0}                   {1}                       {2}", service.Breed, service.Species, service.FullName));
                            break;

                    }
                }
                Console.WriteLine();
            }
        }

        public void SortingServiceDogsByReverseSpeciesName(List<DisplayDogs> ServiceDogs)
        {

            var servicedogslist = ServiceDogs.OrderByDescending(servicesort => servicesort.Species).OrderByDescending(servicesort => servicesort.FullName).ToList();

            foreach (var service in ServiceDogs)
            {
                if (service.DogId >= 1 && service.DogId < 10)
                {
                    switch (service.Species)
                    {
                        case "Australian herd guard":
                            Console.WriteLine(String.Format("      {0}                   {1}           {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Bernardine":
                            Console.WriteLine(String.Format("      {0}                   {1}                      {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Boxer":
                            Console.WriteLine(String.Format("      {0}                   {1}                           {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Bearded koli":
                            Console.WriteLine(String.Format("      {0}                   {1}                    {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Doga":
                            Console.WriteLine(String.Format("      {0}                   {1}                            {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Husky":
                            Console.WriteLine(String.Format("      {0}                   {1}                           {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Hound":
                            Console.WriteLine(String.Format("      {0}                   {1}                {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Cattle dog":
                            Console.WriteLine(String.Format("      {0}                   {1}                {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Loser dog":
                            Console.WriteLine(String.Format("      {0}                    {1}            {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Japanese dog":
                            Console.WriteLine(String.Format("      {0}                    {1}                {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Lendsir":
                            Console.WriteLine(String.Format("      {0}                    {1}                {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Leonberg dog":
                            Console.WriteLine(String.Format("      {0}                    {1}                {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Mastiff":
                            Console.WriteLine(String.Format("      {0}                    {1}                {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Newfoundlander":
                            Console.WriteLine(String.Format("      {0}                    {1}                {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Sheep dog":
                            Console.WriteLine(String.Format("      {0}                    {1}                {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Shepherd dog":
                            Console.WriteLine(String.Format("      {0}                    {1}                {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Pinch":
                            Console.WriteLine(String.Format("      {0}                    {1}                {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Mountain dog":
                            Console.WriteLine(String.Format("      {0}                    {1}                {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Polar dog":
                            Console.WriteLine(String.Format("      {0}                    {1}                {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Siberian husky":
                            Console.WriteLine(String.Format("      {0}                    {1}                {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Spitz":
                            Console.WriteLine(String.Format("      {0}                    {1}                {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Rottweiler":
                            Console.WriteLine(String.Format("      {0}                    {1}                {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Water dog":
                            Console.WriteLine(String.Format("      {0}                    {1}                {2}", service.Breed, service.Species, service.FullName));
                            break;

                    }
                }
                else
                {
                    switch (service.Species)
                    {
                        case "Australian herd guard":
                            Console.WriteLine(String.Format("      {0}                   {1}                    {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Bernardine":
                            Console.WriteLine(String.Format("      {0}                   {1}                   {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Boxer":
                            Console.WriteLine(String.Format("      {0}                   {1}                      {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Bearded koli":
                            Console.WriteLine(String.Format("      {0}                   {1}                     {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Doga":
                            Console.WriteLine(String.Format("      {0}                   {1}                            {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Husky":
                            Console.WriteLine(String.Format("      {0}                   {1}                           {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Hound":
                            Console.WriteLine(String.Format("      {0}                   {1}                           {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Cattle dog":
                            Console.WriteLine(String.Format("      {0}                   {1}                      {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Loser dog":
                            Console.WriteLine(String.Format("      {0}                   {1}                       {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Japanese dog":
                            Console.WriteLine(String.Format("      {0}                   {1}                    {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Lendsir":
                            Console.WriteLine(String.Format("      {0}                   {1}                         {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Leonberg dog":
                            Console.WriteLine(String.Format("      {0}                   {1}                    {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Mastiff":
                            Console.WriteLine(String.Format("      {0}                   {1}                         {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Newfoundlander":
                            Console.WriteLine(String.Format("      {0}                   {1}                  {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Sheep dog":
                            Console.WriteLine(String.Format("      {0}                   {1}                       {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Shepherd dog":
                            Console.WriteLine(String.Format("      {0}                   {1}                    {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Pinch":
                            Console.WriteLine(String.Format("      {0}                   {1}                           {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Mountain dog":
                            Console.WriteLine(String.Format("      {0}                   {1}                    {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Polar dog":
                            Console.WriteLine(String.Format("      {0}                   {1}                       {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Siberian husky":
                            Console.WriteLine(String.Format("      {0}                   {1}                  {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Spitz":
                            Console.WriteLine(String.Format("      {0}                   {1}                           {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Rottweiler":
                            Console.WriteLine(String.Format("      {0}                   {1}                      {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Water dog":
                            Console.WriteLine(String.Format("      {0}                   {1}                       {2}", service.Breed, service.Species, service.FullName));
                            break;

                    }
                }
                Console.WriteLine();
            }
        }

        public void SortingServiceDogsBySpeciesReverseName(List<DisplayDogs> ServiceDogs)
        {

            var servicedogslist = ServiceDogs.OrderByDescending(servicesort => servicesort.Species).OrderBy(servicesort => servicesort.FullName).ToList();

            foreach (var service in ServiceDogs)
            {
                if (service.DogId >= 1 && service.DogId < 10)
                {
                    switch (service.Species)
                    {
                        case "Australian herd guard":
                            Console.WriteLine(String.Format("      {0}                   {1}           {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Bernardine":
                            Console.WriteLine(String.Format("      {0}                   {1}                      {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Boxer":
                            Console.WriteLine(String.Format("      {0}                   {1}                           {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Bearded koli":
                            Console.WriteLine(String.Format("      {0}                   {1}                    {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Doga":
                            Console.WriteLine(String.Format("      {0}                   {1}                            {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Husky":
                            Console.WriteLine(String.Format("      {0}                   {1}                           {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Hound":
                            Console.WriteLine(String.Format("      {0}                   {1}                {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Cattle dog":
                            Console.WriteLine(String.Format("      {0}                   {1}                {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Loser dog":
                            Console.WriteLine(String.Format("      {0}                    {1}            {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Japanese dog":
                            Console.WriteLine(String.Format("      {0}                    {1}                {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Lendsir":
                            Console.WriteLine(String.Format("      {0}                    {1}                {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Leonberg dog":
                            Console.WriteLine(String.Format("      {0}                    {1}                {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Mastiff":
                            Console.WriteLine(String.Format("      {0}                    {1}                {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Newfoundlander":
                            Console.WriteLine(String.Format("      {0}                    {1}                {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Sheep dog":
                            Console.WriteLine(String.Format("      {0}                    {1}                {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Shepherd dog":
                            Console.WriteLine(String.Format("      {0}                    {1}                {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Pinch":
                            Console.WriteLine(String.Format("      {0}                    {1}                {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Mountain dog":
                            Console.WriteLine(String.Format("      {0}                    {1}                {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Polar dog":
                            Console.WriteLine(String.Format("      {0}                    {1}                {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Siberian husky":
                            Console.WriteLine(String.Format("      {0}                    {1}                {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Spitz":
                            Console.WriteLine(String.Format("      {0}                    {1}                {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Rottweiler":
                            Console.WriteLine(String.Format("      {0}                    {1}                {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Water dog":
                            Console.WriteLine(String.Format("      {0}                    {1}                {2}", service.Breed, service.Species, service.FullName));
                            break;

                    }
                }
                else
                {
                    switch (service.Species)
                    {
                        case "Australian herd guard":
                            Console.WriteLine(String.Format("      {0}                   {1}                    {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Bernardine":
                            Console.WriteLine(String.Format("      {0}                   {1}                   {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Boxer":
                            Console.WriteLine(String.Format("      {0}                   {1}                      {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Bearded koli":
                            Console.WriteLine(String.Format("      {0}                   {1}                     {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Doga":
                            Console.WriteLine(String.Format("      {0}                   {1}                            {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Husky":
                            Console.WriteLine(String.Format("      {0}                   {1}                           {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Hound":
                            Console.WriteLine(String.Format("      {0}                   {1}                           {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Cattle dog":
                            Console.WriteLine(String.Format("      {0}                   {1}                      {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Loser dog":
                            Console.WriteLine(String.Format("      {0}                   {1}                       {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Japanese dog":
                            Console.WriteLine(String.Format("      {0}                   {1}                    {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Lendsir":
                            Console.WriteLine(String.Format("      {0}                   {1}                         {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Leonberg dog":
                            Console.WriteLine(String.Format("      {0}                   {1}                    {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Mastiff":
                            Console.WriteLine(String.Format("      {0}                   {1}                         {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Newfoundlander":
                            Console.WriteLine(String.Format("      {0}                   {1}                  {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Sheep dog":
                            Console.WriteLine(String.Format("      {0}                   {1}                       {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Shepherd dog":
                            Console.WriteLine(String.Format("      {0}                   {1}                    {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Pinch":
                            Console.WriteLine(String.Format("      {0}                   {1}                           {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Mountain dog":
                            Console.WriteLine(String.Format("      {0}                   {1}                    {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Polar dog":
                            Console.WriteLine(String.Format("      {0}                   {1}                       {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Siberian husky":
                            Console.WriteLine(String.Format("      {0}                   {1}                  {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Spitz":
                            Console.WriteLine(String.Format("      {0}                   {1}                           {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Rottweiler":
                            Console.WriteLine(String.Format("      {0}                   {1}                      {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Water dog":
                            Console.WriteLine(String.Format("      {0}                   {1}                       {2}", service.Breed, service.Species, service.FullName));
                            break;

                    }
                }
                Console.WriteLine();
            }
        }

        public void SortingServiceDogsBySpeciesNameReverse(List<DisplayDogs> ServiceDogs)
        {

            var servicedogslist = ServiceDogs.OrderBy(servicesort => servicesort.Species).OrderByDescending(servicesort => servicesort.FullName).ToList();

            foreach (var service in ServiceDogs)
            {
                if (service.DogId >= 1 && service.DogId < 10)
                {
                    switch (service.Species)
                    {
                        case "Australian herd guard":
                            Console.WriteLine(String.Format("      {0}                   {1}           {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Bernardine":
                            Console.WriteLine(String.Format("      {0}                   {1}                      {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Boxer":
                            Console.WriteLine(String.Format("      {0}                   {1}                           {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Bearded koli":
                            Console.WriteLine(String.Format("      {0}                   {1}                    {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Doga":
                            Console.WriteLine(String.Format("      {0}                   {1}                            {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Husky":
                            Console.WriteLine(String.Format("      {0}                   {1}                           {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Hound":
                            Console.WriteLine(String.Format("      {0}                   {1}                {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Cattle dog":
                            Console.WriteLine(String.Format("      {0}                   {1}                {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Loser dog":
                            Console.WriteLine(String.Format("      {0}                    {1}            {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Japanese dog":
                            Console.WriteLine(String.Format("      {0}                    {1}                {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Lendsir":
                            Console.WriteLine(String.Format("      {0}                    {1}                {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Leonberg dog":
                            Console.WriteLine(String.Format("      {0}                    {1}                {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Mastiff":
                            Console.WriteLine(String.Format("      {0}                    {1}                {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Newfoundlander":
                            Console.WriteLine(String.Format("      {0}                    {1}                {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Sheep dog":
                            Console.WriteLine(String.Format("      {0}                    {1}                {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Shepherd dog":
                            Console.WriteLine(String.Format("      {0}                    {1}                {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Pinch":
                            Console.WriteLine(String.Format("      {0}                    {1}                {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Mountain dog":
                            Console.WriteLine(String.Format("      {0}                    {1}                {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Polar dog":
                            Console.WriteLine(String.Format("      {0}                    {1}                {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Siberian husky":
                            Console.WriteLine(String.Format("      {0}                    {1}                {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Spitz":
                            Console.WriteLine(String.Format("      {0}                    {1}                {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Rottweiler":
                            Console.WriteLine(String.Format("      {0}                    {1}                {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Water dog":
                            Console.WriteLine(String.Format("      {0}                    {1}                {2}", service.Breed, service.Species, service.FullName));
                            break;

                    }
                }
                else
                {
                    switch (service.Species)
                    {
                        case "Australian herd guard":
                            Console.WriteLine(String.Format("      {0}                   {1}                    {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Bernardine":
                            Console.WriteLine(String.Format("      {0}                   {1}                   {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Boxer":
                            Console.WriteLine(String.Format("      {0}                   {1}                      {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Bearded koli":
                            Console.WriteLine(String.Format("      {0}                   {1}                     {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Doga":
                            Console.WriteLine(String.Format("      {0}                   {1}                            {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Husky":
                            Console.WriteLine(String.Format("      {0}                   {1}                           {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Hound":
                            Console.WriteLine(String.Format("      {0}                   {1}                           {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Cattle dog":
                            Console.WriteLine(String.Format("      {0}                   {1}                      {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Loser dog":
                            Console.WriteLine(String.Format("      {0}                   {1}                       {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Japanese dog":
                            Console.WriteLine(String.Format("      {0}                   {1}                    {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Lendsir":
                            Console.WriteLine(String.Format("      {0}                   {1}                         {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Leonberg dog":
                            Console.WriteLine(String.Format("      {0}                   {1}                    {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Mastiff":
                            Console.WriteLine(String.Format("      {0}                   {1}                         {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Newfoundlander":
                            Console.WriteLine(String.Format("      {0}                   {1}                  {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Sheep dog":
                            Console.WriteLine(String.Format("      {0}                   {1}                       {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Shepherd dog":
                            Console.WriteLine(String.Format("      {0}                   {1}                    {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Pinch":
                            Console.WriteLine(String.Format("      {0}                   {1}                           {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Mountain dog":
                            Console.WriteLine(String.Format("      {0}                   {1}                    {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Polar dog":
                            Console.WriteLine(String.Format("      {0}                   {1}                       {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Siberian husky":
                            Console.WriteLine(String.Format("      {0}                   {1}                  {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Spitz":
                            Console.WriteLine(String.Format("      {0}                   {1}                           {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Rottweiler":
                            Console.WriteLine(String.Format("      {0}                   {1}                      {2}", service.Breed, service.Species, service.FullName));
                            break;

                        case "Water dog":
                            Console.WriteLine(String.Format("      {0}                   {1}                       {2}", service.Breed, service.Species, service.FullName));
                            break;

                    }
                }
                Console.WriteLine();
            }
        }
    }
}
