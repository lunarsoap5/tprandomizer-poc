using System;
using System.Linq;
using System.Reflection;
using Newtonsoft.Json;
using System.IO;
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
        RoomFunctions Rooms = new RoomFunctions();
        CheckFunctions Checks = new CheckFunctions();
        public ScriptOptions options = ScriptOptions.Default.AddReferences(typeof(LogicFunctions).Assembly).AddImports("tprandomizer_poc_main");
        public void start()
        {
            Checks.InitializeChecks();
            deserializeChecks();

            Rooms.InitializeRooms();
            deserializeRooms();
            
            Singleton.getInstance().Items.generateItemPool();

            Room startingRoom = setupGraph();
            placeItemsInWorld(startingRoom);

            
                
                //myJsonObject.requirements = Regex.Replace(myJsonObject.requirements, @"\bLogic\b", "Logic.LogicFunctions");
                //var options = ScriptOptions.Default.AddReferences(typeof(LogicFunctions).Assembly).AddImports("Assets.Items");
                //var now = CSharpScript.EvaluateAsync(myJsonObject.requirements, options).Result;
        }

        public Room setupGraph()
        {
            resetAllRoomsVisited();
            Room startingRoom = Rooms.RoomDict["Arbiters Grounds 00"];
            startingRoom.isStartingRoom = true;
            Rooms.RoomDict["Arbiters Grounds 00"] = startingRoom;

            List<string> roomChecks = new List<string>();
            List<Item> playthroughItems = new List<Item>();
            List<Room> roomsToExplore = new List<Room>();
            startingRoom.visited = true;
            roomsToExplore.Add(startingRoom);
                
            while (roomsToExplore.Count() > 0)
            {
                if (roomsToExplore[0].visited)
                {
                    Console.WriteLine("Currently exploring: " + roomsToExplore[0].name);
                    
                    for (int i = 0; i < roomsToExplore[0].neighbours.Count(); i++)
                    {
                    //Parse the neighbour's requirements to find out if we can access it
                        if ((Rooms.RoomDict[roomsToExplore[0].neighbours[i]].visited == false))
                        {
                            Room currentNeighbour = Rooms.RoomDict[roomsToExplore[0].neighbours[i]];
                            currentNeighbour.visited = true;
                            Console.WriteLine("Neighbour: " + currentNeighbour.name + " added to room list.");
                            if (roomsToExplore[0].accessRequirements != null)
                            {
                                currentNeighbour.accessRequirements = "(" + roomsToExplore[0].accessRequirements + ")" +  " and " +  "(" + roomsToExplore[0].neighbourRequirements[i] + ")";
                            }
                            else
                            {
                                currentNeighbour.accessRequirements = "(" + roomsToExplore[0].neighbourRequirements[i] + ")";
                            }
                            for (int j = 0; j < currentNeighbour.checks.Count(); j++)
                            {
                                Check currentCheck;
                                if (!Checks.CheckDict.TryGetValue(currentNeighbour.checks[j], out currentCheck)) 
                                {
                                    Console.WriteLine("Room has no checks, continuing on....");
                                }
                                if (!(currentNeighbour.checks[j].ToString() == ""))
                                {
                                    currentCheck.requirements = "(" + currentCheck.requirements + ")" +  " and " +  "(" + currentNeighbour.accessRequirements + ")";
                                }
                                
                            }
                            roomsToExplore.Add(currentNeighbour);
                        }
                    }
                    roomsToExplore.Remove(roomsToExplore[0]);
                }
            }
            foreach (KeyValuePair<string, Check> checkList in Checks.CheckDict.ToList())
            {
                Check currentCheck = checkList.Value;
                currentCheck.requirements = "(" + currentCheck.requirements + ")";
                Checks.CheckDict[checkList.Key] = currentCheck;
            }
            return startingRoom;
        }

        public void resetAllRoomsVisited()
        {
            foreach (KeyValuePair<string, Room> roomList in Rooms.RoomDict.ToList())
            {
                Room currentRoom = roomList.Value;
                currentRoom.visited = false;
                Rooms.RoomDict[roomList.Key] = currentRoom;
            }
            return;
        }

        public void resetAllChecksVisited()
        {
            foreach (KeyValuePair<string, Check> checkList in Checks.CheckDict.ToList())
            {
                Check currentCheck = checkList.Value;
                currentCheck.hasBeenReached = false;
                Checks.CheckDict[checkList.Key] = currentCheck;
            }
            return;
        }

        void startOver(Room startingRoom)
        {
            Console.WriteLine("Starting Over.");
            ItemFunctions.nbSkybooksPlaced = 0;
            Singleton.getInstance().Items.generateItemPool();
            deserializeChecks();
            placeItemsInWorld(startingRoom);
        }

        void placeItemsInWorld(Room startingRoom)
        {
            //First we want to replace items that are locked in their respective dungeon
            placeDungeonItems (startingRoom, Singleton.getInstance().Items.heldItems, Singleton.getInstance().Items.regionItems);
            placeImportantItems(startingRoom, Singleton.getInstance().Items.heldItems, Singleton.getInstance().Items.ImportantItems);
            return;
        }

        void placeDungeonItems (Room startingRoom, List<Item> heldItems, List<Item> ItemsToBeRandomized)
        {
            Random rnd = new Random();
            List<string> availableChecks = new List<string>();
            Item itemToPlace;
            Check checkToReciveItem;
            

            while (ItemsToBeRandomized.Count() > 0)
            {
                itemToPlace = Singleton.getInstance().Items.verifyItem(ItemsToBeRandomized[rnd.Next(ItemsToBeRandomized.Count()-1)], ItemsToBeRandomized);
                Console.WriteLine("Item to place: " + itemToPlace);
                heldItems.Remove(itemToPlace);
                ItemsToBeRandomized.Remove(itemToPlace);
                availableChecks = listAllAvailableDungeonChecks(startingRoom, itemToPlace);
                checkToReciveItem = Checks.CheckDict[availableChecks[rnd.Next(availableChecks.Count()-1)].ToString()];
                
                placeItemInCheck(itemToPlace,checkToReciveItem);

                availableChecks.Clear();
            }
            if (ItemsToBeRandomized.Count() > 0)
            {//no more available checks and still items to place, starting over
                //failsafe: assumed fill can fail, but rarely, so it is best to start over if it happens
                startOver(startingRoom);
            }
            return;
        }
      public List<string> listAllAvailableDungeonChecks(Room startingRoom, Item itemToPlace)
        {
            resetAllChecksVisited();
            List<string> roomChecks = new List<string>();
            List<Item> playthroughItems = new List<Item>();
    
            restart: 
            foreach (KeyValuePair<string, Check> checkList in Checks.CheckDict.ToList())
            {
                //Parse through every check to see if an item has been placed in it
                Check currentCheck = checkList.Value;
                if (currentCheck.itemWasPlaced && (!currentCheck.hasBeenReached))
                {
                    //If the check has an item in it and has not been collected, we need to see if we can get the item.
                    //var areCheckRequirementsMet = CSharpScript.EvaluateAsync(currentCheck.requirements, options).Result;
                    Console.WriteLine("Checking Logic for check: " + currentCheck.checkName);
                    var areCheckRequirementsMet = evaluateRequirements(currentCheck.requirements);
                    if ((bool)areCheckRequirementsMet == true)
                    {
                        //If we can get the item, we add it to our inventory and restart our search since we may be able to get more placed items with our new item pool
                        Singleton.getInstance().Items.heldItems.Add(currentCheck.itemId);
                        playthroughItems.Add(currentCheck.itemId);
                        currentCheck.hasBeenReached = true;
                        GC.Collect();
                        goto restart;
                    }
                }
            }
            foreach (KeyValuePair<string, Check> checkList in Checks.CheckDict.ToList())
            {
                Check currentCheck = checkList.Value;
                //Confirms that we can get the check and checks to see if an item was placed in it.
                if (isDungeonCheck(itemToPlace.ToString(), currentCheck))
                {
                    Console.WriteLine("Checking Logic for check: " + currentCheck.checkName);
                    Console.WriteLine("Checking Logic...");
                    //var areCheckRequirementsMet = CSharpScript.EvaluateAsync(currentCheck.requirements, options).Result;
                    var areCheckRequirementsMet = evaluateRequirements(currentCheck.requirements);
                    Console.WriteLine("Can get check: " + currentCheck.checkName + " " + areCheckRequirementsMet);
                    if (((bool)areCheckRequirementsMet == true) && (!currentCheck.itemWasPlaced))
                    {
                        roomChecks.Add(currentCheck.checkName);
                    }
                }
            }
            foreach (var newItem in playthroughItems)
            {
                Singleton.getInstance().Items.heldItems.Remove(newItem);
            }
            return roomChecks;
        }  


        void placeImportantItems (Room startingRoom, List<Item> heldItems, List<Item> ItemsToBeRandomized)
        {
            Random rnd = new Random();
            List<string> availableChecks = new List<string>();
            Item itemToPlace;
            Check checkToReciveItem;

            while (ItemsToBeRandomized.Count() > 0)
            {
                itemToPlace = Singleton.getInstance().Items.verifyItem(ItemsToBeRandomized[rnd.Next(ItemsToBeRandomized.Count()-1)], ItemsToBeRandomized);
                Console.WriteLine("Item to place: " + itemToPlace);
                heldItems.Remove(itemToPlace);
                ItemsToBeRandomized.Remove(itemToPlace);
                availableChecks = listAllAvailableChecks(startingRoom, itemToPlace);
                
                checkToReciveItem = Checks.CheckDict[availableChecks[rnd.Next(availableChecks.Count()-1)].ToString()];
                placeItemInCheck(itemToPlace,checkToReciveItem);

                availableChecks.Clear();
                GC.Collect();
            }
            if (ItemsToBeRandomized.Count() > 0)
            {//no more available checks and still items to place, starting over
                //failsafe: assumed fill can fail, but rarely, so it is best to start over if it happens
                startOver(startingRoom);
            }
            return;
        }

        
        
        public List<string> listAllAvailableChecks(Room startingRoom, Item itemToPlace)
        {
            resetAllChecksVisited();
            List<string> roomChecks = new List<string>();
            List<Item> playthroughItems = new List<Item>();
            var areCheckRequirementsMet = false;
            Check currentCheck;
    
            restart: 
            foreach (KeyValuePair<string, Check> checkList in Checks.CheckDict.ToList())
            {
                //Parse through every check to see if an item has been placed in it
                currentCheck = checkList.Value;
                if (currentCheck.itemWasPlaced && (!currentCheck.hasBeenReached))
                {
                    //If the check has an item in it and has not been collected, we need to see if we can get the item.
                    areCheckRequirementsMet = (bool)CSharpScript.EvaluateAsync(currentCheck.requirements, options).Result;
                    if (areCheckRequirementsMet == true)
                    {
                        //If we can get the item, we add it to our inventory and restart our search since we may be able to get more placed items with our new item pool
                        Singleton.getInstance().Items.heldItems.Add(currentCheck.itemId);
                        playthroughItems.Add(currentCheck.itemId);
                        currentCheck.hasBeenReached = true;
                        GC.Collect();
                        goto restart;
                    }
                }
            }
            foreach (KeyValuePair<string, Check> checkList in Checks.CheckDict.ToList())
            {
                currentCheck = checkList.Value;
                if (!currentCheck.itemWasPlaced)
                {
                    //If the check is empty, we want to see if we can get it
                    areCheckRequirementsMet = (bool)CSharpScript.EvaluateAsync(currentCheck.requirements, options).Result;
                    if (areCheckRequirementsMet == true)
                    {
                        //If we can get the check, we want to add it to the list of available checks
                        roomChecks.Add(currentCheck.checkName);
                    }
                }
                GC.Collect();
            }
            foreach (var newItem in playthroughItems)
            {
                Singleton.getInstance().Items.heldItems.Remove(newItem);
            }
            GC.Collect();
            return roomChecks;
        }

        public void placeItemInCheck(Item item, Check check)
        {
            Console.WriteLine("Placing item in check.");
            check.itemWasPlaced = true;
            check.itemId = item;
            Console.WriteLine("Placed " + check.itemId + " in check " + check.checkName);
            return;
        }

        public void deserializeChecks()
        {
            foreach (string file in System.IO.Directory.GetFiles("./Checks/", "*",SearchOption.AllDirectories))
            {
                string contents = File.ReadAllText(file);
                string fileName = Path.GetFileNameWithoutExtension(file);
                Checks.CheckDict[fileName] = JsonConvert.DeserializeObject<Check>(contents);
                Check currentCheck = Checks.CheckDict[fileName];
                currentCheck.requirements = Regex.Replace(currentCheck.requirements, @"\bLogic\b", "LogicFunctions");
                Checks.CheckDict[fileName] = currentCheck;
                Console.WriteLine("Check File Loaded " + fileName);
            }
            return;
        }
        

        public void deserializeRooms()
        {
            foreach (string file in System.IO.Directory.GetFiles("./Assets/Rooms/", "*", SearchOption.AllDirectories))
            {
                string contents = File.ReadAllText(file);
                string fileName = Path.GetFileNameWithoutExtension(file);
                Rooms.RoomDict[fileName] = JsonConvert.DeserializeObject<Room>(contents);
                Room currentRoom = Rooms.RoomDict[fileName];
                var newList = currentRoom.neighbourRequirements.Select(s => s.Replace("Logic", "LogicFunctions")).ToList();
                currentRoom.neighbourRequirements = newList;
                Rooms.RoomDict[fileName] = currentRoom;
                Console.WriteLine("Room File Loaded " + fileName);
            }
            return;
        }



        Room getDungeonEntrance(string itemToPlace)
        {
            Room regionRoom = new Room();
            if (itemToPlace.Contains("Forest_Temple"))
            {
                regionRoom = Rooms.RoomDict["Forest Temple 22"];
            }
            else if (itemToPlace.Contains("Goron_Mines"))
            {
              regionRoom = Rooms.RoomDict["Goron Mines 01"];
            }
            else if (itemToPlace.Contains("Lakebed_Temple"))
            {
                regionRoom = Rooms.RoomDict["Lakebed Temple 00 01"];
            }
            else if (itemToPlace.Contains("Arbiters_Grounds"))
            {
                regionRoom = Rooms.RoomDict["Arbiters Grounds 00"];
            }
            else if (itemToPlace.Contains("Snowpeak_Ruins"))
            {
                regionRoom = Rooms.RoomDict["Snowpeak Ruins 00 01 02 03"];
            }
            else if (itemToPlace.Contains("Temple_of_Time"))
            {
               regionRoom = Rooms.RoomDict["Temple of Time 00"];
            }
            else if (itemToPlace.Contains("City_in_The_Sky"))
            {
                regionRoom = Rooms.RoomDict["City in The Sky 00 16"];
            }
            else if (itemToPlace.Contains("Palace_of_Twilight"))
            {
                regionRoom = Rooms.RoomDict["Palace of Twilight 00 01"];
            }
            else if (itemToPlace.Contains("Hyrule_Castle"))
            {
                regionRoom = Rooms.RoomDict["Hyrule Castle 11"];
            }
            return regionRoom;
        }

        bool isDungeonCheck( string itemToPlace, Check currentCheck)
        {
            if (itemToPlace.Contains("Forest_Temple") && (currentCheck.category.Contains("Forest Temple")))
            {
                return true;
            }
            else if (itemToPlace.Contains("Goron_Mines") && (currentCheck.category.Contains("Goron Mines")))
            {
              return true;
            }
            else if (itemToPlace.Contains("Lakebed_Temple") && (currentCheck.category.Contains("Lakebed Temple")))
            {
                return true;
            }
            else if (itemToPlace.Contains("Arbiters_Grounds") && (currentCheck.category.Contains("Arbiters Grounds")))
            {
                return true;
            }
            else if ((itemToPlace.Contains("Snowpeak_Ruins") || itemToPlace.Contains("Ordon_Pumpkin") || itemToPlace.Contains("Ordon_Goat_Cheese")) && (currentCheck.category.Contains("Snowpeak Ruins")))
            {
                return true;
            }
            else if (itemToPlace.Contains("Temple_of_Time") && (currentCheck.category.Contains("Temple of Time")))
            {
               return true;
            }
            else if (itemToPlace.Contains("City_in_The_Sky") && (currentCheck.category.Contains("City in The Sky")))
            {
                return true;
            }
            else if (itemToPlace.Contains("Palace_of_Twilight") && (currentCheck.category.Contains("Palace of Twilight")))
            {
                return true;
            }
            else if (itemToPlace.Contains("Hyrule_Castle") && (currentCheck.category.Contains("Hyrule Castle")))
            {
                return true;
            }
            return false;
        }

        public bool evaluateRequirements(string expression)
        {
            Parser parse = new Parser();
            Console.WriteLine("Tokenizing Logic...");
            parse.ParserReset();
            Singleton.getInstance().Logic.TokenDict = new Tokenizer(expression).Tokenize();
            Console.WriteLine("Parsing Logic...");
            return parse.Parse();
        }
    }
}