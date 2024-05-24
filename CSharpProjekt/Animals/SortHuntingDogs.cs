using CSharpProjekt.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpProjekt.Animals
{
    public class SortHuntingDogs : IHuntingDog
    {
        internal void HuntingDogsListSort(string answer)
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


            switch (answer)
            {
                case "1":
                    Console.WriteLine("         Breed                       Species                        Fullname");
                    Console.WriteLine("    ---------------------------------------------------------------------------------------------------------");
                    SortingHuntingDogsBySpecies(HuntingDogs);
                    break;

                case "2":
                    Console.WriteLine("         Breed                       Species                        Fullname");
                    Console.WriteLine("    ---------------------------------------------------------------------------------------------------------");
                    SortingHuntingDogsBySpeciesReverse(HuntingDogs);
                    break;

                case "3":
                    Console.WriteLine("         Breed                       Species                        Fullname");
                    Console.WriteLine("    ---------------------------------------------------------------------------------------------------------");
                    SortingHuntingDogsByName(HuntingDogs);
                    break;

                case "4":
                    Console.WriteLine("         Breed                       Species                        Fullname");
                    Console.WriteLine("    ---------------------------------------------------------------------------------------------------------");
                    SortingHuntingDogsByNameReverse(HuntingDogs);
                    break;

                case "5":
                    Console.WriteLine("         Breed                       Species                        Fullname");
                    Console.WriteLine("    ---------------------------------------------------------------------------------------------------------");
                    SortingHuntingDogsBySpeciesName(HuntingDogs);
                    break;

                case "6":
                    Console.WriteLine("         Breed                       Species                        Fullname");
                    Console.WriteLine("    ---------------------------------------------------------------------------------------------------------");
                    SortingHuntingDogsByReverseSpeciesName(HuntingDogs);
                    break;

                case "7":
                    Console.WriteLine("         Breed                       Species                        Fullname");
                    Console.WriteLine("    ---------------------------------------------------------------------------------------------------------");
                    SortingHuntingDogsBySpeciesReverseName(HuntingDogs);
                    break;

                case "8":
                    Console.WriteLine("         Breed                       Species                        Fullname");
                    Console.WriteLine("    ---------------------------------------------------------------------------------------------------------");
                    SortingHuntingDogsBySpeciesNameReverse(HuntingDogs);
                    break;

                default:
                    Console.WriteLine("Next time please input one of displayed numbers!");
                    break;

            }
        }

        public void SortingHuntingDogsBySpecies(List<DisplayDogs> HuntingDogs)
        {

            var huntingdogslist = HuntingDogs.OrderBy(huntersort => huntersort.Species).ToList();

            foreach (var hunt in huntingdogslist)
            {
                if (hunt.DogId >= 1 && hunt.DogId < 10)
                {
                    switch (hunt.Species)
                    {
                        case "Basset":
                            Console.WriteLine(String.Format("      {0}                   {1}                          {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Basenji":
                            Console.WriteLine(String.Format("      {0}                   {1}                         {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Doga":
                            Console.WriteLine(String.Format("      {0}                   {1}                            {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Hound":
                            Console.WriteLine(String.Format("      {0}                   {1}                           {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Epaniel":
                            Console.WriteLine(String.Format("      {0}                   {1}                      {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Dachshund":
                            Console.WriteLine(String.Format("      {0}                   {1}                      {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Foxhound":
                            Console.WriteLine(String.Format("      {0}                   {1}                      {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Pointer":
                            Console.WriteLine(String.Format("      {0}                   {1}                      {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Bird watcher":
                            Console.WriteLine(String.Format("      {0}                    {1}                      {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Setter":
                            Console.WriteLine(String.Format("      {0}                    {1}                      {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Retriever":
                            Console.WriteLine(String.Format("      {0}                    {1}                      {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Spaniel":
                            Console.WriteLine(String.Format("      {0}                    {1}                      {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Beagle":
                            Console.WriteLine(String.Format("      {0}                    {1}                      {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                    }
                }
                else if (hunt.DogId >= 10 && hunt.DogId < 100)
                {
                    switch (hunt.Species)
                    {
                        case "Basset":
                            Console.WriteLine(String.Format("      {0}                   {1}                      {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Basenji":
                            Console.WriteLine(String.Format("      {0}                   {1}                      {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Doga":
                            Console.WriteLine(String.Format("      {0}                   {1}                      {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Hound":
                            Console.WriteLine(String.Format("      {0}                   {1}                           {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Epaniel":
                            Console.WriteLine(String.Format("      {0}                   {1}                         {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Dachshund":
                            Console.WriteLine(String.Format("      {0}                   {1}                       {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Foxhound":
                            Console.WriteLine(String.Format("      {0}                   {1}                        {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Pointer":
                            Console.WriteLine(String.Format("      {0}                   {1}                         {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Bird watcher":
                            Console.WriteLine(String.Format("      {0}                   {1}                    {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Setter":
                            Console.WriteLine(String.Format("      {0}                   {1}                      {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Retriever":
                            Console.WriteLine(String.Format("      {0}                   {1}                      {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Spaniel":
                            Console.WriteLine(String.Format("      {0}                   {1}                      {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Beagle":
                            Console.WriteLine(String.Format("      {0}                   {1}                      {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                    }
                }
                else
                {
                    switch (hunt.Species)
                    {
                        case "Basset":
                            Console.WriteLine(String.Format("      {0}                   {1}                      {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Basenji":
                            Console.WriteLine(String.Format("      {0}                   {1}                      {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Doga":
                            Console.WriteLine(String.Format("      {0}                   {1}                      {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Hound":
                            Console.WriteLine(String.Format("      {0}                   {1}                      {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Epaniel":
                            Console.WriteLine(String.Format("      {0}                   {1}                      {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Dachshund":
                            Console.WriteLine(String.Format("      {0}                   {1}                      {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Foxhound":
                            Console.WriteLine(String.Format("      {0}                   {1}                      {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Pointer":
                            Console.WriteLine(String.Format("      {0}                   {1}                      {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Bird watcher":
                            Console.WriteLine(String.Format("      {0}                   {1}                    {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Setter":
                            Console.WriteLine(String.Format("      {0}                   {1}                          {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Retriever":
                            Console.WriteLine(String.Format("      {0}                   {1}                       {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Spaniel":
                            Console.WriteLine(String.Format("      {0}                   {1}                         {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Beagle":
                            Console.WriteLine(String.Format("      {0}                   {1}                          {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                    }
                }
                Console.WriteLine();
            }
        }

        public void SortingHuntingDogsBySpeciesReverse(List<DisplayDogs> HuntingDogs)
        {

            var huntingdogslist = HuntingDogs.OrderByDescending(huntersort => huntersort.Species).ToList();

            foreach (var hunt in huntingdogslist)
            {
                if (hunt.DogId >= 1 && hunt.DogId < 10)
                {
                    switch (hunt.Species)
                    {
                        case "Basset":
                            Console.WriteLine(String.Format("      {0}                   {1}                          {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Basenji":
                            Console.WriteLine(String.Format("      {0}                   {1}                         {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Doga":
                            Console.WriteLine(String.Format("      {0}                   {1}                            {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Hound":
                            Console.WriteLine(String.Format("      {0}                   {1}                           {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Epaniel":
                            Console.WriteLine(String.Format("      {0}                   {1}                      {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Dachshund":
                            Console.WriteLine(String.Format("      {0}                   {1}                      {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Foxhound":
                            Console.WriteLine(String.Format("      {0}                   {1}                      {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Pointer":
                            Console.WriteLine(String.Format("      {0}                   {1}                      {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Bird watcher":
                            Console.WriteLine(String.Format("      {0}                    {1}                      {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Setter":
                            Console.WriteLine(String.Format("      {0}                    {1}                      {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Retriever":
                            Console.WriteLine(String.Format("      {0}                    {1}                      {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Spaniel":
                            Console.WriteLine(String.Format("      {0}                    {1}                      {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Beagle":
                            Console.WriteLine(String.Format("      {0}                    {1}                      {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                    }
                }
                else if (hunt.DogId >= 10 && hunt.DogId < 100)
                {
                    switch (hunt.Species)
                    {
                        case "Basset":
                            Console.WriteLine(String.Format("      {0}                   {1}                      {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Basenji":
                            Console.WriteLine(String.Format("      {0}                   {1}                      {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Doga":
                            Console.WriteLine(String.Format("      {0}                   {1}                      {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Hound":
                            Console.WriteLine(String.Format("      {0}                   {1}                           {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Epaniel":
                            Console.WriteLine(String.Format("      {0}                   {1}                         {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Dachshund":
                            Console.WriteLine(String.Format("      {0}                   {1}                       {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Foxhound":
                            Console.WriteLine(String.Format("      {0}                   {1}                        {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Pointer":
                            Console.WriteLine(String.Format("      {0}                   {1}                         {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Bird watcher":
                            Console.WriteLine(String.Format("      {0}                   {1}                    {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Setter":
                            Console.WriteLine(String.Format("      {0}                   {1}                      {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Retriever":
                            Console.WriteLine(String.Format("      {0}                   {1}                      {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Spaniel":
                            Console.WriteLine(String.Format("      {0}                   {1}                      {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Beagle":
                            Console.WriteLine(String.Format("      {0}                   {1}                      {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                    }
                }
                else
                {
                    switch (hunt.Species)
                    {
                        case "Basset":
                            Console.WriteLine(String.Format("      {0}                   {1}                      {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Basenji":
                            Console.WriteLine(String.Format("      {0}                   {1}                      {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Doga":
                            Console.WriteLine(String.Format("      {0}                   {1}                      {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Hound":
                            Console.WriteLine(String.Format("      {0}                   {1}                      {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Epaniel":
                            Console.WriteLine(String.Format("      {0}                   {1}                      {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Dachshund":
                            Console.WriteLine(String.Format("      {0}                   {1}                      {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Foxhound":
                            Console.WriteLine(String.Format("      {0}                   {1}                      {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Pointer":
                            Console.WriteLine(String.Format("      {0}                   {1}                      {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Bird watcher":
                            Console.WriteLine(String.Format("      {0}                   {1}                    {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Setter":
                            Console.WriteLine(String.Format("      {0}                   {1}                          {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Retriever":
                            Console.WriteLine(String.Format("      {0}                   {1}                       {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Spaniel":
                            Console.WriteLine(String.Format("      {0}                   {1}                         {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Beagle":
                            Console.WriteLine(String.Format("      {0}                   {1}                          {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                    }
                }
                Console.WriteLine();
            }
        }

        public void SortingHuntingDogsByName(List<DisplayDogs> HuntingDogs)
        {

            var huntingdogslist = HuntingDogs.OrderBy(huntersort => huntersort.FullName).ToList();

            foreach (var hunt in huntingdogslist)
            {
                if (hunt.DogId >= 1 && hunt.DogId < 10)
                {
                    switch (hunt.Species)
                    {
                        case "Basset":
                            Console.WriteLine(String.Format("      {0}                   {1}                          {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Basenji":
                            Console.WriteLine(String.Format("      {0}                   {1}                         {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Doga":
                            Console.WriteLine(String.Format("      {0}                   {1}                            {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Hound":
                            Console.WriteLine(String.Format("      {0}                   {1}                           {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Epaniel":
                            Console.WriteLine(String.Format("      {0}                   {1}                      {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Dachshund":
                            Console.WriteLine(String.Format("      {0}                   {1}                      {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Foxhound":
                            Console.WriteLine(String.Format("      {0}                   {1}                      {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Pointer":
                            Console.WriteLine(String.Format("      {0}                   {1}                      {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Bird watcher":
                            Console.WriteLine(String.Format("      {0}                    {1}                      {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Setter":
                            Console.WriteLine(String.Format("      {0}                    {1}                      {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Retriever":
                            Console.WriteLine(String.Format("      {0}                    {1}                      {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Spaniel":
                            Console.WriteLine(String.Format("      {0}                    {1}                      {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Beagle":
                            Console.WriteLine(String.Format("      {0}                    {1}                      {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                    }
                }
                else if (hunt.DogId >= 10 && hunt.DogId < 100)
                {
                    switch (hunt.Species)
                    {
                        case "Basset":
                            Console.WriteLine(String.Format("      {0}                   {1}                      {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Basenji":
                            Console.WriteLine(String.Format("      {0}                   {1}                      {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Doga":
                            Console.WriteLine(String.Format("      {0}                   {1}                      {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Hound":
                            Console.WriteLine(String.Format("      {0}                   {1}                           {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Epaniel":
                            Console.WriteLine(String.Format("      {0}                   {1}                         {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Dachshund":
                            Console.WriteLine(String.Format("      {0}                   {1}                       {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Foxhound":
                            Console.WriteLine(String.Format("      {0}                   {1}                        {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Pointer":
                            Console.WriteLine(String.Format("      {0}                   {1}                         {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Bird watcher":
                            Console.WriteLine(String.Format("      {0}                   {1}                    {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Setter":
                            Console.WriteLine(String.Format("      {0}                   {1}                      {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Retriever":
                            Console.WriteLine(String.Format("      {0}                   {1}                      {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Spaniel":
                            Console.WriteLine(String.Format("      {0}                   {1}                      {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Beagle":
                            Console.WriteLine(String.Format("      {0}                   {1}                      {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                    }
                }
                else
                {
                    switch (hunt.Species)
                    {
                        case "Basset":
                            Console.WriteLine(String.Format("      {0}                   {1}                      {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Basenji":
                            Console.WriteLine(String.Format("      {0}                   {1}                      {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Doga":
                            Console.WriteLine(String.Format("      {0}                   {1}                      {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Hound":
                            Console.WriteLine(String.Format("      {0}                   {1}                      {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Epaniel":
                            Console.WriteLine(String.Format("      {0}                   {1}                      {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Dachshund":
                            Console.WriteLine(String.Format("      {0}                   {1}                      {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Foxhound":
                            Console.WriteLine(String.Format("      {0}                   {1}                      {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Pointer":
                            Console.WriteLine(String.Format("      {0}                   {1}                      {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Bird watcher":
                            Console.WriteLine(String.Format("      {0}                   {1}                    {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Setter":
                            Console.WriteLine(String.Format("      {0}                   {1}                          {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Retriever":
                            Console.WriteLine(String.Format("      {0}                   {1}                       {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Spaniel":
                            Console.WriteLine(String.Format("      {0}                   {1}                         {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Beagle":
                            Console.WriteLine(String.Format("      {0}                   {1}                          {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                    }
                }
                Console.WriteLine();
            }
        }

        public void SortingHuntingDogsByNameReverse(List<DisplayDogs> HuntingDogs)
        {

            var huntingdogslist = HuntingDogs.OrderByDescending(huntersort => huntersort.FullName).ToList();

            foreach (var hunt in huntingdogslist)
            {
                if (hunt.DogId >= 1 && hunt.DogId < 10)
                {
                    switch (hunt.Species)
                    {
                        case "Basset":
                            Console.WriteLine(String.Format("      {0}                   {1}                          {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Basenji":
                            Console.WriteLine(String.Format("      {0}                   {1}                         {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Doga":
                            Console.WriteLine(String.Format("      {0}                   {1}                            {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Hound":
                            Console.WriteLine(String.Format("      {0}                   {1}                           {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Epaniel":
                            Console.WriteLine(String.Format("      {0}                   {1}                      {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Dachshund":
                            Console.WriteLine(String.Format("      {0}                   {1}                      {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Foxhound":
                            Console.WriteLine(String.Format("      {0}                   {1}                      {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Pointer":
                            Console.WriteLine(String.Format("      {0}                   {1}                      {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Bird watcher":
                            Console.WriteLine(String.Format("      {0}                    {1}                      {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Setter":
                            Console.WriteLine(String.Format("      {0}                    {1}                      {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Retriever":
                            Console.WriteLine(String.Format("      {0}                    {1}                      {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Spaniel":
                            Console.WriteLine(String.Format("      {0}                    {1}                      {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Beagle":
                            Console.WriteLine(String.Format("      {0}                    {1}                      {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                    }
                }
                else if (hunt.DogId >= 10 && hunt.DogId < 100)
                {
                    switch (hunt.Species)
                    {
                        case "Basset":
                            Console.WriteLine(String.Format("      {0}                   {1}                      {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Basenji":
                            Console.WriteLine(String.Format("      {0}                   {1}                      {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Doga":
                            Console.WriteLine(String.Format("      {0}                   {1}                      {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Hound":
                            Console.WriteLine(String.Format("      {0}                   {1}                           {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Epaniel":
                            Console.WriteLine(String.Format("      {0}                   {1}                         {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Dachshund":
                            Console.WriteLine(String.Format("      {0}                   {1}                       {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Foxhound":
                            Console.WriteLine(String.Format("      {0}                   {1}                        {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Pointer":
                            Console.WriteLine(String.Format("      {0}                   {1}                         {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Bird watcher":
                            Console.WriteLine(String.Format("      {0}                   {1}                    {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Setter":
                            Console.WriteLine(String.Format("      {0}                   {1}                      {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Retriever":
                            Console.WriteLine(String.Format("      {0}                   {1}                      {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Spaniel":
                            Console.WriteLine(String.Format("      {0}                   {1}                      {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Beagle":
                            Console.WriteLine(String.Format("      {0}                   {1}                      {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                    }
                }
                else
                {
                    switch (hunt.Species)
                    {
                        case "Basset":
                            Console.WriteLine(String.Format("      {0}                   {1}                      {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Basenji":
                            Console.WriteLine(String.Format("      {0}                   {1}                      {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Doga":
                            Console.WriteLine(String.Format("      {0}                   {1}                      {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Hound":
                            Console.WriteLine(String.Format("      {0}                   {1}                      {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Epaniel":
                            Console.WriteLine(String.Format("      {0}                   {1}                      {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Dachshund":
                            Console.WriteLine(String.Format("      {0}                   {1}                      {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Foxhound":
                            Console.WriteLine(String.Format("      {0}                   {1}                      {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Pointer":
                            Console.WriteLine(String.Format("      {0}                   {1}                      {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Bird watcher":
                            Console.WriteLine(String.Format("      {0}                   {1}                    {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Setter":
                            Console.WriteLine(String.Format("      {0}                   {1}                          {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Retriever":
                            Console.WriteLine(String.Format("      {0}                   {1}                       {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Spaniel":
                            Console.WriteLine(String.Format("      {0}                   {1}                         {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Beagle":
                            Console.WriteLine(String.Format("      {0}                   {1}                          {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                    }
                }
                Console.WriteLine();
            }
        }

        public void SortingHuntingDogsBySpeciesName(List<DisplayDogs> HuntingDogs)
        {

            var huntingdogslist = HuntingDogs.OrderBy(huntersort => huntersort.Species).OrderBy(huntersort => huntersort.FullName).ToList();

            foreach (var hunt in huntingdogslist)
            {
                if (hunt.DogId >= 1 && hunt.DogId < 10)
                {
                    switch (hunt.Species)
                    {
                        case "Basset":
                            Console.WriteLine(String.Format("      {0}                   {1}                          {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Basenji":
                            Console.WriteLine(String.Format("      {0}                   {1}                         {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Doga":
                            Console.WriteLine(String.Format("      {0}                   {1}                            {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Hound":
                            Console.WriteLine(String.Format("      {0}                   {1}                           {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Epaniel":
                            Console.WriteLine(String.Format("      {0}                   {1}                      {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Dachshund":
                            Console.WriteLine(String.Format("      {0}                   {1}                      {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Foxhound":
                            Console.WriteLine(String.Format("      {0}                   {1}                      {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Pointer":
                            Console.WriteLine(String.Format("      {0}                   {1}                      {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Bird watcher":
                            Console.WriteLine(String.Format("      {0}                    {1}                      {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Setter":
                            Console.WriteLine(String.Format("      {0}                    {1}                      {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Retriever":
                            Console.WriteLine(String.Format("      {0}                    {1}                      {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Spaniel":
                            Console.WriteLine(String.Format("      {0}                    {1}                      {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Beagle":
                            Console.WriteLine(String.Format("      {0}                    {1}                      {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                    }
                }
                else if (hunt.DogId >= 10 && hunt.DogId < 100)
                {
                    switch (hunt.Species)
                    {
                        case "Basset":
                            Console.WriteLine(String.Format("      {0}                   {1}                      {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Basenji":
                            Console.WriteLine(String.Format("      {0}                   {1}                      {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Doga":
                            Console.WriteLine(String.Format("      {0}                   {1}                      {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Hound":
                            Console.WriteLine(String.Format("      {0}                   {1}                           {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Epaniel":
                            Console.WriteLine(String.Format("      {0}                   {1}                         {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Dachshund":
                            Console.WriteLine(String.Format("      {0}                   {1}                       {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Foxhound":
                            Console.WriteLine(String.Format("      {0}                   {1}                        {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Pointer":
                            Console.WriteLine(String.Format("      {0}                   {1}                         {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Bird watcher":
                            Console.WriteLine(String.Format("      {0}                   {1}                    {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Setter":
                            Console.WriteLine(String.Format("      {0}                   {1}                      {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Retriever":
                            Console.WriteLine(String.Format("      {0}                   {1}                      {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Spaniel":
                            Console.WriteLine(String.Format("      {0}                   {1}                      {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Beagle":
                            Console.WriteLine(String.Format("      {0}                   {1}                      {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                    }
                }
                else
                {
                    switch (hunt.Species)
                    {
                        case "Basset":
                            Console.WriteLine(String.Format("      {0}                   {1}                      {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Basenji":
                            Console.WriteLine(String.Format("      {0}                   {1}                      {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Doga":
                            Console.WriteLine(String.Format("      {0}                   {1}                      {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Hound":
                            Console.WriteLine(String.Format("      {0}                   {1}                      {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Epaniel":
                            Console.WriteLine(String.Format("      {0}                   {1}                      {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Dachshund":
                            Console.WriteLine(String.Format("      {0}                   {1}                      {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Foxhound":
                            Console.WriteLine(String.Format("      {0}                   {1}                      {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Pointer":
                            Console.WriteLine(String.Format("      {0}                   {1}                      {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Bird watcher":
                            Console.WriteLine(String.Format("      {0}                   {1}                    {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Setter":
                            Console.WriteLine(String.Format("      {0}                   {1}                          {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Retriever":
                            Console.WriteLine(String.Format("      {0}                   {1}                       {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Spaniel":
                            Console.WriteLine(String.Format("      {0}                   {1}                         {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Beagle":
                            Console.WriteLine(String.Format("      {0}                   {1}                          {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                    }
                }
                Console.WriteLine();
            }
        }

        public void SortingHuntingDogsByReverseSpeciesName(List<DisplayDogs> HuntingDogs)
        {

            var huntingdogslist = HuntingDogs.OrderByDescending(huntersort => huntersort.Species).OrderByDescending(huntersort => huntersort.FullName).ToList();

            foreach (var hunt in huntingdogslist)
            {
                if (hunt.DogId >= 1 && hunt.DogId < 10)
                {
                    switch (hunt.Species)
                    {
                        case "Basset":
                            Console.WriteLine(String.Format("      {0}                   {1}                          {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Basenji":
                            Console.WriteLine(String.Format("      {0}                   {1}                         {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Doga":
                            Console.WriteLine(String.Format("      {0}                   {1}                            {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Hound":
                            Console.WriteLine(String.Format("      {0}                   {1}                           {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Epaniel":
                            Console.WriteLine(String.Format("      {0}                   {1}                      {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Dachshund":
                            Console.WriteLine(String.Format("      {0}                   {1}                      {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Foxhound":
                            Console.WriteLine(String.Format("      {0}                   {1}                      {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Pointer":
                            Console.WriteLine(String.Format("      {0}                   {1}                      {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Bird watcher":
                            Console.WriteLine(String.Format("      {0}                    {1}                      {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Setter":
                            Console.WriteLine(String.Format("      {0}                    {1}                      {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Retriever":
                            Console.WriteLine(String.Format("      {0}                    {1}                      {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Spaniel":
                            Console.WriteLine(String.Format("      {0}                    {1}                      {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Beagle":
                            Console.WriteLine(String.Format("      {0}                    {1}                      {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                    }
                }
                else if (hunt.DogId >= 10 && hunt.DogId < 100)
                {
                    switch (hunt.Species)
                    {
                        case "Basset":
                            Console.WriteLine(String.Format("      {0}                   {1}                      {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Basenji":
                            Console.WriteLine(String.Format("      {0}                   {1}                      {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Doga":
                            Console.WriteLine(String.Format("      {0}                   {1}                      {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Hound":
                            Console.WriteLine(String.Format("      {0}                   {1}                           {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Epaniel":
                            Console.WriteLine(String.Format("      {0}                   {1}                         {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Dachshund":
                            Console.WriteLine(String.Format("      {0}                   {1}                       {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Foxhound":
                            Console.WriteLine(String.Format("      {0}                   {1}                        {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Pointer":
                            Console.WriteLine(String.Format("      {0}                   {1}                         {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Bird watcher":
                            Console.WriteLine(String.Format("      {0}                   {1}                    {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Setter":
                            Console.WriteLine(String.Format("      {0}                   {1}                      {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Retriever":
                            Console.WriteLine(String.Format("      {0}                   {1}                      {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Spaniel":
                            Console.WriteLine(String.Format("      {0}                   {1}                      {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Beagle":
                            Console.WriteLine(String.Format("      {0}                   {1}                      {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                    }
                }
                else
                {
                    switch (hunt.Species)
                    {
                        case "Basset":
                            Console.WriteLine(String.Format("      {0}                   {1}                      {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Basenji":
                            Console.WriteLine(String.Format("      {0}                   {1}                      {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Doga":
                            Console.WriteLine(String.Format("      {0}                   {1}                      {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Hound":
                            Console.WriteLine(String.Format("      {0}                   {1}                      {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Epaniel":
                            Console.WriteLine(String.Format("      {0}                   {1}                      {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Dachshund":
                            Console.WriteLine(String.Format("      {0}                   {1}                      {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Foxhound":
                            Console.WriteLine(String.Format("      {0}                   {1}                      {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Pointer":
                            Console.WriteLine(String.Format("      {0}                   {1}                      {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Bird watcher":
                            Console.WriteLine(String.Format("      {0}                   {1}                    {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Setter":
                            Console.WriteLine(String.Format("      {0}                   {1}                          {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Retriever":
                            Console.WriteLine(String.Format("      {0}                   {1}                       {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Spaniel":
                            Console.WriteLine(String.Format("      {0}                   {1}                         {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Beagle":
                            Console.WriteLine(String.Format("      {0}                   {1}                          {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                    }
                }
                Console.WriteLine();
            }
        }

        public void SortingHuntingDogsBySpeciesReverseName(List<DisplayDogs> HuntingDogs)
        {

            var huntingdogslist = HuntingDogs.OrderByDescending(huntersort => huntersort.Species).OrderBy(huntersort => huntersort.FullName).ToList();

            foreach (var hunt in huntingdogslist)
            {
                if (hunt.DogId >= 1 && hunt.DogId < 10)
                {
                    switch (hunt.Species)
                    {
                        case "Basset":
                            Console.WriteLine(String.Format("      {0}                   {1}                          {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Basenji":
                            Console.WriteLine(String.Format("      {0}                   {1}                         {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Doga":
                            Console.WriteLine(String.Format("      {0}                   {1}                            {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Hound":
                            Console.WriteLine(String.Format("      {0}                   {1}                           {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Epaniel":
                            Console.WriteLine(String.Format("      {0}                   {1}                      {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Dachshund":
                            Console.WriteLine(String.Format("      {0}                   {1}                      {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Foxhound":
                            Console.WriteLine(String.Format("      {0}                   {1}                      {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Pointer":
                            Console.WriteLine(String.Format("      {0}                   {1}                      {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Bird watcher":
                            Console.WriteLine(String.Format("      {0}                    {1}                      {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Setter":
                            Console.WriteLine(String.Format("      {0}                    {1}                      {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Retriever":
                            Console.WriteLine(String.Format("      {0}                    {1}                      {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Spaniel":
                            Console.WriteLine(String.Format("      {0}                    {1}                      {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Beagle":
                            Console.WriteLine(String.Format("      {0}                    {1}                      {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                    }
                }
                else if (hunt.DogId >= 10 && hunt.DogId < 100)
                {
                    switch (hunt.Species)
                    {
                        case "Basset":
                            Console.WriteLine(String.Format("      {0}                   {1}                      {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Basenji":
                            Console.WriteLine(String.Format("      {0}                   {1}                      {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Doga":
                            Console.WriteLine(String.Format("      {0}                   {1}                      {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Hound":
                            Console.WriteLine(String.Format("      {0}                   {1}                           {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Epaniel":
                            Console.WriteLine(String.Format("      {0}                   {1}                         {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Dachshund":
                            Console.WriteLine(String.Format("      {0}                   {1}                       {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Foxhound":
                            Console.WriteLine(String.Format("      {0}                   {1}                        {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Pointer":
                            Console.WriteLine(String.Format("      {0}                   {1}                         {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Bird watcher":
                            Console.WriteLine(String.Format("      {0}                   {1}                    {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Setter":
                            Console.WriteLine(String.Format("      {0}                   {1}                      {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Retriever":
                            Console.WriteLine(String.Format("      {0}                   {1}                      {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Spaniel":
                            Console.WriteLine(String.Format("      {0}                   {1}                      {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Beagle":
                            Console.WriteLine(String.Format("      {0}                   {1}                      {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                    }
                }
                else
                {
                    switch (hunt.Species)
                    {
                        case "Basset":
                            Console.WriteLine(String.Format("      {0}                   {1}                      {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Basenji":
                            Console.WriteLine(String.Format("      {0}                   {1}                      {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Doga":
                            Console.WriteLine(String.Format("      {0}                   {1}                      {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Hound":
                            Console.WriteLine(String.Format("      {0}                   {1}                      {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Epaniel":
                            Console.WriteLine(String.Format("      {0}                   {1}                      {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Dachshund":
                            Console.WriteLine(String.Format("      {0}                   {1}                      {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Foxhound":
                            Console.WriteLine(String.Format("      {0}                   {1}                      {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Pointer":
                            Console.WriteLine(String.Format("      {0}                   {1}                      {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Bird watcher":
                            Console.WriteLine(String.Format("      {0}                   {1}                    {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Setter":
                            Console.WriteLine(String.Format("      {0}                   {1}                          {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Retriever":
                            Console.WriteLine(String.Format("      {0}                   {1}                       {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Spaniel":
                            Console.WriteLine(String.Format("      {0}                   {1}                         {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Beagle":
                            Console.WriteLine(String.Format("      {0}                   {1}                          {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                    }
                }
                Console.WriteLine();
            }
        }

        public void SortingHuntingDogsBySpeciesNameReverse(List<DisplayDogs> HuntingDogs)
        {

            var huntingdogslist = HuntingDogs.OrderBy(huntersort => huntersort.Species).OrderByDescending(huntersort => huntersort.FullName).ToList();

            foreach (var hunt in huntingdogslist)
            {
                if (hunt.DogId >= 1 && hunt.DogId < 10)
                {
                    switch (hunt.Species)
                    {
                        case "Basset":
                            Console.WriteLine(String.Format("      {0}                   {1}                          {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Basenji":
                            Console.WriteLine(String.Format("      {0}                   {1}                         {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Doga":
                            Console.WriteLine(String.Format("      {0}                   {1}                            {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Hound":
                            Console.WriteLine(String.Format("      {0}                   {1}                           {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Epaniel":
                            Console.WriteLine(String.Format("      {0}                   {1}                      {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Dachshund":
                            Console.WriteLine(String.Format("      {0}                   {1}                      {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Foxhound":
                            Console.WriteLine(String.Format("      {0}                   {1}                      {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Pointer":
                            Console.WriteLine(String.Format("      {0}                   {1}                      {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Bird watcher":
                            Console.WriteLine(String.Format("      {0}                    {1}                      {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Setter":
                            Console.WriteLine(String.Format("      {0}                    {1}                      {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Retriever":
                            Console.WriteLine(String.Format("      {0}                    {1}                      {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Spaniel":
                            Console.WriteLine(String.Format("      {0}                    {1}                      {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Beagle":
                            Console.WriteLine(String.Format("      {0}                    {1}                      {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                    }
                }
                else if (hunt.DogId >= 10 && hunt.DogId < 100)
                {
                    switch (hunt.Species)
                    {
                        case "Basset":
                            Console.WriteLine(String.Format("      {0}                   {1}                      {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Basenji":
                            Console.WriteLine(String.Format("      {0}                   {1}                      {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Doga":
                            Console.WriteLine(String.Format("      {0}                   {1}                      {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Hound":
                            Console.WriteLine(String.Format("      {0}                   {1}                           {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Epaniel":
                            Console.WriteLine(String.Format("      {0}                   {1}                         {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Dachshund":
                            Console.WriteLine(String.Format("      {0}                   {1}                       {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Foxhound":
                            Console.WriteLine(String.Format("      {0}                   {1}                        {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Pointer":
                            Console.WriteLine(String.Format("      {0}                   {1}                         {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Bird watcher":
                            Console.WriteLine(String.Format("      {0}                   {1}                    {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Setter":
                            Console.WriteLine(String.Format("      {0}                   {1}                      {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Retriever":
                            Console.WriteLine(String.Format("      {0}                   {1}                      {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Spaniel":
                            Console.WriteLine(String.Format("      {0}                   {1}                      {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Beagle":
                            Console.WriteLine(String.Format("      {0}                   {1}                      {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                    }
                }
                else
                {
                    switch (hunt.Species)
                    {
                        case "Basset":
                            Console.WriteLine(String.Format("      {0}                   {1}                      {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Basenji":
                            Console.WriteLine(String.Format("      {0}                   {1}                      {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Doga":
                            Console.WriteLine(String.Format("      {0}                   {1}                      {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Hound":
                            Console.WriteLine(String.Format("      {0}                   {1}                      {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Epaniel":
                            Console.WriteLine(String.Format("      {0}                   {1}                      {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Dachshund":
                            Console.WriteLine(String.Format("      {0}                   {1}                      {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Foxhound":
                            Console.WriteLine(String.Format("      {0}                   {1}                      {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Pointer":
                            Console.WriteLine(String.Format("      {0}                   {1}                      {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Bird watcher":
                            Console.WriteLine(String.Format("      {0}                   {1}                    {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Setter":
                            Console.WriteLine(String.Format("      {0}                   {1}                          {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Retriever":
                            Console.WriteLine(String.Format("      {0}                   {1}                       {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Spaniel":
                            Console.WriteLine(String.Format("      {0}                   {1}                         {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                        case "Beagle":
                            Console.WriteLine(String.Format("      {0}                   {1}                          {2}", hunt.Breed, hunt.Species, hunt.FullName));
                            break;

                    }
                }
                Console.WriteLine();
            }
        }
    }
}
