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
            placeDungeonItems (startingRoom, heldItems, Singleton.getInstance().Items.regionItems);
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

        void placeDungeonItems (Room startingRoom, List<Item> heldItems, List<Item> regionItems)
        {
            Random rnd = new Random();
            List<string> availableChecks = new List<string>();
            Item itemToPlace;
            string checkToReciveItem;
            foreach (var item in heldItems)
            {
                Console.WriteLine(item);
            }

            while (regionItems.Count() > 0)
            {
                itemToPlace = Singleton.getInstance().Items.verifyItem(regionItems[rnd.Next(regionItems.Count()-1)], regionItems);
                Console.WriteLine("Item to place: " + itemToPlace);
                heldItems.Remove(itemToPlace);
                regionItems.Remove(itemToPlace);
                availableChecks = listAllAvailableDungeonChecks(startingRoom, itemToPlace);
                checkToReciveItem = availableChecks[rnd.Next(availableChecks.Count()-1)];
                
                Singleton.getInstance().Checks.placeItemInCheck(itemToPlace,checkToReciveItem);

                availableChecks.Remove(checkToReciveItem);
            }
            if (regionItems.Count() > 0)
            {//no more available checks and still items to place, starting over
                //failsafe: assumed fill can fail, but rarely, so it is best to start over if it happens
                startOver(startingRoom);
            }
        }

        List<Room> listofRegionRooms(string itemToPlace)
        {
            List<Room> regionRooms = new List<Room>();
            if (itemToPlace.Contains("Forest_Temple"))
            {
                foreach (KeyValuePair<string, Room> room in Singleton.getInstance().Rooms.RoomDict)
                {
                    if (room.Value.region == "Forest Temple")
                    {
                        regionRooms.Add(room.Value);
                    }
                }
            }
            else if (itemToPlace.Contains("Goron_Mines"))
            {
                foreach (KeyValuePair<string, Room> room in Singleton.getInstance().Rooms.RoomDict)
                {
                    if (room.Value.region == "Goron Mines")
                    {
                        regionRooms.Add(room.Value);
                    }
                }
            }
            else if (itemToPlace.Contains("Lakebed_Temple"))
            {
                foreach (KeyValuePair<string, Room> room in Singleton.getInstance().Rooms.RoomDict)
                {
                    if (room.Value.region == "Lakebed Temple")
                    {
                        regionRooms.Add(room.Value);
                    }
                }
            }
            else if (itemToPlace.Contains("Arbiters_Grounds"))
            {
                foreach (KeyValuePair<string, Room> room in Singleton.getInstance().Rooms.RoomDict)
                {
                    if (room.Value.region == "Arbiters Grounds")
                    {
                        regionRooms.Add(room.Value);
                    }
                }
            }
            else if (itemToPlace.Contains("Snowpeak_Ruins"))
            {
                foreach (KeyValuePair<string, Room> room in Singleton.getInstance().Rooms.RoomDict)
                {
                    if (room.Value.region == "Snowpeak Ruins")
                    {
                        regionRooms.Add(room.Value);
                    }
                }
            }
            else if (itemToPlace.Contains("Temple_of_Time"))
            {
                foreach (KeyValuePair<string, Room> room in Singleton.getInstance().Rooms.RoomDict)
                {
                    if (room.Value.region == "Temple of Time")
                    {
                        regionRooms.Add(room.Value);
                    }
                }
            }
            else if (itemToPlace.Contains("City_in_The_Sky"))
            {
                foreach (KeyValuePair<string, Room> room in Singleton.getInstance().Rooms.RoomDict)
                {
                    if (room.Value.region == "City in The Sky")
                    {
                        regionRooms.Add(room.Value);
                    }
                }
            }
            else if (itemToPlace.Contains("Palace_of_Twilight"))
            {
                foreach (KeyValuePair<string, Room> room in Singleton.getInstance().Rooms.RoomDict)
                {
                    if (room.Value.region == "Palace of Twilight")
                    {
                        regionRooms.Add(room.Value);
                    }
                }
            }
            else if (itemToPlace.Contains("Hyrule_Castle"))
            {
                foreach (KeyValuePair<string, Room> room in Singleton.getInstance().Rooms.RoomDict)
                {
                    if (room.Value.region == "Hyrule Castle")
                    {
                        regionRooms.Add(room.Value);
                    }
                }
            }
            return regionRooms;
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
            List<Room> roomsToExplore = listofRegionRooms(itemToPlace.ToString());
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
    }
}