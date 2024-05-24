using CSharpProjekt.Animals;
using System.Collections.Generic;

namespace CSharpProjekt.Interfaces
{
    public interface IGreyhound
    {
        void SortingGreyhoundsByName(List<DisplayDogs> greyhound);
        void SortingGreyhoundsByNameReverse(List<DisplayDogs> greyhound);
    }

    public interface IDwarfDog
    {
        void SortingDwarfDogsBySpecies(List<DisplayDogs> dwarfdog);
        void SortingDwarfDogsBySpeciesReverse(List<DisplayDogs> dwarfdog);
        void SortingDwarfDogsByName(List<DisplayDogs> dwarfdog);
        void SortingDwarfDogsByNameReverse(List<DisplayDogs> dwarfdog);
        void SortingDwarfDogsBySpeciesName(List<DisplayDogs> dwarfdog);
        void SortingDwarfDogsByReverseSpeciesName(List<DisplayDogs> dwarfdog);
        void SortingDwarfDogsBySpeciesReverseName(List<DisplayDogs> dwarfdog);
        void SortingDwarfDogsBySpeciesNameReverse(List<DisplayDogs> dwarfdog);
    }

    public interface IFollowerDog
    {
        void SortingFollowerDogsBySpecies(List<DisplayDogs> followerdog);
        void SortingFollowerDogsBySpeciesReverse(List<DisplayDogs> followerdog);
        void SortingFollowerDogsByName(List<DisplayDogs> followerdog);
        void SortingFollowerDogsByNameReverse(List<DisplayDogs> followerdog);
        void SortingFollowerDogsBySpeciesName(List<DisplayDogs> followerdog);
        void SortingFollowerDogsByReverseSpeciesName(List<DisplayDogs> followerdog);
        void SortingFollowerDogsBySpeciesReverseName(List<DisplayDogs> followerdog);
        void SortingFollowerDogsBySpeciesNameReverse(List<DisplayDogs> followerdog);
    }

    public interface IHuntingDog
    {
        void SortingHuntingDogsBySpecies(List<DisplayDogs> huntingdog);
        void SortingHuntingDogsBySpeciesReverse(List<DisplayDogs> huntingdog);
        void SortingHuntingDogsByName(List<DisplayDogs> huntingdog);
        void SortingHuntingDogsByNameReverse(List<DisplayDogs> huntingdog);
        void SortingHuntingDogsBySpeciesName(List<DisplayDogs> huntingdog);
        void SortingHuntingDogsByReverseSpeciesName(List<DisplayDogs> huntingdog);
        void SortingHuntingDogsBySpeciesReverseName(List<DisplayDogs> huntingdog);
        void SortingHuntingDogsBySpeciesNameReverse(List<DisplayDogs> huntingdog);
    }
    
    public interface ITerrier
    {
        void SortingTerriersBySpecies(List<DisplayDogs> terrier);
        void SortingTerriersBySpeciesReverse(List<DisplayDogs> terrier);
        void SortingTerriersByName(List<DisplayDogs> terrier);
        void SortingTerriersByNameReverse(List<DisplayDogs> terrier);
        void SortingTerriersBySpeciesName(List<DisplayDogs> terrier);
        void SortingTerriersByReverseSpeciesName(List<DisplayDogs> terrier);
        void SortingTerriersBySpeciesReverseName(List<DisplayDogs> terrier);
        void SortingTerriersBySpeciesNameReverse(List<DisplayDogs> terrier);
    }
    
    public interface IServiceDog
    {
        void SortingServiceDogsBySpecies(List<DisplayDogs> servicedog);
        void SortingServiceDogsBySpeciesReverse(List<DisplayDogs> servicedog);
        void SortingServiceDogsByName(List<DisplayDogs> servicedog);
        void SortingServiceDogsByNameReverse(List<DisplayDogs> servicedog);
        void SortingServiceDogsBySpeciesName(List<DisplayDogs> servicedog);
        void SortingServiceDogsByReverseSpeciesName(List<DisplayDogs> servicedog);
        void SortingServiceDogsBySpeciesReverseName(List<DisplayDogs> servicedog);
        void SortingServiceDogsBySpeciesNameReverse(List<DisplayDogs> servicedog);
    }
}
