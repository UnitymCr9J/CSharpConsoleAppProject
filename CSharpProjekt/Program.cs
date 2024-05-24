using CSharpProjekt.Animals;
using System;
using System.Text.RegularExpressions;

namespace CSharpProjekt
{
    class Program
    {
        public static void Main(string[] args)
        {
            var quit = false;
            while (!quit)
            {
                Console.WriteLine("Would you like to display or sort data?\nPlease enter one of the numbers that are beside next options:\n");
                Console.WriteLine("1        Sort data\n\n2        Display data\n\n");
                Console.WriteLine("In case you don't want to do either kindly press \"Enter\" or input \"N\" to quit application.");
                var answer = Console.ReadLine();
                Console.WriteLine("\n\n");
                if (answer.ToUpper() == "N" || answer == "")
                {
                    quit = true;
                }
                else if (answer == "1")
                {
                    Console.WriteLine("Kindly choose which list you would like to do sort on.\nFor choosing please enter one of the numbers which are beside next options:\n");
                    Console.WriteLine("1        Greyhounds\n\n2        Dwarf dogs\n\n3        Follower dogs\n\n4        Hunting dogs\n\n5        Terriers\n\n6        Service dogs\n");
                    var answer2 = Console.ReadLine();
                    Console.WriteLine("\n\n");
                    if (answer2 == "1")
                    {
                        Console.WriteLine("How would you like to sort the data?\nPlease enter one of the numbers beside next options:\n");
                        Console.WriteLine("1        Name Ascending\n\n2        Name Descending\n");
                        var answer3 = Console.ReadLine();
                        Console.WriteLine("\n\n");
                        if (answer3 == "1")
                        {
                            Console.WriteLine("   ******************************************************************************************");
                            Console.WriteLine("   *                                   Greyhounds                                           *");
                            Console.WriteLine("   ******************************************************************************************\n\n");
                            SortGreyhoundDogs greyhound = new SortGreyhoundDogs();
                            greyhound.GreyhoundsListSort(answer3);
                            Console.WriteLine("\n\n");
                        }
                        else if (answer3 == "2")
                        {
                            Console.WriteLine("   ******************************************************************************************");
                            Console.WriteLine("   *                                   Greyhounds                                           *");
                            Console.WriteLine("   ******************************************************************************************\n\n");
                            SortGreyhoundDogs greyhound = new SortGreyhoundDogs();
                            greyhound.GreyhoundsListSort(answer3);
                            Console.WriteLine("\n\n");
                        }
                        else
                        {
                            SortGreyhoundDogs greyhound = new SortGreyhoundDogs();
                            greyhound.GreyhoundsListSort(answer3);
                            Console.WriteLine("\n\n");
                        }
                    }
                    else if (answer2 == "2")
                    {
                        Console.WriteLine("How would you like to sort the data?\nPlease enter one of the numbers beside next options:\n");
                        Console.WriteLine("1        Species Ascending\n\n2        Species Descending\n\n3        Name Ascending\n\n4        Name Descending\n\n5        Species Ascending Name Ascending\n\n6        Species Descending Name Descending\n");
                        Console.WriteLine("7        Species Descending Name Ascending\n\n8        Species Ascending Name Descending\n");
                        var answer3 = Console.ReadLine();
                        Console.WriteLine("\n\n");
                        if (answer3 == "1")
                        {
                            Console.WriteLine("   ***********************************************************************************************");
                            Console.WriteLine("   *                                         Dwarf dogs                                          *");
                            Console.WriteLine("   ***********************************************************************************************\n\n");
                            SortDwarfDogs dwarfdog = new SortDwarfDogs();
                            dwarfdog.DwarfDogsListSort(answer3);
                            Console.WriteLine("\n\n");
                        }
                        else if (answer3 == "2")
                        {
                            Console.WriteLine("   ***********************************************************************************************");
                            Console.WriteLine("   *                                         Dwarf dogs                                          *");
                            Console.WriteLine("   ***********************************************************************************************\n\n");
                            SortDwarfDogs dwarfdog = new SortDwarfDogs();
                            dwarfdog.DwarfDogsListSort(answer3);
                            Console.WriteLine("\n\n");
                        }
                        else if (answer3 == "3")
                        {
                            Console.WriteLine("   ***********************************************************************************************");
                            Console.WriteLine("   *                                         Dwarf dogs                                          *");
                            Console.WriteLine("   ***********************************************************************************************\n\n");
                            SortDwarfDogs dwarfdog = new SortDwarfDogs();
                            dwarfdog.DwarfDogsListSort(answer3);
                            Console.WriteLine("\n\n");
                        }
                        else if (answer3 == "4")
                        {
                            Console.WriteLine("   ***********************************************************************************************");
                            Console.WriteLine("   *                                         Dwarf dogs                                          *");
                            Console.WriteLine("   ***********************************************************************************************\n\n");
                            SortDwarfDogs dwarfdog = new SortDwarfDogs();
                            dwarfdog.DwarfDogsListSort(answer3);
                            Console.WriteLine("\n\n");
                        }
                        else if (answer3 == "5")
                        {
                            Console.WriteLine("   ***********************************************************************************************");
                            Console.WriteLine("   *                                         Dwarf dogs                                          *");
                            Console.WriteLine("   ***********************************************************************************************\n\n");
                            SortDwarfDogs dwarfdog = new SortDwarfDogs();
                            dwarfdog.DwarfDogsListSort(answer3);
                            Console.WriteLine("\n\n");
                        }
                        else if (answer3 == "6")
                        {
                            Console.WriteLine("   ***********************************************************************************************");
                            Console.WriteLine("   *                                         Dwarf dogs                                          *");
                            Console.WriteLine("   ***********************************************************************************************\n\n");
                            SortDwarfDogs dwarfdog = new SortDwarfDogs();
                            dwarfdog.DwarfDogsListSort(answer3);
                            Console.WriteLine("\n\n");
                        }
                        else if (answer3 == "7")
                        {
                            Console.WriteLine("   ***********************************************************************************************");
                            Console.WriteLine("   *                                         Dwarf dogs                                          *");
                            Console.WriteLine("   ***********************************************************************************************\n\n");
                            SortDwarfDogs dwarfdog = new SortDwarfDogs();
                            dwarfdog.DwarfDogsListSort(answer3);
                            Console.WriteLine("\n\n");
                        }
                        else if (answer3 == "8")
                        {
                            Console.WriteLine("   ***********************************************************************************************");
                            Console.WriteLine("   *                                         Dwarf dogs                                          *");
                            Console.WriteLine("   ***********************************************************************************************\n\n");
                            SortDwarfDogs dwarfdog = new SortDwarfDogs();
                            dwarfdog.DwarfDogsListSort(answer3);
                            Console.WriteLine("\n\n");
                        }
                        else
                        {
                            SortDwarfDogs dwarfdog = new SortDwarfDogs();
                            dwarfdog.DwarfDogsListSort(answer3);
                            Console.WriteLine("\n\n");
                        }
                    }
                    else if (answer2 == "3")
                    {
                        Console.WriteLine("How would you like to sort the data?\nPlease enter one of the numbers beside next options:\n");
                        Console.WriteLine("1        Species Ascending\n\n2        Species Descending\n\n3        Name Ascending\n\n4        Name Descending\n\n5        Species Ascending Name Ascending\n\n6        Species Descending Name Descending\n");
                        Console.WriteLine("7        Species Descending Name Ascending\n\n8        Species Ascending Name Descending\n");
                        var answer3 = Console.ReadLine();
                        Console.WriteLine("\n\n");
                        if (answer3 == "1")
                        {
                            Console.WriteLine("   ***********************************************************************************************");
                            Console.WriteLine("   *                                        Follower dogs                                        *");
                            Console.WriteLine("   ***********************************************************************************************\n\n");
                            SortFollowerDogs followerdog = new SortFollowerDogs();
                            followerdog.FollowerDogsListSort(answer3);
                            Console.WriteLine("\n\n");
                        }
                        else if (answer3 == "2")
                        {
                            Console.WriteLine("   ***********************************************************************************************");
                            Console.WriteLine("   *                                        Follower dogs                                        *");
                            Console.WriteLine("   ***********************************************************************************************\n\n");
                            SortFollowerDogs followerdog = new SortFollowerDogs();
                            followerdog.FollowerDogsListSort(answer3);
                            Console.WriteLine("\n\n");
                        }
                        else if (answer3 == "3")
                        {
                            Console.WriteLine("   ***********************************************************************************************");
                            Console.WriteLine("   *                                        Follower dogs                                        *");
                            Console.WriteLine("   ***********************************************************************************************\n\n");
                            SortFollowerDogs followerdog = new SortFollowerDogs();
                            followerdog.FollowerDogsListSort(answer3);
                            Console.WriteLine("\n\n");
                        }
                        else if (answer3 == "4")
                        {
                            Console.WriteLine("   ***********************************************************************************************");
                            Console.WriteLine("   *                                        Follower dogs                                        *");
                            Console.WriteLine("   ***********************************************************************************************\n\n");
                            SortFollowerDogs followerdog = new SortFollowerDogs();
                            followerdog.FollowerDogsListSort(answer3);
                            Console.WriteLine("\n\n");
                        }
                        else if (answer3 == "5")
                        {
                            Console.WriteLine("   ***********************************************************************************************");
                            Console.WriteLine("   *                                        Follower dogs                                        *");
                            Console.WriteLine("   ***********************************************************************************************\n\n");
                            SortFollowerDogs followerdog = new SortFollowerDogs();
                            followerdog.FollowerDogsListSort(answer3);
                            Console.WriteLine("\n\n");
                        }
                        else if (answer3 == "6")
                        {
                            Console.WriteLine("   ***********************************************************************************************");
                            Console.WriteLine("   *                                        Follower dogs                                        *");
                            Console.WriteLine("   ***********************************************************************************************\n\n");
                            SortFollowerDogs followerdog = new SortFollowerDogs();
                            followerdog.FollowerDogsListSort(answer3);
                            Console.WriteLine("\n\n");
                        }
                        else if (answer3 == "7")
                        {
                            Console.WriteLine("   ***********************************************************************************************");
                            Console.WriteLine("   *                                        Follower dogs                                        *");
                            Console.WriteLine("   ***********************************************************************************************\n\n");
                            SortFollowerDogs followerdog = new SortFollowerDogs();
                            followerdog.FollowerDogsListSort(answer3);
                            Console.WriteLine("\n\n");
                        }
                        else if (answer3 == "8")
                        {
                            Console.WriteLine("   ***********************************************************************************************");
                            Console.WriteLine("   *                                        Follower dogs                                        *");
                            Console.WriteLine("   ***********************************************************************************************\n\n");
                            SortFollowerDogs followerdog = new SortFollowerDogs();
                            followerdog.FollowerDogsListSort(answer3);
                            Console.WriteLine("\n\n");
                        }
                        else
                        {
                            SortFollowerDogs followerdog = new SortFollowerDogs();
                            followerdog.FollowerDogsListSort(answer3);
                            Console.WriteLine("\n\n");
                        }
                    }
                    else if (answer2 == "4")
                    {
                        Console.WriteLine("How would you like to sort the data?\nPlease enter one of the numbers beside next options:\n");
                        Console.WriteLine("1        Species Ascending\n\n2        Species Descending\n\n3        Name Ascending\n\n4        Name Descending\n\n5        Species Ascending Name Ascending\n\n6        Species Descending Name Descending\n");
                        Console.WriteLine("7        Species Descending Name Ascending\n\n8        Species Ascending Name Descending\n");
                        var answer3 = Console.ReadLine();
                        Console.WriteLine("\n\n");
                        if (answer3 == "1")
                        {
                            Console.WriteLine("   **********************************************************************************************************");
                            Console.WriteLine("   *                                            Hunting dogs                                                *");
                            Console.WriteLine("   **********************************************************************************************************\n\n");
                            SortHuntingDogs huntingdog = new SortHuntingDogs();
                            huntingdog.HuntingDogsListSort(answer3);
                            Console.WriteLine("\n\n");
                        }
                        else if (answer3 == "2")
                        {
                            Console.WriteLine("   **********************************************************************************************************");
                            Console.WriteLine("   *                                            Hunting dogs                                                *");
                            Console.WriteLine("   **********************************************************************************************************\n\n");
                            SortHuntingDogs huntingdog = new SortHuntingDogs();
                            huntingdog.HuntingDogsListSort(answer3);
                            Console.WriteLine("\n\n");
                        }
                        else if (answer3 == "3")
                        {
                            Console.WriteLine("   **********************************************************************************************************");
                            Console.WriteLine("   *                                            Hunting dogs                                                *");
                            Console.WriteLine("   **********************************************************************************************************\n\n");
                            SortHuntingDogs huntingdog = new SortHuntingDogs();
                            huntingdog.HuntingDogsListSort(answer3);
                            Console.WriteLine("\n\n");
                        }
                        else if (answer3 == "4")
                        {
                            Console.WriteLine("   **********************************************************************************************************");
                            Console.WriteLine("   *                                            Hunting dogs                                                *");
                            Console.WriteLine("   **********************************************************************************************************\n\n");
                            SortHuntingDogs huntingdog = new SortHuntingDogs();
                            huntingdog.HuntingDogsListSort(answer3);
                            Console.WriteLine("\n\n");
                        }
                        else if (answer3 == "5")
                        {
                            Console.WriteLine("   **********************************************************************************************************");
                            Console.WriteLine("   *                                            Hunting dogs                                                *");
                            Console.WriteLine("   **********************************************************************************************************\n\n");
                            SortHuntingDogs huntingdog = new SortHuntingDogs();
                            huntingdog.HuntingDogsListSort(answer3);
                            Console.WriteLine("\n\n");
                        }
                        else if (answer3 == "6")
                        {
                            Console.WriteLine("   **********************************************************************************************************");
                            Console.WriteLine("   *                                            Hunting dogs                                                *");
                            Console.WriteLine("   **********************************************************************************************************\n\n");
                            SortHuntingDogs huntingdog = new SortHuntingDogs();
                            huntingdog.HuntingDogsListSort(answer3);
                            Console.WriteLine("\n\n");
                        }
                        else if (answer3 == "7")
                        {
                            Console.WriteLine("   **********************************************************************************************************");
                            Console.WriteLine("   *                                            Hunting dogs                                                *");
                            Console.WriteLine("   **********************************************************************************************************\n\n");
                            SortHuntingDogs huntingdog = new SortHuntingDogs();
                            huntingdog.HuntingDogsListSort(answer3);
                            Console.WriteLine("\n\n");
                        }
                        else if (answer3 == "8")
                        {
                            Console.WriteLine("   **********************************************************************************************************");
                            Console.WriteLine("   *                                            Hunting dogs                                                *");
                            Console.WriteLine("   **********************************************************************************************************\n\n");
                            SortHuntingDogs huntingdog = new SortHuntingDogs();
                            huntingdog.HuntingDogsListSort(answer3);
                            Console.WriteLine("\n\n");
                        }
                        else
                        {
                            SortHuntingDogs huntingdog = new SortHuntingDogs();
                            huntingdog.HuntingDogsListSort(answer3);
                            Console.WriteLine("\n\n");
                        }
                    }
                    else if (answer2 == "5")
                    {
                        Console.WriteLine("How would you like to sort the data?\nPlease enter one of the numbers beside next options:\n");
                        Console.WriteLine("1        Species Ascending\n\n2        Species Descending\n\n3        Name Ascending\n\n4        Name Descending\n\n5        Species Ascending Name Ascending\n\n6        Species Descending Name Descending\n");
                        Console.WriteLine("7        Species Descending Name Ascending\n\n8        Species Ascending Name Descending\n");
                        var answer3 = Console.ReadLine();
                        Console.WriteLine("\n\n");
                        if (answer3 == "1")
                        {
                            Console.WriteLine("   ***********************************************************************************************");
                            Console.WriteLine("   *                                          Terriers                                           *");
                            Console.WriteLine("   ***********************************************************************************************\n\n");
                            SortTerrierDogs terrier = new SortTerrierDogs();
                            terrier.TerriersListSort(answer3);
                            Console.WriteLine("\n\n");
                        }
                        else if (answer3 == "2")
                        {
                            Console.WriteLine("   ***********************************************************************************************");
                            Console.WriteLine("   *                                          Terriers                                           *");
                            Console.WriteLine("   ***********************************************************************************************\n\n");
                            SortTerrierDogs terrier = new SortTerrierDogs();
                            terrier.TerriersListSort(answer3);
                            Console.WriteLine("\n\n");
                        }
                        else if (answer3 == "3")
                        {
                            Console.WriteLine("   ***********************************************************************************************");
                            Console.WriteLine("   *                                          Terriers                                           *");
                            Console.WriteLine("   ***********************************************************************************************\n\n");
                            SortTerrierDogs terrier = new SortTerrierDogs();
                            terrier.TerriersListSort(answer3);
                            Console.WriteLine("\n\n");
                        }
                        else if (answer3 == "4")
                        {
                            Console.WriteLine("   ***********************************************************************************************");
                            Console.WriteLine("   *                                          Terriers                                           *");
                            Console.WriteLine("   ***********************************************************************************************\n\n");
                            SortTerrierDogs terrier = new SortTerrierDogs();
                            terrier.TerriersListSort(answer3);
                            Console.WriteLine("\n\n");
                        }
                        else if (answer3 == "5")
                        {
                            Console.WriteLine("   ***********************************************************************************************");
                            Console.WriteLine("   *                                          Terriers                                           *");
                            Console.WriteLine("   ***********************************************************************************************\n\n");
                            SortTerrierDogs terrier = new SortTerrierDogs();
                            terrier.TerriersListSort(answer3);
                            Console.WriteLine("\n\n");
                        }
                        else if (answer3 == "6")
                        {
                            Console.WriteLine("   ***********************************************************************************************");
                            Console.WriteLine("   *                                          Terriers                                           *");
                            Console.WriteLine("   ***********************************************************************************************\n\n");
                            SortTerrierDogs terrier = new SortTerrierDogs();
                            terrier.TerriersListSort(answer3);
                            Console.WriteLine("\n\n");
                        }
                        else if (answer3 == "7")
                        {
                            Console.WriteLine("   ***********************************************************************************************");
                            Console.WriteLine("   *                                          Terriers                                           *");
                            Console.WriteLine("   ***********************************************************************************************\n\n");
                            SortTerrierDogs terrier = new SortTerrierDogs();
                            terrier.TerriersListSort(answer3);
                            Console.WriteLine("\n\n");
                        }
                        else if (answer3 == "8")
                        {
                            Console.WriteLine("   ***********************************************************************************************");
                            Console.WriteLine("   *                                          Terriers                                           *");
                            Console.WriteLine("   ***********************************************************************************************\n\n");
                            SortTerrierDogs terrier = new SortTerrierDogs();
                            terrier.TerriersListSort(answer3);
                            Console.WriteLine("\n\n");
                        }
                        else
                        {
                            SortTerrierDogs terrier = new SortTerrierDogs();
                            terrier.TerriersListSort(answer3);
                            Console.WriteLine("\n\n");
                        }
                    }
                    else if (answer2 == "6")
                    {
                        Console.WriteLine("How would you like to sort the data?\nPlease enter one of the numbers beside next options:\n");
                        Console.WriteLine("1        Species Ascending\n\n2        Species Descending\n\n3        Name Ascending\n\n4        Name Descending\n\n5        Species Ascending Name Ascending\n\n6        Species Descending Name Descending\n");
                        Console.WriteLine("7        Species Descending Name Ascending\n\n8        Species Ascending Name Descending\n");
                        var answer3 = Console.ReadLine();
                        Console.WriteLine("\n\n");
                        if (answer3 == "1")
                        {
                            Console.WriteLine("   ******************************************************************************************************");
                            Console.WriteLine("   *                                          Service dogs                                              *");
                            Console.WriteLine("   ******************************************************************************************************\n\n");
                            SortServiceDogs servicedog = new SortServiceDogs();
                            servicedog.ServiceDogsListSort(answer3);
                            Console.WriteLine("\n\n");
                        }
                        else if (answer3 == "2")
                        {
                            Console.WriteLine("   ******************************************************************************************************");
                            Console.WriteLine("   *                                          Service dogs                                              *");
                            Console.WriteLine("   ******************************************************************************************************\n\n");
                            SortServiceDogs servicedog = new SortServiceDogs();
                            servicedog.ServiceDogsListSort(answer3);
                            Console.WriteLine("\n\n");
                        }
                        else if (answer3 == "3")
                        {
                            Console.WriteLine("   ******************************************************************************************************");
                            Console.WriteLine("   *                                          Service dogs                                              *");
                            Console.WriteLine("   ******************************************************************************************************\n\n");
                            SortServiceDogs servicedog = new SortServiceDogs();
                            servicedog.ServiceDogsListSort(answer3);
                            Console.WriteLine("\n\n");
                        }
                        else if (answer3 == "4")
                        {
                            Console.WriteLine("   ******************************************************************************************************");
                            Console.WriteLine("   *                                          Service dogs                                              *");
                            Console.WriteLine("   ******************************************************************************************************\n\n");
                            SortServiceDogs servicedog = new SortServiceDogs();
                            servicedog.ServiceDogsListSort(answer3);
                            Console.WriteLine("\n\n");
                        }
                        else if (answer3 == "5")
                        {
                            Console.WriteLine("   ******************************************************************************************************");
                            Console.WriteLine("   *                                          Service dogs                                              *");
                            Console.WriteLine("   ******************************************************************************************************\n\n");
                            SortServiceDogs servicedog = new SortServiceDogs();
                            servicedog.ServiceDogsListSort(answer3);
                            Console.WriteLine("\n\n");
                        }
                        else if (answer3 == "6")
                        {
                            Console.WriteLine("   ******************************************************************************************************");
                            Console.WriteLine("   *                                          Service dogs                                              *");
                            Console.WriteLine("   ******************************************************************************************************\n\n");
                            SortServiceDogs servicedog = new SortServiceDogs();
                            servicedog.ServiceDogsListSort(answer3);
                            Console.WriteLine("\n\n");
                        }
                        else if (answer3 == "7")
                        {
                            Console.WriteLine("   ******************************************************************************************************");
                            Console.WriteLine("   *                                          Service dogs                                              *");
                            Console.WriteLine("   ******************************************************************************************************\n\n");
                            SortServiceDogs servicedog = new SortServiceDogs();
                            servicedog.ServiceDogsListSort(answer3);
                            Console.WriteLine("\n\n");
                        }
                        else if (answer3 == "8")
                        {
                            Console.WriteLine("   ******************************************************************************************************");
                            Console.WriteLine("   *                                          Service dogs                                              *");
                            Console.WriteLine("   ******************************************************************************************************\n\n");
                            SortServiceDogs servicedog = new SortServiceDogs();
                            servicedog.ServiceDogsListSort(answer3);
                            Console.WriteLine("\n\n");
                        }
                        else
                        {
                            SortServiceDogs servicedog = new SortServiceDogs();
                            servicedog.ServiceDogsListSort(answer3);
                            Console.WriteLine("\n\n");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Next time kindly enter one of the available numbers.\n\n");
                    }
                }
                else if (answer == "2")
                {
                    Console.WriteLine("Kindly choose which list you would like to display.\nFor choosing please enter one of the numbers which are beside next options:\n");
                    Console.WriteLine("1        Display All\n\n2        Display Greyhounds\n\n3        Display Dwarf dogs\n\n4        Display Follower dogs\n\n5        Display Hunting dogs\n\n6        Display Terriers\n\n7        Display Service dogs\n");
                    var answer2 = Console.ReadLine();
                    Console.WriteLine("\n\n");
                    if (answer2 == "1")
                    {
                        Console.WriteLine("   ***********************************************************************************************************");
                        Console.WriteLine("   *                                               Greyhounds                                                *");
                        Console.WriteLine("   ***********************************************************************************************************\n\n");
                        Animal.GreyhoundList();
                        Console.WriteLine("\n\n\n\n");
                        Console.WriteLine("   ***********************************************************************************************************");
                        Console.WriteLine("   *                                               Dwarf dogs                                                *");
                        Console.WriteLine("   ***********************************************************************************************************\n\n");
                        Animal.DwarfDogsList();
                        Console.WriteLine("\n\n\n\n");
                        Console.WriteLine("   ***********************************************************************************************************");
                        Console.WriteLine("   *                                             Follower dogs                                               *");
                        Console.WriteLine("   ***********************************************************************************************************\n\n");
                        Animal.FollowerDogsList();
                        Console.WriteLine("\n\n\n\n");
                        Console.WriteLine("   *********************************************************************************************************************");
                        Console.WriteLine("   *                                                 Hunting dogs                                                      *");
                        Console.WriteLine("   *********************************************************************************************************************\n\n");
                        Animal.HuntingDogsList();
                        Console.WriteLine("\n\n\n\n");
                        Console.WriteLine("   ***********************************************************************************************************");
                        Console.WriteLine("   *                                               Terriers                                                  *");
                        Console.WriteLine("   ***********************************************************************************************************\n\n");
                        Animal.TerrierList();
                        Console.WriteLine("\n\n\n\n");
                        Console.WriteLine("   ***********************************************************************************************************");
                        Console.WriteLine("   *                                             Service dogs                                                *");
                        Console.WriteLine("   ***********************************************************************************************************\n\n");
                        Animal.ServiceDogsList();
                        Console.WriteLine("\n\n\n\n");
                    }
                    else if (answer2 == "2")
                    {
                        Console.WriteLine("Please choose one of the 2 options by entering the number that is next to them:\n\n1        Display All Greyhounds\n\n2        Display certain number of Greyhounds\n");
                        var answer3 = Console.ReadLine();
                        Console.WriteLine("\n\n");
                        if (answer3 == "1")
                        {
                            Console.WriteLine("   ***********************************************************************************************************");
                            Console.WriteLine("   *                                               Greyhounds                                                *");
                            Console.WriteLine("   ***********************************************************************************************************\n\n");
                            Animal.GreyhoundList();
                            Console.WriteLine("\n\n");
                        }
                        else if (answer3 == "2")
                        {
                            Console.Write("Please enter how many greyhounds you would like to display: ");
                            var answer4 = Console.ReadLine();
                            Console.WriteLine("\n\n");
                            var check = Regex.IsMatch(answer4, @"^\d+$");
                            if (check == true)
                            {
                                Console.WriteLine("   ***********************************************************************************************************");
                                Console.WriteLine("   *                                               Greyhounds                                                *");
                                Console.WriteLine("   ***********************************************************************************************************\n\n");
                                AnimalSplit.GreyhoundList(answer4);
                                Console.WriteLine("\n\n");
                            }
                            else
                            {
                                Console.WriteLine("Next time kindly enter one of the available numbers.\n\n");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Next time kindly enter one of the available numbers.\n\n");
                        }
                    }
                    else if (answer2 == "3")
                    {
                        Console.WriteLine("Please choose one of the 2 options by entering the number that is next to them:\n\n1        Display All Dwarf dogs\n\n2        Display certain number of Dwarf dogs\n");
                        var answer3 = Console.ReadLine();
                        Console.WriteLine("\n\n");
                        if (answer3 == "1")
                        {
                            Console.WriteLine("   ***********************************************************************************************************");
                            Console.WriteLine("   *                                               Dwarf dogs                                                *");
                            Console.WriteLine("   ***********************************************************************************************************\n\n");
                            Animal.DwarfDogsList();
                            Console.WriteLine("\n\n");
                        }
                        else if (answer3 == "2")
                        {
                            Console.Write("Please enter how many dwarf dogs you would like to display: ");
                            var answer4 = Console.ReadLine();
                            Console.WriteLine("\n\n");
                            var check = Regex.IsMatch(answer4, @"^\d+$");
                            if (check == true)
                            {
                                Console.WriteLine("   ***********************************************************************************************************");
                                Console.WriteLine("   *                                               Dwarf dogs                                                *");
                                Console.WriteLine("   ***********************************************************************************************************\n\n");
                                AnimalSplit.DwarfDogsList(answer4);
                                Console.WriteLine("\n\n");
                            }
                            else
                            {
                                Console.WriteLine("Next time kindly enter one of the available numbers.\n\n");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Next time kindly enter one of the available numbers.\n\n");
                        }
                    }
                    else if (answer2 == "4")
                    {
                        Console.WriteLine("Please choose one of the 2 options by entering the number that is next to them:\n\n1        Display All Follower dogs\n\n2        Display certain number of Follower dogs\n");
                        var answer3 = Console.ReadLine();
                        Console.WriteLine("\n\n");
                        if (answer3 == "1")
                        {
                            Console.WriteLine("   ***********************************************************************************************************");
                            Console.WriteLine("   *                                             Follower dogs                                               *");
                            Console.WriteLine("   ***********************************************************************************************************\n\n");
                            Animal.FollowerDogsList();
                            Console.WriteLine("\n\n");
                        }
                        else if (answer3 == "2")
                        {
                            Console.Write("Please enter how many follower dogs you would like to display: ");
                            var answer4 = Console.ReadLine();
                            Console.WriteLine("\n\n");
                            var check = Regex.IsMatch(answer4, @"^\d+$");
                            if (check == true)
                            {
                                Console.WriteLine("   ***********************************************************************************************************");
                                Console.WriteLine("   *                                             Follower dogs                                               *");
                                Console.WriteLine("   ***********************************************************************************************************\n\n");
                                AnimalSplit.FollowerDogsList(answer4);
                                Console.WriteLine("\n\n");
                            }
                            else
                            {
                                Console.WriteLine("Next time kindly enter one of the available numbers.\n\n");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Next time kindly enter one of the available numbers.\n\n");
                        }
                    }
                    else if (answer2 == "5")
                    {
                        Console.WriteLine("Please choose one of the 2 options by entering the number that is next to them:\n\n1        Display All Hunting dogs\n\n2        Display certain number of Hunting dogs\n");
                        var answer3 = Console.ReadLine();
                        Console.WriteLine("\n\n");
                        if (answer3 == "1")
                        {
                            Console.WriteLine("   *********************************************************************************************************************");
                            Console.WriteLine("   *                                                 Hunting dogs                                                      *");
                            Console.WriteLine("   *********************************************************************************************************************\n\n");
                            Animal.HuntingDogsList();
                            Console.WriteLine("\n\n");
                        }
                        else if (answer3 == "2")
                        {
                            Console.Write("Please enter how many hunting dogs you would like to display: ");
                            var answer4 = Console.ReadLine();
                            Console.WriteLine("\n\n");
                            var check = Regex.IsMatch(answer4, @"^\d+$");
                            if (check == true)
                            {
                                Console.WriteLine("   *********************************************************************************************************************");
                                Console.WriteLine("   *                                                 Hunting dogs                                                      *");
                                Console.WriteLine("   *********************************************************************************************************************\n\n");
                                AnimalSplit.HuntingDogsList(answer4);
                                Console.WriteLine("\n\n");
                            }
                            else
                            {
                                Console.WriteLine("Next time kindly enter one of the available numbers.\n\n");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Next time kindly enter one of the available numbers.\n\n");
                        }
                    }
                    else if (answer2 == "6")
                    {
                        Console.WriteLine("Please choose one of the 2 options by entering the number that is next to them:\n\n1        Display All Terriers\n\n2        Display certain number of Terriers\n");
                        var answer3 = Console.ReadLine();
                        Console.WriteLine("\n\n");
                        if (answer3 == "1")
                        {
                            Console.WriteLine("   ***********************************************************************************************************");
                            Console.WriteLine("   *                                               Terriers                                                  *");
                            Console.WriteLine("   ***********************************************************************************************************\n\n");
                            Animal.TerrierList();
                            Console.WriteLine("\n\n");
                        }
                        else if (answer3 == "2")
                        {
                            Console.Write("Please enter how many terriers you would like to display: ");
                            var answer4 = Console.ReadLine();
                            Console.WriteLine("\n\n");
                            var check = Regex.IsMatch(answer4, @"^\d+$");
                            if (check == true)
                            {
                                Console.WriteLine("   ***********************************************************************************************************");
                                Console.WriteLine("   *                                               Terriers                                                  *");
                                Console.WriteLine("   ***********************************************************************************************************\n\n");
                                AnimalSplit.TerrierList(answer4);
                                Console.WriteLine("\n\n");
                            }
                            else
                            {
                                Console.WriteLine("Next time please enter one of the available numbers.\n\n");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Next time please enter one of the available numbers.\n\n");
                        }
                    }
                    else if (answer2 == "7")
                    {
                        Console.WriteLine("Please choose one of the 2 options by entering the number that is next to them:\n\n1        Display All Service dogs\n\n2        Display certain number of Service dogs\n");
                        var answer3 = Console.ReadLine();
                        Console.WriteLine("\n\n");
                        if (answer3 == "1")
                        {
                            Console.WriteLine("   ***********************************************************************************************************");
                            Console.WriteLine("   *                                             Service dogs                                                *");
                            Console.WriteLine("   ***********************************************************************************************************\n\n");
                            Animal.ServiceDogsList();
                            Console.WriteLine("\n\n");
                        }
                        else if (answer3 == "2")
                        {
                            Console.Write("Please enter how many service dogs you would like to display: ");
                            var answer4 = Console.ReadLine();
                            Console.WriteLine("\n\n");
                            var check = Regex.IsMatch(answer4, @"^\d+$");
                            if (check == true)
                            {
                                Console.WriteLine("   ***********************************************************************************************************");
                                Console.WriteLine("   *                                             Service dogs                                                *");
                                Console.WriteLine("   ***********************************************************************************************************\n\n");
                                AnimalSplit.ServiceDogsList(answer4);
                                Console.WriteLine("\n\n");
                            }
                            else
                            {
                                Console.WriteLine("Next time kindly enter one of the available numbers.\n\n");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Next time kindly enter one of the available numbers.\n\n");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Next time kindly enter one of the available numbers.\n\n");
                    }
                }
                else
                {
                    Console.WriteLine("Next time kindly enter one of the available numbers.\n\n");
                }
            }
        }
    }
}
