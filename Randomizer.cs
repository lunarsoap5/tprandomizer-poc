using System;
using System.Linq;
using System.Reflection;
using Newtonsoft.Json;
using System.IO;
using Logic;
using System.Collections.Generic;
using Microsoft.CodeAnalysis.CSharp.Scripting;
using Microsoft.CodeAnalysis.Scripting;
using System.Text.RegularExpressions;
using System.CodeDom.Compiler;
using System.Diagnostics.CodeAnalysis;

namespace tprandomizer_poc_main
{ 
    public class Randomizer
    {
        LogicFunctions Logic = new LogicFunctions();
        public void start()
        {
            Singleton.getInstance().Checks.InitializeChecks();
            Singleton.getInstance().Checks.deserializeChecks();

            Singleton.getInstance().Rooms.InitializeRooms();
            Singleton.getInstance().Rooms.deserializeRooms();
            
            Singleton.getInstance().Items.generateItemPool();

            Room startingRoom = Singleton.getInstance().Rooms.setupGraph();
            placeItemsInWorld(startingRoom, Singleton.getInstance().Items.heldItems);

            
                
                //myJsonObject.requirements = Regex.Replace(myJsonObject.requirements, @"\bLogic\b", "Logic.LogicFunctions");
                //var options = ScriptOptions.Default.AddReferences(typeof(LogicFunctions).Assembly).AddImports("Assets.Items");
                //var now = CSharpScript.EvaluateAsync(myJsonObject.requirements, options).Result;
        }

        void startOver(Room startingRoom)
        {
            Console.WriteLine("Starting Over.");
            ItemFunctions.nbSkybooksPlaced = 0;
            Singleton.getInstance().Items.generateItemPool();
            Singleton.getInstance().Checks.deserializeChecks();

            placeItemsInWorld(startingRoom, Singleton.getInstance().Items.heldItems);
        }

        void placeItemsInWorld(Room startingRoom, List<Item> heldItems)
        {

            //First we want to replace items that are locked in their respective dungeon
            placeDungeonItems (startingRoom);
            Random rnd = new Random();
            List<string> availableChecks = new List<string>();
            Item itemToPlace;
            string checkToReciveItem;
            foreach (var item in heldItems)
            {
                Console.WriteLine(item);
            }
            List<Item> ItemsToBeRandomized = Singleton.getInstance().Items.ImportantItems;

            while (ItemsToBeRandomized.Count() > 0)
            {
                itemToPlace = Singleton.getInstance().Items.verifyItem(ItemsToBeRandomized[rnd.Next(ItemsToBeRandomized.Count()-1)], ItemsToBeRandomized);
                Console.WriteLine("Item to place: " + itemToPlace);
                heldItems.Remove(itemToPlace);
                ItemsToBeRandomized.Remove(itemToPlace);
                availableChecks = listAllAvailableChecks(startingRoom);
                
                checkToReciveItem = availableChecks[rnd.Next(availableChecks.Count()-1)];

                //Commented out because it is obsolete
               /* while (!Singleton.getInstance().Checks.checkIfItemNotNeededToReachCheck(itemToPlace, checkToReciveItem, startingRoom))
                {
                    checkToReciveItem = availableChecks[rnd.Next(availableChecks.Count()-1)];
                }*/
                //Singleton.getInstance().Items.heldItems.Add(itemToPlace);
                Singleton.getInstance().Checks.placeItemInCheck(itemToPlace,checkToReciveItem);

                availableChecks.Remove(checkToReciveItem);
            }
            if (ItemsToBeRandomized.Count() > 0)
            {//no more available checks and still items to place, starting over
                //failsafe: assumed fill can fail, but rarely, so it is best to start over if it happens
                startOver(startingRoom);
            }
        }

        void placeDungeonItems (Room startingRoom)
        {
            Random rnd = new Random();
            List<string> availableChecks = new List<string>();
            Item itemToPlace;
            string checkToReciveItem;
            foreach (var item in Singleton.getInstance().Items.heldItems)
            {
                Console.WriteLine(item);
            }

            while (Singleton.getInstance().Items.regionItems.Count() > 0)
            {
                itemToPlace = Singleton.getInstance().Items.verifyItem(Singleton.getInstance().Items.regionItems[rnd.Next(Singleton.getInstance().Items.regionItems.Count()-1)], Singleton.getInstance().Items.regionItems);
                Console.WriteLine("Item to place: " + itemToPlace);
                Singleton.getInstance().Items.heldItems.Remove(itemToPlace);
                Singleton.getInstance().Items.regionItems.Remove(itemToPlace);
                foreach (var item in Singleton.getInstance().Items.heldItems)
			{
				Console.WriteLine(item);
			}
                availableChecks = listAllAvailableDungeonChecks(startingRoom, itemToPlace);
                checkToReciveItem = availableChecks[rnd.Next(availableChecks.Count()-1)];
                
                Singleton.getInstance().Checks.placeItemInCheck(itemToPlace,checkToReciveItem);

                availableChecks.Remove(checkToReciveItem);
            }
            if (Singleton.getInstance().Items.regionItems.Count() > 0)
            {//no more available checks and still items to place, starting over
                //failsafe: assumed fill can fail, but rarely, so it is best to start over if it happens
                startOver(startingRoom);
            }
        }

        Room getDungeonEntrance(string itemToPlace)
        {
            Room regionRoom = new Room();
            if (itemToPlace.Contains("Forest_Temple"))
            {
                regionRoom = Singleton.getInstance().Rooms.RoomDict["Forest Temple 22"];
            }
            else if (itemToPlace.Contains("Goron_Mines"))
            {
              regionRoom = Singleton.getInstance().Rooms.RoomDict["Goron Mines 01"];
            }
            else if (itemToPlace.Contains("Lakebed_Temple"))
            {
                regionRoom = Singleton.getInstance().Rooms.RoomDict["Lakebed Temple 00 01"];
            }
            else if (itemToPlace.Contains("Arbiters_Grounds"))
            {
                regionRoom = Singleton.getInstance().Rooms.RoomDict["Arbiters Grounds 00"];
            }
            else if (itemToPlace.Contains("Snowpeak_Ruins"))
            {
                regionRoom = Singleton.getInstance().Rooms.RoomDict["Snowpeak Ruins 00 01 02 03"];
            }
            else if (itemToPlace.Contains("Temple_of_Time"))
            {
               regionRoom = Singleton.getInstance().Rooms.RoomDict["Temple of Time 00"];
            }
            else if (itemToPlace.Contains("City_in_The_Sky"))
            {
                regionRoom = Singleton.getInstance().Rooms.RoomDict["City in The Sky 00 16"];
            }
            else if (itemToPlace.Contains("Palace_of_Twilight"))
            {
                regionRoom = Singleton.getInstance().Rooms.RoomDict["Palace of Twilight 00 01"];
            }
            else if (itemToPlace.Contains("Hyrule_Castle"))
            {
                regionRoom = Singleton.getInstance().Rooms.RoomDict["Hyrule Castle 11"];
            }
            return regionRoom;
        }

        bool isInDungeonRegion( string itemToPlace, Room currentNeighbour)
        {
            if (itemToPlace.Contains("Forest_Temple") && (currentNeighbour.region == "Forest Temple"))
            {
                return true;
            }
            else if (itemToPlace.Contains("Goron_Mines") && (currentNeighbour.region == "Goron Mines"))
            {
              return true;
            }
            else if (itemToPlace.Contains("Lakebed_Temple") && (currentNeighbour.region == "Lakebed Temple"))
            {
                return true;
            }
            else if (itemToPlace.Contains("Arbiters_Grounds") && (currentNeighbour.region == "Arbiters Grounds"))
            {
                return true;
            }
            else if (itemToPlace.Contains("Snowpeak_Ruins") && (currentNeighbour.region == "Snowpeak Ruins"))
            {
                return true;
            }
            else if (itemToPlace.Contains("Temple_of_Time") && (currentNeighbour.region == "Temple of Time"))
            {
               return true;
            }
            else if (itemToPlace.Contains("City_in_The_Sky") && (currentNeighbour.region == "City in The Sky"))
            {
                return true;
            }
            else if (itemToPlace.Contains("Palace_of_Twilight") && (currentNeighbour.region == "Palace of Twilight"))
            {
                return true;
            }
            else if (itemToPlace.Contains("Hyrule_Castle") && (currentNeighbour.region == "Hyrule Castle"))
            {
                return true;
            }
            return false;
        }
        
        public List<string> listAllAvailableChecks(Room startingRoom)
        {
            Singleton.getInstance().Rooms.resetAllRoomsVisited();
            List<string> roomChecks = new List<string>();
            List<Room> roomsToExplore = new List<Room>();
            startingRoom.visited = true;
            roomsToExplore.Add(startingRoom);
            var options = ScriptOptions.Default.AddReferences(typeof(LogicFunctions).Assembly).AddImports("tprandomizer_poc_main");
                
            while (roomsToExplore.Count() > 0)
            {
                Console.WriteLine("Currently exploring: " + roomsToExplore[0].name);
                for (int i = 0; i < roomsToExplore[0].neighbours.Count(); i++)
                {
                   //Parse the neighbour's requirements to find out if we can access it
                    var areNeighbourRequirementsMet = CSharpScript.EvaluateAsync(roomsToExplore[0].neighbourRequirements[i], options).Result;
                    //If you can access the neighbour and it hasnt been visited yet.
                    if ((((bool)areNeighbourRequirementsMet == true)) &&  (Singleton.getInstance().Rooms.RoomDict[roomsToExplore[0].neighbours[i]].visited == false))
                    {
                        Room currentNeighbour = Singleton.getInstance().Rooms.RoomDict[roomsToExplore[0].neighbours[i]];
                        currentNeighbour.visited = true;
                        Console.WriteLine("Neighbour: " + currentNeighbour.name + " added to room list.");
                        roomsToExplore.Add(currentNeighbour);
                    }
                }
                for (int i = 0; i < roomsToExplore[0].checks.Count(); i++)
                {
                    //Create reference to the dictionary entry of the check whose logic we are evaluating
                    Check currentCheck;
                    if (!Singleton.getInstance().Checks.CheckDict.TryGetValue(roomsToExplore[0].checks[i], out currentCheck)) 
                    {
                        if (roomsToExplore[0].checks[i].ToString() == "")
                        {
                            Console.WriteLine("Room has no checks, continuing on....");
                            break;
                        }
                        Console.WriteLine("Check: " + roomsToExplore[0].checks[i] + " does not exist.");
                    }
                    //Parse the requirements to see if we can get the check
                    var areCheckRequirementsMet = CSharpScript.EvaluateAsync(currentCheck.requirements, options).Result;
                    //Confirms that we can get the check and checks to see if an item was placed in it.
                    if (((bool)areCheckRequirementsMet == true) && currentCheck.itemWasPlaced == false)
                    {
                        roomChecks.Add(currentCheck.checkName);
                    }
                }
                Logic.checkBossFlags(roomsToExplore[0]);
                roomsToExplore.Remove(roomsToExplore[0]);
            }
            return roomChecks;
        }  

        public List<string> listAllAvailableDungeonChecks(Room startingRoom, Item itemToPlace)
        {
            Singleton.getInstance().Rooms.resetAllRoomsVisited();
            List<string> roomChecks = new List<string>();
            List<Item> playthroughItems = new List<Item>();
            List<Room> roomsToExplore = new List<Room>(); 
            roomsToExplore.Add(getDungeonEntrance(itemToPlace.ToString()));
            roomsToExplore[0].visited = true;
            Console.WriteLine(roomsToExplore[0].name);
            var options = ScriptOptions.Default.AddReferences(typeof(LogicFunctions).Assembly).AddImports("tprandomizer_poc_main");
                
            while (roomsToExplore.Count() > 0)
            {
                if (roomsToExplore[0].visited)
                {
                    Console.WriteLine("Currently exploring: " + roomsToExplore[0].name);
                    for (int i = 0; i < roomsToExplore[0].checks.Count(); i++)
                    {
                        //Create reference to the dictionary entry of the check whose logic we are evaluating
                        Check currentCheck;
                        if (!Singleton.getInstance().Checks.CheckDict.TryGetValue(roomsToExplore[0].checks[i], out currentCheck)) 
                        {
                            if (roomsToExplore[0].checks[i].ToString() == "")
                            {
                                Console.WriteLine("Room has no checks, continuing on....");
                                break;
                            }
                            Console.WriteLine("Check: " + roomsToExplore[0].checks[i] + " does not exist.");
                        }
                        //Parse the requirements to see if we can get the check
                        var areCheckRequirementsMet = CSharpScript.EvaluateAsync(currentCheck.requirements, options).Result;
                        //Confirms that we can get the check and checks to see if an item was placed in it.
                        if (((bool)areCheckRequirementsMet == true))
                        {
                            if (!currentCheck.itemWasPlaced)
                            {
                                roomChecks.Add(currentCheck.checkName);
                            }
                            else
                            {
                                Singleton.getInstance().Items.heldItems.Add(currentCheck.itemId);
                                playthroughItems.Add(currentCheck.itemId);
                            }
                        }
                    }
                    for (int i = 0; i < roomsToExplore[0].neighbours.Count(); i++)
                    {
                    //Parse the neighbour's requirements to find out if we can access it
                        var areNeighbourRequirementsMet = CSharpScript.EvaluateAsync(roomsToExplore[0].neighbourRequirements[i], options).Result;
                        //If you can access the neighbour and it hasnt been visited yet.
                        if ((((bool)areNeighbourRequirementsMet == true)) &&  (Singleton.getInstance().Rooms.RoomDict[roomsToExplore[0].neighbours[i]].visited == false) && isInDungeonRegion(itemToPlace.ToString(), Singleton.getInstance().Rooms.RoomDict[roomsToExplore[0].neighbours[i]]))
                        {
                            Room currentNeighbour = Singleton.getInstance().Rooms.RoomDict[roomsToExplore[0].neighbours[i]];
                            currentNeighbour.visited = true;
                            Console.WriteLine("Neighbour: " + currentNeighbour.name + " added to room list.");
                            roomsToExplore.Add(currentNeighbour);
                        }
                    }
                }
                Logic.checkBossFlags(roomsToExplore[0]);
                roomsToExplore.Remove(roomsToExplore[0]);
            }
            foreach (var newItem in playthroughItems)
            {
                Singleton.getInstance().Items.heldItems.Remove(newItem);
            }
            return roomChecks;
        }  
    }
}